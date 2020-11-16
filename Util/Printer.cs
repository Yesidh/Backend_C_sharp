using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '+'));
        }
        
        public static void WriteTitle (string titulo)
        {
            var tamanho = titulo.Length + 4;
            DibujarLinea(tamanho);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamanho);
        }
    }
}