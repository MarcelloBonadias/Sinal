int numeroDigitado;

Console.WriteLine("Digite um número, por favor");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

if (numeroDigitado == 0)
{
    Console.WriteLine ("Zero");
} 

 else if (numeroDigitado < 0 )
{
    Console.WriteLine("Negativo");
}

if (numeroDigitado > 0) 
{
    Console.WriteLine("Positivo");
}
