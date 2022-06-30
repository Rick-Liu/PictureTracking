namespace PictureTracking
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.TemplateButton = new System.Windows.Forms.Button();
            this.ShowTemplatPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowTemplatPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(48, 66);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(899, 749);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(981, 100);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(188, 75);
            this.OpenButton.TabIndex = 1;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // TemplateButton
            // 
            this.TemplateButton.Location = new System.Drawing.Point(981, 218);
            this.TemplateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TemplateButton.Name = "TemplateButton";
            this.TemplateButton.Size = new System.Drawing.Size(188, 75);
            this.TemplateButton.TabIndex = 2;
            this.TemplateButton.Text = "Template";
            this.TemplateButton.UseVisualStyleBackColor = true;
            this.TemplateButton.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // ShowTemplatPictureBox
            // 
            this.ShowTemplatPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowTemplatPictureBox.Location = new System.Drawing.Point(981, 328);
            this.ShowTemplatPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowTemplatPictureBox.Name = "ShowTemplatPictureBox";
            this.ShowTemplatPictureBox.Size = new System.Drawing.Size(179, 179);
            this.ShowTemplatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowTemplatPictureBox.TabIndex = 3;
            this.ShowTemplatPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 892);
            this.Controls.Add(this.ShowTemplatPictureBox);
            this.Controls.Add(this.TemplateButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowTemplatPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button TemplateButton;
        private System.Windows.Forms.PictureBox ShowTemplatPictureBox;
    }
}

