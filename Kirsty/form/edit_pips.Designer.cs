﻿
namespace Kirsty.form
{
    partial class edit_pips
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
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.label2 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.abort = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.border = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.bunifuCards2.SuspendLayout();
            this.border.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(this.label2);
            this.bunifuCards2.Controls.Add(this.key);
            this.bunifuCards2.Controls.Add(this.value);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(12, 36);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(235, 65);
            this.bunifuCards2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(7, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Edit:";
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.ForeColor = System.Drawing.Color.DimGray;
            this.key.Location = new System.Drawing.Point(41, 15);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(25, 13);
            this.key.TabIndex = 1;
            this.key.Text = "Key";
            // 
            // value
            // 
            this.value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.value.ForeColor = System.Drawing.Color.HotPink;
            this.value.Location = new System.Drawing.Point(10, 38);
            this.value.Margin = new System.Windows.Forms.Padding(10);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(215, 20);
            this.value.TabIndex = 0;
            this.value.TextChanged += new System.EventHandler(this.value_TextChanged);
            // 
            // abort
            // 
            this.abort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.abort.FlatAppearance.BorderSize = 0;
            this.abort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abort.ForeColor = System.Drawing.Color.DimGray;
            this.abort.Location = new System.Drawing.Point(40, 114);
            this.abort.Margin = new System.Windows.Forms.Padding(10);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(75, 23);
            this.abort.TabIndex = 23;
            this.abort.Text = "Abort";
            this.abort.UseVisualStyleBackColor = false;
            this.abort.Click += new System.EventHandler(this.abort_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.DimGray;
            this.save.Location = new System.Drawing.Point(135, 114);
            this.save.Margin = new System.Windows.Forms.Padding(10);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 22;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(28)))));
            this.border.Controls.Add(this.label1);
            this.border.Controls.Add(this.version);
            this.border.Dock = System.Windows.Forms.DockStyle.Top;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(259, 30);
            this.border.TabIndex = 24;
            this.border.MouseDown += new System.Windows.Forms.MouseEventHandler(this.border_MouseDown);
            this.border.MouseMove += new System.Windows.Forms.MouseEventHandler(this.border_MouseMove);
            this.border.MouseUp += new System.Windows.Forms.MouseEventHandler(this.border_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "version:";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.Color.DimGray;
            this.version.Location = new System.Drawing.Point(62, 9);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(31, 13);
            this.version.TabIndex = 10;
            this.version.Text = "1.0.0";
            // 
            // edit_number
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(259, 156);
            this.Controls.Add(this.border);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.save);
            this.Controls.Add(this.bunifuCards2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit_number";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit";
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.border.ResumeLayout(false);
            this.border.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Panel border;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label version;
    }
}