// Console.WriteLine("entre com um numero inteiro"); 
// int numero = int.Parse(Console.ReadLine());

// Console.WriteLine("entre com o segundo numero inteiro"); 
// int numero2 = int.Parse(Console.ReadLine());

// int soma = numero + numero2;
// Console.WriteLine("A soma dos numeros é: " + soma);

// int subtracao = numero - numero2;
// Console.WriteLine("A subtração dos numeros é: " + subtracao);

// int multiplicacao = numero * numero2;
// Console.WriteLine("A multiplicação dos numeros é: " + multiplicacao);

// int divisao = numero / numero2;
// Console.WriteLine("A divisão dos numeros 6: " + divisao);

// --atividade 2


// Console.WriteLine("Digite um número inteiro:");
// int num = int.Parse(Console.ReadLine());

// if (num % 2 == 0)
//     Console.WriteLine("O número é par");
// else
//     Console.WriteLine("O número é ímpar");

 
// Console.WriteLine("Digite o primeiro número:");
// int a = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o segundo número:");
// int b = int.Parse(Console.ReadLine());

// if (a > b)
//     Console.WriteLine("O maior número é: " + a);
// else if (b > a)
//     Console.WriteLine("O maior número é: " + b);
// else
//     Console.WriteLine("Os números são iguais");


// Console.WriteLine("Digite a nota do aluno:");
// double nota = double.Parse(Console.ReadLine());

// if (nota >= 7)
//     Console.WriteLine("O aluno está aprovado");
// else if (nota >= 5)
//     Console.WriteLine("O aluno está em recuperação");
// else
//     Console.WriteLine("O aluno está reprovado");


// Console.WriteLine("Digite a idade:");
// int idade = int.Parse(Console.ReadLine());

// if (idade < 18)
//     Console.WriteLine("Menor de idade");
// else if (idade < 60)
//     Console.WriteLine("Adulto");
// else
//     Console.WriteLine("Idoso");


// Console.WriteLine("Digite um número:");
// int n = int.Parse(Console.ReadLine());

// if (n > 0)
//     Console.WriteLine("Positivo");
// else if (n < 0)
//     Console.WriteLine("Negativo");
// else
//     Console.WriteLine("Zero");

// >>>>>>>>>ATIVIDde3
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine(i);
// }


// >>>>>>>>>ATIVIDde3.2
// for (int i = 1; i <= 50; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.WriteLine(i);
//     }
// }


// >>>>>>>>>ATIVIDde3.2
// Console.WriteLine("Digite um número:");
// int numero = int.Parse(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     int resultado = numero * i;
//     Console.WriteLine(numero + " x " + i + " = " + resultado);
// }

// >>>>>>>>>ATIVIDde3.3
// int soma = 0;

// Console.WriteLine("Digite um número (0 para sair):");
// int numero = int.Parse(Console.ReadLine());

// while (numero != 0)
// {
//     soma = soma + numero;

//     Console.WriteLine("Digite um número (0 para sair):");
//     numero = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Soma dos números: " + soma);

// >>>>>>>>>ATIVIDde3.4
// int positivos = 0;

// for (int i = 1; i <= 5; i++)
// {
//     Console.WriteLine("Digite um número:");
//     int numero = int.Parse(Console.ReadLine());

//     if (numero > 0)
//     {
//         positivos++;
//     }
// }

// Console.WriteLine("Quantidade de números positivos: " + positivos);



// >>>>>>>>>>>>>> ATIVIDADE4
// Console.WriteLine("Escolha uma opção:");
// Console.WriteLine("1 - Somar");
// Console.WriteLine("2 - Subtrair");
// Console.WriteLine("3 - Multiplicar");
// Console.WriteLine("4 - Dividir");

// int opcao = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o primeiro número inteiro:");
// int numero1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Digite o segundo número inteiro:");
// int numero2 = int.Parse(Console.ReadLine());

// switch (opcao)
// {
//     case 1:
//         int soma = numero1 + numero2;
//         Console.WriteLine("A soma é: " + soma);
//         break;

