namespace ExamFingerprintVerificationSystem
{
    partial class MainForm
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
            this.lollipopLabel1 = new LollipopLabel();
            this.lollipopButton1 = new LollipopButton();
            this.btn_verify = new System.Windows.Forms.Button();
            this.btn_enrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(88, 21);
            this.lollipopLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(296, 23);
            this.lollipopLabel1.TabIndex = 1;
            this.lollipopLabel1.Text = "Examination Simulation System";
            // 
            // lollipopButton1
            // 
            this.lollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopButton1.BGColor = "#F4F4F4";
            this.lollipopButton1.Enabled = false;
            this.lollipopButton1.FontColor = "#ffffff";
            this.lollipopButton1.Location = new System.Drawing.Point(54, 96);
            this.lollipopButton1.Name = "lollipopButton1";
            this.lollipopButton1.Size = new System.Drawing.Size(359, 1);
            this.lollipopButton1.TabIndex = 2;
            // 
            // btn_verify
            // 
            this.btn_verify.BackColor = System.Drawing.Color.Transparent;
            this.btn_verify.BackgroundImage = global::ExamFingerprintVerificationSystem.Properties.Resources.barcode;
            this.btn_verify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_verify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_verify.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verify.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_verify.Location = new System.Drawing.Point(247, 103);
            this.btn_verify.Name = "btn_verify";
            this.btn_verify.Size = new System.Drawing.Size(166, 119);
            this.btn_verify.TabIndex = 3;
            this.btn_verify.Text = "Verification";
            this.btn_verify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_verify.UseVisualStyleBackColor = false;
            this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
            // 
            // btn_enrol
            // 
            this.btn_enrol.BackColor = System.Drawing.Color.Transparent;
            this.btn_enrol.BackgroundImage = global::ExamFingerprintVerificationSystem.Properties.Resources.sign_up;
            this.btn_enrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_enrol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enrol.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enrol.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_enrol.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_enrol.Location = new System.Drawing.Point(54, 103);
            this.btn_enrol.Name = "btn_enrol";
            this.btn_enrol.Size = new System.Drawing.Size(166, 119);
            this.btn_enrol.TabIndex = 3;
            this.btn_enrol.Text = "Enrollment";
            this.btn_enrol.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_enrol.UseVisualStyleBackColor = false;
            this.btn_enrol.Click += new System.EventHandler(this.btn_enrol_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ExamFingerprintVerificationSystem.Properties.Resources._2081169_L;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 335);
            this.Controls.Add(this.btn_enrol);
            this.Controls.Add(this.btn_verify);
            this.Controls.Add(this.lollipopButton1);
            this.Controls.Add(this.lollipopLabel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination Fingerprint Verification System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LollipopLabel lollipopLabel1;
        private LollipopButton lollipopButton1;
        private System.Windows.Forms.Button btn_verify;
        private System.Windows.Forms.Button btn_enrol;
    }
}

