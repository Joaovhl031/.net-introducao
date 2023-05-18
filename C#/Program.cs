using ExemplosAritmeticos.models;

Calculadora calc = new Calculadora();

Console.WriteLine("Aritméticos");
Console.WriteLine("Aritméticos");
calc.Somar(10, 10);
calc.Subtrair(10, 5);
calc.Multiplicar(10, 2);
calc.Dividir(10, 2);
calc.Potencia(3, 3);

Console.WriteLine("Trigonometricos");
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);

Console.WriteLine("laços de repetição");
Console.WriteLine("For");
int numero = 2;
for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}

Console.WriteLine("while");
int num = 5;
int conta = 1;
while(conta <= 10)
{
    Console.WriteLine($"{conta}° Execução: {num} X {conta} = {num * conta}");
    conta++; 
    if(conta == 9) 
    {
        break;
    }
}


int soma = 0, number = 0;

do{
    Console.WriteLine("Digite um numero (0 para parar)");
    number = Convert.ToInt32(Console.ReadLine());

    soma += number;
} while (number != 0);

Console.WriteLine($"Total da soma dos numeros digitador é:{soma}");



Console.WriteLine("Arrey");

int[] arreyInteiros = new int [4];
arreyInteiros[0] = 18;
arreyInteiros[1] = 38;
arreyInteiros[2] = 23;
arreyInteiros[3] = 90;

Console.WriteLine("Percorrendo o arrey com FOR");
for(int i = 0 ;i > arreyInteiros.Length; i++)
{
    Console.WriteLine($"Posicao N°{i} - {arreyInteiros[i]}");
}

Console.WriteLine("Percorrendo o arrey com FOREACH");

foreach(int valor in arreyInteiros)
{
    Console.WriteLine($"Posicao do arrey {valor}°");
}