using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace NOVA_AVENIDA
{
    class Program
    {
        static void Main(string[] args)
        {
            //N = NORTE SUL
            //M = LESTE OESTE
            int N, M, i;
           
            FileStream arq = new FileStream("ENTRADA.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq);
            string leitura = ler.ReadToEnd();
            string[] quebra = leitura.Split(' ', ',', '.', '\n');
            M = Convert.ToInt32(quebra[0]);
            N = Convert.ToInt32(quebra[1]);
            int[,] matriz = new int[M, N];
            int p = 2;
            for (int w = 0; w < M; w++)
            {
                for (int c = 0; c < N; c++)
                {
                    matriz[w, c] = Convert.ToInt32(quebra[p]);
                    p++;

                }
            }
            int soma = 0;
            int j;
            int[] vetor = new int[N];

            //N = NORTE SUL
            //M = LESTE OESTE
            //M = Convert.ToInt32(quebra[0]);
            //N = Convert.ToInt32(quebra[1]);
            //3 4\n5 3 12\n4 5 4\n7 2 5\n1 10 5
            for (i = 0; i < M; i++)
            {                
                for (j = 0; j < M; j++)
                {
                    soma += matriz[j, i];
                    if (j == M-1)
                    {
                        vetor[i] = soma;
                        soma = 0;
                    }
                }
            }
            int teste = vetor[0];
            for (int r = 0; r< M; r++)
            {
                if (vetor[r] < teste)
                {
                    teste = vetor[r];
                }
            }

            FileStream esc = new FileStream("SAIDA.txt", FileMode.Create);
            StreamWriter escreve = new StreamWriter(esc);
            escreve.Write(teste);
            escreve.Close();
            Console.ReadKey();
        }

    }
}

