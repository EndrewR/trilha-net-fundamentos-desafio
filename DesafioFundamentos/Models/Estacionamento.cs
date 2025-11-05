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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            // Implementado
            veiculos.Add(Console.ReadLine().ToUpper());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = "";
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // Implementado
            placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            /* 
                Problema: Se o usuário digitar, em maiusculo,
                uma placa que está listada em caracteres minusculos,
                a verificação é aceita e remove uma placa não existente,
                enquanto a placa listada em minusculo continua listada

                Modificação: .ToUpper() adicionado ao ler os inputs
                e removido da verificação devido a redundância
            */
            if (veiculos.Any(x => x.ToUpper() == placa/*.ToUpper()*/))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                int horas = 0;
                decimal valorTotal = 0;

                //Implementado
                horas = Convert.ToInt32(Console.ReadLine());
                valorTotal = precoInicial + precoPorHora * horas;

                //Implementado
                veiculos.Remove(placa);

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
                Console.WriteLine("Os veículos estacionados são:");

                // Implementado
                foreach (string item in veiculos)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
