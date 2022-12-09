namespace Forca
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            //cria array de palavras chave
            string[] arrayPalavraChave = { "nanotecnologo" , "escaravelho" , "ampulheta" , "bergamota"};
            //cria array de temas de acordo com as palavras chave
            string[] arrayTema = { "profissão" , "animal" , "objeto" , "fruta"};

            //cria um número aleatório
            Random aleatorio = new Random();
            //cria um inteiro de índice e armazena um número aleatório nele de acordo com o
            //tamanho do array de palavras chave
            int indice = aleatorio.Next(arrayPalavraChave.Length);

            //cria e atribui uma palavra chave aleatória à variável
            string palavraChave = arrayPalavraChave[indice].ToUpper();
            //cria e atribui um tema de acordo com a palavra chave escolhida
            string tema = arrayTema[indice];

            //cria um array de char com a palavra oculta
            char[] oculta = new char[palavraChave.Length];

            //cria as variáveis que serão usadas para controlar o jogo
            int acertos = 0;
            int erros = 0;
            int chances = 6;

            //cria um booleano de continuação
            bool continua = true;

            //coloca '_' (underlines) no array de char 'oculta'
            for (int i = 0; i < palavraChave.Length; i++)
            {
                oculta[i] = '_';
            }

            //cria a variável para controle das letras que serão digitadas
            int indiceLetra = 0;
            //cria array das letras que serão digitadas
            char[] letrasDigitadas = new char[26];

            //estrutura de repetição principal do jogo
            while ((erros < chances) && continua)
            {
                View.imprimirDesenhoForca();

                //imprime infos do grupo
                Console.WriteLine("Grupo 7 - Bruno, Sylmara e Eder\n");

                //imprime o desenho do enforcado de acordo com o numero de erros
                View.imprimirEnforcado(erros);

                //imprime quantidade de erros e chances disponíveis
                Console.WriteLine($"\nATENÇÃO -> {erros} erros cometidos - {chances} chances disponíveis \n\n");
                
                //imprime o número de letras a serem acertadas e o tema em que a palavra se refere
                Console.WriteLine($"\n\nSua palavra possui {palavraChave.Length} letras e o tema é {tema.ToUpper()}\n");

                //imprime a palavra com traços
                Console.WriteLine(oculta);

                //organiza array de letras digitadas em ordem alfabética
                Array.Sort(letrasDigitadas);

                //imprime letras digitadas
                View.imprimirLetrasDigitadas(letrasDigitadas);

                Console.WriteLine();

                //cria variável para armazenar a letra que será digitada
                char letra = Util.receberLetra();

                Util.verificarRepetidas(ref letrasDigitadas, letra, ref indiceLetra, palavraChave, ref oculta, ref acertos, ref erros);

                try
                {
                    Util.verificarErrosAcertos(erros, acertos, chances, palavraChave, ref continua);
                } catch
                {
                    Console.Clear();
                    View.imprimirEnforcado(erros);
                    Console.WriteLine("\nDEU FORCA... Você perdeu.\n");
                    Console.WriteLine($"\nA palavra chave era {palavraChave.ToUpper()}\n");
                    Console.WriteLine("\nFIM!");
                    Console.ReadKey();
                }
                

                Console.Clear();
            }
        }
    }
}
