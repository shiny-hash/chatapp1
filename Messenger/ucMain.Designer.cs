﻿namespace Messenger
{
    partial class ucMain
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
            this.listOnline = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listOnline
            // 
            this.listOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOnline.FormattingEnabled = true;
            this.listOnline.ItemHeight = 20;
            this.listOnline.Items.AddRange(new object[] {
            "aabi",
            "chettabutta",
            "pichi"});
            this.listOnline.Location = new System.Drawing.Point(0, 0);
            this.listOnline.Name = "listOnline";
            this.listOnline.Size = new System.Drawing.Size(661, 461);
            this.listOnline.TabIndex = 0;
            this.listOnline.Click += new System.EventHandler(this.listOnline_Click);
            this.listOnline.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ucMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listOnline);
            this.Name = "ucMain";
            this.Size = new System.Drawing.Size(661, 461);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOnline;
    }
}
