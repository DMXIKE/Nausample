namespace Nsc.RecoImageText
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOcr = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnClipOcr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOcr
            // 
            this.btnOcr.Location = new System.Drawing.Point(372, 9);
            this.btnOcr.Name = "btnOcr";
            this.btnOcr.Size = new System.Drawing.Size(75, 23);
            this.btnOcr.TabIndex = 0;
            this.btnOcr.Text = "文字识别";
            this.btnOcr.UseVisualStyleBackColor = true;
            this.btnOcr.Click += new System.EventHandler(this.btnOcr_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPath.Location = new System.Drawing.Point(50, 11);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(268, 21);
            this.txtPath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "图片：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "选择";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtResult.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtResult.Location = new System.Drawing.Point(291, 49);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(337, 296);
            this.txtResult.TabIndex = 4;
            // 
            // pbImage
            // 
            this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pbImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pbImage.Location = new System.Drawing.Point(4, 49);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(281, 296);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 6;
            this.pbImage.TabStop = false;
            // 
            // btnClipOcr
            // 
            this.btnClipOcr.Location = new System.Drawing.Point(482, 9);
            this.btnClipOcr.Name = "btnClipOcr";
            this.btnClipOcr.Size = new System.Drawing.Size(106, 23);
            this.btnClipOcr.TabIndex = 7;
            this.btnClipOcr.Text = "粘贴并识别";
            this.btnClipOcr.UseVisualStyleBackColor = true;
            this.btnClipOcr.Click += new System.EventHandler(this.btnClipOcr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 350);
            this.Controls.Add(this.btnClipOcr);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnOcr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "图片文字识别";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOcr;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnClipOcr;
    }
}

