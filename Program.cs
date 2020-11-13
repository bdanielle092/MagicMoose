using System;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            // welcomes user
            Console.WriteLine("Welcome to Magic Moose !");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            //let the moose speak!
            //We use MooseSays method to prompt user to ask a question
            MooseSays("Ask me a question...");
            //Line 17 allows user to ask a question 
            Console.ReadLine();
        }

//MooseSays Method allow the moose to say something to the user

        static void MooseSays(string message)
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
                      |  .-. .-.  |            {message}
                      \ / o| |o \ /
                       |   / \   |   
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
        }
    }
}
