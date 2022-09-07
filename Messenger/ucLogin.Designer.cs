namespace Messenger
{
    partial class ucLogin
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
            this.btnsignin = new LollipopButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lollipopLabel1 = new LollipopLabel();
            this.lollipopTextBox1 = new LollipopTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsignin
            // 
            this.btnsignin.BackColor = System.Drawing.Color.Transparent;
            this.btnsignin.BGColor = "#508ef5";
            this.btnsignin.FontColor = "#ffffff";
            this.btnsignin.Location = new System.Drawing.Point(110, 257);
            this.btnsignin.Name = "btnsignin";
            this.btnsignin.Size = new System.Drawing.Size(143, 41);
            this.btnsignin.TabIndex = 1;
            this.btnsignin.Text = "sign in";
            this.btnsignin.Click += new System.EventHandler(this.btnsignin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Messenger.Properties.Resources.image1;
            this.pictureBox1.Location = new System.Drawing.Point(120, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(115, 199);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(62, 25);
            this.lollipopLabel1.TabIndex = 2;
            this.lollipopLabel1.Text = "name";
            // 
            // lollipopTextBox1
            // 
            this.lollipopTextBox1.FocusedColor = "#508ef5";
            this.lollipopTextBox1.FontColor = "#999999";
            this.lollipopTextBox1.IsEnabled = true;
            this.lollipopTextBox1.Location = new System.Drawing.Point(110, 227);
            this.lollipopTextBox1.MaxLength = 32767;
            this.lollipopTextBox1.Multiline = false;
            this.lollipopTextBox1.Name = "lollipopTextBox1";
            this.lollipopTextBox1.ReadOnly = false;
            this.lollipopTextBox1.Size = new System.Drawing.Size(300, 24);
            this.lollipopTextBox1.TabIndex = 3;
            this.lollipopTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.lollipopTextBox1.UseSystemPasswordChar = false;
            // 
            // ucLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lollipopTextBox1);
            this.Controls.Add(this.lollipopLabel1);
            this.Controls.Add(this.btnsignin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucLogin";
            this.Size = new System.Drawing.Size(432, 497);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private LollipopButton btnsignin;
        private LollipopLabel lollipopLabel1;
        private LollipopTextBox lollipopTextBox1;
    }
}
