using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ProjectCloud
{
    class RijndaelHelper
    {
        public static void EncryptFile(string inputFile, string outputFile, byte[] key, byte[] iv)
        {
            using (var rijndael = new RijndaelManaged())
            {
                rijndael.IV = iv;
                rijndael.Key = key;
                using (var inputStream = File.OpenRead(inputFile))
                using (var outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                using (var encStream = new CryptoStream(outputStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    outputStream.SetLength(0);
                    inputStream.CopyTo(encStream);
                }
            }
        }

        public static void DecryptFile(string inputFile, string outputFile, byte[] key, byte[] iv)
        {
            using (RijndaelManaged aes = new RijndaelManaged())
            {
                using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
                {
                    using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                    {
                        using (ICryptoTransform decryptor = aes.CreateDecryptor(key, iv))
                        {
                            using (CryptoStream cs = new CryptoStream(fsCrypt, decryptor, CryptoStreamMode.Read))
                            {
                                int data;
                                while ((data = cs.ReadByte()) != -1)
                                {
                                    fsOut.WriteByte((byte)data);
                                }
                            }
                        }
                    }
                }
            }
            //using (var rijndael = new RijndaelManaged())
            //{
            //    rijndael.IV = iv;
            //    rijndael.Key = key;
            //    using (var inputStream = File.OpenRead(inputFile))
            //    using (var decStream = new CryptoStream(inputStream, rijndael.CreateDecryptor(), CryptoStreamMode.Read))
            //    using (var outputStream = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
            //    {
            //        decStream.CopyTo(outputStream);
            //    }
            //}
        }




    }
}
