using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memoria
{
    public partial class JogoDaMemoria : Form
    {
        // Array responsável pela armazenagem das imagens.
        Image[] vetImg = { Properties.Resources.Language_Cpp, Properties.Resources.Language_CSharp,
                           Properties.Resources.Language_Css, Properties.Resources.Language_Html,
                           Properties.Resources.Language_JS, Properties.Resources.Language_Python};

        Image imgPadrao = Properties.Resources.Invisible; // Imagem para esconder jogadas.

        Vetor vetParesAleatorios = new Vetor(); // Posições das imagens pares

        Button[] vetButtons;
        // Agentes de comparacao
        Button btnJogadaAtual;
        Button btnJogadaAnterior;
        bool imgFoiSelecionada = false; 
        int acertos = 0, numImagemAnterior = 0;

        // Metodos de Inicialização do Jogo Da Memoria
        public JogoDaMemoria()
        {
            InitializeComponent();
            // Inicializa array responsável pela armazenagem dos botões de jogadas.
            vetButtons = new Button[] {  
                btnJogada1, btnJogada2, btnJogada3, btnJogada4,
                btnJogada5, btnJogada6, btnJogada7, btnJogada8,
                btnJogada9, btnJogada10, btnJogada11, btnJogada12
            };
        }

        private void Btn_IniciaJogo_Click(object sender, EventArgs e)
        {
            EsconderJogadas();
            IniciarJogo();
            acertos = 0;
        }

        private void IniciarJogo()
        {
            Size = new Size(820, 360); // Redimensiona o Form1
            vetParesAleatorios.AleatorizarPares();

            MessageBox.Show("3 segundos para ver as figuras!");
            for (int i = 0; i <= 11; i++) // Revelar Cartas
            {
                int numImg = vetParesAleatorios.ExibeDadosDoVetor(i);

                Button btnJogada = vetButtons[i];
                btnJogada.BackgroundImage = vetImg[numImg - 1];
            }
            MemorizarCartas();
        }

        private async void MemorizarCartas()
        {
            await Task.Delay(3000); // 3 segundos para olhar as cartas
            EsconderJogadas();
            LiberarCartas();
        }

        private void EsconderJogadas()
        {
            foreach (Button btnJogada in vetButtons)
            {
                btnJogada.BackgroundImage = imgPadrao;
            }
        }

        private void LiberarCartas()
        {
            foreach (Button btnJogada in vetButtons)
            {
                btnJogada.Enabled = true;
            }
            btn_IniciarJogada.Visible = false;
        }

        // Metodos chamados Durante o Jogo

        private void Btn_TentarJogada_Click(object sender, EventArgs e)
        {
            Button btnJogadaAtual = sender as Button;
            ConteudoBotao(btnJogadaAtual);
        }

        private void ConteudoBotao(Button btnJogada)
        {
            btnJogadaAtual = btnJogada;
            int numJogadaAtual = Array.IndexOf(vetButtons, btnJogada);
            int numImagemAtual = vetParesAleatorios.ExibeDadosDoVetor(numJogadaAtual);

            DesativarJogada(btnJogada, numImagemAtual);
            VerificaParImagens(numJogadaAtual);
        }

        private void DesativarJogada(Button btnJogada, int numImagemAtual)
        {
            btnJogada.Enabled = false;
            btnJogada.BackgroundImage = vetImg[numImagemAtual - 1];
        }

        private void VerificaParImagens(int numJogadaAtual)
        {
            if (!imgFoiSelecionada)
            {
                numImagemAnterior = vetParesAleatorios.ExibeDadosDoVetor(numJogadaAtual);
                btnJogadaAnterior = vetButtons[numJogadaAtual];

                imgFoiSelecionada = true;
            }
            else
            {
                int numImagemAtual = vetParesAleatorios.ExibeDadosDoVetor(numJogadaAtual);
                imgFoiSelecionada = false;

                if (numImagemAtual == numImagemAnterior)
                {
                    acertos++;
                    VerificaSeAcabouOJogo();
                }
                else
                {
                    LiberarJogadas();
                }
            }
        }

        private void VerificaSeAcabouOJogo()
        {
            if (acertos != 6) return;

            MessageBox.Show("Fim de jogo. Parabéns, clique em Iniciar Jogada para recomeçar!");
            Size = new Size(820, 433); // Redimensiona o Form1
            btn_IniciarJogada.Visible = true;
        }
        private void LiberarJogadas()
        {
            btnJogadaAtual.Enabled = true;
            btnJogadaAnterior.Enabled = true;

            btnJogadaAtual.BackgroundImage = imgPadrao;
            btnJogadaAnterior.BackgroundImage = imgPadrao;

            Thread.Sleep(500);
        }
    }
}