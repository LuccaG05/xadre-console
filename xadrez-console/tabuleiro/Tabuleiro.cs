
namespace tabuleiro
{
    class Tabuleiro
    {
        public int linhas {  get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        //como a Peca é privada, esse metodo permite pegar a peca
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        //operacao para colocar peca no tabuleiro
        public void colocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
    }
}
