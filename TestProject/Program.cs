using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //            Application.Run(new TestForm1());
             Application.Run(new TestForm2());




            //Using_Statement.Learn_Using_Statement learn_Using_Statement =
            //    new Using_Statement.Learn_Using_Statement();

            //learn_Using_Statement.Using_Sample1();
            //            learn_Using_Statement.Using_Sample2();
            //            learn_Using_Statement.Using_Sample3();
            //            learn_Using_Statement.Using_Sample4();
            //learn_Using_Statement.Using_Sample5();
            //learn_Using_Statement.Using_Sample6();
        }
    }
}
