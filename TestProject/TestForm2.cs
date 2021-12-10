using Learning_ClassLibrary.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class TestForm2 : BaseForm
    {
        public TestForm2()
        {
            InitializeComponent();
        }

        private void myToolbar1_AddButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Button is clicked!");
            
        }

        private void myTextBox1_Validating(object sender, CancelEventArgs e)
        {
        }

        private void myToolbar1_UpdateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Update Button is clicked!");
        }

        private void TestForm2_Load(object sender, EventArgs e)
        {
            //expandable_Property1.Border.BorderColor =
            expandable_Property1.MyButton.Text = "test";
        }
    }
}
