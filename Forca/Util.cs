using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Forca
{
    internal class Util
    {
        public static char receberLetra()
        {
            char letra;

            //cria booleano para verificar se o caractere digitado é uma letra
            bool verificaLetra;

            //espera a entrada de uma letra
            do
            {
                Console.WriteLine("\nDigite uma letra:");
                char.TryParse(Console.ReadLine().ToUpper(), out letra);
                verificaLetra = char.IsLetter(letra);
            } while (!verificaLetra);

            return letra;
        }

        public static void verificarRepetidas( ref char[] letrasDigitadas, char letra, ref int indiceLetra, string palavraChave, ref char[] oculta, ref int acertos, ref int erros) {
            //verifica se a letra digitada já foi digitada anteriormente
            if (Array.IndexOf(letrasDigitadas, letra) == -1)
            {
                //se ainda não foi, guarda a letra no array de letras digitadas
                letrasDigitadas[indiceLetra] = letra;
                indiceLetra++;

                //verifica se a palavra chave contém a letra
                if (palavraChave.Contains(letra))
                {
                    //mostra a letra digitada na posição na palavra chave
                    for (int i = 0; i < palavraChave.Length; i++)
                    {
                        if (letra == palavraChave[i])
                        {
                            oculta[i] = palavraChave[i];
                            acertos++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"\nA letra '{letra}' não existe na palavra chave.");
                    erros++;
                    chances--;
                    Console.WriteLine("\nPressione ENTER para continuar.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("\nLetra já informada. Tente uma novamente...");
                Console.WriteLine("\nPressione ENTER para continuar.");
                Console.ReadKey();
            }
        }

        public static bool verificarErrosAcertos(int erros, int acertos, int chances, string palavraChave, ref bool continua)
        {
            //verifica se o número de acertos é o mesmo do tamanho da palavra
            //vitória
            if (acertos == palavraChave.Length)
            {
                Console.Clear();
                Console.WriteLine($"\nA palavra chave é: {palavraChave.ToUpper()}");
                Console.WriteLine("\nPARABÉNS! Você venceu!");
                continua = false;
                Console.WriteLine("\nFIM!");
                Console.ReadKey();
            }
            //verifica se o número de erros é igual ao número de chances
            //derrota
            else if (erros == 6)
            {
                throw new Exception();
            }

            return continua;
        }
    }
}
