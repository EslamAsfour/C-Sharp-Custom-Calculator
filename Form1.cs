namespace Bonus
{
    public partial class Form1 : Form
    {
        char[] ch ;
        public Form1()
        {
            ch  = new char[] { '*', '+', '-' };
            InitializeComponent();
        }
        private void Calc()
        {
            int num1, num2;
            String UncalculatedEq = "",FullEx = L_IO.Text;
            
            char op;
            int OpInd, OpInd2;
            // Get Op Index
            OpInd = FullEx.IndexOfAny(ch);
            // Get Index Type
            op = FullEx[OpInd];
            // SubString To get Each Number
            num1 = int.Parse(FullEx.Substring(0, OpInd));
            // If We have more Than One Operator So we Take Only the Left Side Op
            if (FullEx.Substring(OpInd + 1).IndexOfAny(ch) == -1)
                // No more Operators
                num2 = int.Parse(FullEx.Substring(OpInd + 1));
            else
            // Extract Num2 as the First Number From the Left
            {
                OpInd2 = FullEx.Substring(OpInd + 1).IndexOfAny(ch);
                num2 = int.Parse(FullEx.Substring(OpInd + 1, OpInd2));
                UncalculatedEq = FullEx.Substring(OpInd + OpInd2 + 1);
            }

            if (op == '+')
                L_IO.Text = (num1 + num2).ToString() + UncalculatedEq;
            else if (op == '-')
                L_IO.Text = (num1 - num2).ToString()+ UncalculatedEq;
            else if (op == '*')
                L_IO.Text = (num1 * num2).ToString()+ UncalculatedEq;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            L_IO.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            L_IO.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            L_IO.Text += "3";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            L_IO.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            L_IO.Text += "5";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            L_IO.Text += "6";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            L_IO.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            L_IO.Text += "8";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            L_IO.Text += "9";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            L_IO.Text += "0";
        }
        private void button13_Click(object sender, EventArgs e)
        {
            // If the Last Character is not an operator
            if( ! ch.Contains(L_IO.Text[L_IO.Text.Length - 1]) )
                L_IO.Text += "+";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            // If the Last Character is not an operator
            if (!ch.Contains(L_IO.Text[L_IO.Text.Length - 1]))
                L_IO.Text += "-";
        }
        private void button11_Click(object sender, EventArgs e)
        {            
            // If the Last Character is not an operator
            if (!ch.Contains(L_IO.Text[L_IO.Text.Length - 1]))
                L_IO.Text += "*";
        }
        // Equal
        private void button14_Click(object sender, EventArgs e)
        {
            // Check if we Have an Operator 
            if(L_IO.Text.IndexOfAny(ch) != -1)
                Calc();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(L_IO.Text != "")
                L_IO.Text = L_IO.Text.Substring(0, L_IO.Text.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    button1.PerformClick();
                    break;
                case '2':
                    button2.PerformClick();
                    break;
                case '3':
                    button3.PerformClick();
                    break;
                case '4':
                    button6.PerformClick();
                    break;
                case '5':
                    button5.PerformClick();
                    break;
                case '6':
                    button4.PerformClick();
                    break;
                case '7':
                    button9.PerformClick();
                    break;
                case '8':
                    button8.PerformClick();
                    break;
                case '9':
                    button7.PerformClick();
                    break;
                case '0':
                    button10.PerformClick();
                    break;
                case '+':
                    button13.PerformClick();
                    break;
                case '-':
                    button12.PerformClick();
                    break;
                case '*':
                    button11.PerformClick();
                    break;
                case '\b':
                    button15.PerformClick();
                    break;
                case '=':
                    button14.PerformClick();
                    break;
            }
        }
    }
}