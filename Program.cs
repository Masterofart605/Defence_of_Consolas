using static cannon.Modes;
using static cannon.Text;
using static cannon.Other;

namespace MyApp {
internal class Program
{
    static void Main(string[] args)
    {
        int manPlace = shipPlacer(); /*locationAssignAndGuess(1);*/
        
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Defender Of Consolas ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"Now is your chance to fight back! \n");
        battle(manPlace);
        //e();
    }


    static void e()
        {
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



    static int shipPlacer()
        {
            Random random = new Random();
            int ship = random.Next(1, 101);
            return ship;
        }
    static int locationAssignAndGuess(int player)
        {
            //Place the manticore, and guess where it is.
            int place = 0;
            while (true)
            {
                try
                {
                    if (player == 1)
                    {
                        //Player 1 places the manticore
                        Console.Write("What cordanate between 1-100 is");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(" The Manticore ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("stationd at? ");
                        place = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }

                    if (player == 2)
                    {
                        //Player 2 guesses at the place of the manticore
                        Console.Write("What will you set the cannon to, in attempt to hit");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(" The Manticore");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("? ");
                        place = Convert.ToInt32(Console.ReadLine());
                    }

                    if (place > 0 && place < 101)
                    {
                        break;
                    }
                    //Number is too big or small
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("That is not a valid space");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");

                }
                catch
                {
                    //A value other than a number was enterd
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("That is not a valid space");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                }
            }
            return place;
        }
    static int takeinput(){
        int input;
        while (true){
            try{
                Console.Write($"Press 0 to see what you can do, or press 1 to advance. \n");
                input = Convert.ToInt32(Console.ReadLine());
                break;
            }catch{
                Console.WriteLine($"That is not a valid input");
            }
        }
        if (input == 0){
            while (true){
                try{
                    Console.Write($"2:Change Cannon Target \n3:Toggle Advanced HP view \n");
                    input = Convert.ToInt32(Console.ReadLine());
                    break;
                }catch{
                    Console.WriteLine($"That is not a valid input");
                }
            }
        }
        return input;
    } 
    static void battle(int manPlace)
        {
            //Determin the power of magic cannon
            int cannonTurn = 1;
            //The Hp of the different parts of the city
            int cityHP = 15;
            //The Hp of the manticore
            int manHP = 10;
            //to determin what the player is doing
            int playerChoise;
            int damage = 0;
            int guess = 0;
            while (cityHP > 0 && manHP > 0)
            {
                //this is the first line, the ones that displasy the health of consolas and the mantacore.
                Console.WriteLine($"----------------------------------------");
                Console.Write($"Status: Round: {cannonTurn} ");
                changeColor("Consolas: ",ConsoleColor.DarkBlue);
                if (cityHP > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (cityHP > 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(cityHP);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"/15 ");
                changeColor("Manticore: ",ConsoleColor.DarkRed);
                if (manHP > 6)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (manHP > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(manHP);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"/10 \n");

                //this is the second line where we show what state the cannon is at.
                damage = MagicCannon(cannonTurn, 5, cannonElement.Fire, cannonLocation.Center);
                
                Targeting(0,cannonLocation.Left,false,false);
                Targeting(0,cannonLocation.Right,false,false);
                Targeting(0,cannonLocation.Center,false,true);
                Targeting(0,cannonLocation.Upper,false,false);
                //the player does something
                playerChoise = takeinput();
                if (playerChoise == 2){
                    while(true){
                        try{
                            Console.Write($"Which cannon do you want to change? \n 1:finish \n 2:Left \n 3:Center \n 4:Right \n 5:Upper");
                            playerChoise = Convert.ToInt32(Console.ReadLine());
                        }catch{
                            Console.WriteLine($"That is not a valid input");
                        }
                    }
                }

                
                //This is the line where the player guesses.
                guess = locationAssignAndGuess(2);

                //This is the line where we determin if the cannon hit.
                Console.Write("Your round ");
                if (manPlace == guess)
                {
                    Console.Write("was a ");
                    changeColor("Direct Hit",ConsoleColor.Magenta);
                    Console.Write("!");
                    Console.Write($" This did {damage} Damage! \n");
                    manHP = manHP - damage;
                }

                if (manPlace > guess)
                {
                    changeColor("Fell Short",ConsoleColor.DarkYellow);
                    Console.Write(" of ");
                    changeColor("The Manticore",ConsoleColor.DarkRed);
                    Console.Write(". \n");
                }

                if (manPlace < guess)
                {
                    changeColor("Overshot", ConsoleColor.DarkYellow);
                    changeColor(" The Manticore", ConsoleColor.DarkRed);
                    Console.Write(". \n");
                }
                if (damage == 10000)
                {
                    manHP = 0;
                }





                cannonTurn++;
                if (manHP > 0)
                {
                    cityHP--;
                }
            }


            if (manHP <= 0 && cityHP <= 0)
            {
                Console.Write("The wall of ");
                changeColor("Consolas ",ConsoleColor.DarkBlue);
                Console.Write("Was destroyed. But at least so was ");
                changeColor("THe Manticore",ConsoleColor.DarkRed);
                Console.Write(".");
            }
            else if (manHP <= 0)
            {
                changeColor("Congradulations!",ConsoleColor.Green);
                Console.Write(" You destroyed ");
                changeColor("The Manticore",ConsoleColor.DarkRed);
                Console.Write(", the city of ");
                changeColor("Concolas ",ConsoleColor.DarkBlue);
                Console.Write("is saved");
            }
            else if (cityHP <= 0)
            {
                changeColor("Oh No!",ConsoleColor.Red);
                changeColor("The Manticore",ConsoleColor.DarkRed);
                Console.Write(" Broke the wall of ");
                changeColor("Consolas ",ConsoleColor.DarkBlue);
                Console.Write("the city is doomed.");
            }
        }
    
}
}