//     case 2:
//         int subtracao = numero1 - numero2;
//         Console.WriteLine("A subtração é: " + subtracao);
//         break;

//     case 3:
//         int multiplicacao = numero1 * numero2;
//         Console.WriteLine("A multiplicação é: " + multiplicacao);
//         break;

//     case 4:
//         int divisao = numero1 / numero2;
//         Console.WriteLine("A divisão é: " + divisao);
//         break;

//     default:
//         Console.WriteLine("Opção inválida!");
//         break;
// }




// >>>>>>>>>>>ATIVIDADE4.2

// Console.WriteLine("Digite um número de 1 a 7:");
// int dia = int.Parse(Console.ReadLine());

// switch (dia)
// {
//     case 1:
//         Console.WriteLine("Domingo");
//         break;
//     case 2:
//         Console.WriteLine("Segunda-feira");
//         break;
//     case 3:
//         Console.WriteLine("Terça-feira");
//         break;
//     case 4:
//         Console.WriteLine("Quarta-feira");
//         break;
//     case 5:
//         Console.WriteLine("Quinta-feira");
//         break;
//     case 6:
//         Console.WriteLine("Sexta-feira");
//         break;
//     case 7:
//         Console.WriteLine("Sábado");
//         break;
//     default:
//         Console.WriteLine("Número inválido");
//         break;
// }



// >>>>>>>>>>>>>>>>>>ATIVIDADE4.3
// Console.WriteLine("Digite o código do produto:");
// int codigo = int.Parse(Console.ReadLine());

// switch (codigo)
// {
//     case 1:
//         Console.WriteLine("Categoria: Alimento");
//         break;
//     case 2:
//         Console.WriteLine("Categoria: Bebida");
//         break;
//     case 3:
//         Console.WriteLine("Categoria: Limpeza");
//         break;
//     default:
//         Console.WriteLine("Código inválido");
//         break;
// }


// >>>>>>>>>>>ATIVIDADE5
// int soma = 0;
// int maior = 0;

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine("Digite um número:");
//     int numero = int.Parse(Console.ReadLine());

//     soma = soma + numero;

//     if (i == 1 || numero > maior)
//     {
//         maior = numero;
//     }
// }

// double media = soma / 10.0;

// Console.WriteLine("Soma: " + soma);
// Console.WriteLine("Média: " + media);
// Console.WriteLine("Maior número: " + maior);


// >>>>>>>>>>>ATIVIDADE5.2

// int somaIdades = 0;
// int contador = 0;

// Console.WriteLine("Digite uma idade (negativo para sair):");
// int idade = int.Parse(Console.ReadLine());

// while (idade >= 0)
// {
//     somaIdades = somaIdades + idade;
//     contador++;

//     Console.WriteLine("Digite uma idade (negativo para sair):");
//     idade = int.Parse(Console.ReadLine());
// }

// if (contador > 0)
// {
//     double mediaIdades = somaIdades / (double)contador;
//     Console.WriteLine("Média das idades: " + mediaIdades);
// }
// else
// {
//     Console.WriteLine("Nenhuma idade válida foi digitada");
// }


// >>>>>>>>>>>ATIVIDADE5.3
// int pares = 0;
// int impares = 0;

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine("Digite um número:");
//     int numero = int.Parse(Console.ReadLine());

//     if (numero % 2 == 0)
//     {
//         pares++;
//     }
//     else
//     {
//         impares++;
//     }
// }

// Console.WriteLine("Pares: " + pares);
// Console.WriteLine("Ímpares: " + impares);


// >>>>>>>>>>>ATIVIDADE6
Console.WriteLine("Digite um número:");
int numero = int.Parse(Console.ReadLine());

int divisores = 0;

for (int i = 1; i <= numero; i++)
{
    if (numero % i == 0)
    {
        divisores++;
    }
}

if (divisores == 2)
{
    Console.WriteLine("Número primo");
}
else
{
    Console.WriteLine("Não é primo");
}
