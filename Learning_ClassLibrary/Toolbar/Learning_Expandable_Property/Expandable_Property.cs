using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Learning_ClassLibrary.Toolbar.Learning_Expandable_Property
{
    public partial class Expandable_Property : MyUserControl
    {
      
        private System.ComponentModel.IContainer components = null;

        public Expandable_Property()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        public Buttons.DefaultButton.Button MyButton { get; set; }

        //[EditorBrowsable(EditorBrowsableState.Always)]
        //  [Editor(typeof(ColorEditor), typeof(UITypeEditor))]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]

        private BorderAppearance _borderAppearanceValue = 
            new BorderAppearance();

        [Browsable(true)]
        [Category("Demo")]
        [TypeConverter(typeof(BorderAppearanceConverter))]
        public BorderAppearance Border
        {
            get
            {
                return this._borderAppearanceValue;
            }

            set
            {
                this._borderAppearanceValue = value;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Expandable_Property
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Name = "Expandable_Property";
            this.Size = new System.Drawing.Size(189, 127);
            this.ResumeLayout(false);

        }
    }
 
}
