Console.WriteLine("--- Media Aritmedica de três ---");

double nota1, nota2, nota3, media;

Console.Write("Acressente o primeiro numero: ");
nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Acressente o segundo numero: ");
nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Acressente o terceiro número: ");
nota3 = Convert.ToDouble(Console.ReadLine());

media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"\nMédia: {media:N1}");
