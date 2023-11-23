using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace ProjetoUrnaEletronica
{
    public partial class Form1 : Form
    {
        private Dictionary<int, string> candidatos = new Dictionary<int, string>
    {
        { 111, "Toddy - PepsiCo" },
        { 222, "Necau - Nestlé" },
        { 333, "Chocollato - 3corações" },
        { 444, "Ovomaltine - ABF" }
    };

        private Dictionary<int, int> votos = new Dictionary<int, int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código a ser executado quando o formulário for carregado
            lblCandidato.Text = "Candidato: N/A";
            lblPartido.Text = "Partido: N/A";
            lblInfo.Text = "Insira o código do candidato e pressione 'Confirmar Voto'.";
            lblResultado.Text = "Resultado: ";
            txtCodigo.Clear();

            txtCodigo.TextChanged += test;

            // Adicione aqui qualquer outra inicialização necessária.
        }




        // Evento acionado quando o usuário insere o código do candidato e pressiona Enter
        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyCode == Keys.Enter)
            {
                ProcessarVoto();
            }
        }

        // Método para processar o voto
        private void ProcessarVoto()
        {
            if (int.TryParse(txtCodigo.Text, out int codigoCandidato))
            {
                if (candidatos.ContainsKey(codigoCandidato))
                {
                    if (votos.ContainsKey(codigoCandidato))
                    {
                        votos[codigoCandidato]++;
                    }
                    else
                    {
                        votos[codigoCandidato] = 1;
                    }

                    txtCodigo.Clear();
                    lblInfo.Text = "Voto registrado com sucesso!";

                    // Separar o nome do candidato e do partido
                    string[] infoCandidato = candidatos[codigoCandidato].Split('-');

                    // Atualizar as labels com as informações do candidato e do partido
                    lblCandidato.Text = $"Candidato: {infoCandidato[0].Trim()}";
                    lblPartido.Text = $"Partido: {infoCandidato[1].Trim()}";
                    lblCandidato.Text = "Candidato:";
                    lblPartido.Text = "Partido:";
                }
                else
                {
                    lblInfo.Text = "Código de candidato inválido!";
                    // Limpar as labels para indicar que não há candidato selecionado
                    lblCandidato.Text = "Candidato: N/A";
                    lblPartido.Text = "Partido: N/A";
                }
            }
            else
            {
                lblInfo.Text = "Por favor, insira um código válido!";
                // Limpar as labels para indicar que não há candidato selecionado
                lblCandidato.Text = "Candidato: N/A";
                lblPartido.Text = "Partido: N/A";
            }
        }



        // Método para mostrar o resultado da votação
        private void MostrarResultado()
        {
            lblResultado.Text = "Resultado da votação:\n";

            foreach (var voto in votos)
            {
                lblResultado.Text += $"{candidatos[voto.Key]}: {voto.Value} votos\n";
            }
        }

        private void btnConfirmarVoto_Click(object sender, EventArgs e)
        {
            ProcessarVoto();
        }

        private void btnFinalizarVotacao_Click_1(object sender, EventArgs e)
        {
            MostrarResultado();
            MessageBox.Show("Votação finalizada!");
        }
        private void txtCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

            MessageBox.Show("Entrada inválida. Por favor, insira apenas números.");
        }

        private void test (object sender, EventArgs e)
        {
                if (txtCodigo.Text == "111")
                {
                    lblCandidato.Text = "Nescau";
                    lblPartido.Text = "PepsiCo";
                pictureBox1.Image = Properties.Resources.nescau;

                }
                else if (txtCodigo.Text == "222")
            {
                lblCandidato.Text = "Toddy";
                lblPartido.Text = "Nestlé";
                pictureBox1.Image = Properties.Resources.toddy;
            }
            else if (txtCodigo.Text == "333")
            {
                lblCandidato.Text = "Chocollato";
                lblPartido.Text = "3corações";
                pictureBox1.Image = Properties.Resources.chocolatto;
            }
            else if (txtCodigo.Text == "444")
            {
                lblCandidato.Text = "Ovomaltine";
                lblPartido.Text = "ABF";
                pictureBox1.Image = Properties.Resources.ovomaltine;
            }


        }


    }

}
