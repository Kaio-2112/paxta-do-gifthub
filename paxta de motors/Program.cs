using System.Reflection;

void Soma(float a, float b){
    float resultado = a + b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Subtraçao(float a, float b){
    float resultado = a - b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Multiplicacao(float a, float b){
    float resultado = a * b;
    Console.WriteLine($"{a} + {b} = {resultado}");
}

void Divisao(float a, float b, object resultado)
    if(b == 0){
        Console.WriteLine($"{a} / {b} = {"Erro de divisao por zero"});
        return;
    }


    float resultado = a / b;
    Console.WriteLine($"{a} / {b} = {resultado}");
    }

//variaveis globais
float a;
float b;

void DigitarAeB(){
    Console.WriteLine("Digite a:");
    a = float.Parse(Console.ReadLine());
    Console.WriteLine("Digite b:");
    b = float.Parse(Console.ReadLine());
}




