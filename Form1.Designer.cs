using System;

namespace Tik_Tak_Reo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(17, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(437, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.newGameToolStripMenuItem.Text = "File";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.File);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "New Game";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(35, 59);
            this.A1.Margin = new System.Windows.Forms.Padding(7);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(102, 106);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.btn_click);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(160, 59);
            this.A2.Margin = new System.Windows.Forms.Padding(7);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(102, 97);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.btn_click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(296, 179);
            this.B3.Margin = new System.Windows.Forms.Padding(7);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(102, 98);
            this.B3.TabIndex = 1;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.btn_click);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(296, 59);
            this.A3.Margin = new System.Windows.Forms.Padding(7);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(102, 97);
            this.A3.TabIndex = 1;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.btn_click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(35, 179);
            this.B1.Margin = new System.Windows.Forms.Padding(7);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(102, 98);
            this.B1.TabIndex = 1;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.btn_click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(160, 179);
            this.B2.Margin = new System.Windows.Forms.Padding(7);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(102, 98);
            this.B2.TabIndex = 1;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.btn_click);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(296, 291);
            this.C3.Margin = new System.Windows.Forms.Padding(7);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(102, 107);
            this.C3.TabIndex = 1;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.btn_click);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(35, 291);
            this.C1.Margin = new System.Windows.Forms.Padding(7);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(102, 107);
            this.C1.TabIndex = 1;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.btn_click);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(160, 291);
            this.C2.Margin = new System.Windows.Forms.Padding(7);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(102, 107);
            this.C2.TabIndex = 1;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.btn_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 443);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Tik Tak Teo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void File(object sender, EventArgs e)
        {
            /*throw new NotImplementedException();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           /* throw new NotImplementedException();*/
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

