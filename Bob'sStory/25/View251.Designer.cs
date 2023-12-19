namespace Bob_sStory._25
{
    partial class View251
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
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(740, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Боб се озова в безизходица. Спирането на употребата на наркотици беше стъпка към " +
    "нов живот,\r\n но дълговете му към дилърите оставаха като тежък товар върху рамене" +
    "те му.\r\n \r\n\r\n\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(489, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Съзнавайки, че ще се нуждае от време, за да върне парите\r\nБоб се ангажира да наме" +
    "ри честен начин за изкарване на пари.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bob_sStory.Properties.Resources.Bob;
            this.pictureBox1.Location = new System.Drawing.Point(542, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 301);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "next>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // View251
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bob_sStory.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(801, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "View251";
            this.Text = "View251";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}