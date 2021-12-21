using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PwdValidatorAPI.Models
{
    public class PasswordValidator
    {
        public bool validatorResult(string pwd)
        {
            ValidateFunctions functions = new ValidateFunctions();

            functions.password = pwd;

            if (functions.lenghtValidator())
            {
                if (functions.blankSpacesValidator())
                {
                    if (functions.numberValidator())
                    {
                        if (functions.lowerCaseValidator())
                        {
                            if (functions.upperCaseValidator())
                            {
                                if (functions.specialCharsValidator())
                                {
                                    return functions.duplicatedCharsValidator();
                                }
                                else
                                {
                                    return false;
                                }
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
    }
}