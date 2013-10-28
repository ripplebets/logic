using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Class1
    { 
        Random Rnd = new Random(GetRandomSeed());
        int luckynumber = 0;
        luckynumber = Rnd.Next(1, 10000);
        ...
        
        private int TestA(double value)
        {
            int xrps = 1000000;
            double percents = (100 / value);
            percents = percents - (percents * 0.01);
            percents = Math.Round(percents * 100) / 100;
            ...
        }

        public static int GetSeed(string hash,int second)
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);
            bytes[2] = Convert.ToByte(int.Parse(Convert.ToInt32(hash.Substring(hash.Length - 1), 16).ToString()));
            bytes[3] = Convert.ToByte(int.Parse(second.ToString()));
            return BitConverter.ToInt32(bytes, 0);
        }
    }
}
