namespace Unreal_Snake
{
    partial class Difficulty
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_easy = new System.Windows.Forms.Button();
            this.button_medium = new System.Windows.Forms.Button();
            this.button_hard = new System.Windows.Forms.Button();
            this.button_2020 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the difficulty";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_easy
            // 
            this.button_easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_easy.Location = new System.Drawing.Point(32, 149);
            this.button_easy.Name = "button_easy";
            this.button_easy.Size = new System.Drawing.Size(162, 52);
            this.button_easy.TabIndex = 1;
            this.button_easy.Text = "Easy";
            this.button_easy.UseVisualStyleBackColor = true;
            this.button_easy.Click += new System.EventHandler(this.button_easy_Click);
            // 
            // button_medium
            // 
            this.button_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_medium.Location = new System.Drawing.Point(200, 149);
            this.button_medium.Name = "button_medium";
            this.button_medium.Size = new System.Drawing.Size(162, 52);
            this.button_medium.TabIndex = 2;
            this.button_medium.Text = "Medium";
            this.button_medium.UseVisualStyleBackColor = true;
            this.button_medium.Click += new System.EventHandler(this.button_medium_Click);
            // 
            // button_hard
            // 
            this.button_hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hard.Location = new System.Drawing.Point(368, 149);
            this.button_hard.Name = "button_hard";
            this.button_hard.Size = new System.Drawing.Size(162, 52);
            this.button_hard.TabIndex = 3;
            this.button_hard.Text = "Hard";
            this.button_hard.UseVisualStyleBackColor = true;
            this.button_hard.Click += new System.EventHandler(this.button_hard_Click);
            // 
            // button_2020
            // 
            this.button_2020.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2020.Location = new System.Drawing.Point(536, 149);
            this.button_2020.Name = "button_2020";
            this.button_2020.Size = new System.Drawing.Size(162, 52);
            this.button_2020.TabIndex = 4;
            this.button_2020.Text = "Legendary";
            this.button_2020.UseVisualStyleBackColor = true;
            this.button_2020.Click += new System.EventHandler(this.button_2020_Click);
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 252);
            this.Controls.Add(this.button_2020);
            this.Controls.Add(this.button_hard);
            this.Controls.Add(this.button_medium);
            this.Controls.Add(this.button_easy);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Difficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Difficulty";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_easy;
        private System.Windows.Forms.Button button_medium;
        private System.Windows.Forms.Button button_hard;
        private System.Windows.Forms.Button button_2020;
    }
}