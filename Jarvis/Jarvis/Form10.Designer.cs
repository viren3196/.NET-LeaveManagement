﻿namespace Jarvis
{
    partial class Form10
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(297, 324);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 51);
            this.button6.TabIndex = 13;
            this.button6.Text = "Arrival";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(167, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 50);
            this.button5.TabIndex = 12;
            this.button5.Text = "Leave";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(297, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 50);
            this.button4.TabIndex = 11;
            this.button4.Text = "Leave Extension";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 51);
            this.button3.TabIndex = 10;
            this.button3.Text = "Transfer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 51);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add a person";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "Check Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "LEAVE MANAGEMENT SYSTEM";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(246, 411);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 46);
            this.button7.TabIndex = 16;
            this.button7.Text = "Clear All";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(615, 491);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
    }
}