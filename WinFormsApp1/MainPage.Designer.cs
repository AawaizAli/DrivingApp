﻿namespace WinFormsApp1
{
    partial class MainPage
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
            Practice = new Button();
            Mock_test = new Button();
            button3 = new Button();
            Signs = new Button();
            Progress = new Button();
            SuspendLayout();
            // 
            // Practice
            // 
            Practice.BackColor = Color.CadetBlue;
            Practice.Cursor = Cursors.Hand;
            Practice.Location = new Point(248, 105);
            Practice.Name = "Practice";
            Practice.Size = new Size(75, 78);
            Practice.TabIndex = 0;
            Practice.Text = "PRACTISE";
            Practice.UseVisualStyleBackColor = false;
            Practice.Click += Practice_Click;
            // 
            // Mock_test
            // 
            Mock_test.BackColor = Color.Cyan;
            Mock_test.Cursor = Cursors.Hand;
            Mock_test.Location = new Point(499, 105);
            Mock_test.Name = "Mock_test";
            Mock_test.Size = new Size(75, 78);
            Mock_test.TabIndex = 1;
            Mock_test.Text = "Mock Exam";
            Mock_test.UseVisualStyleBackColor = false;
            Mock_test.Click += Mock_test_Click;
            // 
            // button3
            // 
            button3.Location = new Point(499, 215);
            button3.Name = "button3";
            button3.Size = new Size(75, 78);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // Signs
            // 
            Signs.BackColor = Color.Coral;
            Signs.Location = new Point(248, 215);
            Signs.Name = "Signs";
            Signs.Size = new Size(75, 78);
            Signs.TabIndex = 3;
            Signs.Text = "Traffic Signs";
            Signs.UseVisualStyleBackColor = false;
            Signs.Click += Signs_Click;
            // 
            // Progress
            // 
            Progress.Location = new Point(693, 15);
            Progress.Name = "Progress";
            Progress.Size = new Size(75, 23);
            Progress.TabIndex = 4;
            Progress.Text = "Progress";
            Progress.UseVisualStyleBackColor = true;
            Progress.Click += Progress_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Progress);
            Controls.Add(Signs);
            Controls.Add(button3);
            Controls.Add(Mock_test);
            Controls.Add(Practice);
            Name = "MainPage";
            Text = "Main Page";
            ResumeLayout(false);
        }

        #endregion
        //completed

        private Button Practice;
        private Button Mock_test;
        private Button button3;
        private Button Signs;
        private Button Progress;
    }
}
