int option = 1;

while (option != 0)
{
    Console.Write("Digite um número para verificar se o mesmo eh par ou impar: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
        Console.WriteLine($"O número digitado {number} eh par!");
    else
        Console.WriteLine($"O número digitado {number} eh impar!");

    Console.Write("Digite 0 caso queira sair e 1 para continuar verificando: ");
    option = Convert.ToInt32(Console.ReadLine());
}
