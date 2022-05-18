namespace QADTimeTabler
{
    partial class AboutSoftware
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
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_Ok.Location = new System.Drawing.Point(244, 280);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(96, 30);
            this.Btn_Ok.TabIndex = 0;
            this.Btn_Ok.Text = "Ok";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // AboutSoftware
            // 
            this.AcceptButton = this.Btn_Ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(342, 316);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Ok);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutSoftware";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About QAD TimeTabler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Ok;
    }
}