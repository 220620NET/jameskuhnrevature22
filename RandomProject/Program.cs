// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a number");
int input = int.Parse(Console.ReadLine());

for (int i = 1 ; i <= input; i++){

    if (i % 3 == 0 && i % 5 == 0 ){
        Console.WriteLine("fizzbuzz");
    }
    else if (i % 3 == 0){
        Console.WriteLine("fizz");
    }
    else if (i % 5 == 0 ){
        Console.WriteLine("buzz");
    }

    else{
        Console.WriteLine(i);
    }

}




