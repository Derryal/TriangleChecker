namespace TriangleChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            bool isValidInput = ValidateInput();

            if (isValidInput)
            {
                int side1 = int.Parse(TriangleSide1.Text);
                int side2 = int.Parse(TriangleSide2.Text);
                int side3 = int.Parse(TriangleSide3.Text);

                if (IsValidTriangle(side1, side2, side3))
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        Result.Text = "Это равносторонний треугольник";
                    }
                    else if (side1 == side2 || side2 == side3 || side3 == side1)
                    {
                        Result.Text = "Это равнобедренный треугольник";
                    }
                    else
                    {
                        Result.Text = "Это разносторонний треугольник";
                    }
                }
                else
                {
                    MessageBox.Show("Введите значения сторон треугольника так, чтобы одна сторона не превышала сумму двух других");
                }
            }
        }

        private void TriangleSide(object sender, EventArgs e)
        {
            
        }

        private bool ValidateInput()
        {
            if (TriangleSide1.Text == "" || TriangleSide2.Text == "" || TriangleSide3.Text == "")
            {
                MessageBox.Show("Заполните все стороны треугольника");
                return false;
            }

            int side1, side2, side3;
            bool isNumeric1 = int.TryParse(TriangleSide1.Text, out side1);
            bool isNumeric2 = int.TryParse(TriangleSide2.Text, out side2);
            bool isNumeric3 = int.TryParse(TriangleSide3.Text, out side3);

            if (!isNumeric1 || !isNumeric2 || !isNumeric3)
            {
                MessageBox.Show("Введите числовые значения для сторон треугольника");
                return false;
            }

            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                MessageBox.Show("Все стороны треугольника должны быть положительными числами");
                return false;
            }

            if (side1 > 100 || side2 > 100 || side3 > 100)
            {
                MessageBox.Show("Значение стороны треугольника не должно превышать 100");
                return false;
            }

            return true;
        }

        private bool IsValidTriangle(int side1, int side2, int side3)
        {
            return side1 + side2 > side3 && side2 + side3 > side1 && side3 + side1 > side2;
        }
    }
}
