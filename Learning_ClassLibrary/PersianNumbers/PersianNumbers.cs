using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_ClassLibrary.PersianNumbers
{
    public static class PersianNumbers : object
    {
        static PersianNumbers()
        {
        }

        internal static string mainResult = String.Empty;

        internal static string result = "";
        public static string ConvertToLetters(string number, string closingLetter)
        {
            return (" %% " + ConvertToLetters(number));
        }

        public static string ConvertToLetters(string number)
        {
            int length = 0;
            long hNumber = 0;

            if (number != "")
            {
                hNumber = Convert.ToInt64(number);
                length = number.Length;
            }
            else
            {
                result = "";
            }

            switch (length)
            {
                case 1:
                    {
                        result = OneDigit(hNumber);
                        break;
                    }
                case 2:
                    {
                        result = Length2(hNumber);
                        break;
                    }
                case 3:
                    {
                        result = Length3(hNumber);
                        break;
                    }
                case 4:
                case 5:
                case 6:
                    {
                        result = Length4(hNumber);
                        break;
                    }
                case 7:
                case 8:
                case 9:
                    {
                        result = Length7(hNumber);
                        break;
                    }
                case 10:
                case 11:
                case 12:
                    {
                        result = Length10(hNumber);
                        break;
                    }
            }

            mainResult = result;

            return (mainResult);
        }

        internal static string Length10(long hNumber)
        {
            long handredMod = hNumber % 1000000000;

            if (handredMod == 0)
            {
                if ((hNumber / 1000000000) < 10)
                {
                    result =
                        OneDigit(hNumber / 1000000000) + " میلیارد ";
                }
                else if ((hNumber / 1000000000) < 100)
                {
                    result =
                        Length2(hNumber / 1000000000) + " میلیارد ";
                }
                else if ((hNumber / 1000000000) < 1000)
                {
                    result =
                        Length3(hNumber / 1000000000) + " میلیارد ";
                }
            }
            else
            {
                string result2 = Length7(handredMod);
                string result1 = "";

                if (((hNumber - handredMod) / 1000000000) < 10)
                {
                    result1 =
                        OneDigit((hNumber - handredMod) / 1000000000) + " میلیارد ";
                }
                else if (((hNumber - handredMod) / 1000000000) < 100)
                {
                    result1 =
                        Length2(((hNumber - handredMod) / 1000000000)) + " میلیارد ";
                }
                else if (((hNumber - handredMod) / 1000000000) < 1000)
                {
                    result1 =
                        Length3(((hNumber - handredMod) / 1000000000)) + " میلیارد ";
                }
                //string result1 = OneDigit((hNumber - handredMod) / 1000) + "هزار";
                result = result1 + " و " + result2;
            }

            return (result);
        }

        internal static string Length7(long hNumber)
        {
            long handredMod = hNumber % 1000000;

            if (handredMod == 0)
            {
                if ((hNumber / 1000000) < 10)
                {
                    result =
                        OneDigit(hNumber / 1000000) + " میلیون ";
                }
                else if ((hNumber / 1000000) < 100)
                {
                    result =
                        Length2(hNumber / 1000000) + " میلیون ";
                }
                else if ((hNumber / 1000000) < 1000)
                {
                    result =
                        Length3(hNumber / 1000000) + " میلیون ";
                }
            }
            else
            {
                string result2 = Length4(handredMod);
                string result1 = "";

                if (((hNumber - handredMod) / 1000000) < 10)
                {
                    result1 =
                        OneDigit((hNumber - handredMod) / 1000000) + " میلیون ";
                }
                else if (((hNumber - handredMod) / 1000000) < 100)
                {
                    result1 =
                        Length2(((hNumber - handredMod) / 1000000)) + " میلیون ";
                }
                else if (((hNumber - handredMod) / 1000000) < 1000)
                {
                    result1 =
                        Length3(((hNumber - handredMod) / 1000000)) + " میلیون ";
                }
                //string result1 = OneDigit((hNumber - handredMod) / 1000) + "هزار";
                result =
                    result1 + " و " + result2;
            }

            return (result);
        }

        internal static string Length4(long hNumber)
        {
            long handredMod = hNumber % 1000;

            if (handredMod == 0)
            {
                if ((hNumber / 1000) < 10)
                    result = OneDigit(hNumber / 1000) + " هزار ";
                else if ((hNumber / 1000) < 100)
                    result = Length2(hNumber / 1000) + " هزار ";
                else if ((hNumber / 1000) < 1000)
                    result = Length3(hNumber / 1000) + " هزار ";

            }
            else
            {
                string result2 = Length3(handredMod);
                string result1 = "";
                if (((hNumber - handredMod) / 1000) < 10)
                    result1 = OneDigit((hNumber - handredMod) / 1000) + " هزار ";
                else if (((hNumber - handredMod) / 1000) < 100)
                    result1 = Length2(((hNumber - handredMod) / 1000)) + " هزار ";
                else if (((hNumber - handredMod) / 1000) < 1000)
                    result1 = Length3(((hNumber - handredMod) / 1000)) + " هزار ";

                //string result1 = OneDigit((hNumber - handredMod) / 1000) + "هزار";
                result = result1 + " و " + result2;
            }
            return (result);
        }

        internal static string Length3(long hNumber)
        {
            long handredMod = hNumber % 100;
            if (handredMod == 0)
            {
                result = HandredDigit(hNumber);
            }
            else
            {
                if (handredMod.ToString().Length == 2)
                {
                    result = Length2(handredMod);
                }
                else
                {
                    result = OneDigit(handredMod);
                }
                string result1 =
                    HandredDigit(hNumber - handredMod);

                result =
                    result1 + " و " + result;
            }

            return (result);
        }

        internal static string Length2(long hNumber)
        {
            long tenMod = hNumber % 10;

            if (tenMod == 0 || hNumber <= 20)
            {
                result = TenDigit(hNumber);
            }
            else
            {
                string result1 =
                    OneDigit(tenMod);

                string result2 =
                    TenDigit(hNumber - tenMod);

                result =
                    result2 + " و " + result1;
            }

            return (result);
        }

        internal static string OneDigit(long number)
        {
            string strResultOneDigit = "";

            switch (number)
            {
                case 0:
                    {
                        strResultOneDigit = "صفر";
                        break;
                    }
                case 1:
                    {
                        strResultOneDigit = "یک";
                        break;
                    }
                case 2:
                    {
                        strResultOneDigit = "دو";
                        break;
                    }
                case 3:
                    {
                        strResultOneDigit = "سه";
                        break;
                    }
                case 4:
                    {
                        strResultOneDigit = "چهار";
                        break;
                    }
                case 5:
                    {
                        strResultOneDigit = "پنج";
                        break;
                    }
                case 6:
                    {
                        strResultOneDigit = "شش";
                        break;
                    }
                case 7:
                    {
                        strResultOneDigit = "هفت";
                        break;
                    }
                case 8:
                    {
                        strResultOneDigit = "هشت";
                        break;
                    }
                case 9:
                    {
                        strResultOneDigit = "نه";
                        break;
                    }
            }

            return (strResultOneDigit);
        }

        internal static string TenDigit(long number)
        {

            string strResultTenDigit = "";

            switch (number)
            {
                case 10:
                    {
                        strResultTenDigit = "ده";
                        break;
                    }
                case 11:
                    {
                        strResultTenDigit = "یازده";
                        break;
                    }
                case 12:
                    {
                        strResultTenDigit = "دوازده";
                        break;
                    }
                case 13:
                    {
                        strResultTenDigit = "سیزده";
                        break;
                    }
                case 14:
                    {
                        strResultTenDigit = "چهارده";
                        break;
                    }
                case 15:
                    {
                        strResultTenDigit = "پانزده";
                        break;
                    }
                case 16:
                    {
                        strResultTenDigit = "شانزده";
                        break;
                    }
                case 17:
                    {
                        strResultTenDigit = "هفده";
                        break;
                    }
                case 18:
                    {
                        strResultTenDigit = "هجده";
                        break;
                    }
                case 19:
                    {
                        strResultTenDigit = "نوزده";
                        break;
                    }
                case 20:
                    {
                        strResultTenDigit = "بیست";
                        break;
                    }
                case 30:
                    {
                        strResultTenDigit = "سی";
                        break;
                    }
                case 40:
                    {
                        strResultTenDigit = "چهل";
                        break;
                    }
                case 50:
                    {
                        strResultTenDigit = "پنجاه";
                        break;
                    }
                case 60:
                    {
                        strResultTenDigit = "شصت";
                        break;
                    }
                case 70:
                    {
                        strResultTenDigit = "هفتاد";
                        break;
                    }
                case 80:
                    {
                        strResultTenDigit = "هشتاد";
                        break;
                    }
                case 90:
                    {
                        strResultTenDigit = "نود";
                        break;
                    }
            }

            return (strResultTenDigit);
        }

        internal static string HandredDigit(long number)
        {
            string strResultHandredDigit = "";

            switch (number)
            {
                case 100:
                    {
                        strResultHandredDigit = "یکصد";
                        break;
                    }
                case 200:
                    {
                        strResultHandredDigit = "دویست";
                        break;
                    }
                case 300:
                    {
                        strResultHandredDigit = "سیصد";
                        break;
                    }
                case 400:
                    {
                        strResultHandredDigit = "چهارصد";
                        break;
                    }
                case 500:
                    {
                        strResultHandredDigit = "پانصد";
                        break;
                    }
                case 600:
                    {
                        strResultHandredDigit = "ششصد";
                        break;
                    }
                case 700:
                    {
                        strResultHandredDigit = "هفتصد";
                        break;
                    }
                case 800:
                    {
                        strResultHandredDigit = "هشتصد";
                        break;
                    }
                case 900:
                    {
                        strResultHandredDigit = "نهصد";
                        break;
                    }
                case 1000:
                    {
                        strResultHandredDigit = "هزار";
                        break;
                    }
            }

            return (strResultHandredDigit);
        }
    }
}
