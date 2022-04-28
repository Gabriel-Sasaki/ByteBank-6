using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(1, 5, 78);

            int idadeSoma = 0;

            for(int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
            }

            Console.ReadLine();
        }

        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668),
                new ContaCorrente(874, 7781438)
            };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice}: {contaAtual.Numero}");
            }
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668)
            };

            lista.AdicionarVarios(contas);


            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i}: {itemAtual.Numero} / {itemAtual.Agencia}");
            }
        }

        static void TestaArrayInt()
        {
            // Criando um array de inteiros, com 5 posições
            int[] idades = null;
            idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            idades[5] = 60;

            int soma = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];

                Console.WriteLine($"Acessando o array idades no índice {i}");
                Console.WriteLine($"Valor de idades[{i}] = {idade}");

                soma += idade;
            }

            int media = soma / idades.Length;

            Console.WriteLine($"Média das Idades: {media}");
        }
    }
}
