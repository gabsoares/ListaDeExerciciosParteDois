int number = 1;

while (number != 0)
{
    Console.Write("Digite um número para verificar se o mesmo eh par ou impar: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0 && number != 0)
        Console.WriteLine($"O número digitado {number} eh par!");
    else if (number == 0)
        Console.WriteLine("A aplicação encerrará...");
    else
        Console.WriteLine($"O número digitado {number} eh impar");
}
