﻿namespace pong
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
            this.components = new System.ComponentModel.Container();
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            this.ticks = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.AutoSize = true;
            this.p1ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p1ScoreLabel.Location = new System.Drawing.Point(99, 19);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(14, 16);
            this.p1ScoreLabel.TabIndex = 0;
            this.p1ScoreLabel.Text = "0";
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.winLabel.Location = new System.Drawing.Point(206, 203);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(62, 19);
            this.winLabel.TabIndex = 1;
            this.winLabel.Text = "winLabel";
            this.winLabel.Visible = false;
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.AutoSize = true;
            this.p2ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.p2ScoreLabel.Location = new System.Drawing.Point(315, 19);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(14, 16);
            this.p2ScoreLabel.TabIndex = 2;
            this.p2ScoreLabel.Text = "0";
            // 
            // ticks
            // 
            this.ticks.Enabled = true;
            this.ticks.Interval = 20;
            this.ticks.Tick += new System.EventHandler(this.tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.p2ScoreLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.p1ScoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
        private System.Windows.Forms.Timer ticks;
    }
}

