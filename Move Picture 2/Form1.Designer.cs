﻿namespace Move_Picture_2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Move_Picture_2.Properties.Resources.Liverpool_07_grande;
            this.pictureBox1.Location = new System.Drawing.Point(324, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Move Right";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Move up";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(453, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Move Left";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(546, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 33);
            this.button4.TabIndex = 4;
            this.button4.Text = "Move Down";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(646, 275);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 36);
            this.button5.TabIndex = 5;
            this.button5.Text = "Square";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(453, 275);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(87, 36);
            this.Triangle.TabIndex = 6;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.button6_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(646, 358);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(86, 32);
            this.Button6.TabIndex = 7;
            this.Button6.Text = "Loop";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Triangle;
        private System.Windows.Forms.Button Button6;
    }
}

