//Напишите программу, которая принимает на вход трехзначное число 
//и на выходе показывает вторую цифру этого числа. 456->5, 782->8, 918->1
int randomNumber = new Random().Next(100,999);

int number2 = randomNumber / 10%10;

Console.WriteLine(randomNumber);
Console.WriteLine(number2);
