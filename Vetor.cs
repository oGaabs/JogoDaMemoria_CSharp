using System;

namespace Jogo_da_Memoria
{
    class Vetor
    {
        // ATRIBUTOS
        private int[] vetorInt_1;

        private int[] vetorInt_2;

        private int limiteLogico, qtosElementosTemNoVetor;

        public Vetor()
        {
            vetorInt_1 = new int[12];
            vetorInt_2 = new int[12];
            limiteLogico = 12;
            qtosElementosTemNoVetor = 0;
        }

        // METODOS GETTERs E SETTERs
        public void SetQtosElementosTemNoVetor(int n)
        { qtosElementosTemNoVetor = n; }

        public int GetQtosElementosTemNoVetor()
        { return qtosElementosTemNoVetor; }

        public void SetLimiteLogico(int l)
        { limiteLogico = l; }

        public int GetLimiteLogico()
        { return limiteLogico; }

        // MÉTODOS FUNCIONAIS
        public bool EstaCheio()
        { return (qtosElementosTemNoVetor == limiteLogico); }

        public bool EstaVazio()
        { return (qtosElementosTemNoVetor == 0); }

        public int ExibeDadosDoVetor(int p)
        {
            int dados;
            dados = vetorInt_1[p - 1];

            return dados;
        }

        public void MontaVetor_1()
        {
            vetorInt_1[0] = 7;
            vetorInt_1[1] = 7;
            vetorInt_1[2] = 7;
            vetorInt_1[3] = 7;
            vetorInt_1[4] = 7;
            vetorInt_1[5] = 7;
            vetorInt_1[6] = 7;
            vetorInt_1[7] = 7;
            vetorInt_1[8] = 7;
            vetorInt_1[9] = 7;
            vetorInt_1[10] = 7;
            vetorInt_1[11] = 7;
            qtosElementosTemNoVetor = 12;
        }

        public void MontaVetor_2()
        {
            if (vetorInt_1[0] != 0)
                for (int indice = 0; indice <= qtosElementosTemNoVetor - 1; indice++)
                {
                    vetorInt_2[indice] = vetorInt_1[indice];
                }
        }

        public void AleatorizarVetor()
        {
            string NumRepetidos = "";
            MontaVetor_1();
            Random RandNum = new Random();
            for (int k = 0; k <= 11; k++)
            {
                MontaVetor_2();

                int Rnd = RandNum.Next(1, 7);
                if (PesquisaBinaria(Rnd))
                {
                    if (NumRepetidos.Contains(Rnd.ToString()))
                    {
                        k += -1;
                        Rnd = 0;
                    }
                    else vetorInt_1[k] = Rnd;
                    NumRepetidos += Rnd.ToString();
                }
                else vetorInt_1[k] = Rnd;
            }
        }

        public void OrdenaVetor()
        {
            int lento, rapido, aux;
            if (vetorInt_1[0] != 0)
                for (lento = 0; lento <= qtosElementosTemNoVetor - 1; lento++)
                {
                    for (rapido = lento + 1; rapido <= qtosElementosTemNoVetor - 1; rapido++)
                    {
                        if (vetorInt_2[lento] > vetorInt_2[rapido])
                        {
                            aux = vetorInt_2[lento];
                            vetorInt_2[lento] = vetorInt_2[rapido];
                            vetorInt_2[rapido] = aux;
                        }
                    }
                }
        }

        public bool PesquisaBinaria(int valor)
        {
            OrdenaVetor();
            int inicio, meio, fim;
            bool achou = false;
            inicio = 0;
            fim = qtosElementosTemNoVetor;
            if (vetorInt_1[0] != 0)
                do
                {
                    meio = (inicio + fim) / 2;
                    if (vetorInt_2[meio] > valor)
                    {
                        fim = meio - 1;
                    }
                    else
                    {
                        if (vetorInt_2[meio] < valor)
                        {
                            inicio = meio + 1;
                        }
                        else
                        {
                            achou = true;
                        }
                    }
                }
                while ((fim >= inicio) && !(achou));

            return achou;
        }
    }
}