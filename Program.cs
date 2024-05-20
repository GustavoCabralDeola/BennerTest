namespace BennerTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de elementos: ");
            int quantidadeElementos = int.Parse(Console.ReadLine());

            Network network = new Network(quantidadeElementos);


            Console.WriteLine("Informe as conexões (formato: 1,2) e pressione Enter. Deixe uma linha em branco para terminar:");
            while (true)
            {
                string conexaoInformada = Console.ReadLine(); 
                if (string.IsNullOrWhiteSpace(conexaoInformada)) // Caso o usuário deixar uma linha em branco, para a execução
                    break;

                // Separa os 2 elementos informados e monta a conexão
                string[] partes = conexaoInformada.Split(','); 
                int elemento1 = int.Parse(partes[0]);
                int elemento2 = int.Parse(partes[1]);

                network.Connect(elemento1, elemento2);
            }

            List<string> resultados = new List<string>();

            Console.WriteLine("Agora informe as conexões que você deseja testar, (formato: 1,2) e pressione Enter. Deixe uma linha em branco para terminar:");
            while (true)
            {
                string conexaoInformada = Console.ReadLine(); 
                if (string.IsNullOrWhiteSpace(conexaoInformada)) // Caso o usuário deixar uma linha em branco, para a execução
                    break;

                // Separa os 2 elementos informados e faz o teste
                string[] partesTeste = conexaoInformada.Split(',');
                int elemento1 = int.Parse(partesTeste[0]);
                int elemento2 = int.Parse(partesTeste[1]);

                bool resultadoConexao = network.Query(elemento1, elemento2);
                resultados.Add($"Conexão ({elemento1},{elemento2}): {resultadoConexao}"); // O resultado é armazenado em uma lista 
            }

            // É listado todos as conexões testadas e seus resultados (True/False)
            Console.WriteLine("Resultados dos testes:");
            foreach (string resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
        }
    }
}