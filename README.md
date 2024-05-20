<h1>Benner Test</h1>
Este projeto implementa uma estrutura de dados para gerenciar a conectividade entre um conjunto de elementos, utilizando a técnica de União-Busca (Union-Find). A estrutura permite criar conexões entre elementos e verificar se dois elementos estão direta ou indiretamente conectados.
<h1>Como executar</h1>
<p>
1. Clone o repositório com  git clone https://github.com/GustavoCabralDeola/BennerTest.git <br>
2. Execute o código <br>
3. Informe os número de elementos <br>
4. Informe as conexões nesta formatação: 1,2 e pressione enter. Após finalizar de digitar as conexões, deixe uma linha em branco <br>
5. E por fim digite as conexões que deseja testar <br>
<br>
No final irá ser listado no console as conexões testadas e irá retornar true caso as conexões estiver interligadas e false caso não.
</p>

<h1>Union-Find</h1>
<h3>Explicação Teórica</h3>
O Union-Find é uma estrutura de dados também conhecida como disjoin-set union, em que consiste em gerenciar e agrupar elementos em raizes, utilizando operações eficientes para unir elementos e encontrar o representante (raiz) de cada conjunto. <br>
Nesta estrutura são utilizadas duas técnicas, o Find e o Union:
<h4>Find</h4>
Método utilizado para encontrar a raiz do elemento, qual é a origem deste elemento. Em situações onde a raiz de um elemento não é diretamente conhecida, utiliza-se a compactação de caminho (path compression). Esta técnica consiste em fazer uma busca profunda para encontrar a raiz e, ao mesmo tempo, encurtar o caminho dos elementos ao conectá-los diretamente à raiz, tornando futuras operações mais eficientes.
<h4>Union</h4>
O método Union utiliza o Find para buscar a raiz do elemento x e do elemento y, e faz um agrupamento delas por meio da união por classificação, essa união consiste em comparar o tamanho das raizes x e y,
a raiz que tiver o menor tamanho será conectada com a raiz de maior tamanho. Caso o tamanho for igual, é criado uma nova raiz e incrementado + 1 em seu tamanho.


<h1>Explicação Técnica</h1>
<h3>Inicialização</h3>
O construtor Network inicializa os vetores raiz e classificacao para representar a estrutura de union-find. Cada elemento é inicialmente seu próprio representante, e a classificação de todos os elementos é zero.
<h3>Union-Find</h3>
Find: Utiliza compressão de caminho para otimizar a busca da raiz de um elemento. <br>
Union: Utiliza união por classificação para unir dois conjuntos.
<h3>Métodos</h3>
Connect: Conecta dois elementos diretamente, ajustando índices baseados em 1 para índices baseados em 0.
Query: Verifica se dois elementos estão conectados, direta ou indiretamente, ajustando os índices baseados em 1 para índices baseados em 0.
<br>
<br>
