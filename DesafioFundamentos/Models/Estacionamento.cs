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
            // Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // Implementado!
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
                    Console.WriteLine("Por favor, informe caracteres válidos. Ex: A-z,0-9...\n");
                }
            }

        }

        public void RemoverVeiculo()

        {
            if (ContarVeiculos() > 0)
            {
                BaixarVeiculo();
            }
            else
            {
                Console.WriteLine($"Não existem veículos cadastrados, por favor, cadastre um veículo antes de tentar remover.\n");
            }

            int ContarVeiculos()
            {
                return Convert.ToInt32(veiculos.Count());
            }

            // TODO: Remover a placa digitada da lista de veículos
            bool BaixarVeiculoPorPlaca(string placa)
            {
                return veiculos.Remove(placa);
            }

            // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal   
            decimal calcularValorPermanecia(decimal preçoInicial, decimal precoPorHora, int horas)
            {
                return preçoInicial + (precoPorHora * horas);
            }

            void BaixarVeiculo()
            {
                // Pedir para o usuário digitar a placa e armazenar na variável placa
                // Implementado!
                Console.WriteLine("Digite a placa do veículo para remover:\n");
                string placa = Console.ReadLine().ToString();

                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
                {
                    // Remover a placa digitada da lista de veículos.
                    // Implementado!
                    if (BaixarVeiculoPorPlaca(placa))
                    {

                        bool tempoDePermanenciaColetado = false;
                        int horas;

                        while (!tempoDePermanenciaColetado)
                        {
                            Console.Clear();
                            //Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado.
                            // Implementado!
                            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:\n" +
                            "Por favor, insira apenas números inteiros positivos, sem casas decimais. Ex: 1, 2, 3 ...\n");
                            horas = Convert.ToInt32(Console.ReadLine());
                            if (horas > 0)
                            {
                                tempoDePermanenciaColetado = true;
                                // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                                // Implementado!
                                decimal valorTotal = calcularValorPermanecia(precoInicial, precoPorHora, horas);
                                Console.Clear();
                                Console.WriteLine($"\nO veículo: {placa}, foi removido e e o preço total foi de: R$ {valorTotal}.\n");
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Por favor, insira apenas números inteiros positivos, sem casas decimais. Ex: 1, 2, 3 ...\n");
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"\nOcorreu um erro ao remover o veículo: {placa}, verifique se o veículo já foi removido ou tente novamente.\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"A placa: {placa} não foi encontrada. Por favor, informe uma placa válida.\n");
                    RemoverVeiculo();
                }

            }

        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.Clear();
                Console.WriteLine("Os veículos estacionados são:\n");
                // Realizar um laço de repetição, exibindo os veículos estacionados
                // Implementado!
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
