using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            bool veiculoAdicionado = false;

            while (!veiculoAdicionado)
            {
                Console.WriteLine("Digite a placa do veículo para estacionar:\n");
                string novoVeiculo = Console.ReadLine().ToString();
                if (!string.IsNullOrWhiteSpace(novoVeiculo))
                {
                    Console.Clear();
                    veiculos.Add(novoVeiculo);
                    veiculoAdicionado = true;
                    Console.WriteLine($"\nO veículo: {veiculos.Last()}, foi adicionado.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Por favor, informe caracteres válidos. Ex: A-z,0-9...\n");
                }
            }

        }

        public void RemoverVeiculo()
        {

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                int horas = 0;
                decimal valorTotal = 0;
                bool tempoDePermanenciaColetado = false;

                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal   
                decimal calcularValorPermanecia(decimal preçoInicial, decimal precoPorHora, int horas)
                {
                    return preçoInicial + (precoPorHora * horas);
                }

                // TODO: Remover a placa digitada da lista de veículos

                void BaixarVeiculoPorPlaca(string placa)
                {
                    bool placaRemovida = veiculos.Remove(placa);
                }

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
               
                
                    while (!tempoDePermanenciaColetado)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:\n" +
                        "Favor inserir apenas números inteiros positivos, sem casas decimais. Ex: 0, 1, 2, 3 ...\n");
                        int tempoPermanencia = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Por favor, informe caracteres válidos. Ex: A-z,0-9...\n");
                        if (tempoPermanencia > 0)
                        {
                            tempoPermanencia;

                        } else {

                        }

                        
                    }

                }

                // Pedir para o usuário digitar a placa e armazenar na variável placa
                // *IMPLEMENTE AQUI*
                string placa = null;

                Console.WriteLine("Digite a placa do veículo para remover:\n");
                placa = Console.ReadLine().ToString();
                if (!string.IsNullOrWhiteSpace(placa))
                {
                    Console.Clear();
                    TempoDePermanenciaVeiculo();

                    Console.WriteLine($"\nO veículo: {veiculos.Last()}, foi adicionado.\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Por favor, informe caracteres válidos. Ex: A-z,0-9...\n");
                }

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:\n");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                veiculos.ForEach((veiculo) =>
                {
                    Console.WriteLine($"- {veiculo}");
                });
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.\n");
            }
        }
    }
}
