namespace QADTimeTabler
{
    partial class Preloader
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
            this.Btn_Continue = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Continue
            // 
            this.Btn_Continue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Btn_Continue.FlatAppearance.BorderSize = 0;
            this.Btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Continue.ForeColor = System.Drawing.Color.White;
            this.Btn_Continue.Location = new System.Drawing.Point(104, 55);
            this.Btn_Continue.Name = "Btn_Continue";
            this.Btn_Continue.Size = new System.Drawing.Size(84, 31);
            this.Btn_Continue.TabIndex = 0;
            this.Btn_Continue.Text = "Continue";
            this.Btn_Continue.UseVisualStyleBackColor = false;
            this.Btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.progressBar1.Location = new System.Drawing.Point(12, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(287, 18);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Value = 50;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(8, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loading";
            // 
            // Preloader
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(311, 88);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.Btn_Continue);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preloader";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Starting QADTimetabler";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Preloader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Continue;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}