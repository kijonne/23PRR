namespace _23pr
{
    partial class MainForm
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
            buttonTaskTwo = new Button();
            buttonTaskThree = new Button();
            buttonTaskFour = new Button();
            SuspendLayout();
            // 
            // buttonTaskTwo
            // 
            buttonTaskTwo.Location = new Point(62, 50);
            buttonTaskTwo.Name = "buttonTaskTwo";
            buttonTaskTwo.Size = new Size(114, 54);
            buttonTaskTwo.TabIndex = 0;
            buttonTaskTwo.Text = "Задание 2";
            buttonTaskTwo.UseVisualStyleBackColor = true;
            buttonTaskTwo.Click += buttonTaskTwo_Click;
            // 
            // buttonTaskThree
            // 
            buttonTaskThree.Location = new Point(62, 123);
            buttonTaskThree.Name = "buttonTaskThree";
            buttonTaskThree.Size = new Size(114, 57);
            buttonTaskThree.TabIndex = 1;
            buttonTaskThree.Text = "Задание 3";
            buttonTaskThree.UseVisualStyleBackColor = true;
            buttonTaskThree.Click += buttonTaskThree_Click;
            // 
            // buttonTaskFour
            // 
            buttonTaskFour.Location = new Point(62, 201);
            buttonTaskFour.Name = "buttonTaskFour";
            buttonTaskFour.Size = new Size(114, 58);
            buttonTaskFour.TabIndex = 2;
            buttonTaskFour.Text = "Задание 4";
            buttonTaskFour.UseVisualStyleBackColor = true;
            buttonTaskFour.Click += buttonTaskFour_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(234, 311);
            Controls.Add(buttonTaskFour);
            Controls.Add(buttonTaskThree);
            Controls.Add(buttonTaskTwo);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главная форма";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTaskTwo;
        private Button buttonTaskThree;
        private Button buttonTaskFour;
    }
}