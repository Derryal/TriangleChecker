namespace TriangleChecker
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
            ButtonCalculate = new Button();
            label1 = new Label();
            Result = new Label();
            TriangleSide1 = new TextBox();
            TriangleSide2 = new TextBox();
            TriangleSide3 = new TextBox();
            SuspendLayout();
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonCalculate.Location = new Point(28, 274);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(237, 61);
            ButtonCalculate.TabIndex = 0;
            ButtonCalculate.Text = "Рассчитать треугольник";
            ButtonCalculate.UseVisualStyleBackColor = true;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 57);
            label1.Name = "label1";
            label1.Size = new Size(307, 21);
            label1.TabIndex = 1;
            label1.Text = "Введите длины сторон треугольника";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Result.ForeColor = SystemColors.ButtonHighlight;
            Result.Location = new Point(309, 294);
            Result.Name = "Result";
            Result.RightToLeft = RightToLeft.Yes;
            Result.Size = new Size(0, 21);
            Result.TabIndex = 2;
            Result.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TriangleSide1
            // 
            TriangleSide1.Location = new Point(39, 117);
            TriangleSide1.Name = "TriangleSide1";
            TriangleSide1.Size = new Size(133, 23);
            TriangleSide1.TabIndex = 3;
            TriangleSide1.TextAlign = HorizontalAlignment.Center;
            TriangleSide1.TextChanged += TriangleSide;
            // 
            // TriangleSide2
            // 
            TriangleSide2.Location = new Point(213, 117);
            TriangleSide2.Name = "TriangleSide2";
            TriangleSide2.Size = new Size(133, 23);
            TriangleSide2.TabIndex = 4;
            TriangleSide2.TextAlign = HorizontalAlignment.Center;
            TriangleSide2.TextChanged += TriangleSide;
            // 
            // TriangleSide3
            // 
            TriangleSide3.Location = new Point(374, 117);
            TriangleSide3.Name = "TriangleSide3";
            TriangleSide3.Size = new Size(133, 23);
            TriangleSide3.TabIndex = 5;
            TriangleSide3.TextAlign = HorizontalAlignment.Center;
            TriangleSide3.TextChanged += TriangleSide;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGreen;
            ClientSize = new Size(632, 386);
            Controls.Add(TriangleSide3);
            Controls.Add(TriangleSide2);
            Controls.Add(TriangleSide1);
            Controls.Add(Result);
            Controls.Add(label1);
            Controls.Add(ButtonCalculate);
            Name = "Form1";
            Text = "TriangleChecker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonCalculate;
        private Label label1;
        private Label Result;
        private TextBox TriangleSide1;
        private TextBox TriangleSide2;
        private TextBox TriangleSide3;
    }
}
