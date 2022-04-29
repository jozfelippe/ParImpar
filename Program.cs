int numeroDigitado;
Console.Write("Digite um número");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

bool numeroEhPar = (numeroDigitado % 2) == 0;

if(numeroEhPar)
{   
    Console.ForegroundColor =ConsoleColor.Blue;
    Console.WriteLine($"{numeroDigitado} é par"!);
}
else
{   
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine ($"{numeroDigitado} é ímpar");
}

Console.ResetColor();

