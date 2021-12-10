using System;
//using System.Collections.Generic;
using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace TestProject.Using_Statement
{
    class Learn_Using_Statement
    {
        public Learn_Using_Statement()
        {
        }

       
        /// <summary>
        /// using statement in c# version older than 8.0
        /// </summary>
        public void Using_Sample1()
        {
            string manyLines = @"This is line one
                               This is line two
                               Here is line three
                               The penultimate line is line four
                               This is the final, fifth line.";

            using (var reader = new StringReader(manyLines))
            {
                string? item;
                do
                {
                    item = reader.ReadLine();
                    System.Windows.Forms.MessageBox.Show(item);
                } while (item != null);
            }

        }

        /// <summary>
        /// using statement in c# after version 8.0
        /// </summary>
        public void Using_Sample2()
        {
            string manyLines = @"This is line one
                               This is line two
                               Here is line three
                               The penultimate line is line four
                               This is the final, fifth line.";

            using var reader = new StringReader(manyLines);
            string? item;
            do
            {
                item = reader.ReadLine();
                System.Windows.Forms.MessageBox.Show(item);
            } while (item != null);
        }

        /// <summary>
        /// instead of using statement use try-finally blocks
        /// </summary>
        public void Using_Sample3()
        {
            string manyLines = @"This is line one
                               This is line two
                               Here is line three
                               The penultimate line is line four
                               This is the final, fifth line.";

            var reader = new StringReader(manyLines);
            try
            {
                string? item;
                do
                {
                    item = reader.ReadLine();
                    System.Windows.Forms.MessageBox.Show(item);
                } while (item != null);
            }
            finally
            {
                reader?.Dispose();
            }

        }

        /// <summary>
        /// Multiple instances of a type can be declared in a single using statement
        /// Notice that you can't use implicitly typed variables (var) 
        /// when you declare multiple variables in a single statement
        /// </summary>
        public void Using_Sample4()
        {
            string numbers = @"One
                                Two
                                Three
                                Four.";
            string letters = @"A
                                B
                                C
                                D.";

            using (StringReader left = new StringReader(numbers),
                right = new StringReader(letters))
            {
                string? item;
                do
                {
                    item = left.ReadLine();
                    System.Windows.Forms.MessageBox.Show(item);
                    Console.Write("    ");
                    item = right.ReadLine();
                    System.Windows.Forms.MessageBox.Show(item);
                } while (item != null);
            }
        }

        /// <summary>
        /// Multiple instances of a type can be declared in a single using statement
        /// in c# after version 8.0
        /// </summary>
        public void Using_Sample5()
        {
            string numbers = @"One
                                Two
                                Three
                                Four.";
            string letters = @"A
                                B
                                C
                                D.";

            using StringReader left = new StringReader(numbers),
                right = new StringReader(letters);
            string? item;
            do
            {
                item = left.ReadLine();
                System.Windows.Forms.MessageBox.Show(item);
                Console.Write("    ");
                item = right.ReadLine();
                System.Windows.Forms.MessageBox.Show(item);
            } while (item != null);
        }

        /// <summary>
        /// define objects outside of using block
        /// </summary>
        public void Using_Sample6()
        {
            string manyLines = @"This is line one
                               This is line two
                               Here is line three
                               The penultimate line is line four
                               This is the final, fifth line.";

            var reader = 
                new StringReader(manyLines);

            using (reader)
            {
                string? item;
                do
                {
                    item = reader.ReadLine();
                    System.Windows.Forms.MessageBox.Show(item);
                } while (item != null);
            }
            // reader is in scope here, but has been disposed
        }
    }
}
