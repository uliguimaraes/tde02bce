
Console.Write("Digite o primeiro número: ");
double numero_1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double numero_2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"A soma dos numeros {numero_1} e {numero_2} é igual a {numero_1 + numero_2}");

double sub_nums = numero_1 - numero_2;

Console.WriteLine("A subtração dos números " + numero_1 + " e " + numero_2 + " é igual a " + sub_nums);

double multiplicacao = numero_1 * numero_2;

string mensagem = string.Format("A multiplicação dos números {0} e {1} é igual a {2}", numero_1, numero_2, multiplicacao);

Console.WriteLine(mensagem);

double divisao = numero_1 / numero_2;

Console.WriteLine($"A divisão do numero {numero_1} e {numero_2} é igual a {divisao}");
