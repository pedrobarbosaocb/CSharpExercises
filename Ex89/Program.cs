using System;

namespace Ex89
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

            public int VerificarRepeticao(double[] vetorA, double[] vetorB )
            {
                int nRepeticoes = 0;
                for (int i = 0; i < vetorA.Length; i++)
                {
                    if  (vetorA[i] == vetorB[i])
                    {
                        nRepeticoes++;
                    }
                }
                return nRepeticoes;
            }
        }

        static void Main(string[] args)
        {
            Vetor geradorDeVetor = new Vetor();

            Console.WriteLine("------------");
            Console.WriteLine("Vetor 1");
            double[] V1 = geradorDeVetor.CriarVetor(15);

            Console.Clear();
            Console.WriteLine("------------");
            Console.WriteLine("Vetor 2");
            double[] V2 = geradorDeVetor.CriarVetor(15);

            Console.Clear();
            Console.WriteLine($"Há {geradorDeVetor.VerificarRepeticao(V1,V2)} valores na mesma posição");

        }
    }
}
