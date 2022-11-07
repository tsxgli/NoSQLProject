using System;
using System.Collections.Generic;
using System.Text;

namespace MODEL
{
    public class PasswordGenerator
    {
        public static string GenerateRandomPassword()
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrs";
            char[] chars = new char[7];
            string finalPassword = "";
            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                finalPassword += letters[random.Next(0, letters.Length)];
                // finalPassword += chars[i];
            }
            return finalPassword;
        }
    }
}
