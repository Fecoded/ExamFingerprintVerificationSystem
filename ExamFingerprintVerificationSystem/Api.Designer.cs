namespace ExamFingerprintVerificationSystem
{
    partial class Api
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
            this.StatusText = new System.Windows.Forms.TextBox();
            this.btnClose = new LollipopButton();
            this.StatusLine = new LollipopLabel();
            this.Prompt = new LollipopTextBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lollipopLabel4 = new LollipopLabel();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.txtDept = new LollipopTextBox();
            this.txtLevel = new LollipopTextBox();
            this.txtName = new LollipopTextBox();
            this.txtMatric = new LollipopTextBox();
            this.lollipopLabel5 = new LollipopLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusText
            // 
            this.StatusText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.StatusText.Location = new System.Drawing.Point(471, 93);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StatusText.Size = new System.Drawing.Size(350, 248);
            this.StatusText.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BGColor = "80, 142, 245";
            this.btnClose.FontColor = "#fff";
            this.btnClose.Location = new System.Drawing.Point(674, 347);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 26);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Clear";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // StatusLine
            // 
            this.StatusLine.AutoSize = true;
            this.StatusLine.BackColor = System.Drawing.Color.Transparent;
            this.StatusLine.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLine.ForeColor = System.Drawing.Color.White;
            this.StatusLine.Location = new System.Drawing.Point(237, 51);
            this.StatusLine.Name = "StatusLine";
            this.StatusLine.Size = new System.Drawing.Size(101, 16);
            this.StatusLine.TabIndex = 7;
            this.StatusLine.Text = "lollipopLabel1";
            // 
            // Prompt
            // 
            this.Prompt.FocusedColor = "#508ef5";
            this.Prompt.FontColor = "#508ef5";
            this.Prompt.IsEnabled = true;
            this.Prompt.Location = new System.Drawing.Point(471, 63);
            this.Prompt.MaxLength = 32767;
            this.Prompt.Multiline = false;
            this.Prompt.Name = "Prompt";
            this.Prompt.ReadOnly = true;
            this.Prompt.Size = new System.Drawing.Size(350, 24);
            this.Prompt.TabIndex = 100;
            this.Prompt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Prompt.UseSystemPasswordChar = false;
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.White;
            this.Picture.Location = new System.Drawing.Point(240, 78);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(189, 173);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 5;
            this.Picture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lollipopLabel4);
            this.groupBox1.Controls.Add(this.lollipopLabel3);
            this.groupBox1.Controls.Add(this.lollipopLabel2);
            this.groupBox1.Controls.Add(this.lollipopLabel1);
            this.groupBox1.Controls.Add(this.txtDept);
            this.groupBox1.Controls.Add(this.txtLevel);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtMatric);
            this.groupBox1.Controls.Add(this.Picture);
            this.groupBox1.Controls.Add(this.StatusLine);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 316);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Correct Details";
            // 
            // lollipopLabel4
            // 
            this.lollipopLabel4.AutoSize = true;
            this.lollipopLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel4.Location = new System.Drawing.Point(12, 204);
            this.lollipopLabel4.Name = "lollipopLabel4";
            this.lollipopLabel4.Size = new System.Drawing.Size(95, 18);
            this.lollipopLabel4.TabIndex = 9;
            this.lollipopLabel4.Text = "Department";
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(12, 145);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(51, 18);
            this.lollipopLabel3.TabIndex = 9;
            this.lollipopLabel3.Text = "Level:";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(12, 87);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(85, 18);
            this.lollipopLabel2.TabIndex = 9;
            this.lollipopLabel2.Text = "Full Name:";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(12, 32);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(84, 18);
            this.lollipopLabel1.TabIndex = 9;
            this.lollipopLabel1.Text = "Matric No:";
            // 
            // txtDept
            // 
            this.txtDept.FocusedColor = "#508ef5";
            this.txtDept.FontColor = "#000";
            this.txtDept.IsEnabled = true;
            this.txtDept.Location = new System.Drawing.Point(16, 227);
            this.txtDept.MaxLength = 32767;
            this.txtDept.Multiline = false;
            this.txtDept.Name = "txtDept";
            this.txtDept.ReadOnly = false;
            this.txtDept.Size = new System.Drawing.Size(199, 24);
            this.txtDept.TabIndex = 3;
            this.txtDept.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDept.UseSystemPasswordChar = false;
            // 
            // txtLevel
            // 
            this.txtLevel.FocusedColor = "#508ef5";
            this.txtLevel.FontColor = "#000";
            this.txtLevel.IsEnabled = true;
            this.txtLevel.Location = new System.Drawing.Point(16, 168);
            this.txtLevel.MaxLength = 32767;
            this.txtLevel.Multiline = false;
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = false;
            this.txtLevel.Size = new System.Drawing.Size(199, 24);
            this.txtLevel.TabIndex = 2;
            this.txtLevel.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLevel.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            this.txtName.FocusedColor = "#508ef5";
            this.txtName.FontColor = "#000";
            this.txtName.IsEnabled = true;
            this.txtName.Location = new System.Drawing.Point(16, 110);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = false;
            this.txtName.Size = new System.Drawing.Size(199, 24);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtMatric
            // 
            this.txtMatric.FocusedColor = "#508ef5";
            this.txtMatric.FontColor = "#000";
            this.txtMatric.IsEnabled = true;
            this.txtMatric.Location = new System.Drawing.Point(16, 54);
            this.txtMatric.MaxLength = 32767;
            this.txtMatric.Multiline = false;
            this.txtMatric.Name = "txtMatric";
            this.txtMatric.ReadOnly = false;
            this.txtMatric.Size = new System.Drawing.Size(199, 24);
            this.txtMatric.TabIndex = 0;
            this.txtMatric.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMatric.UseSystemPasswordChar = false;
            // 
            // lollipopLabel5
            // 
            this.lollipopLabel5.AutoSize = true;
            this.lollipopLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lollipopLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.lollipopLabel5.Location = new System.Drawing.Point(161, 19);
            this.lollipopLabel5.Name = "lollipopLabel5";
            this.lollipopLabel5.Size = new System.Drawing.Size(536, 23);
            this.lollipopLabel5.TabIndex = 9;
            this.lollipopLabel5.Text = "Fingerprint Verification System for Examination Simulation";
            // 
            // Api
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ExamFingerprintVerificationSystem.Properties.Resources._2081169_L;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.lollipopLabel5);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Api";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination Fingerprint Verification System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Api_FormClosed);
            this.Load += new System.EventHandler(this.Api_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StatusText;
        private LollipopButton btnClose;
        private LollipopLabel StatusLine;
        private LollipopTextBox Prompt;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.GroupBox groupBox1;
        private LollipopLabel lollipopLabel4;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
        private LollipopLabel lollipopLabel5;
        public LollipopTextBox txtDept;
        public LollipopTextBox txtLevel;
        public LollipopTextBox txtName;
        public LollipopTextBox txtMatric;
    }
}