namespace CalculadoraWindowsForms
{
    public partial class Form1 : Form
    {
        private double valorAtual = 0;
        private string operador = "";
        private bool operacaoEmAndamento = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operador = "+";
            valorAtual = Convert.ToDouble(ttbView.Text);
            operacaoEmAndamento = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            operador = "-";
            valorAtual = Convert.ToDouble(ttbView.Text);
            operacaoEmAndamento = true;
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            operador = "/";
            valorAtual = Convert.ToDouble(ttbView.Text);
            operacaoEmAndamento = true;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = "*";
            valorAtual = Convert.ToDouble(ttbView.Text);
            operacaoEmAndamento = true;
        }

        private void ttbView_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            ttbView.Text += "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            ttbView.Text += "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            ttbView.Text += "7";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            ttbView.Text += "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            ttbView.Text += "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            ttbView.Text += "4";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            ttbView.Text += "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            ttbView.Text += "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            ttbView.Text += "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            ttbView.Text += "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double valorNovo = Convert.ToDouble(ttbView.Text);
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = valorAtual + valorNovo;
                    break;
                case "-":
                    resultado = valorAtual - valorNovo;
                    break;
                case "*":
                    resultado = valorAtual * valorNovo;
                    break;
                case "/":
                    if (valorNovo != 0)
                        resultado = valorAtual / valorNovo;
                    else
                        MessageBox.Show("Erro: Divisão por zero!");
                    break;
            }

            ttbView.Text = resultado.ToString();
            valorAtual = resultado;
            operador = "";
            operacaoEmAndamento = false;  // Isso evita problemas em operações futuras
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ttbView.Text.Length > 1)
            {
                ttbView.Text = ttbView.Text.Substring(0, ttbView.Text.Length - 1);
            }
            else
            {
                ttbView.Text = "0";
            }
        }

        private void btnAllDelete_Click(object sender, EventArgs e)
        {
            ttbView.Text = "0";
            valorAtual = 0;
            operador = "";
            operacaoEmAndamento = false;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            // Verifica se o texto atual no visor já contém um ponto
            if (!ttbView.Text.Contains("."))
            {
                // Se não contiver, adiciona o ponto ao final do texto
                ttbView.Text += ".";
            }
        }
    }
}
