namespace Messenger
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.lollipopTextBox1 = new LollipopTextBox();
            this.LollipopButton1 = new LollipopButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Messenger.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(179, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(229, 168);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(61, 25);
            this.lollipopLabel1.TabIndex = 1;
            this.lollipopLabel1.Text = "name";
            // 
            // lollipopTextBox1
            // 
            this.lollipopTextBox1.FocusedColor = "#508ef5";
            this.lollipopTextBox1.FontColor = "#999999";
            this.lollipopTextBox1.IsEnabled = true;
            this.lollipopTextBox1.Location = new System.Drawing.Point(163, 221);
            this.lollipopTextBox1.MaxLength = 32767;
            this.lollipopTextBox1.Multiline = false;
            this.lollipopTextBox1.Name = "lollipopTextBox1";
            this.lollipopTextBox1.ReadOnly = false;
            this.lollipopTextBox1.Size = new System.Drawing.Size(215, 24);
            this.lollipopTextBox1.TabIndex = 2;
            this.lollipopTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox1.UseSystemPasswordChar = false;
            // 
            // LollipopButton1
            // 
            this.LollipopButton1.BackColor = System.Drawing.Color.Transparent;
            this.LollipopButton1.BGColor = "#508ef5";
            this.LollipopButton1.FontColor = "#ffffff";
            this.LollipopButton1.Location = new System.Drawing.Point(200, 291);
            this.LollipopButton1.Name = "LollipopButton1";
            this.LollipopButton1.Size = new System.Drawing.Size(143, 41);
            this.LollipopButton1.TabIndex = 3;
            this.LollipopButton1.Text = "sign in";
            this.LollipopButton1.Click += new System.EventHandler(this.LollipopButton1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LollipopButton1);
            this.Controls.Add(this.lollipopTextBox1);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(533, 488);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox lollipopTextBox1;
        private LollipopButton LollipopButton1;
    }
}
