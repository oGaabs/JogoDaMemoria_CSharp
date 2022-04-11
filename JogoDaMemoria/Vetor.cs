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
        { 
            qtosElementosTemNoVetor = n; 
        }

        public int GetQtosElementosTemNoVetor()
        { 
            return qtosElementosTemNoVetor; 
        }

        public void SetLimiteLogico(int l)
        { 
            limiteLogico = l; 
        }

        public int GetLimiteLogico()
        { 
            return limiteLogico; 
        }

        // MÉTODOS FUNCIONAIS
        public bool EstaCheio()
        { 
            return qtosElementosTemNoVetor == limiteLogico; 
        }

        public bool EstaVazio()
        { 
            return qtosElementosTemNoVetor == 0; 
        }

        public int ExibeDadosDoVetor(int p)
        {
            int dados = vetorInt_1[p];

            return dados;
        }

        private void ResetarVetor()
        {
            for (int i = 0; i < limiteLogico; i++)
            {
                vetorInt_1[i] = 7;
            }
            qtosElementosTemNoVetor = 12;
        }

        public void AleatorizarPares()
        {
            string NumRepetidos = "";
            ResetarVetor();
            Random RandNum = new Random();
            for (int index = 0; index <= 11; index++)
            {
                int randomNumber = RandNum.Next(1, 7);
                if (PesquisaBinaria(randomNumber))
                {
                    if (NumRepetidos.Contains(randomNumber.ToString()))
                    {
                        index--;
                    }
                    else 
                    {
                        vetorInt_1[index] = randomNumber;
                        NumRepetidos += randomNumber.ToString();
                    } 
                }
                else vetorInt_1[index] = randomNumber;
            }
        }

        public bool PesquisaBinaria(int valor)
        {
            CopiarVetor_ParaOutro();
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

        private void OrdenaVetor()
        {
            int lento, rapido, aux;
            if (vetorInt_1[0] == 0) return;

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

        private void CopiarVetor_ParaOutro()
        {
            if (vetorInt_1[0] == 0) return;

            for (int indice = 0; indice <= qtosElementosTemNoVetor - 1; indice++)
            {
                vetorInt_2[indice] = vetorInt_1[indice];
            }
        }
    }
}