namespace N_Puzzle_Game
{
    partial class Eight_Puzzle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eight_Puzzle));
            button3 = new Button();
            button2 = new Button();
            radioButton2 = new RadioButton();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            panel1 = new Panel();
            lbl_time = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Monotype Corsiva", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(136, 364);
            button3.Name = "button3";
            button3.Size = new Size(145, 44);
            button3.TabIndex = 13;
            button3.Text = "Solution";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Monotype Corsiva", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(304, 364);
            button2.Name = "button2";
            button2.Size = new Size(291, 44);
            button2.TabIndex = 12;
            button2.Text = "Choose Image";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            radioButton2.Location = new Point(13, 330);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(132, 29);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Image Puzzle";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(304, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 333);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 21.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(11, 364);
            button1.Name = "button1";
            button1.Size = new Size(117, 44);
            button1.TabIndex = 8;
            button1.Text = "Shuffle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(11, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 270);
            panel1.TabIndex = 7;
            // 
            // lbl_time
            // 
            lbl_time.AutoSize = true;
            lbl_time.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_time.Location = new Point(14, 297);
            lbl_time.Name = "lbl_time";
            lbl_time.Size = new Size(49, 22);
            lbl_time.TabIndex = 14;
            lbl_time.Text = "time :";
            // 
            // Eight_Puzzle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 416);
            Controls.Add(lbl_time);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(radioButton2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Eight_Puzzle";
            Opacity = 0.99D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Image Puzzle Game";
            FormClosed += Eight_Puzzle_FormClosed;
            Load += Eight_Puzzle_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_time;
    }
}