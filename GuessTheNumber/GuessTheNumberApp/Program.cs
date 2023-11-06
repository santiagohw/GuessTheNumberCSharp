// See https://aka.ms/new-console-template for more information
Console.WriteLine("Guess the number game!.");
Console.WriteLine("Guess a number from 1-100");

int secretNumber = 0;
int count = 0;
int userNumber = 0;
bool exitGame = false;
string userImput = string.Empty;
Random random = new Random();

secretNumber = random.Next(100);

while (exitGame == false)
{
	userImput = Console.ReadLine();
	if (int.TryParse(userImput, out userNumber) == true)
	{
		///We are shure that the input is a valid number
		if (userNumber > secretNumber)
		{
			Console.WriteLine("Its Above");
		}
		if (userNumber < secretNumber)
		{
			Console.WriteLine("Its Too Low");
		}
		if (userNumber == secretNumber)
		{
			Console.WriteLine("You Are The Champion!!!");
			exitGame = true;
		}
	}
	else
	{
		Console.WriteLine("The imput is not a valid number :(");
	} 
	count++;
	Console.WriteLine("TRIES: " + count.ToString());
}