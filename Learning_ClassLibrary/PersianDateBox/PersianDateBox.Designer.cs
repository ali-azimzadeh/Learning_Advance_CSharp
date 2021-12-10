
namespace Learning_ClassLibrary.PersianDateBox
{
    partial class PersianDateBox
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mskTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mskTextBox
            // 
            this.mskTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mskTextBox.HideSelection = false;
            this.mskTextBox.Location = new System.Drawing.Point(0, 0);
            this.mskTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.mskTextBox.Mask = "13##/##/##";
            this.mskTextBox.MaximumSize = new System.Drawing.Size(99, 30);
            this.mskTextBox.Name = "mskTextBox";
            this.mskTextBox.RejectInputOnFirstFailure = true;
            this.mskTextBox.Size = new System.Drawing.Size(99, 30);
            this.mskTextBox.TabIndex = 0;
            this.mskTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskTextBox.Enter += new System.EventHandler(this.mskTextBox_Enter);
            this.mskTextBox.Leave += new System.EventHandler(this.mskTextBox_Leave);
            this.mskTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.mskTextBox_Validating);
            // 
            // PersianDateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mskTextBox);
            this.Font = new System.Drawing.Font("IRANSans(FaNum)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersianDateBox";
            this.Size = new System.Drawing.Size(101, 28);
            this.Load += new System.EventHandler(this.DateBox_Load);
            this.RightToLeftChanged += new System.EventHandler(this.DateBox_RightToLeftChanged);
            this.Enter += new System.EventHandler(this.DateBox_Enter);
            this.Resize += new System.EventHandler(this.DateBox_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox mskTextBox;
    }
}
