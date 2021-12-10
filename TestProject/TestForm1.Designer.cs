
namespace TestProject
{
    partial class TestForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bitmapButton1 = new Learning_ClassLibrary.Buttons.BitmapButton.BitmapButton();
            this.button1 = new Learning_ClassLibrary.Buttons.DefaultButton.Button();
            this.glassButton1 = new Learning_ClassLibrary.Buttons.GlassButton.GlassButton();
            this.gradientButton1 = new Learning_ClassLibrary.Buttons.GradientButton.GradientButton();
            this.SuspendLayout();
            // 
            // bitmapButton1
            // 
            this.bitmapButton1.BorderColor = System.Drawing.Color.DarkBlue;
            this.bitmapButton1.FocusRectangleEnabled = true;
            this.bitmapButton1.Image = null;
            this.bitmapButton1.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.bitmapButton1.ImageBorderEnabled = true;
            this.bitmapButton1.ImageDropShadow = true;
            this.bitmapButton1.ImageFocused = null;
            this.bitmapButton1.ImageInactive = null;
            this.bitmapButton1.ImageMouseOver = null;
            this.bitmapButton1.ImageNormal = null;
            this.bitmapButton1.ImagePressed = null;
            this.bitmapButton1.InnerBorderColor = System.Drawing.Color.LightGray;
            this.bitmapButton1.InnerBorderColor_Focus = System.Drawing.Color.LightBlue;
            this.bitmapButton1.InnerBorderColor_MouseOver = System.Drawing.Color.Gold;
            this.bitmapButton1.Location = new System.Drawing.Point(12, 75);
            this.bitmapButton1.Name = "bitmapButton1";
            this.bitmapButton1.OffsetPressedContent = true;
            this.bitmapButton1.Size = new System.Drawing.Size(438, 59);
            this.bitmapButton1.StretchImage = false;
            this.bitmapButton1.TabIndex = 0;
            this.bitmapButton1.Text = "bitmapButton1";
            this.bitmapButton1.TextDropShadow = true;
            this.bitmapButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(438, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // glassButton1
            // 
            this.glassButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glassButton1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.glassButton1.Location = new System.Drawing.Point(12, 152);
            this.glassButton1.Name = "glassButton1";
            this.glassButton1.Size = new System.Drawing.Size(438, 64);
            this.glassButton1.TabIndex = 2;
            this.glassButton1.Text = "glassButton1";
            this.glassButton1.UseVisualStyleBackColor = false;
            // 
            // gradientButton1
            // 
            this.gradientButton1.Location = new System.Drawing.Point(12, 233);
            this.gradientButton1.Name = "gradientButton1";
            this.gradientButton1.Size = new System.Drawing.Size(438, 58);
            this.gradientButton1.TabIndex = 3;
            this.gradientButton1.Text = "gradientButton1";
            this.gradientButton1.UseVisualStyleBackColor = true;
            // 
            // TestForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 303);
            this.Controls.Add(this.gradientButton1);
            this.Controls.Add(this.glassButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bitmapButton1);
            this.Name = "TestForm1";
            this.Text = "TestForm1";
            this.ResumeLayout(false);

        }

        #endregion

        private Learning_ClassLibrary.Buttons.BitmapButton.BitmapButton bitmapButton1;
        private Learning_ClassLibrary.Buttons.DefaultButton.Button button1;
        private Learning_ClassLibrary.Buttons.GlassButton.GlassButton glassButton1;
        private Learning_ClassLibrary.Buttons.GradientButton.GradientButton gradientButton1;
    }
}