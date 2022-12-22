namespace RefOutComCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Ref
            int a = 5;

            Calculadora.TriplicarRef(ref a);
            Console.WriteLine(a);

            // Out
            int b = 10;
            int TriplicarOut;

            CalculadoraOut.TriplicarOut(b, out TriplicarOut);
            Console.WriteLine(TriplicarOut);
        }
    }
}