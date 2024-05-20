namespace BennerTest
{
    public class Network
    {
        private int[] raiz;
        private int[] classificacao;

        public Network(int numeroElementos)
        {
           // Os números devem ser positivos e maiores que 0
            if (numeroElementos <= 0)
                throw new ArgumentException("O número de elementos deve ser um inteiro positivo.");

            // Inicializa os vetores 'raiz' e 'classificacao' com o tamanho do número de elementos
            raiz = new int[numeroElementos]; 
            classificacao = new int[numeroElementos];

            // Para cada elemento, é definido a raiz como o próprio elemento (inicialmente cada elemento é seu próprio conjunto)
            // e inicializa a classificação com 0
            for (int i = 0; i < numeroElementos; i++)
            {
                raiz[i] = i;
                classificacao[i] = 0; // No início, a classificação de todos os elementos é 0, pois cada elemento é um conjunto individual
            }
        }

        private int Find(int elemento)
        {
            // Método que encontra a raiz do elemento informado no parametro, caso esse elemento não for raiz,
            // irá ser feito a busca de compactação de caminho

            if (raiz[elemento] != elemento)
                raiz[elemento] = Find(raiz[elemento]);  // Compactação de caminho
            return raiz[elemento];
        }

        private void Union(int elemento1, int elemento2)
        {
            // Método que agrupa os elementos das raizes X e Y e os une em uma raiz única utilizando as classificações

            int raizX = Find(elemento1); 
            int raizY = Find(elemento2);

            if (raizX != raizY)
            {
                // Faz o agrupamento pela classificação
                if (classificacao[raizX] > classificacao[raizY])
                {
                    raiz[raizY] = raizX;
                }
                else if (classificacao[raizX] < classificacao[raizY])
                {

                    raiz[raizX] = raizY;
                }
                else
                {
                    raiz[raizY] = raizX; 
                    classificacao[raizX]++;
                }
            }
        }

        public void Connect(int elemento1, int elemento2)
        {
            // Método que determina as conexões diretas dos 2 elementos

            // Ajusta os índices para serem baseados em zero
            elemento1 = elemento1 - 1;
            elemento2 = elemento2 - 1;

            // Verifica se o elemento está fora do intervalo
            if (elemento1 < 0 || elemento1 >= raiz.Length || elemento2 < 0 || elemento2 >= raiz.Length)
                throw new ArgumentException("Os elementos devem estar em um intervalo válido. ");

            Union(elemento1, elemento2);
        }

        public bool Query(int elemento1, int elemento2)
        {
            // Método que testa ambas as conexões diretas ou indiretas

            elemento1 = elemento1 - 1; 
            elemento2 = elemento2 - 1;

            // Verifica se o elemento está fora do intervalo
            if (elemento1 < 0 || elemento1 >= raiz.Length || elemento2 < 0 || elemento2 >= raiz.Length)
                throw new ArgumentException("Os elementos devem estar em um intervalo válido. ");

            return Find(elemento1) == Find(elemento2);
        }
    }
}

