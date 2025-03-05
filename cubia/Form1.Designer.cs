namespace cubia
{
    partial class Form1
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
            Name = new Label();
            textBox1 = new TextBox();
            Grades = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            Result = new Label();
            SuspendLayout();
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name.Location = new Point(19, 11);
            Name.Name = "Name";
            Name.Size = new Size(42, 15);
            Name.TabIndex = 0;
            Name.Text = "Name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 9);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(382, 23);
            textBox1.TabIndex = 1;
            // 
            // Grades
            // 
            Grades.AutoSize = true;
            Grades.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Grades.Location = new Point(70, 38);
            Grades.Name = "Grades";
            Grades.Size = new Size(43, 15);
            Grades.TabIndex = 2;
            Grades.Text = "Grades";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(19, 58);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "English";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 56);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(64, 23);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(70, 84);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(64, 23);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 86);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 5;
            label2.Text = "Math";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(70, 113);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(64, 23);
            textBox4.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 115);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 7;
            label3.Text = "Science";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(70, 142);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(64, 23);
            textBox5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(19, 144);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 9;
            label4.Text = "Filipino";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(70, 170);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(64, 23);
            textBox6.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(19, 173);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 11;
            label5.Text = "History";
            // 
            // button1
            // 
            button1.Location = new Point(19, 199);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(115, 58);
            button1.TabIndex = 13;
            button1.Text = "Generate Average";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Result
            // 
            Result.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Result.Location = new Point(139, 56);
            Result.Name = "Result";
            Result.Size = new Size(313, 119);
            Result.TabIndex = 14;
            Result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 338);
            Controls.Add(Result);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(Grades);
            Controls.Add(textBox1);
            Controls.Add(Name);
            Margin = new Padding(3, 2, 3, 2);
            //Name = "Form1";
            Text = "Student Grade Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Name;
        private TextBox textBox1;
        private Label Grades;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private Label label4;
        private TextBox textBox6;
        private Label label5;
        private Button button1;
        private Label Result;
    }
}