using System;

namespace Ex90
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
        }

        static void Main(string[] args)
        {
            Vetor geradorDeVetor = new Vetor();

            Console.WriteLine("------------");
            Console.WriteLine("Vetor 1");
            double[] V1 = geradorDeVetor.CriarVetor(30);

            Console.WriteLine("insira um valor e direi quantas vezes ele aparece no vetor: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"O valor aparece {geradorDeVetor.CalcValorNoVetor(valor, V1)} vezes");
        }
    }
}
