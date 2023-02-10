using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez_console.tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(cor, tabuleiro)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
