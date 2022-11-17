using System.Linq;
using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("Ask me a question!");

    List<string> questions = new List<string>() 
{
    "Is Canada real?",
    "Are you enthusiastic?", 
    "Do you love C# yet?", 
    "Do you want to know a secret?",
};

List<string> yesses = new List<string>() 
{
    "Really? It seems very unlikely.",
    "Yay!", 
    "Good job sucking up to your instructor!", 
    "ME TOO!!!! I love secrets...tell me one!",
};

List<string> nos = new List<string>() 
{
    "I  K N E W  I T !!!",
    "You should try it!", 
    "You will...oh, yes, you will...", 
    "Oh, no...secrets are the best, I love to share them!",
};

int i = 0; 

foreach (string question in questions)
{
    Console.WriteLine($"{question}(Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

     if (answer == "y") 
    {
        Console.WriteLine($"{yesses[i]}");
        i++;
    }
    else
    {
        Console.WriteLine($"{nos[i]}") ;
        i++;
    }

}
}


void MooseSays(string message)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
};










