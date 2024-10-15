
using System;
using System.ComponentModel.Design;


//Console.WriteLine("Hello");
//Console.WriteLine("Insert base side lenght");
//string baseSideInput = Console.ReadLine();
//double baseSide = double.Parse(baseSideInput);
//if(baseSide < 0 || baseSide > 20)
//{
//    Console.WriteLine("You inserted an invalid value");
//    return; 

//}

//Console.WriteLine("Insert height side lenght");
//string heightSideInput = Console.ReadLine();
//double heightSide = double.Parse(heightSideInput);
//if (heightSide < 0)
//{
//    Console.WriteLine("You inserted an invalid value");
//    return;
//}

//double h = Math.Sqrt(baseSide * baseSide + heightSide * heightSide);
//Console.WriteLine($"Hypotenuse:{h}");


bool isNum1Valid;
double num1;
do
{
    Console.WriteLine("Scrivi un numero");
    string num1Input = Console.ReadLine();
    bool isNum1Valid = double.TryParse(num1Input, out num1);

}
while (!isNum1Valid);
if (!isNum1Valid)
{
    Console.WriteLine("Il numero non è valido");
    return;
}
Console.WriteLine("Scrivi un numero");
string num2Input = Console.ReadLine();  
bool isNum2Valid = double.TryParse(num2Input,out double num2);
if (!isNum2Valid)
{
    Console.WriteLine("Il numero non è valido");
    return;
}
if (num1 > num2)
{
    Console.WriteLine($"Il numero maggiore è:{num1}");

}
else if (num2 > num1)
{
    Console.WriteLine($"Il numero maggiore è: {num2}");
    
}
else
{
    Console.WriteLine("I numeri sono uguali");
}




