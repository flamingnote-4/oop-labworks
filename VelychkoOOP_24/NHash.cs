using System;
using System.Text;

public static class NHash
{
    private const int BlockSize = 64;

    private static ulong[] InitialState = { 0x6a09e667f3bcc908, 0xbb67ae8584caa73b };

    public static ulong[] ComputeHash(string message)
    {
        byte[] padded = PadMessage(Encoding.UTF8.GetBytes(message));
        ulong[] state = (ulong[])InitialState.Clone();

        for (int i = 0; i < padded.Length; i += 8)
        {
            ulong block = BitConverter.ToUInt64(padded, i);
            state = Compress(state, block);
        }

        return state;
    }

    public static string ComputeHashHex(string message)
    {
        var hash = ComputeHash(message);
        return $"{hash[0]:X16}{hash[1]:X16}";
    }

    private static ulong[] Compress(ulong[] state, ulong block)
    {
        ulong a = state[0];
        ulong b = state[1];

        a = RotateLeft(a ^ block, 13) + b;
        b = RotateLeft(b ^ block, 29) + a;

        return new[] { a, b };
    }

    private static byte[] PadMessage(byte[] message)
    {
        int originalLength = message.Length;
        int paddedLength = ((originalLength + 8) / 8) * 8;
        if (paddedLength == originalLength) paddedLength += 8;

        byte[] padded = new byte[paddedLength];
        Buffer.BlockCopy(message, 0, padded, 0, message.Length);

        padded[originalLength] = 0x80;
        byte[] lengthBytes = BitConverter.GetBytes((ulong)originalLength * 8);
        Buffer.BlockCopy(lengthBytes, 0, padded, padded.Length - 8, 8);

        return padded;
    }

    private static ulong RotateLeft(ulong x, int bits)
    {
        return (x << bits) | (x >> (64 - bits));
    }
}
