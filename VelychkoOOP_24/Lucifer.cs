using System;

namespace VelychkoOOP_24
{
    class Lucifer
    {
        static int ROUNDS = 16;

        static UInt32 F(UInt32 halfBlock, UInt32 roundKey)
        {
            return halfBlock ^ roundKey;
        }

        static UInt32[] GenerateRoundKeys(UInt64 key)
        {
            UInt32[] roundKeys = new UInt32[ROUNDS];
            for (int i = 0; i < ROUNDS; i++)
            {
                roundKeys[i] = (UInt32)((key >> (i * 4)) & 0xFFFFFFFF);
            }
            return roundKeys;
        }

        public static UInt64 Encrypt(UInt64 block, UInt64 key)
        {
            UInt32 left = (UInt32)(block >> 32);
            UInt32 right = (UInt32)(block & 0xFFFFFFFF);

            UInt32[] roundKeys = GenerateRoundKeys(key);

            for (int i = 0; i < ROUNDS; i++)
            {
                UInt32 temp = right;
                right = left ^ F(right, roundKeys[i]);
                left = temp;
            }

            return ((UInt64)left << 32) | right;
        }

        public static UInt64 Decrypt(UInt64 block, UInt64 key)
        {
            UInt32 left = (UInt32)(block >> 32);
            UInt32 right = (UInt32)(block & 0xFFFFFFFF);

            UInt32[] roundKeys = GenerateRoundKeys(key);

            for (int i = ROUNDS - 1; i >= 0; i--)
            {
                UInt32 temp = left;
                left = right ^ F(left, roundKeys[i]);
                right = temp;
            }

            return ((UInt64)left << 32) | right;
        }
    }
}
