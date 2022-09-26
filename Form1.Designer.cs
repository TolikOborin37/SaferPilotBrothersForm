namespace SaferPilotBrothersForm
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.GameName = new System.Windows.Forms.Label();
            this.rules = new System.Windows.Forms.Label();
            this.numSize = new System.Windows.Forms.NumericUpDown();
            this.butStartGame = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameName
            // 
            this.GameName.AutoSize = true;
            this.GameName.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameName.Location = new System.Drawing.Point(57, 86);
            this.GameName.Name = "GameName";
            this.GameName.Size = new System.Drawing.Size(566, 110);
            this.GameName.TabIndex = 0;
            this.GameName.Text = "Логическая игра\r\n\"Сейф братьев пилотов\"\r\n";
            this.GameName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rules
            // 
            this.rules.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rules.Location = new System.Drawing.Point(12, 209);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(611, 357);
            this.rules.TabIndex = 1;
            this.rules.Text = resources.GetString("rules.Text");
            // 
            // numSize
            // 
            this.numSize.Location = new System.Drawing.Point(12, 466);
            this.numSize.Name = "numSize";
            this.numSize.Size = new System.Drawing.Size(120, 23);
            this.numSize.TabIndex = 2;
            this.numSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numSize.ValueChanged += new System.EventHandler(this.numSize_ValueChanged);
            // 
            // butStartGame
            // 
            this.butStartGame.Location = new System.Drawing.Point(240, 590);
            this.butStartGame.Name = "butStartGame";
            this.butStartGame.Size = new System.Drawing.Size(132, 23);
            this.butStartGame.TabIndex = 3;
            this.butStartGame.Text = "Начать игру";
            this.butStartGame.UseVisualStyleBackColor = true;
            this.butStartGame.Click += new System.EventHandler(this.butStartGame_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SaferPilotBrothersForm.Properties.Resources._16906_original;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormGame
            // 
            this.ClientSize = new System.Drawing.Size(635, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butStartGame);
            this.Controls.Add(this.numSize);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.GameName);
            this.Name = "FormGame";
            this.Text = "Сейф братьев пилотов";
            ((System.ComponentModel.ISupportInitialize)(this.numSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label GameName;
        private System.Windows.Forms.Label rules;
        private System.Windows.Forms.NumericUpDown numSize;
        private System.Windows.Forms.Button butStartGame;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
