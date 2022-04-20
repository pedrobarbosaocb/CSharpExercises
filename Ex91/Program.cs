using System;
using System.Collections.Generic;

namespace Ex91
{
    internal class Program
    {
        public class Vetor
        {
            double[] vetorRepository;

            public double[] CriarVetor(int tamanhoVetor)
            {
                double[] vetor = new double[tamanhoVetor];
                for (int i = 0; i < tamanhoVetor; i++)
                {
                    Console.WriteLine($"insira {i + 1} valor: ");
                    vetor[i] = double.Parse(Console.ReadLine());
                }
                return vetor;
            }

            public int CalcValorNoVetor(double valor, double[] vetor)
            {
                int qtdValorAparece = 0;
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] == valor)
                    {
                        qtdValorAparece++;
                    }
                }
                return qtdValorAparece;
            }

            public List<string> VerificarRepeticao(double[] vetor)
            {
                List<string> listaRepeticoes = new List<string>();

                string repeticao;

                for (int i = 0; i < vetor.Length; i++)
                {
                    for (int j = 0; j < vetor.Length; j++)
                    {
                        if (vetor[i] == vetor[j])
                        {
                            bool isInLista = false;
                            repeticao = $"Valor: {vetor[i]}; Posicao {i}";
                            foreach (string str in listaRepeticoes) {
                                if (str == repeticao)
                                {
                                    isInLista = true;
                                };
                            }
                            if (!isInLista)
                            {
                                listaRepeticoes.Add(repeticao);
                            }
                            
                        }
                    }
                }
                return listaRepeticoes;
            }
        }

        static void Main(string[] args)
        {
            Vetor geradorDeVetor = new Vetor();

            Console.WriteLine("------------");
            Console.WriteLine("Vetor");
            double[] V1 = geradorDeVetor.CriarVetor(50);

            List<string> listaRepeticoes = geradorDeVetor.VerificarRepeticao(V1);
            foreach (string str in listaRepeticoes)
            {
                Console.WriteLine(str);
            }
        }
    }
}
