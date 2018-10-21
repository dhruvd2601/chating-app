namespace Text_Chat
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.localport = new System.Windows.Forms.TextBox();
            this.locaip = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.friendport = new System.Windows.Forms.TextBox();
            this.friendip = new System.Windows.Forms.TextBox();
            this.messageworkspace = new System.Windows.Forms.ListBox();
            this.textmessage = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.End = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.localport);
            this.groupBox1.Controls.Add(this.locaip);
            this.groupBox1.Location = new System.Drawing.Point(32, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 157);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "   Your Address   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // localport
            // 
            this.localport.Location = new System.Drawing.Point(222, 88);
            this.localport.Name = "localport";
            this.localport.Size = new System.Drawing.Size(114, 22);
            this.localport.TabIndex = 1;
            // 
            // locaip
            // 
            this.locaip.Location = new System.Drawing.Point(120, 31);
            this.locaip.Name = "locaip";
            this.locaip.Size = new System.Drawing.Size(216, 22);
            this.locaip.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.friendport);
            this.groupBox2.Controls.Add(this.friendip);
            this.groupBox2.Location = new System.Drawing.Point(500, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 156);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  Friend ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // friendport
            // 
            this.friendport.Location = new System.Drawing.Point(286, 92);
            this.friendport.Name = "friendport";
            this.friendport.Size = new System.Drawing.Size(103, 22);
            this.friendport.TabIndex = 1;
            // 
            // friendip
            // 
            this.friendip.Location = new System.Drawing.Point(152, 31);
            this.friendip.Name = "friendip";
            this.friendip.Size = new System.Drawing.Size(237, 22);
            this.friendip.TabIndex = 0;
            // 
            // messageworkspace
            // 
            this.messageworkspace.FormattingEnabled = true;
            this.messageworkspace.ItemHeight = 16;
            this.messageworkspace.Location = new System.Drawing.Point(35, 236);
            this.messageworkspace.Name = "messageworkspace";
            this.messageworkspace.Size = new System.Drawing.Size(872, 212);
            this.messageworkspace.TabIndex = 2;
            this.messageworkspace.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textmessage
            // 
            this.textmessage.Location = new System.Drawing.Point(32, 470);
            this.textmessage.Name = "textmessage";
            this.textmessage.Size = new System.Drawing.Size(875, 22);
            this.textmessage.TabIndex = 3;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(955, 236);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(92, 35);
            this.start.TabIndex = 4;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(955, 312);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(92, 35);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // End
            // 
            this.End.Enabled = false;
            this.End.Location = new System.Drawing.Point(955, 378);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(92, 36);
            this.End.TabIndex = 6;
            this.End.Text = "End";
            this.End.UseVisualStyleBackColor = true;
            this.End.Click += new System.EventHandler(this.End_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 581);
            this.Controls.Add(this.End);
            this.Controls.Add(this.send);
            this.Controls.Add(this.start);
            this.Controls.Add(this.textmessage);
            this.Controls.Add(this.messageworkspace);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "    TextChat ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox localport;
        private System.Windows.Forms.TextBox locaip;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox friendport;
        private System.Windows.Forms.TextBox friendip;
        private System.Windows.Forms.ListBox messageworkspace;
        private System.Windows.Forms.TextBox textmessage;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button End;
    }
}

