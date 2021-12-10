using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_ClassLibrary.Toolbar
{
    public partial class MyToolbar : MyUserControl
    {
        public MyToolbar()
        {
            InitializeComponent();
            MyTest = new Test(test1: 0);
        }

        //public override string Text 
        //{ 
        //    get => base.Text; 
        //    set => base.Text = value; 
        //}

      //  [Serializable]
        public struct Test
        {
            public Test(int test1)
            {
                _test1 = test1;
              
            }

            private int _test1;
            public int Test1
            {
                get
                {
                    return _test1;
                }
                set
                {
                    _test1 = value;
                }
            }

           
        }

        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Test MyTest { get; set; } 

        //private Learning_ClassLibrary.Buttons.BitmapButton.BitmapButton _bitmapButton = null;

        //public Learning_ClassLibrary.Buttons.BitmapButton.BitmapButton AddButton
        //{
        //    get
        //    {
        //        return _bitmapButton;
        //    }
        //    set
        //    {
        //        _bitmapButton = value;
        //    }
        //}

        /// <summary>
        /// Property Bubbling
        /// یعنی ویژگی یک کنترل را که درون یک کنترل دیگر به کار رفته است را به دنیای بیرون آن کنترل اصلی انتقال دهیم 
        /// </summary>
        private string _AddButtonText = null;
        public string AddButtonText
        {
            get
            {
                btnAdd.Text = _AddButtonText;
                return (btnAdd.Text);
            }
            set
            {
                _AddButtonText = value;
                btnAdd.Text = AddButtonText;
            }
        }

        public string UpdateButtonText
        {
            get
            {
                return (btnUpdate.Text);
            }
            set
            {
                btnUpdate.Text = value;
            }
        }

        /// <summary>
        ///  event خلق یک 
        ///  An event is a wrapper around a delegate. It depends on the delegate.
        ///  Use "event" keyword with delegate type variable to declare an event.
        ///  Events can be declared static, virtual, sealed, and abstract.
        ///  Name the method which raises an event prefixed with "On" with the event name.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void AddButtonEventHandler(object sender, EventArgs e);

        public event AddButtonEventHandler AddButton_Click;
        virtual protected void OnAddButton_Click(EventArgs e)
        {
            if (AddButton_Click != null)
            {
                AddButton_Click(this, e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Add Button is clicked!");

            OnAddButton_Click(e);
        }

        public delegate void UpdateButtonEventHandler(object sender, EventArgs e);

        public event UpdateButtonEventHandler UpdateButton_Click;

        protected virtual void OnUpdateButton_Click(EventArgs e)
        {
            if (UpdateButton_Click != null)
            {
                UpdateButton_Click(this, e);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            OnUpdateButton_Click(e);
        }


    }
}
