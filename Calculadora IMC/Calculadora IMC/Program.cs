Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("---CALCULADORA DE IMC---");
float imc = 0;
Console.WriteLine("Digite o Seu Peso: ".Replace(".",","));
float.TryParse(Console.ReadLine()!, out float peso);
Console.WriteLine("Digite a Altura: ".Replace(".", ","));
float.TryParse(Console.ReadLine()!, out float altura);
imc = (float)(peso / Math.Round(altura, 2));
imc = peso / (altura * altura);
Console.WriteLine($"\nO Peso: {peso}\nAltura: {altura}\nIMC: {imc} ");

// incrível
