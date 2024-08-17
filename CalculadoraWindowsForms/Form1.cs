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

        private void AdicionarNumero(string numero)
        {
            // Se é uma nova operação ou o visor contém "0", limpa o visor
            if (operacaoEmAndamento || ttbView.Text == "0")
            {
                ttbView.Clear();
                operacaoEmAndamento = false;
            }

            // Adiciona o número ao visor
            ttbView.Text += numero;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            {
                AdicionarNumero("9");
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            {
                AdicionarNumero("8");
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            {
                AdicionarNumero("7");
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            {
                AdicionarNumero("6");
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            {
                AdicionarNumero("5");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            {
                AdicionarNumero("4");
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            {
                AdicionarNumero("3");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            {
                AdicionarNumero("2");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            {
                AdicionarNumero("1");
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            {
                AdicionarNumero("0");
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Tenta converter o valor do visor para um número decimal
            if (double.TryParse(ttbView.Text, out double valorNovo))
            {
                double resultado = 0;

                // Verifica o operador e realiza a operação correspondente
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

                // Atualiza o visor com o resultado e redefine o estado
                ttbView.Text = resultado.ToString("G"); // Usar formato geral para lidar com precisão
                valorAtual = resultado;
                operador = "";
                operacaoEmAndamento = true;
            }
            else
            {
                MessageBox.Show("Erro: Entrada inválida.");
            }
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
            if (!ttbView.Text.Contains("."))
            {
                ttbView.Text += ".";
            }
        }
    }
}
