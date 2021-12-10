
namespace TestProject
{
    partial class TestForm2
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
            Learning_ClassLibrary.Toolbar.Learning_Expandable_Property.BorderAppearance borderAppearance1 = new Learning_ClassLibrary.Toolbar.Learning_Expandable_Property.BorderAppearance();
            this.myToolbar1 = new Learning_ClassLibrary.Toolbar.MyToolbar();
            this.myTextBox1 = new Learning_ClassLibrary.TextBox.MyTextBox();
            this.myTextBox2 = new Learning_ClassLibrary.TextBox.MyTextBox();
            this.expandable_Property1 = new Learning_ClassLibrary.Toolbar.Learning_Expandable_Property.Expandable_Property();
            this.button1 = new Learning_ClassLibrary.Buttons.DefaultButton.Button();
            this.SuspendLayout();
            // 
            // myToolbar1
            // 
            this.myToolbar1.AddButtonText = "درج اطلاعات";
            this.myToolbar1.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.myToolbar1.Location = new System.Drawing.Point(102, 301);
            this.myToolbar1.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.myToolbar1.Name = "myToolbar1";
            this.myToolbar1.Size = new System.Drawing.Size(643, 70);
            this.myToolbar1.TabIndex = 0;
            this.myToolbar1.UpdateButtonText = "تغییر اطلاعات";
            this.myToolbar1.AddButton_Click += new Learning_ClassLibrary.Toolbar.MyToolbar.AddButtonEventHandler(this.myToolbar1_AddButton_Click);
            this.myToolbar1.UpdateButton_Click += new Learning_ClassLibrary.Toolbar.MyToolbar.UpdateButtonEventHandler(this.myToolbar1_UpdateButton_Click);
            // 
            // myTextBox1
            // 
            this.myTextBox1.Location = new System.Drawing.Point(246, 66);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.PassWordChar = '\0';
            this.myTextBox1.Required = true;
            this.myTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.myTextBox1.Size = new System.Drawing.Size(284, 35);
            this.myTextBox1.TabIndex = 1;
            this.myTextBox1.TextType = Learning_ClassLibrary.TextBox.TextBoxType.Number;
            this.myTextBox1.Validating += new System.ComponentModel.CancelEventHandler(this.myTextBox1_Validating);
            // 
            // myTextBox2
            // 
            this.myTextBox2.Location = new System.Drawing.Point(246, 126);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.PassWordChar = '\0';
            this.myTextBox2.Required = false;
            this.myTextBox2.Size = new System.Drawing.Size(284, 35);
            this.myTextBox2.TabIndex = 2;
            this.myTextBox2.TextType = Learning_ClassLibrary.TextBox.TextBoxType.Text;
            // 
            // expandable_Property1
            // 
            this.expandable_Property1.BackColor = System.Drawing.Color.MistyRose;
            borderAppearance1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            borderAppearance1.BorderSize = 40;
            this.expandable_Property1.Border = borderAppearance1;
            this.expandable_Property1.Font = new System.Drawing.Font("IRANSans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expandable_Property1.Location = new System.Drawing.Point(75, 221);
            this.expandable_Property1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.expandable_Property1.MyButton = this.button1;
            this.expandable_Property1.Name = "expandable_Property1";
            this.expandable_Property1.Size = new System.Drawing.Size(150, 150);
            this.expandable_Property1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TestForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.expandable_Property1);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox1);
            this.Controls.Add(this.myToolbar1);
            this.Name = "TestForm2";
            this.Text = "TestForm2";
            this.Load += new System.EventHandler(this.TestForm2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Learning_ClassLibrary.Toolbar.MyToolbar myToolbar1;
        private Learning_ClassLibrary.TextBox.MyTextBox myTextBox1;
        private Learning_ClassLibrary.TextBox.MyTextBox myTextBox2;
        private Learning_ClassLibrary.Toolbar.Learning_Expandable_Property.Expandable_Property expandable_Property1;
        private Learning_ClassLibrary.Buttons.DefaultButton.Button button1;
    }
}