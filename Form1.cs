using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_Memoria
{
    public partial class Form1 : Form
    {
        static Vetor vet_Numero = new Vetor();
        string caminhoIMG = "C:\\Users\\Gabri\\source\\repos\\Jogo da Memoria\\IMG\\";
        int Acertos = 0, Selec = 0, auxV = 0, auxB;

        public Form1()
        {
            InitializeComponent();
        }

        private void AtivaBotoes()
        {
            btn_img1.Enabled = true;
            btn_img2.Enabled = true;
            btn_img3.Enabled = true;
            btn_img4.Enabled = true;
            btn_img5.Enabled = true;
            btn_img6.Enabled = true;
            btn_img7.Enabled = true;
            btn_img8.Enabled = true;
            btn_img9.Enabled = true;
            btn_img10.Enabled = true;
            btn_img11.Enabled = true;
            btn_img12.Enabled = true;
            Btn_IniciaJogada.Visible = false;
        }

        private void RevelaBtn_DesativaJogada(int p)
        {
            string imagem = vet_Numero.ExibeDadosDoVetor(p).ToString();
            switch (p)
            {
                case 1: btn_img1.Enabled = false; btn_img1.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 2: btn_img2.Enabled = false; btn_img2.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 3: btn_img3.Enabled = false; btn_img3.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 4: btn_img4.Enabled = false; btn_img4.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 5: btn_img5.Enabled = false; btn_img5.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 6: btn_img6.Enabled = false; btn_img6.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 7: btn_img7.Enabled = false; btn_img7.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 8: btn_img8.Enabled = false; btn_img8.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 9: btn_img9.Enabled = false; btn_img9.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 10: btn_img10.Enabled = false; btn_img10.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 11: btn_img11.Enabled = false; btn_img11.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                case 12: btn_img12.Enabled = false; btn_img12.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
            }
        }

        private void EscondeBotoes()
        {
            btn_img1.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img2.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img3.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img4.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img5.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img6.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img7.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img8.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img9.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img10.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img11.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
            btn_img12.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png");
        }

        private void Ativa_Esconde_Btn(int p, int auxB)
        {
            switch (p)
            {
                case 1: btn_img1.Enabled = true; btn_img1.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 2: btn_img2.Enabled = true; btn_img2.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 3: btn_img3.Enabled = true; btn_img3.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 4: btn_img4.Enabled = true; btn_img4.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 5: btn_img5.Enabled = true; btn_img5.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 6: btn_img6.Enabled = true; btn_img6.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 7: btn_img7.Enabled = true; btn_img7.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 8: btn_img8.Enabled = true; btn_img8.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 9: btn_img9.Enabled = true; btn_img9.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 10: btn_img10.Enabled = true; btn_img10.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 11: btn_img11.Enabled = true; btn_img11.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 12: btn_img12.Enabled = true; btn_img12.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
            }
            switch (auxB)
            {
                case 1: btn_img1.Enabled = true; btn_img1.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 2: btn_img2.Enabled = true; btn_img2.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 3: btn_img3.Enabled = true; btn_img3.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 4: btn_img4.Enabled = true; btn_img4.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 5: btn_img5.Enabled = true; btn_img5.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 6: btn_img6.Enabled = true; btn_img6.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 7: btn_img7.Enabled = true; btn_img7.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 8: btn_img8.Enabled = true; btn_img8.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 9: btn_img9.Enabled = true; btn_img9.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 10: btn_img10.Enabled = true; btn_img10.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 11: btn_img11.Enabled = true; btn_img11.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
                case 12: btn_img12.Enabled = true; btn_img12.BackgroundImage = Image.FromFile(caminhoIMG + "0" + ".png"); break;
            }
            Thread.Sleep(500);
        }

        private async void Memorizar()
        {
            await Task.Delay(3000);
            EscondeBotoes();
            AtivaBotoes();
        }

        private void EmJogo()
        {
            Size = new Size(820, 360); // Redimensiona Form
            vet_Numero.AleatorizarVetor();
            MessageBox.Show("3 segundos para ver as figuras!");
            for (int i = 1; i <= 12; i++)
            {
                string imagem = vet_Numero.ExibeDadosDoVetor(i).ToString();
                switch (i)
                {
                    case 1: btn_img1.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 2: btn_img2.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 3: btn_img3.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 4: btn_img4.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 5: btn_img5.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 6: btn_img6.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 7: btn_img7.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 8: btn_img8.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 9: btn_img9.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 10: btn_img10.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 11: btn_img11.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                    case 12: btn_img12.BackgroundImage = Image.FromFile(caminhoIMG + imagem + ".png"); break;
                }
            }
            Memorizar();
        }

        private void Btn_IniciaJogada_Click(object sender, EventArgs e)
        {
            EscondeBotoes();
            EmJogo();
            Acertos = 0;
        }

        private void VerificaFimdeJogo()
        {
            if (Acertos == 6)
            {
                MessageBox.Show("Fim de jogo. Parabéns, clique em Iniciar Jogada para recomeçar!");
                Size = new Size(820, 433); // Redimensiona Form
                Btn_IniciaJogada.Visible = true;
            }
        }

        private void ConteudoBotao(int p)
        {
            RevelaBtn_DesativaJogada(p);
            VerificaPar(p);
        }

        private void VerificaPar(int p)
        {
            if (Selec == 0)
            {
                Selec++;
                auxV = vet_Numero.ExibeDadosDoVetor(p);
                auxB = p;
            }
            else
            {
                Selec = 0;
                if (auxV == vet_Numero.ExibeDadosDoVetor(p))
                {
                    Acertos++;
                    VerificaFimdeJogo();
                }
                else
                {
                    Ativa_Esconde_Btn(p, auxB);
                }
            }
        }

        private void Btn_img1_Click(object sender, EventArgs e)
        {
            ConteudoBotao(1);
        }

        private void Btn_img2_Click(object sender, EventArgs e)
        {
            ConteudoBotao(2);
        }

        private void Btn_img3_Click(object sender, EventArgs e)
        {
            ConteudoBotao(3);
        }

        private void Btn_img4_Click(object sender, EventArgs e)
        {
            ConteudoBotao(4);
        }

        private void Btn_img5_Click(object sender, EventArgs e)
        {
            ConteudoBotao(5);
        }

        private void Btn_img6_Click(object sender, EventArgs e)
        {
            ConteudoBotao(6);
        }

        private void Btn_img7_Click(object sender, EventArgs e)
        {
            ConteudoBotao(7);
        }

        private void Btn_img8_Click(object sender, EventArgs e)
        {
            ConteudoBotao(8);
        }

        private void Btn_img9_Click(object sender, EventArgs e)
        {
            ConteudoBotao(9);
        }

        private void Btn_img10_Click(object sender, EventArgs e)
        {
            ConteudoBotao(10);
        }

        private void Btn_img11_Click(object sender, EventArgs e)
        {
            ConteudoBotao(11);
        }

        private void Btn_img12_Click(object sender, EventArgs e)
        {
            ConteudoBotao(12);
        }
    }
}