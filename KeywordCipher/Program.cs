using System;

namespace KeywordCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Keyword cipher = new Keyword();
            Decryptor decrypt = new Decryptor();
            Console.WriteLine("Please enter in a keyword");
            string key = Console.ReadLine();
            Console.WriteLine("Please enter message to be decrypted");
            string message = Console.ReadLine();
            Console.WriteLine(cipher.Encrypt(message, key));
        }
    }
}
