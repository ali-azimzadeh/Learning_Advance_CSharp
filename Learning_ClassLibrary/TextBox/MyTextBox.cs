using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_ClassLibrary.TextBox
{
    public class MyTextBox : System.Windows.Forms.TextBox
    {
        public MyTextBox() : base()
        {

        }

        private TextBoxType _textBoxType;

        public TextBoxType TextType
        {
            get
            {
                return _textBoxType;
            }
            set
            {
                _textBoxType = value;

                if (_textBoxType == TextBoxType.Password)
                {
                    this.PasswordChar = PassWordChar;
                }

                if (_textBoxType == TextBoxType.Number)
                {
                    this.RightToLeft = RightToLeft.No;
                }

            }
        }

        private char _chrPassWord;
        public char PassWordChar
        {
            get
            {
                return _chrPassWord;
            }
            set
            {
                _chrPassWord = value;
            }
        }

        private bool _required = false;
        public bool Required
        {
            get
            {
                return _required;
            }

            set
            {
                _required = value;
            }
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (this.TextType == TextBoxType.Number)
            {
                if (!((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                {
                    //بی خیال شو
                    e.Handled = true;
                }
            }

            base.OnKeyPress(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
        }

        protected override void OnValidated(EventArgs e)
        {
            if (Required == true)
            {
                if (string.IsNullOrWhiteSpace(this.Text) == true)
                {
                    BackColor = Color.Orange;
                }
            }
            base.OnValidated(e);
        }
    }
}
