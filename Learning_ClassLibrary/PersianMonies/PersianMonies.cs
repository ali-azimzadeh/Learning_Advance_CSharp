using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_ClassLibrary.PersianMonies
{
    /// <summary>
    /// این کلاس برای تبدیل اعداد به فرمت ریال استفاده می شود
    /// </summary>
    public class PersianMonies : object
    {
        public PersianMonies() : base()
        {
        }

        /// <summary>
        /// این متد مبلغ را به عنوان ورودی می گیرد و نتیجه را به ريال به صورت سه رقم سه رقم برمی گرداند
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public static string ConvertPersianMoniesToRialFormat(long money)
        {
            return (ConvertToFormatString(money));
        }

        /// <summary>
        /// این متد فقط در داخل این پروژه قابل استفاده است و 
        /// از دنیای بیرون آن دسترسی نداریم و وظیقه ی تبدیل عدد را به فرمت ریال برعهده دارد
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        internal static string ConvertToFormatString(long money)
        {
            string MainResult = "";
            string strMoney = money.ToString();
            int length = strMoney.Length;
            if (length > 3)
            {
                if (length % 3 == 0)
                {
                    for (int index = 3; index <= length; index += 4)
                    {
                        MainResult = strMoney.Insert(index, ",");
                        strMoney = MainResult;
                    }
                }
                else
                {
                    for (int index = length % 3; index <= length; index += 4)
                    {
                        MainResult = strMoney.Insert(index, ",");
                        strMoney = MainResult;
                    }

                }
            }
            else
            {
                MainResult = money.ToString();
            }
            return (MainResult);
        }
    }
}
