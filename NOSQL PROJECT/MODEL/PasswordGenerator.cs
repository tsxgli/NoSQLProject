using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class PasswordGenerator
    {
        //method to generate a random password
        public static string GenerateRandomPassword()
        {
            //the letters used
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrs";
            char[] chars = new char[7];
            string finalPassword = "";

            Random random = new Random();

            //make a new 8 letter password
            for (int i = 0; i < 7; i++)
            {
                finalPassword += letters[random.Next(0, letters.Length)];
            }
            return finalPassword;
        }
    }
}
