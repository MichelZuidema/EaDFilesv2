using System;
using EncryptAndDecrypt;

namespace EaDFilesv2
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to EncryptAndDecrypt!");
            Console.WriteLine("Please select one of the following options:");;
            Console.WriteLine("1. Encrypt text file");
            Console.WriteLine("2. Encrypt text");
            Console.WriteLine("3. Decrypt text file");
            Console.WriteLine("4. Decrypt text");

            int userChoice = Convert.ToInt32(Console.ReadLine());
            
            switch(userChoice) {
                case 1:
                    EncryptTextFile();
                    break;
                case 2:
                    EncryptText();
                    break;
                case 3:
                    DecryptTextFile();
                    break;
                case 4:
                    DecryptText();
                    break;
                default:
                    Console.WriteLine("Not a valid input.");
                    break;
            }
        }

        static void GetContentFromFile(string filename) {

        }

        static void EncryptTextFile() {

        }

        static void EncryptText() {
            Console.WriteLine("Enter text to encrypt:");
            string decryptedText = Console.ReadLine();
            string encryptedText = EncryptDecrypt.Encrypt(decryptedText);

            Console.WriteLine("Decrypted Text: {0}", decryptedText);
            Console.WriteLine("Encrypted Text: {0}", encryptedText);
        }

        static void DecryptTextFile() {

        }

        static void DecryptText() {
            Console.WriteLine("Enter text to decrypt:");
            string encryptedText = Console.ReadLine();
            string decryptedText = EncryptDecrypt.Decrypt(encryptedText);

            Console.WriteLine("Encrypted Text: {0}", encryptedText);
            Console.WriteLine("Decrypted Text: {0}", decryptedText);
        }
    }
}
