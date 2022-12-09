using static Utilities.Cannons;
using static Utilities.Text;
using static Utilities.Other;
using static Utilities.Settings;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int, int) manPlace = shipPlacer(); /*locationAssignAndGuess(1);*/
            Console.Clear();
            //colorTester();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Defender Of Consolas ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"The City is under attack it is time to fight back! \n");

            ChangeColor("IMPORTANT \n ", ConsoleColor.Red);
            ChangeColor("Currently the upgrades menu does not work, people have been haveing issues getting stuck in it (hopefully I will have that fixed by now) \n",ConsoleColor.Yellow);
            Console.Write("I also need a little guide of how to run the program \n");
            Console.Write("So in the first menu you can press 0 to end the round, or 1 to change settings \n");
            Console.Write("This is where most stuff happens. For the purposes of playing the game you only NEED to pay attention to the first one \n");
            Console.Write("This is change cannon target, you will press 1 to select it. Currently you only have the right cannon so you will press 3 to select it \n");
            Console.Write("(if you wish to go bcak press 0) \n");
            Console.Write("The you will input the place you want to target to try and guess were the enemy is starting with x and then y \n");
            Console.Write("(Tip: it has to be from -50 to 50) \n");
            ChangeColor("Then you press 0 to finish since you only have 1 cannon right now \n",ConsoleColor.Yellow);
            Console.Write("You will then be told on relitive to the enemy what side your shot missed to \n");
            Console.Write("You will continue this untill the opponent is defeated \n");
            ChangeColor("The only way to exit the program is to destroy the enemy. In the future when I implement saveing this will be changed \n", ConsoleColor.Yellow);



            battle(manPlace);

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
        static (int, int) shipPlacer()
        {
            Random random = new Random();
            int ship1 = random.Next(-50, 51);
            int ship2 = random.Next(-50, 51);
            return (ship1, ship2);
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
        static int takeinput()
        {
            int input;
            while (true)
            {
                try
                {
                    Console.Write($"Press 9 change settings, or press 0 to advance. \n");
                    input = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine($"That is not a valid input");
                }
            }
            if (input == 9)
            {
                while (true)
                {
                    try
                    {
                        Console.Write($"1:Change Cannon Target \n2:Toggle Advanced HP view \n3:Toggle Advanced Enemy view \n4:Toggle extra missed shot guide \n5:Upgrade Cannons\n9:Screen Refresh every cycle (One person who reviewed this thinks this is needed)\n");
                        input = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine($"That is not a valid input");
                    }
                }
            }
            return input;
        }
        static void radarPing(List<(int, int)> enemyPlacement, int index)
        {
            ChangeColor("The Radar detected ", ConsoleColor.DarkGray);
            ChangeColor("The Manticore ", ConsoleColor.Red);
            ChangeColor("in the [", ConsoleColor.DarkGray);
            if (enemyPlacement[index].Item1 > 0)
            {
                ChangeColor("+", ConsoleColor.Green);
            }
            if (enemyPlacement[index].Item1 < 0)
            {
                ChangeColor("-", ConsoleColor.Red);
            }
            ChangeColor(",", ConsoleColor.DarkGray);
            if (enemyPlacement[index].Item2 > 0)
            {
                ChangeColor("+", ConsoleColor.Green);
            }
            if (enemyPlacement[index].Item2 < 0)
            {
                ChangeColor("-", ConsoleColor.Red);
            }
            ChangeColor("] quadrent \n", ConsoleColor.DarkGray);
        }
        static void battle((int, int) manPlace)
        {
            /*

            I know this method is long, but i caenemyTypennot split it up, that would requre me to pass
            and retreavie 15+ variables some of which are lists from each and every method that 
            I would theoretical split it into.

            */
            //Determin the power of magic cannon
            int cannonTurn = 1;
            int roundNumber = 1;
            //The Hp of the different parts of the city
            //{Main Wall, Secondary Wall, City Center}
            int cityHP = 25;
            int[] cityPartsHp = new int[3] { 10, 10, 5 };
            //All of the enemy settings
            List<(int, int)> enemyPlacement = new List<(int, int)>();
            List<int> enemyHp = new List<int>();
            List<enemyTypes> enemyType = new List<enemyTypes>();
            bool enemyStillAlive = true;
            int manHP = 10;
            //to determin what the player is doing
            int playerChoise;
            //The Cannon Data 
            //{left,center,right,upper,super}
            bool[] hasCannon = new bool[] { false, false, true, false, false };
            //DON'T CHANGE
            cannonLocation[] cannonLookup = new cannonLocation[] { cannonLocation.Left, cannonLocation.Center, cannonLocation.Right, cannonLocation.Upper, cannonLocation.Super };
            (int, int)[] cannonTarget = new (int, int)[] { (0, 0), (0, 0), (0, 0), (0, 0), (0, 0) };
            int[] cannonHP = new int[] { 5, 5, 5, 5, 0 };
            int[] cannonLevel = new int[] { 1, 1, 1, 1, 0 };
            cannonTypes[] curentCannonType = new cannonTypes[] { cannonTypes.Basic, cannonTypes.Basic, cannonTypes.Basic, cannonTypes.Basic, cannonTypes.Super };
            int[] cannonDamage = new int[] { 0, 0, 0, 0, 0 };
            //settings {City HP, Enemy HP view, Extra Missed Shot guide}
            bool[] viewSettings = new bool[] { false, true, true, false };
            int upgradePoints = 0;
            Random random = new Random();
            int damage = 0;
            //index is used in most of the foreach loops for reasons
            int index = 0;
            int index2 = 0;


            /*Test the enemy location on the radar*/

            (int, int) imAlsoMad = (random.Next(-50, 50), random.Next(-50, 50));
            enemyPlacement.Add(imAlsoMad);
            enemyHp.Add(10);

            //This is where the game loop starts
            while (true)
            {
                //This is where each round starts
                while (cityPartsHp[2] > 0 && enemyStillAlive == true)
                {
                    //this is the first line, the ones that displasy the health of consolas and the mantacore.
                    //this is if advancced Hp view is not checked
                    Console.WriteLine($"----------------------------------------");
                    Console.Write($"Round: {cannonTurn} ");
                    if (viewSettings[0] == false)
                    {
                        //Veiw City Hp basic
                        BasicCityHp(cityHP, manHP);
                    }
                    //This group is what displays when advanced hp is true
                    if (viewSettings[0] == true)
                    {
                        //Veiw city hp advanced
                        AdvancedCityHP(cityPartsHp, cannonHP);
                    }

                    if (viewSettings[1] == false)
                    {
                        //The Manticore
                        ChangeColor("Manticore: ", ConsoleColor.Red);
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
                    }

                    if (viewSettings[1] == true)
                    {
                        AdvancedEnemyHp(enemyHp);
                    }
                    //this is the second line where we show what state the cannon is at.
                    //as well as what cordanents that are being targeted.
                    //Index is used for all for each loops to help cycle trough all indexes in the array
                    index = 0;
                    index2 = 0;
                    foreach (bool thing in hasCannon)
                    {
                        if (hasCannon[index] == true && cannonHP[index] > 0)
                        {
                            //Currently this only checks if the cannon is a magic cannon type
                            if (curentCannonType[index] == cannonTypes.Magic)
                            {
                                //outputs cannon damage baised on the cannon's level and the turn number and stores it in the damage array
                                cannonDamage[index] = MagicCannon(cannonTurn, cannonLevel[index], MagicCannonElement.Fire, cannonLookup[index]);
                            }
                            if (curentCannonType[index] == cannonTypes.Basic)
                            {
                                cannonDamage[index] = BasicCannon(cannonLevel[index], cannonLookup[index]);
                            }
                            if (curentCannonType[index] == cannonTypes.Auto)
                            {
                                (int, (int, int)) output = AutoCannon(cannonLevel[index], enemyPlacement, cannonTarget[index], cannonLookup[index]);
                                cannonDamage[index] = output.Item1;
                                cannonTarget[index] = output.Item2;
                            }
                            Console.Write($"Target: {cannonTarget[index]}   \n");
                        }
                        index++;
                    }

                    //The Radar ping showing where the manticore is
                    index = 0;
                    foreach ((int, int) thing in enemyPlacement)
                    {
                        radarPing(enemyPlacement, index);
                        index++;
                    }


                    //the player does something
                    playerChoise = takeinput();



                    //Advanced Hp
                    if (playerChoise == 2)
                    {
                        if (viewSettings[0] == true)
                        {
                            viewSettings[0] = false;
                        }
                        else
                        {
                            viewSettings[0] = true;
                        }
                        playerChoise = takeinput();
                    }
                    //Enemy View
                    if (playerChoise == 3)
                    {
                        if (viewSettings[1] == true)
                        {
                            viewSettings[1] = false;
                        }
                        else
                        {
                            viewSettings[1] = true;
                        }
                        playerChoise = takeinput();
                    }
                    //Extra Missed Sot guide
                    if (playerChoise == 4)
                    {
                        if (viewSettings[2] == true)
                        {
                            viewSettings[2] = false;
                        }
                        else
                        {
                            viewSettings[2] = true;
                        }
                        playerChoise = takeinput();
                    }
                    //refresh screen every cycle
                    if (playerChoise == 9)
                    {
                        if (viewSettings[3] == true)
                        {
                            viewSettings[3] = false;
                        }
                        else
                        {
                            viewSettings[3] = true;
                        }
                        playerChoise = takeinput();
                    }

                    //Upgrade Cannons
                    if (playerChoise == 5)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Write($"---------------------------------------- \n");
                                int cost = 0;
                                Console.Write($"You have ");
                                ChangeColor($"{upgradePoints}", ConsoleColor.Blue);
                                ChangeColor(" Upgrade Points", ConsoleColor.Yellow);
                                Console.Write(" what would you like to upgrade? \n");
                                index = 0;
                                Console.Write("This has not been fully implemented yet... (Press 0 to exit) \n");
                                foreach (cannonLocation thing in cannonLookup)
                                {
                                    //If it has a show what cannon has, else say empty
                                    Console.Write($" {index + 1}:");
                                    if (hasCannon[index] == true)
                                    {
                                        
                                        //basic cannons show up as white can only go to level three
                                        if (curentCannonType[index] == cannonTypes.Basic)
                                        {
                                            if (cannonLevel[index] <= 2)
                                            {
                                                Console.Write($"Basic, Level:{cannonLevel[index]}     (Level Up:{Math.Pow(cannonLevel[index], 2) * 5})(Upgrade:(Magic:{(Math.Pow(cannonLevel[index], 2) * 5) * 2}|Ink:??|) \n");
                                            }
                                            else
                                            {
                                                Console.Write($"Basic, Level:{cannonLevel[index]}     (Upgrade(Magic:{(Math.Pow(cannonLevel[index], 2) * 5) * 2}|Ink:??|) \n");
                                            }
                                        }
                                        if (curentCannonType[index] == cannonTypes.Magic)
                                        {
                                            //Change color of the word magic depending on level
                                            if (cannonLevel[index] <= 2)
                                            {
                                                ChangeColor("Magic", ConsoleColor.DarkMagenta);
                                            }
                                            else if (cannonLevel[index] > 2)
                                            {
                                                ChangeColor("Magic", ConsoleColor.Magenta);
                                            }
                                            Console.Write($", Level:{cannonLevel[index]}     (Level Up:{Math.Pow((cannonLevel[index] + 1), 3) * 4}) \n");

                                        }
                                    }
                                    else
                                    {
                                        ChangeColor("Empty  Station", ConsoleColor.DarkGray);
                                        Console.Write("     (Basic:1)\n");
                                    }
                                    index++;
                                }
                                playerChoise = Convert.ToInt32(Console.ReadLine());
                                if (playerChoise == 0){
                                    break;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"That is not a valid input");
                            }
                        }
                    }

                    //The Player Selects to change the target of a cannon
                    if (playerChoise == 1)
                    {
                        while (true)
                        {
                            try
                            {
                                Console.Write($"Which cannon do you want to change? \n 0:finish \n");
                                int selectNumber = 1;
                                index = 0;
                                //If there is a cannon show it in color, otherwise gray it out 
                                foreach (bool entry in hasCannon)
                                {
                                    if (entry == true && curentCannonType[index] != cannonTypes.Auto)
                                    {
                                        ChangeColor($" {selectNumber}:{cannonLookup[index],5}      ({curentCannonType[index]})\n", ConsoleColor.White);
                                    }
                                    else
                                    {
                                        ChangeColor($" {selectNumber}:{cannonLookup[index],5}      ({curentCannonType[index]})\n", ConsoleColor.DarkGray);
                                    }
                                    selectNumber++;
                                    index++;
                                }
                                playerChoise = Convert.ToInt32(Console.ReadLine());
                                cannonLocation wichCannonDoYouWantToChange = cannonLocation.Left;
                                switch (playerChoise)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                        wichCannonDoYouWantToChange = cannonLocation.Left;
                                        break;
                                    case 2:
                                        wichCannonDoYouWantToChange = cannonLocation.Center;
                                        break;
                                    case 3:
                                        wichCannonDoYouWantToChange = cannonLocation.Right;
                                        break;
                                    case 4:
                                        wichCannonDoYouWantToChange = cannonLocation.Upper;
                                        break;
                                    default:
                                        playerChoise = 0;
                                        break;
                                }
                                if (playerChoise != 0)
                                {
                                    Targeting(cannonTarget[playerChoise - 1], wichCannonDoYouWantToChange, false, hasCannon[playerChoise - 1]);
                                    if (hasCannon[playerChoise - 1] == true && (curentCannonType[playerChoise - 1] != cannonTypes.Auto))
                                    {
                                        (int, int) newCannonTarget = Targeting((0, 0), wichCannonDoYouWantToChange, true, true);
                                        cannonTarget[playerChoise - 1] = newCannonTarget;
                                    }
                                    else
                                    {
                                        Console.Write("You cannont change the target of this cannon");
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"That is not a valid input");
                            }
                        }
                    }




                    Console.Write($"---------------------------------------- \n");


                    //clears the console when the "refresh every cycle" option is true
                    if (viewSettings[3] == true){
                        Console.Clear();
                    }

                    //This is the line where we determin if the cannon hit.
                    index = 0;
                    foreach ((int, int) entry in cannonTarget)
                    {
                        //The "If" checks if a cannon exists and has more that 0 hp for the selected area
                        if (hasCannon[index] == true && cannonHP[index] > 0)
                        {
                            bool[] shotRelitiveToEnemy = new bool[4] { false, false, false, false };
                            Console.Write($"{cannonLookup[index]} cannon's round ");
                            index2 = 0;
                            foreach ((int, int) thing in enemyPlacement)
                            {
                                if (enemyPlacement[index2] == cannonTarget[index])
                                {
                                    Console.Write("was a ");
                                    ChangeColor("Direct Hit", ConsoleColor.Magenta);
                                    Console.Write("!");
                                    Console.Write($" This did {cannonDamage[index]} Damage! \n");
                                    enemyHp[index2] = enemyHp[index2] - cannonDamage[index];
                                }

                                if (enemyPlacement[index2].Item1 > cannonTarget[index].Item1)
                                {
                                    ChangeColor("fell to the left", ConsoleColor.DarkYellow);
                                    //Console.Write(" of ");
                                    //ChangeColor("The Manticore",ConsoleColor.DarkRed);
                                    //Console.Write(". \n");
                                    shotRelitiveToEnemy[0] = true;
                                }

                                if (enemyPlacement[index2].Item1 < cannonTarget[index].Item1)
                                {
                                    ChangeColor("fell to the right", ConsoleColor.DarkYellow);
                                    //Console.Write(" of ");
                                    //ChangeColor("The Manticore",ConsoleColor.DarkRed);
                                    //Console.Write(". \n");
                                    shotRelitiveToEnemy[1] = true;
                                }
                                Console.Write(" and ");
                                if (enemyPlacement[index2].Item2 > cannonTarget[index].Item2)
                                {
                                    ChangeColor("fell short", ConsoleColor.DarkYellow);
                                    Console.Write(" of ");
                                    ChangeColor(" The Manticore", ConsoleColor.DarkRed);
                                    Console.Write(". \n");
                                    shotRelitiveToEnemy[2] = true;
                                }

                                if (enemyPlacement[index2].Item2 < cannonTarget[index].Item2)
                                {
                                    ChangeColor("overshot", ConsoleColor.DarkYellow);
                                    ChangeColor(" The Manticore", ConsoleColor.DarkRed);
                                    Console.Write(". \n");
                                    shotRelitiveToEnemy[3] = true;
                                }

                                if (damage == 10000)
                                {
                                    enemyHp[index2] = 0;
                                }

                                //Show the relitive possition of the missed shot
                                if (viewSettings[2] == true)
                                {
                                    if (shotRelitiveToEnemy[0] == true)
                                    {
                                        if (shotRelitiveToEnemy[3] == true)
                                        {
                                            ChangeColor(" *", ConsoleColor.Green);
                                            ChangeColor("\n  M\n", ConsoleColor.Red);
                                        }
                                        else if (shotRelitiveToEnemy[2] == true)
                                        {
                                            ChangeColor("  M", ConsoleColor.Red);
                                            ChangeColor("\n *\n", ConsoleColor.Green);
                                        }
                                        else
                                        {
                                            ChangeColor(" *", ConsoleColor.Green);
                                            ChangeColor("M\n", ConsoleColor.Red);
                                        }
                                    }
                                    else if (shotRelitiveToEnemy[1] == true)
                                    {
                                        if (shotRelitiveToEnemy[3] == true)
                                        {
                                            ChangeColor("   *", ConsoleColor.Green);
                                            ChangeColor("\n  M\n", ConsoleColor.Red);
                                        }
                                        else if (shotRelitiveToEnemy[2] == true)
                                        {
                                            ChangeColor("  M", ConsoleColor.Red);
                                            ChangeColor("\n   *\n", ConsoleColor.Green);
                                        }
                                        else
                                        {
                                            ChangeColor(" M", ConsoleColor.Red);
                                            ChangeColor("*\n", ConsoleColor.Green);
                                        }
                                    }
                                    else if (shotRelitiveToEnemy[2] == true)
                                    {
                                        ChangeColor("  M", ConsoleColor.Red);
                                        ChangeColor("\n  *\n", ConsoleColor.Green);
                                    }
                                    else if (shotRelitiveToEnemy[3] == true)
                                    {
                                        ChangeColor("  *", ConsoleColor.Green);
                                        ChangeColor("\n  M\n", ConsoleColor.Red);
                                    }
                                }
                                index2++;
                            }
                        }
                        index++;
                    }




                    cannonTurn++;
                    // The Enimys strike back
                    index = 0;
                    foreach (int thing in enemyHp)
                    {
                        if (enemyHp[index] > 0)
                        {
                            //determin which part it hits
                            int hit = random.Next(1, 6);
                            //Which cannon is hit when cannons are hit
                            int cHit = random.Next(0, 4);
                            if (cannonHP[0] == 0)
                            {
                                cHit = random.Next(0, 4);
                            }
                            if (cannonHP[1] == 0)
                            {
                                cHit = random.Next(0, 4);
                            }
                            if (cannonHP[2] == 0)
                            {
                                cHit = random.Next(0, 4);
                            }
                            if (cannonHP[3] == 0)
                            {
                                cHit = random.Next(0, 4);
                            }

                            if (cityPartsHp[0] != 0)
                            {
                                switch (hit)
                                {
                                    case 1:
                                        cityPartsHp[0]--;
                                        break;
                                    case 2:
                                        cityPartsHp[0]--;
                                        break;
                                    case 3:
                                        cityPartsHp[0]--;
                                        break;
                                    case 4:
                                        cityPartsHp[1]--;
                                        break;
                                    case 5:
                                        cannonHP[cHit]--;
                                        break;
                                }
                            }
                            else if (cityPartsHp[1] != 0)
                            {
                                switch (hit)
                                {
                                    case 1:
                                        cityPartsHp[1]--;
                                        break;
                                    case 2:
                                        cityPartsHp[1]--;
                                        break;
                                    case 3:
                                        cityPartsHp[2]--;
                                        break;
                                    case 4:
                                        cannonHP[cHit]--;
                                        break;
                                    case 5:
                                        cannonHP[cHit]--;
                                        break;
                                }
                            }
                            else
                            {
                                switch (hit)
                                {
                                    case 1:
                                        cityPartsHp[2]--;
                                        break;
                                    case 2:
                                        cityPartsHp[2]--;
                                        break;
                                    case 3:
                                        cannonHP[cHit]--;
                                        break;
                                    case 4:
                                        cannonHP[cHit]--;
                                        break;
                                    case 5:
                                        cannonHP[cHit]--;
                                        break;
                                }
                            }
                            cityHP = 0;
                            foreach (int part in cityPartsHp)
                            {
                                cityHP = part + cityHP;
                            }

                        }
                    }
                    index = 0;
                    enemyStillAlive = false;
                    foreach (int thing in enemyHp)
                    {
                        if (enemyHp[index] > 0)
                        {
                            enemyStillAlive = true;
                        }
                        index++;
                    }
                }
                roundNumber++;

                //this break is only temporary untill I add more rounds
                break;
            }


            


            if (enemyStillAlive == false && cityPartsHp[2] <= 0)
            {
                Console.Write("The wall of ");
                ChangeColor("Consolas ", ConsoleColor.DarkBlue);
                Console.Write("Was destroyed. But at least so was ");
                ChangeColor("The Manticore", ConsoleColor.DarkRed);
                Console.Write(".");
            }
            else if (enemyStillAlive == false)
            {
                ChangeColor("Congradulations!", ConsoleColor.Green);
                Console.Write(" You destroyed ");
                ChangeColor("The Manticore", ConsoleColor.DarkRed);
                Console.Write(", the city of ");
                ChangeColor("Consolas ", ConsoleColor.DarkBlue);
                Console.Write("is saved");
            }
            else if (cityPartsHp[2] <= 0)
            {
                ChangeColor("Oh No!", ConsoleColor.Red);
                ChangeColor("The Manticore", ConsoleColor.DarkRed);
                Console.Write(" Broke the wall of ");
                ChangeColor("Consolas ", ConsoleColor.DarkBlue);
                Console.Write("the city is doomed.");
            }
        }

    }
}