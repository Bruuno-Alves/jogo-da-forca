using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca
{
    internal class View
    {

        

        public static void imprimirDesenhoForca()
        {
            //cria array com as partes do desenho do nome do jogo
            string[] desenhoJogoDaForca = { "\r\n" +
                    "       _                         _         ______                  \r\n" +
                    "      | |                       | |       |  ____|                 \r\n" +
                    "      | | ___   __ _  ___     __| | __ _  | |__ ___  _ __ ___ __ _ \r\n" +
                    "  _   | |/ _ \\ / _` |/ _ \\   / _` |/ _` | |  __/ _ \\| '__/ __/ _` |\r\n" +
                    " | |__| | (_) | (_| | (_) | | (_| | (_| | | | | (_) | | | (_| (_| |\r\n" +
                    "  \\____/ \\___/ \\__, |\\___/   \\__,_|\\__,_| |_|  \\___/|_|  \\___\\__,_|\r\n" +
                    "                __/ |                                              \r\n" +
                    "               |___/                                               \r\n"
        };

            //imprime o desenho do nome do jogo
            foreach (string parte in desenhoJogoDaForca)
            {
                Console.WriteLine(parte);
            }
        }

        public static void imprimirEnforcado(int erros)
        {
            //cria array com as partes do desenho do enforcado
            string[] desenhoEnforcado = { "  +---+\r\n  |   |\r\n      |\r\n      |\r\n      |\r\n      |",
            "  +---+\r\n  |   |\r\n  O   |\r\n      |\r\n      |\r\n      |",
            "  +---+\r\n  |   |\r\n  O   |\r\n  |   |\r\n      |\r\n      |",
            "  +---+\r\n  |   |\r\n  O   |\r\n /|   |\r\n      |\r\n      |",
            "  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n      |\r\n      |",
            "  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n /    |\r\n      |",
            "  +---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |"
            };

            //imprime o desenho do enforcado de acordo com o numero de erros
            Console.WriteLine(desenhoEnforcado[erros]);
        }

        public static void imprimirLetrasDigitadas(char[] letras)
        {
            //imprime letras digitadas
            Console.WriteLine("\nLetras digitadas:\n");
            foreach (char letraDigitada in letras)
            {
                if (letraDigitada != 0)
                {
                    Console.Write($"{letraDigitada} ");
                }
            }
        }
    }
}
