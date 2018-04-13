namespace Day06
{
    partial class Server
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
            this.btnSend = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnMusic = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rTB1 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lbIP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(794, 382);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 82);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(794, 240);
            this.btnImg.Margin = new System.Windows.Forms.Padding(4);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(100, 41);
            this.btnImg.TabIndex = 16;
            this.btnImg.Text = "Images";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnMusic
            // 
            this.btnMusic.Location = new System.Drawing.Point(794, 163);
            this.btnMusic.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusic.Name = "btnMusic";
            this.btnMusic.Size = new System.Drawing.Size(100, 41);
            this.btnMusic.TabIndex = 15;
            this.btnMusic.Text = "Musics";
            this.btnMusic.UseVisualStyleBackColor = true;
            this.btnMusic.Click += new System.EventHandler(this.btnMusic_Click);
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(794, 80);
            this.btnFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(100, 43);
            this.btnFile.TabIndex = 14;
            this.btnFile.Text = "Files";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Message";
            // 
            // rTB1
            // 
            this.rTB1.Location = new System.Drawing.Point(50, 382);
            this.rTB1.Margin = new System.Windows.Forms.Padding(4);
            this.rTB1.Name = "rTB1";
            this.rTB1.Size = new System.Drawing.Size(679, 82);
            this.rTB1.TabIndex = 12;
            this.rTB1.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(50, 80);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(679, 244);
            this.listBox1.TabIndex = 11;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(165, 26);
            this.tbIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(233, 22);
            this.tbIP.TabIndex = 10;
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(46, 30);
            this.lbIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(59, 17);
            this.lbIP.TabIndex = 9;
            this.lbIP.Text = "Client IP";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 483);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnMusic);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTB1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.lbIP);
            this.Name = "Server";
            this.Text = "Chat Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnMusic;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rTB1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lbIP;
    }
}

