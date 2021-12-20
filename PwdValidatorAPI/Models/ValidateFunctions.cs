using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PwdValidatorAPI.Models
{
    public class ValidateFunctions
    {
        public string password { get; set; }
        public bool lenghtValidator()
        {
            if (password.Length >= 9)
                return true;
            else
                return false;
        }

        public bool numberValidator()
        {
            bool result = false;
            char[] pwdArray = password.ToCharArray();


            foreach (var item in pwdArray)
            {
                if (Char.IsDigit(item))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool upperCaseValidator()
        {
            bool result = false;
            char[] pwdArray = password.ToCharArray();


            foreach (var item in pwdArray)
            {
                if (Char.IsUpper(item))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
        public bool lowerCaseValidator()
        {
            bool result = false;
            char[] pwdArray = password.ToCharArray();


            foreach (var item in pwdArray)
            {
                if (Char.IsLower(item))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
        public bool specialCharsValidator()
        {
            bool result = false;
            string specialChars = @"!@#$%^&*()-+";

            foreach (var item in specialChars)
            {
                if (password.Contains(item))
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public bool duplicatedCharsValidator()
        {
            if (password.GroupBy(i => i).Any(d => d.Count() > 1))
                return false;
            else
                return true;
        }

    }
}