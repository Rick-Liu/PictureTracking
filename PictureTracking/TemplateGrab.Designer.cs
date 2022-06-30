namespace PictureTracking
{
    partial class TemplateGrab
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
            this.TemplatePictureBox = new System.Windows.Forms.PictureBox();
            this.GrabButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TemplatePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TemplatePictureBox
            // 
            this.TemplatePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TemplatePictureBox.Location = new System.Drawing.Point(38, 34);
            this.TemplatePictureBox.Name = "TemplatePictureBox";
            this.TemplatePictureBox.Size = new System.Drawing.Size(372, 326);
            this.TemplatePictureBox.TabIndex = 1;
            this.TemplatePictureBox.TabStop = false;
            // 
            // GrabButton
            // 
            this.GrabButton.Location = new System.Drawing.Point(444, 102);
            this.GrabButton.Name = "GrabButton";
            this.GrabButton.Size = new System.Drawing.Size(110, 44);
            this.GrabButton.TabIndex = 2;
            this.GrabButton.Text = "Grab";
            this.GrabButton.UseVisualStyleBackColor = true;
            this.GrabButton.Click += new System.EventHandler(this.GrabButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(444, 199);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(110, 44);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TemplateGrab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 397);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.GrabButton);
            this.Controls.Add(this.TemplatePictureBox);
            this.Name = "TemplateGrab";
            this.Text = "TemplateGrab";
            this.Load += new System.EventHandler(this.TemplateGrab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TemplatePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TemplatePictureBox;
        private System.Windows.Forms.Button GrabButton;
        private System.Windows.Forms.Button CloseButton;
    }
}