namespace testsendmail
{
    partial class SendMail
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
            this.listMail = new System.Windows.Forms.ListBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.txtMailSender = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAppPassword = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMailrecep = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBSubject = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listMail
            // 
            this.listMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listMail.FormattingEnabled = true;
            this.listMail.ItemHeight = 22;
            this.listMail.Location = new System.Drawing.Point(12, 12);
            this.listMail.Name = "listMail";
            this.listMail.Size = new System.Drawing.Size(325, 598);
            this.listMail.TabIndex = 0;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.txtMailSender);
            this.gb.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gb.Location = new System.Drawing.Point(358, 25);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(350, 56);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "Email người gửi";
            // 
            // txtMailSender
            // 
            this.txtMailSender.Location = new System.Drawing.Point(22, 23);
            this.txtMailSender.Name = "txtMailSender";
            this.txtMailSender.Size = new System.Drawing.Size(322, 28);
            this.txtMailSender.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAppPassword);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(358, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 56);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "App Password";
            // 
            // txtAppPassword
            // 
            this.txtAppPassword.Location = new System.Drawing.Point(22, 23);
            this.txtAppPassword.Name = "txtAppPassword";
            this.txtAppPassword.Size = new System.Drawing.Size(322, 28);
            this.txtAppPassword.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMailrecep);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(769, 98);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 56);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Email người nhận";
            // 
            // txtMailrecep
            // 
            this.txtMailrecep.Location = new System.Drawing.Point(22, 23);
            this.txtMailrecep.Name = "txtMailrecep";
            this.txtMailrecep.Size = new System.Drawing.Size(322, 28);
            this.txtMailrecep.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.rBSubject);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(358, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 62);
            this.panel1.TabIndex = 5;
            // 
            // rBSubject
            // 
            this.rBSubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rBSubject.Location = new System.Drawing.Point(94, 10);
            this.rBSubject.Name = "rBSubject";
            this.rBSubject.Size = new System.Drawing.Size(643, 41);
            this.rBSubject.TabIndex = 1;
            this.rBSubject.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiêu đề :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.rBContent);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(358, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 309);
            this.panel2.TabIndex = 6;
            // 
            // rBContent
            // 
            this.rBContent.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rBContent.Location = new System.Drawing.Point(111, 22);
            this.rBContent.Name = "rBContent";
            this.rBContent.Size = new System.Drawing.Size(625, 273);
            this.rBContent.TabIndex = 3;
            this.rBContent.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(14, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nội dung :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(995, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gửi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1142, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.listMail);
            this.Name = "SendMail";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SendMail_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listMail;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMailSender;
        private System.Windows.Forms.TextBox txtAppPassword;
        private System.Windows.Forms.TextBox txtMailrecep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rBSubject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rBContent;
        private System.Windows.Forms.Button button1;
    }
}

