namespace Death_Star_Summative
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.startButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.startMisson = new System.Windows.Forms.Button();
            this.deathstarBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.deathstarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(216, 282);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(178, 58);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Briefing";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("OCR A Std", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(374, 29);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Death Star Sabotage";
            // 
            // startMisson
            // 
            this.startMisson.BackColor = System.Drawing.Color.White;
            this.startMisson.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.startMisson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.startMisson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startMisson.Font = new System.Drawing.Font("OCR A Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMisson.Location = new System.Drawing.Point(216, 282);
            this.startMisson.Name = "startMisson";
            this.startMisson.Size = new System.Drawing.Size(178, 58);
            this.startMisson.TabIndex = 2;
            this.startMisson.Text = "Start Misson";
            this.startMisson.UseVisualStyleBackColor = false;
            this.startMisson.Click += new System.EventHandler(this.startMisson_Click);
            // 
            // deathstarBox
            // 
            this.deathstarBox.Image = global::Death_Star_Summative.Properties.Resources.The_Death_Star;
            this.deathstarBox.Location = new System.Drawing.Point(25, 33);
            this.deathstarBox.Name = "deathstarBox";
            this.deathstarBox.Size = new System.Drawing.Size(355, 307);
            this.deathstarBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deathstarBox.TabIndex = 3;
            this.deathstarBox.TabStop = false;
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(406, 352);
            this.Controls.Add(this.startMisson);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.deathstarBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Window";
            this.Text = "Death Star";
            ((System.ComponentModel.ISupportInitialize)(this.deathstarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startMisson;
        private System.Windows.Forms.PictureBox deathstarBox;
    }
}

