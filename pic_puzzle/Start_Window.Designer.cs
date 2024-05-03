namespace N_Puzzle_Game
{
    partial class Start_Window
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
            cmbx_size = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // cmbx_size
            // 
            cmbx_size.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbx_size.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbx_size.ForeColor = SystemColors.ActiveCaptionText;
            cmbx_size.FormattingEnabled = true;
            cmbx_size.Items.AddRange(new object[] { "3 * 3" });
            cmbx_size.Location = new Point(192, 14);
            cmbx_size.Name = "cmbx_size";
            cmbx_size.Size = new Size(240, 33);
            cmbx_size.TabIndex = 0;
            cmbx_size.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(9, 15);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 1;
            label1.Text = "Choose Puzzle :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(9, 77);
            label2.Name = "label2";
            label2.Size = new Size(175, 28);
            label2.TabIndex = 3;
            label2.Text = "Choose Algorthim :";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            comboBox2.ForeColor = SystemColors.ActiveCaptionText;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(194, 75);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(240, 33);
            comboBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(71, 134);
            button1.Name = "button1";
            button1.Size = new Size(149, 39);
            button1.TabIndex = 4;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Monotype Corsiva", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(230, 134);
            button2.Name = "button2";
            button2.Size = new Size(149, 39);
            button2.TabIndex = 5;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Start_Window
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 185);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(cmbx_size);
            Font = new Font("Tahoma", 8F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Start_Window";
            Opacity = 0.98D;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Artificial Intelligence | N Puzzle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_size;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}