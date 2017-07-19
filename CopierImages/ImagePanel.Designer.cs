namespace CopierImages
{
    partial class ImagePanel
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
            this.img_new = new System.Windows.Forms.PictureBox();
            this.img_original = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_original)).BeginInit();
            this.SuspendLayout();
            // 
            // img_new
            // 
            this.img_new.Location = new System.Drawing.Point(304, 12);
            this.img_new.Name = "img_new";
            this.img_new.Size = new System.Drawing.Size(268, 208);
            this.img_new.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_new.TabIndex = 0;
            this.img_new.TabStop = false;
            // 
            // img_original
            // 
            this.img_original.Location = new System.Drawing.Point(12, 12);
            this.img_original.Name = "img_original";
            this.img_original.Size = new System.Drawing.Size(268, 208);
            this.img_original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_original.TabIndex = 1;
            this.img_original.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(344, 226);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "VOLTAR";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(425, 226);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "SAIR";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(263, 226);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "INICIAR";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // ImagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.img_original);
            this.Controls.Add(this.img_new);
            this.Name = "ImagePanel";
            this.Text = "ImagePanel";
            ((System.ComponentModel.ISupportInitialize)(this.img_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_original)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox img_new;
        private System.Windows.Forms.PictureBox img_original;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_start;
    }
}