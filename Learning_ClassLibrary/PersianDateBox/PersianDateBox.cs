using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_ClassLibrary.PersianDateBox
{
    //public partial class PersianDateBox : Toolbar.MyUserControl
    //{
    //    public PersianDateBox()
    //    {
    //        InitializeComponent();
    //    }
    //}

    public partial class PersianDateBox : UserControl
    {
     
        public PersianDateBox()
        {
            InitializeComponent();
        }

        //************************************

        //************************************

        private MaskFormat _mskText;
        public MaskFormat MaskTextFormat
        {
            get
            {
                return _mskText;
            }
            set
            {
                _mskText = value;
                this.mskTextBox.TextMaskFormat = _mskText;
            }
        }

        //************************************

        //************************************

        private string _dateText;
        public string FormattedText
        {
            get
            {
                return _dateText;
            }
            set
            {
                _dateText = value;
                this.mskTextBox.Text = _dateText;
            }
        }

        //************************************

        //************************************

        private bool _dateRequired;
        public bool Required
        {
            get
            {
                return _dateRequired;
            }
            set
            {
                _dateRequired = value;

                if (!_dateRequired)
                {
                    RequiredColor = SystemColors.Window;
                }
                else
                {
                    RequiredColor = Color.LightGoldenrodYellow;
                }
            }
        }

        //************************************

        //************************************

        private Color _dateRequiredColor = Color.LightGoldenrodYellow;
        public Color RequiredColor
        {
            get
            {
                return _dateRequiredColor;
            }
            set
            {
                _dateRequiredColor = value;
                this.mskTextBox.BackColor = _dateRequiredColor;
            }
        }

        //************************************

        //************************************

        private string _dateErrorMessage;
        public string ErrorMessage
        {
            get
            {
                return _dateErrorMessage;
            }
            set
            {
                _dateErrorMessage = value;
            }
        }

        //************************************

        //************************************

        private ErrorIconAlignment _dateErrorIconAlignment;
        public ErrorIconAlignment ErrorIconAlignment
        {
            get
            {
                return _dateErrorIconAlignment;
            }
            set
            {
                _dateErrorIconAlignment = value;
            }
        }

        private void DateBox_RightToLeftChanged(object sender, EventArgs e)
        {
            this.RightToLeft = RightToLeft.No;
        }

        private void DateBox_Load(object sender, EventArgs e)
        {
            errorProvider1.SetError(this, string.Empty);
        }

        private void DateBox_Resize(object sender, EventArgs e)
        {
            this.Height = this.mskTextBox.Height + 2;
        }

        private void mskTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (_dateRequired) //
            {
                if (!this.mskTextBox.MaskFull)
                {
                    this.mskTextBox.SelectionStart = 2;
                    this.mskTextBox.SelectionLength = 8;
                    e.Cancel = true;
                    this.errorProvider1.SetIconAlignment(this, _dateErrorIconAlignment);
                    this.errorProvider1.SetError(this, _dateErrorMessage);
                }
                else
                {
                    e.Cancel = 
                        !IsValidDate(this.mskTextBox.Text);

                    if (e.Cancel)
                    {
                        this.errorProvider1.SetIconAlignment(this, _dateErrorIconAlignment);
                        this.errorProvider1.SetError(this, _dateErrorMessage);
                    }
                    else
                    {
                        this.errorProvider1.Dispose();
                    }
                }
            }
            else
            {
                if (!this.mskTextBox.MaskFull)
                {
                    if ((_mskText == MaskFormat.IncludeLiterals && 
                        this.mskTextBox.Text == "13  /  /") || 
                        (_mskText == MaskFormat.ExcludePromptAndLiterals && 
                        this.mskTextBox.Text == "") || 
                        (_mskText == MaskFormat.IncludePrompt && 
                        this.mskTextBox.Text == "______") || 
                        (_mskText == MaskFormat.IncludePromptAndLiterals && 
                        this.mskTextBox.Text == "13__/__/__")) 
                                                                                                                                                                                                                                                                                                                                                                  //                        if ((mskText == MaskFormat.IncludeLiterals && this.mskTextBox.Text == "13  /  /") || (mskText == MaskFormat.ExcludePromptAndLiterals && this.mskTextBox.Text == "") || (mskText == MaskFormat.IncludePrompt && this.mskTextBox.Text == "______") || (mskText == MaskFormat.IncludePromptAndLiterals && this.mskTextBox.Text == "13__/__/__")) //"13__/__/__") //)
                    {
                        e.Cancel = false;
                        this.errorProvider1.Dispose();
                    }
                    else
                    {
                        this.mskTextBox.SelectionStart = 2;
                        this.mskTextBox.SelectionLength = 8;
                        e.Cancel = true;
                        this.errorProvider1.SetIconAlignment(this, _dateErrorIconAlignment);
                        this.errorProvider1.SetError(this, _dateErrorMessage);
                    }
                }
                else
                {
                    e.Cancel = 
                        !IsValidDate(this.mskTextBox.Text);

                    if (e.Cancel)
                    {
                        this.errorProvider1.SetIconAlignment(this, _dateErrorIconAlignment);
                        this.errorProvider1.SetError(this, _dateErrorMessage);
                    }
                    else
                    {
                        this.errorProvider1.Dispose();
                    }
                }

            }
        }
        public bool IsValidDate(object sender)
        {
            if (Convert.ToInt32(this.mskTextBox.Text.Substring(5, 2)) > 12 || 
                Convert.ToInt32(this.mskTextBox.Text.Substring(5, 2)) == 0)
            {
                //    dateErrorMessage = "ßÇÑÈÑ ÑÇãí ÚÏÏ æÇÑÏ ÔÏå ÏÑ ÞÓãÊ ãÇå ÈÒÑÊÑ ÇÒ 12 ãí ÈÇÔÏ áØÝÇ ÇÕáÇÍ äãÇííÏ";
                this.mskTextBox.SelectionStart = 5;
                this.mskTextBox.SelectionLength = 2;
                return false;
            }
            else
            {
                if ((Convert.ToInt32(this.mskTextBox.Text.Substring(5, 2)) < 7 &&
                    Convert.ToInt32(this.mskTextBox.Text.Substring(8, 2)) > 31 ||
                    Convert.ToInt32(this.mskTextBox.Text.Substring(8, 2)) == 0))
                {
                    //    dateErrorMessage = "ßÇÑÈÑ ÑÇãí ÚÏÏ æÇÑÏ ÔÏå ÏÑ ÞÓãÊ ãÇå ÈÒÑÊÑ ÇÒ 12 ãí ÈÇÔÏ áØÝÇ ÇÕáÇÍ äãÇííÏ";
                    this.mskTextBox.SelectionStart = 8;
                    this.mskTextBox.SelectionLength = 2;
                    return false;
                }
                else
                {
                    if ((Convert.ToInt32(this.mskTextBox.Text.Substring(5, 2)) > 6 &&
                        Convert.ToInt32(this.mskTextBox.Text.Substring(8, 2)) > 30 ||
                        Convert.ToInt32(this.mskTextBox.Text.Substring(5, 2)) == 12 && 
                        Convert.ToInt32(this.mskTextBox.Text.Substring(8, 2)) == 30) || 
                        Convert.ToInt32(this.mskTextBox.Text.Substring(8, 2)) == 0)
                    {
                        //    dateErrorMessage = "ßÇÑÈÑ ÑÇãí ÚÏÏ æÇÑÏ ÔÏå ÏÑ ÞÓãÊ ãÇå ÈÒÑÊÑ ÇÒ 12 ãí ÈÇÔÏ áØÝÇ ÇÕáÇÍ äãÇííÏ";
                        this.mskTextBox.SelectionStart = 8;
                        this.mskTextBox.SelectionLength = 2;
                        return false;
                    }
                }
            }
            _dateText = this.mskTextBox.Text;
            return true;
        }


        private void DateBox_Enter(object sender, EventArgs e)
        {
            if (!this.mskTextBox.MaskFull && _dateRequired)
            {
                this.mskTextBox.Focus();
                this.mskTextBox.SelectionStart = 2;
                this.mskTextBox.SelectionLength = 8;
            }
        }

        private void mskTextBox_Enter(object sender, EventArgs e)
        {
            //  this.mskTextBox.SelectionStart = 2;
            //    this.mskTextBox.SelectionLength = 8;
        }

        private void mskTextBox_Leave(object sender, EventArgs e)
        {
            this.mskTextBox.DeselectAll();
        }

    }
}
