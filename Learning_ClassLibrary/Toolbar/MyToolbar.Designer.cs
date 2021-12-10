
namespace Learning_ClassLibrary.Toolbar
{
    partial class MyToolbar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new Learning_ClassLibrary.Buttons.BitmapButton.BitmapButton();
            this.btnUpdate = new Learning_ClassLibrary.Buttons.BitmapButton.BitmapButton();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnAdd.FocusRectangleEnabled = true;
            this.btnAdd.Image = null;
            this.btnAdd.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnAdd.ImageBorderEnabled = true;
            this.btnAdd.ImageDropShadow = true;
            this.btnAdd.ImageFocused = null;
            this.btnAdd.ImageInactive = null;
            this.btnAdd.ImageMouseOver = null;
            this.btnAdd.ImageNormal = null;
            this.btnAdd.ImagePressed = null;
            this.btnAdd.InnerBorderColor = System.Drawing.Color.LightGray;
            this.btnAdd.InnerBorderColor_Focus = System.Drawing.Color.LightBlue;
            this.btnAdd.InnerBorderColor_MouseOver = System.Drawing.Color.Gold;
            this.btnAdd.Location = new System.Drawing.Point(509, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OffsetPressedContent = true;
            this.btnAdd.Size = new System.Drawing.Size(133, 70);
            this.btnAdd.StretchImage = false;
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ثبت اطلاعات";
            this.btnAdd.TextDropShadow = true;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.DarkBlue;
            this.btnUpdate.FocusRectangleEnabled = true;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageBorderColor = System.Drawing.Color.Chocolate;
            this.btnUpdate.ImageBorderEnabled = true;
            this.btnUpdate.ImageDropShadow = true;
            this.btnUpdate.ImageFocused = null;
            this.btnUpdate.ImageInactive = null;
            this.btnUpdate.ImageMouseOver = null;
            this.btnUpdate.ImageNormal = null;
            this.btnUpdate.ImagePressed = null;
            this.btnUpdate.InnerBorderColor = System.Drawing.Color.LightGray;
            this.btnUpdate.InnerBorderColor_Focus = System.Drawing.Color.LightBlue;
            this.btnUpdate.InnerBorderColor_MouseOver = System.Drawing.Color.Gold;
            this.btnUpdate.Location = new System.Drawing.Point(377, 0);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OffsetPressedContent = true;
            this.btnUpdate.Size = new System.Drawing.Size(133, 70);
            this.btnUpdate.StretchImage = false;
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "اصلاح اطلاعات";
            this.btnUpdate.TextDropShadow = true;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MyToolbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "MyToolbar";
            this.Size = new System.Drawing.Size(643, 70);
            this.ResumeLayout(false);

        }

        #endregion

        private Buttons.BitmapButton.BitmapButton btnAdd;
        private Buttons.DefaultButton.Button button1;
        private Buttons.BitmapButton.BitmapButton btnUpdate;
    }
}
