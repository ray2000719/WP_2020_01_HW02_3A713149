﻿namespace WP_2020_01_HW02_3A713149
{
    partial class frmGame
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPump = new System.Windows.Forms.Button();
            this.pbshow = new System.Windows.Forms.PictureBox();
            this.rtbshow = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbshow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPump
            // 
            this.btnPump.Font = new System.Drawing.Font("新細明體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPump.Location = new System.Drawing.Point(446, 27);
            this.btnPump.Name = "btnPump";
            this.btnPump.Size = new System.Drawing.Size(173, 169);
            this.btnPump.TabIndex = 0;
            this.btnPump.Text = "抽牌";
            this.btnPump.UseVisualStyleBackColor = true;
            this.btnPump.Click += new System.EventHandler(this.btnPump_Click);
            // 
            // pbshow
            // 
            this.pbshow.Location = new System.Drawing.Point(446, 238);
            this.pbshow.Name = "pbshow";
            this.pbshow.Size = new System.Drawing.Size(173, 160);
            this.pbshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbshow.TabIndex = 1;
            this.pbshow.TabStop = false;
            this.pbshow.Click += new System.EventHandler(this.pbshow_Click);
            // 
            // rtbshow
            // 
            this.rtbshow.Location = new System.Drawing.Point(96, 112);
            this.rtbshow.Name = "rtbshow";
            this.rtbshow.Size = new System.Drawing.Size(186, 286);
            this.rtbshow.TabIndex = 2;
            this.rtbshow.Text = "";
            this.rtbshow.TextChanged += new System.EventHandler(this.rtbshow_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(99, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "歷程";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbshow);
            this.Controls.Add(this.pbshow);
            this.Controls.Add(this.btnPump);
            this.Name = "frmGame";
            this.Text = "frmGame";
            this.Load += new System.EventHandler(this.frmGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPump;
        private System.Windows.Forms.PictureBox pbshow;
        private System.Windows.Forms.RichTextBox rtbshow;
        private System.Windows.Forms.Label label1;
    }
}

