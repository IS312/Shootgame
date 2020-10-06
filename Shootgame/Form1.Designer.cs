namespace Shootgame
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
            this.ShootAHead = new System.Windows.Forms.Button();
            this.ShootAway = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.PlayTheGameAgain = new System.Windows.Forms.Button();
            this.Score = new System.Windows.Forms.MaskedTextBox();
            this.TextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // ShootAHead
            // 
            this.ShootAHead.Location = new System.Drawing.Point(613, 42);
            this.ShootAHead.Name = "ShootAHead";
            this.ShootAHead.Size = new System.Drawing.Size(114, 50);
            this.ShootAHead.TabIndex = 0;
            this.ShootAHead.Text = "ShootAHead";
            this.ShootAHead.UseVisualStyleBackColor = true;
            this.ShootAHead.Click += new System.EventHandler(this.ShootAHead_Click);
            // 
            // ShootAway
            // 
            this.ShootAway.Location = new System.Drawing.Point(613, 134);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(114, 50);
            this.ShootAway.TabIndex = 1;
            this.ShootAway.Text = "ShootAway";
            this.ShootAway.UseVisualStyleBackColor = true;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // Spin
            // 
            this.Spin.Location = new System.Drawing.Point(613, 217);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(114, 50);
            this.Spin.TabIndex = 2;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(613, 303);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(114, 50);
            this.Load.TabIndex = 3;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // PlayTheGameAgain
            // 
            this.PlayTheGameAgain.Location = new System.Drawing.Point(60, 149);
            this.PlayTheGameAgain.Name = "PlayTheGameAgain";
            this.PlayTheGameAgain.Size = new System.Drawing.Size(124, 50);
            this.PlayTheGameAgain.TabIndex = 4;
            this.PlayTheGameAgain.Text = "PlayTheGameAgain";
            this.PlayTheGameAgain.UseVisualStyleBackColor = true;
            this.PlayTheGameAgain.Click += new System.EventHandler(this.button5_Click);
            // 
            // Score
            // 
            this.Score.Location = new System.Drawing.Point(124, 315);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(85, 26);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score";
            this.Score.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Score_MaskInputRejected);
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(272, 315);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(85, 26);
            this.TextBox2.TabIndex = 6;
            this.TextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Shootgame.Resource1.bg1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.PlayTheGameAgain);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.ShootAHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShootAHead;
        private System.Windows.Forms.Button ShootAway;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button PlayTheGameAgain;
        private System.Windows.Forms.MaskedTextBox Score;
        private System.Windows.Forms.MaskedTextBox TextBox2;
    }
}

