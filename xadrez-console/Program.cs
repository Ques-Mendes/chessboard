using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;
using xadrez_console.tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro Tab = new Tabuleiro(8, 8);

            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new Posicao(0, 0));
            Tab.ColocarPeca(new Torre(Tab, Cor.Preta), new Posicao(1, 3));
            Tab.ColocarPeca(new Rei(Tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(Tab);

            Console.ReadLine();
        }
    }
}
