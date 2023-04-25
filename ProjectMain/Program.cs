using static Utilities.Text;
using classlib;


    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player((1,1));
            ScreenDisplay THESCREEN = new ScreenDisplay();
            ConsoleKey theGottenKey;
            while(true){
                THESCREEN.AdvancedDisplay(player);
                theGottenKey = Console.ReadKey(false).Key;
                switch(theGottenKey){
                    case ConsoleKey.A:
                    player.MoveLeft();
                    break;
                    case ConsoleKey.LeftArrow:
                    player.MoveLeft();
                    break;
                    case ConsoleKey.D:
                    player.MoveRight();
                    break;
                    case ConsoleKey.RightArrow:
                    player.MoveRight();
                    break;
                    case ConsoleKey.W:
                    player.Jump();
                    break;
                    case ConsoleKey.UpArrow:
                    player.Jump();
                    break;
                    case ConsoleKey.E:
                    throw new Exception();
                    break;
                    default:
                    player.Fall();
                    break;
                }
                
            }
        }


        static void colorTester()
        {
            //this exists just so that I can see what all of the console colors like when printed in the console
            //it is not used in the game
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("e");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("e");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("e");
        }
    }
