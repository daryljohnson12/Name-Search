namespace Name_Search
{
    partial class NameSearchForm
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
            this.girlsNameLabel = new System.Windows.Forms.Label();
            this.boysNameLabel = new System.Windows.Forms.Label();
            this.girlsNameTextBox = new System.Windows.Forms.TextBox();
            this.boysNameTextBox = new System.Windows.Forms.TextBox();
            this.checkNameButton = new System.Windows.Forms.Button();
            this.randomGirlsButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.randomBoysButton = new System.Windows.Forms.Button();
            this.girlNameLabel = new System.Windows.Forms.Label();
            this.boyNameLabel = new System.Windows.Forms.Label();
            this.boyRandomNameLabel = new System.Windows.Forms.Label();
            this.girlRandomNameLabel = new System.Windows.Forms.Label();
            this.girlLabel = new System.Windows.Forms.Label();
            this.boyLabel = new System.Windows.Forms.Label();
            this.babyPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.babyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // girlsNameLabel
            // 
            this.girlsNameLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girlsNameLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.girlsNameLabel.Location = new System.Drawing.Point(39, 30);
            this.girlsNameLabel.Name = "girlsNameLabel";
            this.girlsNameLabel.Size = new System.Drawing.Size(156, 23);
            this.girlsNameLabel.TabIndex = 0;
            this.girlsNameLabel.Text = "Enter a girl name:";
            // 
            // boysNameLabel
            // 
            this.boysNameLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boysNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.boysNameLabel.Location = new System.Drawing.Point(39, 90);
            this.boysNameLabel.Name = "boysNameLabel";
            this.boysNameLabel.Size = new System.Drawing.Size(156, 23);
            this.boysNameLabel.TabIndex = 1;
            this.boysNameLabel.Text = "Enter a boy name:";
            // 
            // girlsNameTextBox
            // 
            this.girlsNameTextBox.ForeColor = System.Drawing.Color.DeepPink;
            this.girlsNameTextBox.Location = new System.Drawing.Point(228, 30);
            this.girlsNameTextBox.Name = "girlsNameTextBox";
            this.girlsNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.girlsNameTextBox.TabIndex = 2;
            // 
            // boysNameTextBox
            // 
            this.boysNameTextBox.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.boysNameTextBox.Location = new System.Drawing.Point(228, 90);
            this.boysNameTextBox.Name = "boysNameTextBox";
            this.boysNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.boysNameTextBox.TabIndex = 3;
            // 
            // checkNameButton
            // 
            this.checkNameButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkNameButton.Location = new System.Drawing.Point(291, 145);
            this.checkNameButton.Name = "checkNameButton";
            this.checkNameButton.Size = new System.Drawing.Size(107, 50);
            this.checkNameButton.TabIndex = 4;
            this.checkNameButton.Text = "Check Name";
            this.checkNameButton.UseVisualStyleBackColor = false;
            this.checkNameButton.Click += new System.EventHandler(this.checkNameButton_Click);
            // 
            // randomGirlsButton
            // 
            this.randomGirlsButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.randomGirlsButton.Location = new System.Drawing.Point(42, 274);
            this.randomGirlsButton.Name = "randomGirlsButton";
            this.randomGirlsButton.Size = new System.Drawing.Size(95, 44);
            this.randomGirlsButton.TabIndex = 5;
            this.randomGirlsButton.Text = "Random Girl Name";
            this.randomGirlsButton.UseVisualStyleBackColor = false;
            this.randomGirlsButton.Click += new System.EventHandler(this.randomGirlsButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clearButton.Location = new System.Drawing.Point(45, 351);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(92, 44);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(291, 351);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(97, 44);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // randomBoysButton
            // 
            this.randomBoysButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.randomBoysButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.randomBoysButton.Location = new System.Drawing.Point(291, 274);
            this.randomBoysButton.Name = "randomBoysButton";
            this.randomBoysButton.Size = new System.Drawing.Size(97, 44);
            this.randomBoysButton.TabIndex = 10;
            this.randomBoysButton.Text = "Random Boy Name";
            this.randomBoysButton.UseVisualStyleBackColor = false;
            this.randomBoysButton.Click += new System.EventHandler(this.randomBoysButton_Click);
            // 
            // girlNameLabel
            // 
            this.girlNameLabel.AutoSize = true;
            this.girlNameLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.girlNameLabel.Location = new System.Drawing.Point(42, 145);
            this.girlNameLabel.Name = "girlNameLabel";
            this.girlNameLabel.Size = new System.Drawing.Size(0, 13);
            this.girlNameLabel.TabIndex = 15;
            // 
            // boyNameLabel
            // 
            this.boyNameLabel.AutoSize = true;
            this.boyNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.boyNameLabel.Location = new System.Drawing.Point(42, 181);
            this.boyNameLabel.Name = "boyNameLabel";
            this.boyNameLabel.Size = new System.Drawing.Size(0, 13);
            this.boyNameLabel.TabIndex = 16;
            // 
            // boyRandomNameLabel
            // 
            this.boyRandomNameLabel.AutoSize = true;
            this.boyRandomNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.boyRandomNameLabel.Location = new System.Drawing.Point(646, 290);
            this.boyRandomNameLabel.Name = "boyRandomNameLabel";
            this.boyRandomNameLabel.Size = new System.Drawing.Size(0, 13);
            this.boyRandomNameLabel.TabIndex = 17;
            // 
            // girlRandomNameLabel
            // 
            this.girlRandomNameLabel.AutoSize = true;
            this.girlRandomNameLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.girlRandomNameLabel.Location = new System.Drawing.Point(646, 351);
            this.girlRandomNameLabel.Name = "girlRandomNameLabel";
            this.girlRandomNameLabel.Size = new System.Drawing.Size(0, 13);
            this.girlRandomNameLabel.TabIndex = 18;
            // 
            // girlLabel
            // 
            this.girlLabel.AutoSize = true;
            this.girlLabel.ForeColor = System.Drawing.Color.DeepPink;
            this.girlLabel.Location = new System.Drawing.Point(480, 351);
            this.girlLabel.Name = "girlLabel";
            this.girlLabel.Size = new System.Drawing.Size(122, 13);
            this.girlLabel.TabIndex = 19;
            this.girlLabel.Text = "The random girl name is:";
            // 
            // boyLabel
            // 
            this.boyLabel.AutoSize = true;
            this.boyLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.boyLabel.Location = new System.Drawing.Point(476, 290);
            this.boyLabel.Name = "boyLabel";
            this.boyLabel.Size = new System.Drawing.Size(126, 13);
            this.boyLabel.TabIndex = 20;
            this.boyLabel.Text = "The random boy name is:";
            // 
            // babyPictureBox
            // 
            this.babyPictureBox.Image = global::Name_Search.Properties.Resources.baby;
            this.babyPictureBox.Location = new System.Drawing.Point(501, 30);
            this.babyPictureBox.Name = "babyPictureBox";
            this.babyPictureBox.Size = new System.Drawing.Size(209, 212);
            this.babyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.babyPictureBox.TabIndex = 21;
            this.babyPictureBox.TabStop = false;
            // 
            // NameSearchForm
            // 
            this.AcceptButton = this.checkNameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.babyPictureBox);
            this.Controls.Add(this.boyLabel);
            this.Controls.Add(this.girlLabel);
            this.Controls.Add(this.girlRandomNameLabel);
            this.Controls.Add(this.boyRandomNameLabel);
            this.Controls.Add(this.boyNameLabel);
            this.Controls.Add(this.girlNameLabel);
            this.Controls.Add(this.randomBoysButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.randomGirlsButton);
            this.Controls.Add(this.checkNameButton);
            this.Controls.Add(this.boysNameTextBox);
            this.Controls.Add(this.girlsNameTextBox);
            this.Controls.Add(this.boysNameLabel);
            this.Controls.Add(this.girlsNameLabel);
            this.Name = "NameSearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Name Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.babyPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label girlsNameLabel;
        private System.Windows.Forms.Label boysNameLabel;
        private System.Windows.Forms.TextBox girlsNameTextBox;
        private System.Windows.Forms.TextBox boysNameTextBox;
        private System.Windows.Forms.Button checkNameButton;
        private System.Windows.Forms.Button randomGirlsButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button randomBoysButton;
        private System.Windows.Forms.Label girlNameLabel;
        private System.Windows.Forms.Label boyNameLabel;
        private System.Windows.Forms.Label boyRandomNameLabel;
        private System.Windows.Forms.Label girlRandomNameLabel;
        private System.Windows.Forms.Label girlLabel;
        private System.Windows.Forms.Label boyLabel;
        private System.Windows.Forms.PictureBox babyPictureBox;
    }
}

