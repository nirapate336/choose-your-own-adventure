namespace choose_your_own_adventure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.redFakeButton = new System.Windows.Forms.Label();
            this.blueFakeButton = new System.Windows.Forms.Label();
            this.yellowFakeButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(1, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(824, 432);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Transparent;
            this.outputLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputLabel.Font = new System.Drawing.Font("Schneidler Md BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(10, 47);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(629, 132);
            this.outputLabel.TabIndex = 1;
            this.outputLabel.Text = "You have decided to finally follow throug with your dream of starting your own co" +
    "mpany. Starting your own business if risky... try to end up rich.  What type of " +
    "company would you like to create?";
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Transparent;
            this.redLabel.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Location = new System.Drawing.Point(51, 179);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(209, 34);
            this.redLabel.TabIndex = 2;
            this.redLabel.Text = "Cupcake business";
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Transparent;
            this.blueLabel.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.Location = new System.Drawing.Point(51, 218);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(209, 34);
            this.blueLabel.TabIndex = 3;
            this.blueLabel.Text = "Clothing Company";
            // 
            // yellowLabel
            // 
            this.yellowLabel.AutoSize = true;
            this.yellowLabel.BackColor = System.Drawing.Color.Transparent;
            this.yellowLabel.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yellowLabel.Location = new System.Drawing.Point(54, 266);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(0, 37);
            this.yellowLabel.TabIndex = 4;
            // 
            // redFakeButton
            // 
            this.redFakeButton.BackColor = System.Drawing.Color.Red;
            this.redFakeButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.redFakeButton.Location = new System.Drawing.Point(12, 179);
            this.redFakeButton.Name = "redFakeButton";
            this.redFakeButton.Size = new System.Drawing.Size(42, 23);
            this.redFakeButton.TabIndex = 5;
            this.redFakeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // blueFakeButton
            // 
            this.blueFakeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.blueFakeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.blueFakeButton.Location = new System.Drawing.Point(12, 218);
            this.blueFakeButton.Name = "blueFakeButton";
            this.blueFakeButton.Size = new System.Drawing.Size(42, 23);
            this.blueFakeButton.TabIndex = 6;
            // 
            // yellowFakeButton
            // 
            this.yellowFakeButton.BackColor = System.Drawing.Color.Transparent;
            this.yellowFakeButton.ForeColor = System.Drawing.Color.Goldenrod;
            this.yellowFakeButton.Location = new System.Drawing.Point(12, 266);
            this.yellowFakeButton.Name = "yellowFakeButton";
            this.yellowFakeButton.Size = new System.Drawing.Size(42, 23);
            this.yellowFakeButton.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 395);
            this.Controls.Add(this.yellowFakeButton);
            this.Controls.Add(this.blueFakeButton);
            this.Controls.Add(this.redFakeButton);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Build your own business";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.Label redFakeButton;
        private System.Windows.Forms.Label blueFakeButton;
        private System.Windows.Forms.Label yellowFakeButton;
    }
}

