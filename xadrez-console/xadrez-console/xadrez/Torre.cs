﻿using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
        }

        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] matriz = new bool[tab.linhas, tab.colunas];

            Posicao pos = new Posicao(0, 0);

            //verfica se pode mover para norte
            pos.definirValores(posicao.linha - 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                matriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }

                pos.linha = pos.linha - 1;
            }

            //verfica se pode mover para leste
            pos.definirValores(posicao.linha, posicao.coluna + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                matriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }

                pos.coluna = pos.coluna + 1;
            }

                //verfica se pode mover para sul
                pos.definirValores(posicao.linha + 1, posicao.coluna);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                matriz[pos.linha, pos.coluna] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }

                pos.linha = pos.linha + 1;
            }

                    //verfica se pode mover para oeste
                    pos.definirValores(posicao.linha, posicao.coluna - 1);
                    while (tab.posicaoValida(pos) && podeMover(pos))
                    {
                        matriz[pos.linha, pos.coluna] = true;
                        if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                        {
                            break;
                        }

                        pos.coluna = pos.coluna - 1;
                    }

                    return matriz;
                }
            }
        }