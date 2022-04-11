using System;
using System.Text;

namespace caesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            int k = 66;

            string test = "Pz-/aI/J`EvfthGH";
            StringBuilder sb = new StringBuilder();
            int res = 0;

            for (int i = 0; i < test.Length; i++)
            {
                if ((byte)test[i] >= 97 & (byte)test[i] < 123)
                {
                    if ((byte)test[i] + k > 90)
                    {
                        res = (test[i] + k);
                        while (res > 122)
                        {
                            res -= 26;
                        }
                        sb.Append((char)res);
                    }
                    else
                        sb.Append((char)(test[i] + k));
                }
                else if ((byte)test[i] >= 65 & (byte)test[i] < 91)
                {
                    if ((byte)test[i] + k > 90)
                    {
                        res = (test[i] + k);
                        while (res > 90)
                        {
                            res -= 26;
                        }
                        sb.Append((char)res);
                    }
                    else
                    {
                        sb.Append((char)(test[i] + k));
                    }
                }
                else
                {
                    sb.Append(test[i]);
                }
            }
                        
            Console.WriteLine(sb);                    

            Console.ReadKey();
        }
    }
}
