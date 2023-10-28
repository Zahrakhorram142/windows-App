using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{

    public class ValidationCheck
    {
        public static string IsValidInput(string name)
        {


            do
            {

                bool isXValid = true;
                if (isXValid)
                {
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (!char.IsLetter(name[i]))
                        {
                            isXValid = false;
                            break;
                        }
                    }
                }

                if (!isXValid)
                {
                    MessageBox.Show("Invalid Input Please Try Again");

                }
                if (isXValid)
                {

                    break;
                }


            }
            while (true);
            return name;
        }

        public static string IsValidNumber(string Number)
        {
            do
            {
                bool isXValid = true;
                if (isXValid)
                {
                    for (int i = 0; i < Number.Length; i++)
                    {
                        if (!char.IsLetter(Number[i]))
                        {
                            isXValid = false;
                            break;
                        }
                    }
                }

                if (!isXValid)
                {
                    MessageBox.Show("Invalid Input Please Try Again:");

                }
                if (isXValid)
                {

                    break;
                }


            }
            while (true);
            return Number;
        }

            public static string IsValidPhoneNumber(string phoneNumber)

            {

                do
                {

                    bool isPhoneValid = phoneNumber.Length == 10 || phoneNumber.Length == 11 || phoneNumber.Length == 13;
                    if (isPhoneValid)
                    {

                        for (int i = 0; i < phoneNumber.Length; i++)
                        {
                            if (!char.IsDigit(phoneNumber[i]))
                            {
                                if (phoneNumber[0] == '+' && phoneNumber.Length == 10)
                                {
                                    if (!(phoneNumber[i] == '+' && i == 0))
                                    {

                                        isPhoneValid = false;

                                        break;

                                    }
                                }
                            }
                        }
                    }
                    if (!isPhoneValid)
                    {
                        MessageBox.Show("Invalid Phone Please Try Again:");


                    }
                    if (isPhoneValid)

                    {
                        break;

                    }


                } while (true);
                return phoneNumber;
            }
        public static string IsValidNationalCode(string nationalCode) 
        {
            do {
                bool isNationalValid = nationalCode.Length == 10;
                if (isNationalValid)
                {
                    break;
                }
                if (!isNationalValid)
                {
                    MessageBox.Show("Invalid NationalCode Please Try Again:");
                }


            }
            while (true);
            return nationalCode;
        }
        
    }

}


internal class MessageBox
{
    internal static void Show(string v)
    {
        throw new NotImplementedException();
    }
}