namespace BasiCalculator
{
    public enum EnmOperacoes
    {
        SOMA = 1,
        SUBTRACAO,
        MULTIPLICACAO,
        DIVISAO,
        OPERACAO_NAO_IDENTIFICADA
    } //ENUMERADO

    public partial class Form : System.Windows.Forms.Form
    {
        #region Atributos

        private EnmOperacoes enmOperacao { get; set; } //porque "enm" ? porque isso é um Enumerado
        private decimal decValorAEsquerda { get; set; } //exemplo: 10 + 20 (no exemplo esse é o valor a esquerda)
        private decimal decValorADireita { get; set; }

        #endregion Atributos

        #region Construtores

        public Form()
        {
            InitializeComponent();
        }

        #endregion Construtores

        #region Métodos

        private void limpar() => this.txtResultado.Text = default;

        private void setOperadorResultado(string strOperador)
        {
            this.decValorAEsquerda = Convert.ToInt32(this.txtResultado.Text);
            this.enmOperacao = this.getEnmOperacao(strOperador);
            this.limpar();
        }

        private EnmOperacoes getEnmOperacao(string strOperador)
        {
            return strOperador switch
            {
                "+" => EnmOperacoes.SOMA,
                "-" => EnmOperacoes.SUBTRACAO,
                "*" => EnmOperacoes.MULTIPLICACAO,
                "/" => EnmOperacoes.DIVISAO,
                _ => EnmOperacoes.OPERACAO_NAO_IDENTIFICADA,
            };
        }

        private void setOperacaoResultado()
        {
            this.decValorADireita = Convert.ToInt32(this.txtResultado.Text);
            switch (this.enmOperacao)
            {
                case EnmOperacoes.SOMA:
                    this.txtResultado.Text = this.getValorFormatado(this.decValorAEsquerda + this.decValorADireita);
                    break;

                case EnmOperacoes.SUBTRACAO:
                    this.txtResultado.Text = this.getValorFormatado(this.decValorAEsquerda - this.decValorADireita);
                    break;

                case EnmOperacoes.MULTIPLICACAO:
                    this.txtResultado.Text = this.getValorFormatado(this.decValorAEsquerda * this.decValorADireita);
                    break;

                case EnmOperacoes.DIVISAO:
                    this.txtResultado.Text = this.getValorFormatado(this.decValorAEsquerda / this.decValorADireita);
                    break;

                case EnmOperacoes.OPERACAO_NAO_IDENTIFICADA:
                    break;

                default:
                    break;
            }
        }

        private string getValorFormatado(decimal valor)
        {
            return valor.ToString("n2");
        }

        private string getDigitoClicado(object sender)
        {
            return (sender as Control)!.Text; //essa linha de código representa o texto do botão clicado (0, 1, 2...)
        }

        #endregion Métodos

        #region Eventos

        private void btn0_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.Text += this.getDigitoClicado(sender);
            }
            catch (Exception ex) //tem que colocar o try catch se não o programa pode fechar ao acontecer um erro não experado
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn01_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.Text += this.getDigitoClicado(sender);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn02_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.Text += this.getDigitoClicado(sender);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn03_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.Text += this.getDigitoClicado(sender);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn04_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.Text += this.getDigitoClicado(sender);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn05_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.Text += this.getDigitoClicado(sender);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn06_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.Text += this.getDigitoClicado(sender);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn07_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.Text += this.getDigitoClicado(sender);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn08_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.Text += this.getDigitoClicado(sender);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn09_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.Text += this.getDigitoClicado(sender);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                this.setOperacaoResultado();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            try
            {
                this.setOperadorResultado(this.getDigitoClicado(sender));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                this.setOperadorResultado(this.getDigitoClicado(sender));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                this.setOperadorResultado(this.getDigitoClicado(sender));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            try
            {
                this.setOperadorResultado(this.getDigitoClicado(sender));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                this.limpar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion Eventos
    }
}