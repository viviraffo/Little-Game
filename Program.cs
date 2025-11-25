using Microsoft.VisualBasic;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
string? result = Console.ReadLine();


if (ShouldPlay(result)) 
{
    PlayGame();
}

void PlayGame()
{
  var play = true;

  while (play)
  {
    var target = random.Next(0,6);
    var roll = random.Next(0,6);

    Console.WriteLine($"Roll a number greater than {target} to win!");
    Console.WriteLine($"You rolled a {roll}");
    WinOrLose(target, roll);
    Console.WriteLine("\nPlay again? (Y/N)");
    string ? result2 = Console.ReadLine();
    play = ShouldPlay(result2);
  }
}

bool ShouldPlay(string result)
{
  if (result != null)
  {
    if (result.ToUpper().Equals("Y"))
    {
      return true;
    }
    else
    {
      return false;
    }
  }
  else
  {
    return false;
  }
}

void WinOrLose(int target, int roll)
{
  if (target >= roll)
  {
    Console.WriteLine("You lose!");
  }
  else if (roll > target)
  {
    Console.WriteLine("You win!");
  }
}