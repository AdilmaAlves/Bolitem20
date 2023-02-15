double media,soma=0;
int qnotas;
double[] array= new double[10];



Console.WriteLine("Qual o nome do aluno?");
String nome = Console.ReadLine();
Console.WriteLine("Quantas notas serão usadas para compor a média?");
qnotas = int.Parse(Console.ReadLine());

for(int i=1; i <= qnotas;i++){
Console.WriteLine("Digite a " + (i)  + " Nota: ");
array[i] = double.Parse(Console.ReadLine());
    soma = soma+array[i];
}
 media = soma/qnotas;

if(media >= 6){
    Console.WriteLine($"Aluno: {nome}");
    for(int i=1; i <= qnotas;i++){
        Console.WriteLine($"N{i}: {array[i]} \n");
}
    Console.WriteLine($"Média: {media} - Aprovado");
}

if(media >= 5 && media < 6){
     Console.WriteLine($"Aluno: {nome}");
    for(int i=1; i <= qnotas;i++){
        Console.WriteLine($"N{i}: {array[i]} \n");
}
    Console.WriteLine($"Média: {media} - Recuperação");
}
if(media < 5){
     Console.WriteLine($"Aluno: {nome}");
    for(int i=1; i <= qnotas;i++){
        Console.WriteLine($"N{i}: {array[i]} \n");
}
    Console.WriteLine($"Média: {media} - Reprovado");
}

