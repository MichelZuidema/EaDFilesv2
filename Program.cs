using System;
using System.IO;
using System.Collections.Generic;
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

            Exit();
        }

        static string GetContentFromFile(string filename) {
            if(File.Exists(filename)) {
                using(StreamReader sr = new StreamReader(filename)) {
                    string filecontent = sr.ReadToEnd();
                    return filecontent;
                }
            } else {
                string error = "404. File not found!";
                return error;
            }
        }

        static void WriteToFile(string filename, string filecontent) {
            using(StreamWriter sw = new StreamWriter(filename)) {
                sw.WriteLine(filecontent);
                Console.WriteLine("Content written to file!");
            } 
        }

        static void EncryptTextFile() {
            Console.WriteLine("Enter filename: ");
            string filename = Console.ReadLine();
            string filecontent = GetContentFromFile(filename);
            string encryptedcontent = EncryptDecrypt.Encrypt(filecontent);

            string newFileName = filename + "-encrypted.txt";
            WriteToFile(newFileName, encryptedcontent);
        }

        static void EncryptText() {
            Console.WriteLine("Enter text to encrypt:");
            string decryptedText = Console.ReadLine();
            string encryptedText = EncryptDecrypt.Encrypt(decryptedText);

            Console.WriteLine("Decrypted Text: {0}", decryptedText);
            Console.WriteLine("Encrypted Text: {0}", encryptedText);
        }

        static void DecryptTextFile() {
            Console.WriteLine("Enter filename: ");
            string filename = Console.ReadLine();
            string filecontent = GetContentFromFile(filename);
            string decryptedcontent = EncryptDecrypt.Decrypt(filecontent);

            string newFileName = filename + "-decrypted.txt";
            WriteToFile(newFileName, decryptedcontent);
        }

        static void DecryptText() {
            Console.WriteLine("Enter text to decrypt:");
            string encryptedText = Console.ReadLine();
            string decryptedText = EncryptDecrypt.Decrypt(encryptedText);

            Console.WriteLine("Encrypted Text: {0}", encryptedText);
            Console.WriteLine("Decrypted Text: {0}", decryptedText);
        }

        static void Exit() {
            Console.WriteLine("Thank you for using this script. This script has been made by Michel Zuidema.");
        }
    }
}
