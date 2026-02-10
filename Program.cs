Console.WriteLine("entre com um numero inteiro"); 
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("entre com o segundo numero inteiro"); 
int numero2 = int.Parse(Console.ReadLine());

int soma = numero + numero2;
Console.WriteLine("A soma dos numeros é: " + soma);

int subtracao = numero - numero2;
Console.WriteLine("A subtração dos numeros é: " + subtracao);

int multiplicacao = numero * numero2;
Console.WriteLine("A multiplicação dos numeros é: " + multiplicacao);

int divisao = numero / numero2;
Console.WriteLine("A divisão dos numeros 6: " + divisao);

  
// >>>>>>>>>>>>ATIVIDADE 1.2

Console.WriteLine("entre com um numero");
int numero = int.Parse(Console.ReadLine());

int dobro = numero * 2;
Console.WriteLine(" O dobro do numero é " + dobro);

int triplo = numero * 3 ;
Console.WriteLine(" o triplo do numero é " + triplo);


// >>>>>>>>>>>>>ATIVIDADE 1.3
Console.WriteLine("Entre com um nome:");
string nome = Console.ReadLine();

string saudacao = "Boas-vindas, " + nome;
Console.WriteLine(saudacao);


// >>>>>>>>>>>>>ATIVIDADE 1.4
Console.WriteLine("fale a sua idade");
int idade = int.Parse (Console.ReadLine());

int futuro = idade + 10;
Console.WriteLine (" Daqui 10 anos voce tera: " + futuro);


//>>>>>>>>>>>>>>>> ATIVIDADE 2

Console.WriteLine("Digite um número inteiro: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0){
    Console.WriteLine("O número é par! ");
}
else{
    Console.WriteLine("O número é ímpar!");
}


// >>>>>>>>>>>>>>>> ATIVIDADE 2.1
 
Console.WriteLine("Digite o primeiro número:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
    Console.WriteLine("O maior número é: " + num1);
else if (num2 > num1)
    Console.WriteLine("O maior número é: " + num2);
else
    Console.WriteLine("Os números são iguais");


// ->>>>>>>>>>>>>>>>ATIVIDADE 2.2

Console.WriteLine("Digite a nota do aluno:");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
    Console.WriteLine("O aluno está aprovado");
else if (nota >= 5)
    Console.WriteLine("O aluno está em recuperação");
else
    Console.WriteLine("O aluno está reprovado");

// >>>>>>>>>>>>>>>>ATIVIDADE 2.3

Console.WriteLine("Digite a idade:");
int idade = int.Parse(Console.ReadLine());

if (idade < 18)
    Console.WriteLine("Menor de idade");
else if (idade < 60)
    Console.WriteLine("Adulto");
else
    Console.WriteLine("Idoso");

//>>>>>>>>>>>>> ATIVIDADE 2.4

Console.WriteLine("Digite um número:");
int n = int.Parse(Console.ReadLine());

if (n > 0)
    Console.WriteLine("Positivo");
else if (n < 0)
    Console.WriteLine("Negativo");
else
    Console.WriteLine("Zero");


//>>>>>>>>>>>>>>>>ATIVIDADE 3
  
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}