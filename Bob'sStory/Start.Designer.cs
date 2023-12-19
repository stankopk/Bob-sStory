namespace Bob_sStory
{
    partial class Start
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
            this.btnCity = new System.Windows.Forms.Button();
            this.btnForest = new System.Windows.Forms.Button();
            this.lblBobsStory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Bob_sStory.Properties.Resources.Bob;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(609, 201);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 237);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCity
            // 
            this.btnCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCity.Location = new System.Drawing.Point(341, 232);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(143, 108);
            this.btnCity.TabIndex = 1;
            this.btnCity.Text = "Go to the City";
            this.btnCity.UseVisualStyleBackColor = true;
            this.btnCity.Click += new System.EventHandler(this.btnCity_Click);
            // 
            // btnForest
            // 
            this.btnForest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnForest.Location = new System.Drawing.Point(55, 306);
            this.btnForest.Name = "btnForest";
            this.btnForest.Size = new System.Drawing.Size(143, 108);
            this.btnForest.TabIndex = 2;
            this.btnForest.Text = "Go to the Forest";
            this.btnForest.UseVisualStyleBackColor = true;
            this.btnForest.Click += new System.EventHandler(this.btnForest_Click);
            // 
            // lblBobsStory
            // 
            this.lblBobsStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBobsStory.Location = new System.Drawing.Point(313, 9);
            this.lblBobsStory.Name = "lblBobsStory";
            this.lblBobsStory.Size = new System.Drawing.Size(475, 74);
            this.lblBobsStory.TabIndex = 3;
            this.lblBobsStory.Text = "This is Bob.He wants to go to the city or the forest. Where will he go ?";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bob_sStory.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBobsStory);
            this.Controls.Add(this.btnForest);
            this.Controls.Add(this.btnCity);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Start";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCity;
        private System.Windows.Forms.Button btnForest;
        private System.Windows.Forms.Label lblBobsStory;
    }
}

