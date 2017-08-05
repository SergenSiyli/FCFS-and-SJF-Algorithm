namespace Operatin_System
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRespond = new System.Windows.Forms.Label();
            this.lblwaiting = new System.Windows.Forms.Label();
            this.lblturnaround = new System.Windows.Forms.Label();
            this.lblRespondTime = new System.Windows.Forms.Label();
            this.lblBurst = new System.Windows.Forms.Label();
            this.lblArrival = new System.Windows.Forms.Label();
            this.txtProsCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstArrival = new System.Windows.Forms.ListBox();
            this.lstBurst = new System.Windows.Forms.ListBox();
            this.lstTurnAround = new System.Windows.Forms.ListBox();
            this.lstWaiting = new System.Windows.Forms.ListBox();
            this.lstRespond = new System.Windows.Forms.ListBox();
            this.lblAtt = new System.Windows.Forms.Label();
            this.lblAwt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblArt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "FCFS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleName = "";
            this.pictureBox1.Location = new System.Drawing.Point(11, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 251);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Turnaround Time :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(739, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Waiting Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(961, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Respond Time :";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Arrival Time :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Burst Time :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(492, 32);
            this.button2.TabIndex = 13;
            this.button2.Text = "SJF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRespond
            // 
            this.lblRespond.AutoSize = true;
            this.lblRespond.Location = new System.Drawing.Point(974, 433);
            this.lblRespond.Name = "lblRespond";
            this.lblRespond.Size = new System.Drawing.Size(0, 13);
            this.lblRespond.TabIndex = 12;
            this.lblRespond.Visible = false;
            // 
            // lblwaiting
            // 
            this.lblwaiting.AutoSize = true;
            this.lblwaiting.Location = new System.Drawing.Point(739, 433);
            this.lblwaiting.Name = "lblwaiting";
            this.lblwaiting.Size = new System.Drawing.Size(0, 13);
            this.lblwaiting.TabIndex = 6;
            // 
            // lblturnaround
            // 
            this.lblturnaround.AutoSize = true;
            this.lblturnaround.Location = new System.Drawing.Point(513, 433);
            this.lblturnaround.Name = "lblturnaround";
            this.lblturnaround.Size = new System.Drawing.Size(0, 13);
            this.lblturnaround.TabIndex = 5;
            // 
            // lblRespondTime
            // 
            this.lblRespondTime.AutoSize = true;
            this.lblRespondTime.Location = new System.Drawing.Point(487, 433);
            this.lblRespondTime.Name = "lblRespondTime";
            this.lblRespondTime.Size = new System.Drawing.Size(0, 13);
            this.lblRespondTime.TabIndex = 7;
            // 
            // lblBurst
            // 
            this.lblBurst.AutoSize = true;
            this.lblBurst.Location = new System.Drawing.Point(287, 433);
            this.lblBurst.Name = "lblBurst";
            this.lblBurst.Size = new System.Drawing.Size(0, 13);
            this.lblBurst.TabIndex = 11;
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(20, 433);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(0, 13);
            this.lblArrival.TabIndex = 10;
            // 
            // txtProsCount
            // 
            this.txtProsCount.Location = new System.Drawing.Point(112, 347);
            this.txtProsCount.Name = "txtProsCount";
            this.txtProsCount.Size = new System.Drawing.Size(100, 20);
            this.txtProsCount.TabIndex = 14;
            this.txtProsCount.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Process Count";
            // 
            // lstArrival
            // 
            this.lstArrival.FormattingEnabled = true;
            this.lstArrival.Location = new System.Drawing.Point(23, 433);
            this.lstArrival.Name = "lstArrival";
            this.lstArrival.Size = new System.Drawing.Size(110, 134);
            this.lstArrival.TabIndex = 16;
            // 
            // lstBurst
            // 
            this.lstBurst.FormattingEnabled = true;
            this.lstBurst.Location = new System.Drawing.Point(281, 433);
            this.lstBurst.Name = "lstBurst";
            this.lstBurst.Size = new System.Drawing.Size(127, 134);
            this.lstBurst.TabIndex = 17;
            // 
            // lstTurnAround
            // 
            this.lstTurnAround.FormattingEnabled = true;
            this.lstTurnAround.Location = new System.Drawing.Point(516, 433);
            this.lstTurnAround.Name = "lstTurnAround";
            this.lstTurnAround.Size = new System.Drawing.Size(120, 134);
            this.lstTurnAround.TabIndex = 18;
            // 
            // lstWaiting
            // 
            this.lstWaiting.FormattingEnabled = true;
            this.lstWaiting.Location = new System.Drawing.Point(742, 433);
            this.lstWaiting.Name = "lstWaiting";
            this.lstWaiting.Size = new System.Drawing.Size(120, 134);
            this.lstWaiting.TabIndex = 19;
            // 
            // lstRespond
            // 
            this.lstRespond.FormattingEnabled = true;
            this.lstRespond.Location = new System.Drawing.Point(955, 433);
            this.lstRespond.Name = "lstRespond";
            this.lstRespond.Size = new System.Drawing.Size(120, 134);
            this.lstRespond.TabIndex = 20;
            this.lstRespond.Visible = false;
            // 
            // lblAtt
            // 
            this.lblAtt.AutoSize = true;
            this.lblAtt.Location = new System.Drawing.Point(516, 574);
            this.lblAtt.Name = "lblAtt";
            this.lblAtt.Size = new System.Drawing.Size(34, 13);
            this.lblAtt.TabIndex = 21;
            this.lblAtt.Text = "ATT :";
            // 
            // lblAwt
            // 
            this.lblAwt.AutoSize = true;
            this.lblAwt.Location = new System.Drawing.Point(739, 574);
            this.lblAwt.Name = "lblAwt";
            this.lblAwt.Size = new System.Drawing.Size(38, 13);
            this.lblAwt.TabIndex = 22;
            this.lblAwt.Text = "AWT :";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 263);
            this.panel1.TabIndex = 23;
            // 
            // lblArt
            // 
            this.lblArt.AutoSize = true;
            this.lblArt.Location = new System.Drawing.Point(957, 577);
            this.lblArt.Name = "lblArt";
            this.lblArt.Size = new System.Drawing.Size(35, 13);
            this.lblArt.TabIndex = 24;
            this.lblArt.Text = "ART :";
            this.lblArt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 601);
            this.Controls.Add(this.lblArt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAwt);
            this.Controls.Add(this.lblAtt);
            this.Controls.Add(this.lstRespond);
            this.Controls.Add(this.lstWaiting);
            this.Controls.Add(this.lstTurnAround);
            this.Controls.Add(this.lstBurst);
            this.Controls.Add(this.lstArrival);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProsCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblRespond);
            this.Controls.Add(this.lblBurst);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRespondTime);
            this.Controls.Add(this.lblwaiting);
            this.Controls.Add(this.lblturnaround);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblBurst;
        private System.Windows.Forms.Label lblRespondTime;
        private System.Windows.Forms.Label lblturnaround;
        private System.Windows.Forms.Label lblwaiting;
        private System.Windows.Forms.Label lblRespond;
        private System.Windows.Forms.TextBox txtProsCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstArrival;
        private System.Windows.Forms.ListBox lstBurst;
        private System.Windows.Forms.ListBox lstTurnAround;
        private System.Windows.Forms.ListBox lstWaiting;
        private System.Windows.Forms.ListBox lstRespond;
        private System.Windows.Forms.Label lblAtt;
        private System.Windows.Forms.Label lblAwt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblArt;
    }
}

