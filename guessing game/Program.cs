// See https://aka.ms/new-console-template for more information

Random randomizer = new Random();
int randomnumber = randomizer.Next(100);
int tries = 7;

System.Console.WriteLine("guess a number between 1 and 100");
int guess = int.Parse(Console.ReadLine());


while(tries > 1)
{
   if(guess > randomnumber)
   {
    tries--;
    System.Console.WriteLine("you guessed too high you have " + tries + " guesses left");
    guess = int.Parse(Console.ReadLine());
    

   }
   else if (guess < randomnumber){
    tries--;
   System.Console.WriteLine("you guessed too low. you have " + tries + " guesses left") ;
    guess = int.Parse(Console.ReadLine());
   }
   else {
    System.Console.WriteLine("congratulations, you guessed the correct number");
    System.Environment.Exit(1);
   }
   

   
   


}

System.Console.WriteLine("Unfortunately you have run out of tries. Please run again");


/*

for (int i = 0 ; i < tries ; i++){

    if(randomnumber == guess){
        System.Console.WriteLine("congrats you guessed it right" + guess);
        tries = ;
        
    }
    else if (guess < randomnumber){

    }
}
*/