
namespace Learning_ClassLibrary.LookupData
{
    partial class LookupForm
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
            this.lvwData = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvwData
            // 
            this.lvwData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwData.HideSelection = false;
            this.lvwData.Location = new System.Drawing.Point(0, 0);
            this.lvwData.Name = "lvwData";
            this.lvwData.RightToLeftLayout = true;
            this.lvwData.Size = new System.Drawing.Size(371, 171);
            this.lvwData.TabIndex = 0;
            this.lvwData.UseCompatibleStateImageBehavior = false;
            // 
            // LookupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 171);
            this.ControlBox = false;
            this.Controls.Add(this.lvwData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LookupForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "گزينه ای را انتخاب نماييد";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lvwData;
    }
}