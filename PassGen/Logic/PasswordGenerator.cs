using System;
using System.Windows;

namespace PassGen
{
    public partial class PasswordGenerator
    {

        public static string GeneratePassword(int length, PasswordOptions options)
        {
            string charList = string.Empty;
            string newPass = string.Empty;

            if (options.UpperCase == true)
                charList += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (options.LowerCase == true)
                charList += "abcdefghijklmnopqrstuvwxyz";

            if (options.Numbers == true)
                charList += "1234567890";

            if (options.SpecialChars == true)
                charList += "!£$%^&*(){}[]@~#_-?/";

            if (charList.Length== 0)
                charList = PasswordOptions.DefaultCharList;


            for (int i = 0; i < length; i++)
            {
                Random r = new Random();
                newPass += charList[r.Next(0, charList.Length)];
            }

            return newPass;
        }
    }
}
