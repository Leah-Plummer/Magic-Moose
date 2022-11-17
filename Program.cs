using System.Linq;
using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Magic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  M A G I C !");
    MooseSays("Ask me a question!");

    string answer = Console.ReadLine().ToLower();



    List<string> responses = new List<string>() 
{
    "As I see it, yes.",
    "Ask again later.",
    "Better not tell you now.",
    "Cannot predict now.",
    "Concentrate and ask again.",
    "Don't count on it.",
    "It is certain.",
    "It is decidedly so.",
    "Most likely.",
    "My reply is no.",
    "My sources say no.",
    "Outlook not so good.",
    "Outlook good.",
    "Reply hazy, try again.",
    "Signs point to yes.",
    "Very doubtful.",
    "Without a doubt.",
    "Yes.",
    "Yes - definitely.",
    "You may rely on it.",
};





   
      Random i = new Random();
      int genRand= i.Next(0,19);
   

// foreach (string response in responses)
// {
//     Console.WriteLine($"{response}(Y/N): ");

    if (answer != "")
    {
        Console.Write($"{responses[genRand]}");
        //answer = Console.ReadLine().ToLower();
    }

//      if (answer == "y") 
//     {
//         Console.WriteLine($"{yesses[i]}");
//         i++;
//     }
//     else
//     {
//         Console.WriteLine($"{nos[i]}") ;
//         i++;
//     }

// }
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

