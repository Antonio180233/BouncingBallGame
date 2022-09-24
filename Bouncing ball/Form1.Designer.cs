
namespace Bouncing_ball
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelY = new System.Windows.Forms.Panel();
            this.panelX = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.panelX.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelY
            // 
            this.panelY.BackColor = System.Drawing.Color.Firebrick;
            this.panelY.Font = new System.Drawing.Font("Castellar", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelY.Location = new System.Drawing.Point(846, 27);
            this.panelY.Name = "panelY";
            this.panelY.Size = new System.Drawing.Size(5, 461);
            this.panelY.TabIndex = 0;
            // 
            // panelX
            // 
            this.panelX.BackColor = System.Drawing.Color.Firebrick;
            this.panelX.Controls.Add(this.label1);
            this.panelX.Font = new System.Drawing.Font("Castellar", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panelX.Location = new System.Drawing.Point(35, 473);
            this.panelX.Name = "panelX";
            this.panelX.Size = new System.Drawing.Size(816, 5);
            this.panelX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 144);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Ball
            // 
            this.Ball.AutoSize = true;
            this.Ball.BackColor = System.Drawing.Color.Transparent;
            this.Ball.Font = new System.Drawing.Font("Castellar", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ball.Location = new System.Drawing.Point(35, 9);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(165, 144);
            this.Ball.TabIndex = 1;
            this.Ball.Text = "O";
            this.Ball.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(869, 119);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(94, 29);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "INICIAR";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(869, 175);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(94, 29);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "DETENER";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 523);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelX);
            this.Controls.Add(this.panelY);
            this.Controls.Add(this.Ball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelX.ResumeLayout(false);
            this.panelX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelY;
        private System.Windows.Forms.Panel panelX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}

