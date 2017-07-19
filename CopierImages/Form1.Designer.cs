namespace CopierImages
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
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_select_file = new System.Windows.Forms.Button();
            this.lbl_file = new System.Windows.Forms.Label();
            this.lbl_threadNumber = new System.Windows.Forms.Label();
            this.lbl_sleep = new System.Windows.Forms.Label();
            this.ipt_threadNumber = new System.Windows.Forms.NumericUpDown();
            this.ipt_sleep = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ipt_threadNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(347, 226);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "ENVIAR";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(428, 226);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.Text = "SAIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_select_file
            // 
            this.btn_select_file.Location = new System.Drawing.Point(28, 170);
            this.btn_select_file.Name = "btn_select_file";
            this.btn_select_file.Size = new System.Drawing.Size(195, 23);
            this.btn_select_file.TabIndex = 2;
            this.btn_select_file.Text = "ESCOLHER ARQUIVO";
            this.btn_select_file.UseVisualStyleBackColor = true;
            this.btn_select_file.Click += new System.EventHandler(this.btn_select_file_Click);
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Location = new System.Drawing.Point(241, 175);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(56, 13);
            this.lbl_file.TabIndex = 3;
            this.lbl_file.Text = "ARQUIVO";
            // 
            // lbl_threadNumber
            // 
            this.lbl_threadNumber.AutoSize = true;
            this.lbl_threadNumber.Location = new System.Drawing.Point(88, 70);
            this.lbl_threadNumber.Name = "lbl_threadNumber";
            this.lbl_threadNumber.Size = new System.Drawing.Size(94, 13);
            this.lbl_threadNumber.TabIndex = 4;
            this.lbl_threadNumber.Text = "THEAD NUMBER";
            // 
            // lbl_sleep
            // 
            this.lbl_sleep.AutoSize = true;
            this.lbl_sleep.Location = new System.Drawing.Point(88, 124);
            this.lbl_sleep.Name = "lbl_sleep";
            this.lbl_sleep.Size = new System.Drawing.Size(41, 13);
            this.lbl_sleep.TabIndex = 5;
            this.lbl_sleep.Text = "SLEEP";
            // 
            // ipt_threadNumber
            // 
            this.ipt_threadNumber.Location = new System.Drawing.Point(244, 70);
            this.ipt_threadNumber.Name = "ipt_threadNumber";
            this.ipt_threadNumber.Size = new System.Drawing.Size(195, 20);
            this.ipt_threadNumber.TabIndex = 6;
            // 
            // ipt_sleep
            // 
            this.ipt_sleep.Location = new System.Drawing.Point(244, 116);
            this.ipt_sleep.Name = "ipt_sleep";
            this.ipt_sleep.Size = new System.Drawing.Size(195, 20);
            this.ipt_sleep.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.ipt_sleep);
            this.Controls.Add(this.ipt_threadNumber);
            this.Controls.Add(this.lbl_sleep);
            this.Controls.Add(this.lbl_threadNumber);
            this.Controls.Add(this.lbl_file);
            this.Controls.Add(this.btn_select_file);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_send);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ipt_threadNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_select_file;
        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.Label lbl_threadNumber;
        private System.Windows.Forms.Label lbl_sleep;
        private System.Windows.Forms.NumericUpDown ipt_threadNumber;
        private System.Windows.Forms.TextBox ipt_sleep;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

