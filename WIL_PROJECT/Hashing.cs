using System;
using System.Collections.Generic;
using System.Text;

namespace WIL_PROJECT
{
    public class Hashing
    {
        //encytion method
        public static string Encrypt(String Word)
        {
            //decalre byte array to hold ascii
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(Word);
            //declaring variable to hold string
            String Encryted = Convert.ToBase64String(b);
            //returning value
            return Encryted;
        }
        //decryption method
        public static string Decrypt(String Word)
        {//byte array to hold bytes
            byte[] b;
            //variable to hold decrypted value
            String Decryted;
            try
            {//converting word from base 64 string
                b = Convert.FromBase64String(Word);
                //assigning decrypted asciiencoding
                Decryted = System.Text.ASCIIEncoding.ASCII.GetString(b);

            }
            catch (Exception)
            {
                //throwing exeptions
                throw;
            }//returning decrypted value
            return Decryted;
        }
    }
}
