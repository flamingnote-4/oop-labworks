using System;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace VelychkoOOP_24
{
    public partial class Form1 : Form
    {
        private Thread luciferThread, nhashThread, rsaThread;
        private ManualResetEvent luciferPause = new ManualResetEvent(true);
        private ManualResetEvent nhashPause = new ManualResetEvent(true);
        private ManualResetEvent rsaPause = new ManualResetEvent(true);

        public Int32 waitingTime = 1000;
        private bool exiting = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void startThreads(object sender, EventArgs e)
        {
            StartThread(ref luciferThread, luciferPause, richTextBox1, GenerateLuciferOutput, waitingTime);
            StartThread(ref nhashThread, nhashPause, richTextBox2, GenerateHashOutput, waitingTime);
            StartThread(ref rsaThread, rsaPause, richTextBox3, GenerateRsaOutput, waitingTime);
        }

        private void startThreadLucifer(object sender, EventArgs e)
        {
            StartThread(ref luciferThread, luciferPause, richTextBox1, GenerateLuciferOutput, waitingTime);
        }

        private void startThreadNHash(object sender, EventArgs e)
        {
            StartThread(ref nhashThread, nhashPause, richTextBox2, GenerateHashOutput, waitingTime);
        }

        private void startThreadRSA(object sender, EventArgs e)
        {
            StartThread(ref rsaThread, rsaPause, richTextBox3, GenerateRsaOutput, waitingTime);
        }

        private void StartThread(ref Thread thread, ManualResetEvent pauseEvent, RichTextBox outputBox, Func<string> contentGenerator, int delay)
        {
            if (thread != null && thread.ThreadState != ThreadState.Unstarted)
                return;

            thread = new Thread(() =>
            {
                while (true)
                {
                    pauseEvent.WaitOne();
                    if (exiting) break;

                    AppendTextThreadSafe(outputBox, contentGenerator());

                    Thread.Sleep(delay);
                }
            });

            thread.IsBackground = true;
            thread.Start();
        }

        private string GenerateLuciferOutput()
        {
            Random rand = new Random();
            ulong block = (ulong)rand.Next();
            ulong key = (ulong)rand.Next();
            ulong encrypted = Lucifer.Encrypt(block, key);
            ulong decrypted = Lucifer.Decrypt(encrypted, key);

            return $"Блок: {block}\nКлюч: {key}\nШифрування: {encrypted}\nДешифрування: {decrypted}\n\n";
        }

        private string GenerateHashOutput()
        {
            Random rand = new Random();
            string input = "";
            for (int i = 0; i < 16; i++)
            {
                int x = rand.Next(26);
                char c = (char)(x + 65);
                input += c;
            }
            string hash = NHash.ComputeHashHex(input);

            return $"Вхід: {input}\nВихід: {hash}\n\n";
        }

        private string GenerateRsaOutput()
        {
            Random rand = new Random();
            byte[] input = new byte[16];
            rand.NextBytes(input);
            RSA key = RSA.Create();
            RSAEncryptionPadding padding = RSAEncryptionPadding.OaepSHA1;
            byte[] encrypted = key.Encrypt(input, padding);
            byte[] decrypted = key.Decrypt(encrypted, padding);

            return $"Дані: {Convert.ToBase64String(input)}\nРозмір ключа: {key.KeySize}\nШифрування: {Convert.ToBase64String(encrypted)}\nДешифрування: {Convert.ToBase64String(decrypted)}\n\n";
        }
        private void AppendTextThreadSafe(RichTextBox box, string text)
        {
            if (box.InvokeRequired)
            {
                box.Invoke(new MethodInvoker(() => box.AppendText(text)));
            }
            else
            {
                box.AppendText(text);
            }
        }
        private void haltThread1(object sender, EventArgs e) => luciferPause.Reset();
        private void haltThread2(object sender, EventArgs e) => nhashPause.Reset();
        private void haltThread3(object sender, EventArgs e) => rsaPause.Reset();

        private void resumeThread1(object sender, EventArgs e) => luciferPause.Set();
        private void resumeThread2(object sender, EventArgs e) => nhashPause.Set();
        private void resumeThread3(object sender, EventArgs e) => rsaPause.Set();
        private void haltAllThreads(object sender, EventArgs e)
        {
            luciferPause.Reset();
            nhashPause.Reset();
            rsaPause.Reset();
        }

        private void resumeAllThreads(object sender, EventArgs e)
        {
            luciferPause.Set();
            nhashPause.Set();
            rsaPause.Set();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            exiting = true;
            resumeAllThreads(sender, e);

            luciferPause.Set();
            nhashPause.Set();
            rsaPause.Set();

            Thread.Sleep(50);

            if (luciferThread?.IsAlive == true) luciferThread.Join();
            if (nhashThread?.IsAlive == true) nhashThread.Join();
            if (rsaThread?.IsAlive == true) rsaThread.Join();

            luciferPause.Dispose();
            nhashPause.Dispose();
            rsaPause.Dispose();
        }
    }
}