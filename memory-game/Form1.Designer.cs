namespace memory_game
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
            this.card4 = new System.Windows.Forms.Button();
            this.card3 = new System.Windows.Forms.Button();
            this.card2 = new System.Windows.Forms.Button();
            this.card1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // card4
            // 
            this.card4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.card4.FlatAppearance.BorderSize = 0;
            this.card4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.card4.Image = global::memory_game.Properties.Resources.HondFoto2;
            this.card4.Location = new System.Drawing.Point(286, 263);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(175, 175);
            this.card4.TabIndex = 3;
            this.card4.Tag = "2";
            this.card4.UseVisualStyleBackColor = true;
            this.card4.Click += new System.EventHandler(this.btn_Click);
            // 
            // card3
            // 
            this.card3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.card3.FlatAppearance.BorderSize = 0;
            this.card3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.card3.Image = global::memory_game.Properties.Resources.HondFoto2;
            this.card3.Location = new System.Drawing.Point(55, 263);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(175, 175);
            this.card3.TabIndex = 2;
            this.card3.Tag = "2";
            this.card3.UseVisualStyleBackColor = true;
            this.card3.Click += new System.EventHandler(this.btn_Click);
            // 
            // card2
            // 
            this.card2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.card2.FlatAppearance.BorderSize = 0;
            this.card2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.card2.Image = global::memory_game.Properties.Resources.HondFoto1;
            this.card2.Location = new System.Drawing.Point(286, 65);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(175, 175);
            this.card2.TabIndex = 1;
            this.card2.Tag = "1";
            this.card2.UseVisualStyleBackColor = true;
            this.card2.Click += new System.EventHandler(this.btn_Click);
            // 
            // card1
            // 
            this.card1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.card1.FlatAppearance.BorderSize = 0;
            this.card1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.card1.Image = global::memory_game.Properties.Resources.HondFoto1;
            this.card1.Location = new System.Drawing.Point(55, 56);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(175, 175);
            this.card1.TabIndex = 0;
            this.card1.Tag = "1";
            this.card1.UseVisualStyleBackColor = true;
            this.card1.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(628, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button card1;
        private System.Windows.Forms.Button card2;
        private System.Windows.Forms.Button card3;
        private System.Windows.Forms.Button card4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

