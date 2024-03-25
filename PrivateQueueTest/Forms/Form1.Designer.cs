namespace PrivateQueueTest
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
            this.messageTxt = new System.Windows.Forms.TextBox();
            this.getMessageTxt = new System.Windows.Forms.TextBox();
            this.startCalcBtn = new System.Windows.Forms.Button();
            this.SendQueueDataBtn = new System.Windows.Forms.Button();
            this.myBrowserBtn = new System.Windows.Forms.Button();
            this.readMsgBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // messageTxt
            // 
            this.messageTxt.BackColor = System.Drawing.Color.Silver;
            this.messageTxt.Location = new System.Drawing.Point(24, 25);
            this.messageTxt.Multiline = true;
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.Size = new System.Drawing.Size(1107, 142);
            this.messageTxt.TabIndex = 0;
            // 
            // getMessageTxt
            // 
            this.getMessageTxt.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.getMessageTxt.Location = new System.Drawing.Point(24, 189);
            this.getMessageTxt.Multiline = true;
            this.getMessageTxt.Name = "getMessageTxt";
            this.getMessageTxt.ReadOnly = true;
            this.getMessageTxt.Size = new System.Drawing.Size(1107, 142);
            this.getMessageTxt.TabIndex = 1;
            // 
            // startCalcBtn
            // 
            this.startCalcBtn.Location = new System.Drawing.Point(260, 399);
            this.startCalcBtn.Name = "startCalcBtn";
            this.startCalcBtn.Size = new System.Drawing.Size(201, 88);
            this.startCalcBtn.TabIndex = 4;
            this.startCalcBtn.Text = "Start Calc";
            this.startCalcBtn.UseVisualStyleBackColor = true;
            // 
            // SendQueueDataBtn
            // 
            this.SendQueueDataBtn.Location = new System.Drawing.Point(24, 399);
            this.SendQueueDataBtn.Name = "SendQueueDataBtn";
            this.SendQueueDataBtn.Size = new System.Drawing.Size(201, 88);
            this.SendQueueDataBtn.TabIndex = 5;
            this.SendQueueDataBtn.Text = "Send Queue Data";
            this.SendQueueDataBtn.UseVisualStyleBackColor = true;
            this.SendQueueDataBtn.Click += new System.EventHandler(this.SendQueueDataBtn_Click);
            // 
            // myBrowserBtn
            // 
            this.myBrowserBtn.Location = new System.Drawing.Point(498, 399);
            this.myBrowserBtn.Name = "myBrowserBtn";
            this.myBrowserBtn.Size = new System.Drawing.Size(201, 88);
            this.myBrowserBtn.TabIndex = 6;
            this.myBrowserBtn.Text = "My Browser";
            this.myBrowserBtn.UseVisualStyleBackColor = true;
            // 
            // readMsgBtn
            // 
            this.readMsgBtn.Location = new System.Drawing.Point(930, 409);
            this.readMsgBtn.Name = "readMsgBtn";
            this.readMsgBtn.Size = new System.Drawing.Size(201, 88);
            this.readMsgBtn.TabIndex = 7;
            this.readMsgBtn.Text = "Read Messages";
            this.readMsgBtn.UseVisualStyleBackColor = true;
            this.readMsgBtn.Click += new System.EventHandler(this.readMsgBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 533);
            this.Controls.Add(this.readMsgBtn);
            this.Controls.Add(this.myBrowserBtn);
            this.Controls.Add(this.SendQueueDataBtn);
            this.Controls.Add(this.startCalcBtn);
            this.Controls.Add(this.getMessageTxt);
            this.Controls.Add(this.messageTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageTxt;
        private System.Windows.Forms.TextBox getMessageTxt;
        private System.Windows.Forms.Button startCalcBtn;
        private System.Windows.Forms.Button SendQueueDataBtn;
        private System.Windows.Forms.Button myBrowserBtn;
        private System.Windows.Forms.Button readMsgBtn;
    }
}

