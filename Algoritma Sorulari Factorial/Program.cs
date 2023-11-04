
// See https://aka.ms/new-console-template for more information


#region 'for' loop factorial

//Console.Write("Input a number to calculate its factorial value : ");
//int input = int.Parse( Console.ReadLine());
//int totalMultiply = 1;
//string print = "";
//for (int i = input;input>0 ;input --)
//{
//    totalMultiply *= input;
//    print += input == 1 ? $"{input} = {totalMultiply}" : $"{input} * ";
//}
//Console.WriteLine($"The factorial of inputted value = {totalMultiply}");
//Console.WriteLine($"This is the proccess of calculating it : | {print} |");
#endregion

#region 'do while' factorial

//int result = 1;
//Console.Write("Input a number to calculate its factorial value : ");
//int input = int.Parse(Console.ReadLine());
//string output = "";
//do
//{

//    result *= input;
//    output += input != 1 ? $"{input} * " : $"{input} = {result} ";
//    input--;
//    if (input == 0) break;
//}
//while (true);
//Console.WriteLine($"This is the proccess of calculating it : | {output} |");

#endregion

#region 'recursive' factorial

Console.Write("Input a number : ");
int input = int.Parse(Console.ReadLine());
Console.WriteLine($"Factorial : {Factorial(input)}");
int Factorial (int n)
{
    if (n > 1)
        return n * Factorial(--n);
    else
        return 1;
}

#endregion
