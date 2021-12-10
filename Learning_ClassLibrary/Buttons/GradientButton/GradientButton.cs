using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning_ClassLibrary.Buttons.GradientButton
{
    public class GradientButton : DefaultButton.Button
    {
        private System.Drawing.Color _firstColor;
        private System.Drawing.Color _secondColor;
        private System.Drawing.Drawing2D.LinearGradientMode _gradientMode;
        private static System.Drawing.StringFormat CaptionFormat = new System.Drawing.StringFormat();
        private bool IsPushed, _flag = true;
        private Color DefaultColor, _disableFirstColor, _disableSecondColor, DefaultFirstColor, DefaultSecondColor;
        public GradientButton()
        {
            _firstColor = System.Drawing.Color.Yellow;
            _secondColor = System.Drawing.Color.Red;
            _gradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            CaptionFormat.Alignment = System.Drawing.StringAlignment.Center;
            CaptionFormat.LineAlignment = System.Drawing.StringAlignment.Center;
            DisableFirstColor = Color.Gray;
            DisableSecondColor = Color.WhiteSmoke;
        }

        [System.ComponentModel.DefaultValue(typeof(Color), "Yellow")]
        [System.ComponentModel.Description("رنگ اولیه افکت دکمه که بصورت متحرک یا حالت شیب دار است را تعیین می کند")]
        public System.Drawing.Color FirstColor
        {
            get
            {
                return (_firstColor);
            }
            set
            {
                _firstColor = value;
                if (this.IsHandleCreated && this.Visible)
                {
                    this.Invalidate();
                }
            }
        }

        [System.ComponentModel.DefaultValue(typeof(Color), "Red")]
        [System.ComponentModel.Description("رنگ ثانویه افکت دکمه که بصورت متحرک یا حالت شیب دار است را تعیین می کند")]
        public System.Drawing.Color SecondColor
        {
            get
            {
                return (_secondColor);
            }
            set
            {
                _secondColor = value;
                if (this.IsHandleCreated && this.Visible)
                {
                    this.Invalidate();
                }
            }
        }

        [System.ComponentModel.DefaultValue(typeof(Color), "Gray")]
        [System.ComponentModel.Description("رنگ اولیه افکت دکمه هنگامی که دکمه غیر فعال است را تعیین می کند")]
        public Color DisableFirstColor
        {
            get
            {
                return _disableFirstColor;
            }
            set
            {
                _disableFirstColor = value;
            }
        }

        [System.ComponentModel.DefaultValue(typeof(Color), "WhiteSmoke")]
        [System.ComponentModel.Description("رنگ ثانویه افکت دکمه هنگامی که دکمه غیر فعال است را تعیین می کند")]
        public Color DisableSecondColor
        {
            get
            {
                return _disableSecondColor;
            }
            set
            {
                _disableSecondColor = value;
            }
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                _flag = true;
            }
        }

        [System.ComponentModel.DefaultValue(System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)]
        [System.ComponentModel.Description("نوع افکت دکمه هنگامی را تعیین می کند")]
        public System.Drawing.Drawing2D.LinearGradientMode GradientMode
        {
            get
            {
                return (_gradientMode);
            }
            set
            {
                _gradientMode = value;
                this.Invalidate();
            }
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            if (_flag)
            {
                DefaultColor = this.ForeColor;
                _flag = false;
            }
            base.OnForeColorChanged(e);
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            if (Enabled)
            {
                this.FirstColor = DefaultFirstColor;
                this.SecondColor = DefaultSecondColor;
            }
            else
            {
                DefaultFirstColor = this.FirstColor;
                DefaultSecondColor = this.SecondColor;
                this.FirstColor = this.DisableFirstColor;
                this.SecondColor = this.DisableSecondColor;
            }
            base.OnEnabledChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            //base.OnPaint (e);
            //System.Drawing.Graphics gButton=e.Graphics;
            //System.Drawing.Rectangle ButtonRect=this.ClientRectangle;
            //ButtonRect.Inflate(-2,-2);
            //if (IsPushed)
            //{
            //    ButtonRect.X++;
            //    ButtonRect.Y++;
            //    ButtonRect.Width--;
            //    ButtonRect.Height--;
            //}
            //System.Drawing.Drawing2D.LinearGradientBrush GradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(ButtonRect,_firstColor,_secondColor,GradientMode);
            //gButton.FillRectangle(GradientBrush,ButtonRect);
            //gButton.DrawString(this.Text,this.Font,new System.Drawing.SolidBrush(this.ForeColor),ButtonRect,CaptionFormat);

            //   base.OnPaint(e);
            System.Drawing.Pen skyBluePen = new System.Drawing.Pen(System.Drawing.Brushes.Red);
            System.Drawing.Graphics gButton = e.Graphics;
            //            System.Drawing.Drawing2D.GraphicsPath gButton = new System.Drawing.Drawing2D.GraphicsPath();
            //     gButton=e.Graphics;
            System.Drawing.Rectangle ButtonRect = this.ClientRectangle;
            ButtonRect.Inflate(-5, -5);
            if (IsPushed)
            {
                ButtonRect.X += 2;
                ButtonRect.Y += 2;
                ButtonRect.Width--;
                ButtonRect.Height--;
            }
            gButton.Clear(this.BackColor);
            if (!Enabled)
            {
                this.ForeColor = Color.WhiteSmoke;// SystemColors.ActiveBorder;
                System.Drawing.Drawing2D.LinearGradientBrush GradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(ButtonRect, SecondColor, FirstColor, GradientMode);
                gButton.FillEllipse(GradientBrush, ButtonRect);
            }
            else
            {
                this.ForeColor = DefaultColor;
                System.Drawing.Drawing2D.LinearGradientBrush GradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(ButtonRect, FirstColor, SecondColor, GradientMode);
                gButton.FillEllipse(GradientBrush, ButtonRect);
            }
            //   e.Graphics.DrawArc(skyBluePen, new Rectangle(this.Location, this.Size),0,360); 
            //e.Graphics.DrawRectangle(skyBluePen, new Rectangle(this.Location, this.Size));
            gButton.DrawString(this.Text, this.Font, new System.Drawing.SolidBrush(this.ForeColor), ButtonRect, CaptionFormat);

        }

        protected override void OnMouseHover(EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            IsPushed = true;
            Color Scolor = this.SecondColor;
            Color Fcolor = this.FirstColor;
            this.FirstColor = Scolor;
            this.SecondColor = Fcolor;
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            IsPushed = false;
            Color Scolor = this.SecondColor;
            Color Fcolor = this.FirstColor;
            this.FirstColor = Scolor;
            this.SecondColor = Fcolor;
            base.OnMouseUp(e);
        }
    }
}
