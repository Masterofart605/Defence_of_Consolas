using static Utilities.Cannons;
using static Utilities.Text;


namespace Utilities
{
    public class Cannons
    {
        public static int MagicCannon(int cannonTurn, int level, MagicCannonElement element, cannonLocation location)
        {
            /*For each level of the cannon I had to paste in all the effects of the last layer
            I know it gets a little confuseing at times, but it was the only way.
            */
            Console.Write($"The Magic Cannon at {location} Station has a ");//basic charge...
            if (level == 1)
            {
                //Basic Shot
                Console.Write("Basic charge \n");
                return 1;
            }
            if (level == 2)
            {
                if (cannonTurn % 3 == 0)
                {
                    //Fire Charge
                    if (element == MagicCannonElement.Fire)
                    {
                        ChangeColor("Fire", ConsoleColor.Red);
                        Console.Write($" Charge. \n");
                        return 3;
                        //Ice charge
                    }
                    else if (element == MagicCannonElement.Ice)
                    {
                        ChangeColor("Frost", ConsoleColor.Cyan);
                        Console.Write($" Charge. \n");
                        return 3;
                    }
                }
                else
                {
                    //Basic charge
                    Console.Write("Basic charge \n");
                    return 1;
                }
            }
            if (level == 3)
            {
                if (cannonTurn % 3 == 0 && cannonTurn % 5 == 0)
                {
                    //Double Charge Fire
                    if (element == MagicCannonElement.Fire)
                    {
                        ChangeColor("Flash", ConsoleColor.Yellow);
                        Console.Write("-");
                        ChangeColor("Burn", ConsoleColor.Red);
                        Console.Write($" charge. \n");
                    }
                    else
                    {
                        //Double Charge Ice
                        ChangeColor("Flash", ConsoleColor.Yellow);
                        Console.Write("-");
                        ChangeColor("Freeze", ConsoleColor.Cyan);
                        Console.Write($" charge. \n");
                    }
                    return 15;
                    //Thunder Charge
                }
                else if (cannonTurn % 5 == 0)
                {
                    ChangeColor("Thunder", ConsoleColor.Yellow);
                    Console.Write($" Charge. \n");
                    return 5;
                    //Fire/Ice charge
                }
                else if (cannonTurn % 3 == 0)
                {
                    //Fire charge
                    if (element == MagicCannonElement.Fire)
                    {
                        ChangeColor("Fire", ConsoleColor.Red);
                        Console.Write($" Charge. \n");
                        return 3;
                        //Ice charge
                    }
                    else
                    {
                        ChangeColor("Frost", ConsoleColor.Cyan);
                        Console.Write($" Charge. \n");
                        return 3;
                    }
                }


                else
                {
                    Console.Write("Basic charge \n");
                    return 1;
                }
            }
            if (level == 4)
            {
                //Any combination of Hydro Charges
                if (cannonTurn % 10 == 0)
                {
                    //hydro
                    if (cannonTurn % 5 == 0)
                    {
                        //thunder
                        if (cannonTurn % 3 == 0)
                        {
                            //fire/ice
                            if (element == MagicCannonElement.Fire)
                            {
                                //Hyrdo, Thunder, Fire
                                ChangeColor("Fire ", ConsoleColor.Red);
                                ChangeColor("Storm", ConsoleColor.Magenta);
                                Console.Write($" charge. \n");
                                return 150;
                            }
                            if (element == MagicCannonElement.Ice)
                            {
                                //Hyrdo, Thunder, Ice
                                ChangeColor("Snow", ConsoleColor.Cyan);
                                ChangeColor(" Storm", ConsoleColor.Magenta);
                                Console.Write($" charge. \n");
                                return 150;
                            }
                        }
                        //Thunder Hydro
                        ChangeColor("Storm", ConsoleColor.Magenta);
                        Console.Write($" charge. \n");
                        return 50;
                    }
                    //Hyrdo Fire/Ice combinations
                    if (cannonTurn % 3 == 0)
                    {
                        //Thunder Fire Charge
                        if (element == MagicCannonElement.Fire)
                        {
                            ChangeColor("Steam", ConsoleColor.DarkRed);
                            Console.Write($" charge. \n");
                            return 30;
                        }
                        //Thunder Ice Charge
                        if (element == MagicCannonElement.Ice)
                        {
                            ChangeColor("Glacier", ConsoleColor.DarkCyan);
                            Console.Write($" charge. \n");
                            return 30;
                        }
                    }
                    //Hydro charge
                    ChangeColor("Hydro", ConsoleColor.Blue);
                    Console.Write($" Charge. \n");
                    return 10;
                }
                //All level 3 Thunder Charges
                if (cannonTurn % 5 == 0)
                {
                    if (cannonTurn % 3 == 0)
                    {
                        //Double Fire charge
                        if (element == MagicCannonElement.Fire)
                        {
                            ChangeColor("Flash", ConsoleColor.Yellow);
                            Console.Write("-");
                            ChangeColor("Burn", ConsoleColor.Red);
                            Console.Write($" charge. \n");
                        }
                        if (element == MagicCannonElement.Ice)
                        {
                            //Double Charge Ice
                            ChangeColor("Flash", ConsoleColor.Yellow);
                            Console.Write("-");
                            ChangeColor("Freeze", ConsoleColor.White);
                            Console.Write($" charge. \n");
                        }
                        return 15;
                    }
                    //Thunder Charge
                    ChangeColor("Thunder", ConsoleColor.Yellow);
                    Console.Write($" Charge. \n");
                    return 5;
                }
                //Level 2 Charges
                if (cannonTurn % 3 == 0)
                {
                    //Fire Charge
                    if (element == MagicCannonElement.Fire)
                    {
                        ChangeColor("Fire", ConsoleColor.Red);
                        Console.Write($" Charge. \n");
                        return 3;
                        //Ice charge
                    }
                    else if (element == MagicCannonElement.Ice)
                    {
                        ChangeColor("Frost", ConsoleColor.Cyan);
                        Console.Write($" Charge. \n");
                        return 3;
                    }
                }
                //Basic shot
                Console.Write("Basic charge \n");
                return 1;
            }
            if (level == 5)
            {
                if (cannonTurn % 15 == 0)
                {
                    //Crio/blaze, and their combos
                    if (cannonTurn % 10 == 0)
                    {
                        //+ Hydro and its combos 
                        if (cannonTurn % 5 == 0)
                        {
                            if (cannonTurn % 3 == 0)
                            {
                                ChangeColor("F", ConsoleColor.Blue);
                                ChangeColor("i", ConsoleColor.Cyan);
                                ChangeColor("n", ConsoleColor.Green);
                                ChangeColor("a", ConsoleColor.Yellow);
                                ChangeColor("l", ConsoleColor.Red);
                                ChangeColor("i", ConsoleColor.Magenta);
                                ChangeColor("t", ConsoleColor.Blue);
                                ChangeColor("y", ConsoleColor.Cyan);
                                ChangeColor(" B", ConsoleColor.Green);
                                ChangeColor("l", ConsoleColor.Yellow);
                                ChangeColor("a", ConsoleColor.Red);
                                ChangeColor("s", ConsoleColor.Magenta);
                                ChangeColor("t", ConsoleColor.Blue);
                                Console.Write(". \n");
                                return 10000;
                            }
                            if (element == MagicCannonElement.Ice)
                            {
                                ChangeColor("Fire", ConsoleColor.Red);
                                ChangeColor(" Storm", ConsoleColor.Yellow);
                                Console.Write($" + charge. \n");
                                return 750;
                            }
                            if (element == MagicCannonElement.Fire)
                            {
                                ChangeColor("Snow", ConsoleColor.Cyan);
                                ChangeColor(" Storm", ConsoleColor.Yellow);
                                Console.Write($" + charge. \n");
                                return 750;
                            }
                        }
                        //Triple element Storm (Crio, Hydro, fire)
                        if (cannonTurn % 3 == 0)
                        {
                            ChangeColor("Tripple Element", ConsoleColor.Magenta);
                            ChangeColor("Storm", ConsoleColor.Yellow);
                            Console.Write($" charge. \n");
                            return 450;
                        }
                        //Crio-Hydro
                        if (element == MagicCannonElement.Fire)
                        {
                            ChangeColor("Glacier", ConsoleColor.DarkCyan);
                            Console.Write($" + charge. \n");
                        }
                        //Blaze-Hydro
                        if (element == MagicCannonElement.Ice)
                        {
                            ChangeColor("Steam", ConsoleColor.DarkRed);
                            Console.Write($" + charge. \n");
                        }
                        return 100;
                    }
                    //Crio/Blaze and Thunder (and Crio Thunder fire)
                    if (cannonTurn % 5 == 0)
                    {
                        //tripple element shock (Crio, Thunder, fire)
                        if (cannonTurn % 3 == 0)
                        {
                            ChangeColor("Tripple Element ", ConsoleColor.Magenta);
                            ChangeColor("Shock", ConsoleColor.Yellow);
                            Console.Write($" charge. \n");
                            return 225;
                        }
                        //Blaze thunder
                        if (element == MagicCannonElement.Ice)
                        {
                            ChangeColor("Flash", ConsoleColor.Yellow);
                            Console.Write("-");
                            ChangeColor("Burn", ConsoleColor.Red);
                            Console.Write($" + charge. \n");
                        }
                        //crio thunder
                        if (element == MagicCannonElement.Fire)
                        {
                            ChangeColor("Flash", ConsoleColor.Yellow);
                            Console.Write("-");
                            ChangeColor("Freeze", ConsoleColor.Cyan);
                            Console.Write(" +");
                            Console.Write($" charge. \n");
                        }
                        return 50;
                    }
                    //Crio/Blase and Fire/Water
                    if (cannonTurn % 3 == 0)
                    {
                        ChangeColor("Frost", ConsoleColor.Cyan);
                        Console.Write("-");
                        ChangeColor("Burn", ConsoleColor.Red);
                        Console.Write($" Charge. \n");
                        return 30;
                    }

                    //Crio Charge
                    if (element == MagicCannonElement.Fire)
                    {
                        ChangeColor("Criogenic", ConsoleColor.DarkCyan);
                        Console.Write($" charge. \n");
                        return 15;
                    }
                    //Blaze Charge
                    if (element == MagicCannonElement.Ice)
                    {
                        ChangeColor("Blaze", ConsoleColor.DarkRed);
                        Console.Write($" charge. \n");
                        return 15;
                    }
                }
                //Any combination of Hydro Charges
                if (cannonTurn % 10 == 0)
                {
                    //hydro
                    if (cannonTurn % 5 == 0)
                    {
                        //thunder
                        if (cannonTurn % 3 == 0)
                        {
                            //fire/ice
                            if (element == MagicCannonElement.Fire)
                            {
                                //Hyrdo, Thunder, Fire
                                ChangeColor("Fire ", ConsoleColor.Red);
                                ChangeColor("Storm", ConsoleColor.Magenta);
                                Console.Write($" charge. \n");
                                return 150;
                            }
                            if (element == MagicCannonElement.Ice)
                            {
                                //Hyrdo, Thunder, Ice
                                ChangeColor("Snow ", ConsoleColor.Cyan);
                                ChangeColor("Storm", ConsoleColor.Magenta);
                                Console.Write($" charge. \n");
                                return 150;
                            }
                        }
                        //Thunder Hydro
                        ChangeColor("Storm", ConsoleColor.Magenta);
                        Console.Write($" charge. \n");
                        return 50;
                    }
                    //Hyrdo Fire/Ice combinations
                    if (cannonTurn % 3 == 0)
                    {
                        //Thunder Fire Charge
                        if (element == MagicCannonElement.Fire)
                        {
                            ChangeColor("Steam", ConsoleColor.DarkRed);
                            Console.Write($" charge. \n");
                            return 30;
                        }
                        //Thunder Ice Charge
                        if (element == MagicCannonElement.Ice)
                        {
                            ChangeColor("Glacier", ConsoleColor.DarkCyan);
                            Console.Write($" charge. \n");
                            return 30;
                        }
                    }
                    //Hydro charge
                    ChangeColor("Hydro", ConsoleColor.Blue);
                    Console.Write($" Charge. \n");
                    return 10;
                }
                //All level 3 Thunder Charges
                if (cannonTurn % 5 == 0)
                {
                    if (cannonTurn % 3 == 0)
                    {
                        //Double Fire charge
                        if (element == MagicCannonElement.Fire)
                        {
                            ChangeColor("Flash", ConsoleColor.Yellow);
                            Console.Write("-");
                            ChangeColor("Burn", ConsoleColor.Red);
                            Console.Write($" charge. \n");
                        }
                        if (element == MagicCannonElement.Ice)
                        {
                            //Double Charge Ice
                            ChangeColor("Flash", ConsoleColor.Yellow);
                            Console.Write("-");
                            ChangeColor("Freeze", ConsoleColor.Cyan);
                            Console.Write($" Charge. \n");
                        }
                        return 15;
                    }
                    //Thunder Charge
                    ChangeColor("Thunnder", ConsoleColor.Yellow);
                    Console.Write($" Charge. \n");
                    return 5;
                }
                //Level 2 Charges
                if (cannonTurn % 3 == 0)
                {
                    //Fire Charge
                    if (element == MagicCannonElement.Fire)
                    {
                        ChangeColor("Fire", ConsoleColor.Red);
                        Console.Write($" Charge. \n");
                        return 3;
                        //Ice charge
                    }
                    else if (element == MagicCannonElement.Ice)
                    {
                        ChangeColor("Frost", ConsoleColor.Cyan);
                        Console.Write($" Charge. \n");
                        return 3;
                    }
                }
                //Basic shot
                Console.Write("Basic charge \n");
                return 1;
            }
            return 0;
        }
        public static int BasicCannon(int level, cannonLocation location)
        {
            Console.Write($"The Basic Cannon at {location} Station is ready to fire. \n");
            if (level == 1)
            {
                return 1;
            }
            if (level == 2)
            {
                return 5;
            }
            if (level >= 3)
            {
                return 15;
            }
            return 0;
        }
        public static (int, (int, int)) AutoCannon(int level, List<(int, int)> enemyLocation, (int, int) cannonTarget, cannonLocation location)
        {
            Random random = new Random();
            int lenght = 0;
            bool hastarget = false;
            foreach ((int, int) thing in enemyLocation)
            {
                if (thing == cannonTarget)
                {
                    hastarget = true;
                }
                lenght++;
            }
            (int, int) target = (-50, -50);
            if (hastarget == false)
            {
                int ship1 = random.Next(0, lenght - 1);
                target = enemyLocation[ship1];
            }
            else
            {
                target = cannonTarget;
            }

            Console.Write($"The Auto Cannon at {location} Startion is ready to fire at:{target} \n");
            int damage = 0;
            if (level == 1)
            {
                damage = 1;
            }
            else if (level == 2)
            {
                damage = 2;
            }
            else if (level == 3)
            {
                damage = 3;
            }
            else if (level == 4)
            {
                damage = 5;
            }
            else if (level == 5)
            {
                damage = 15;
            }
            return (damage, target);
        }
        public static int InkCannon(int level, (int, int) target, List<(int, int)> enemyLocation)
        {
            int counter = 0;
            foreach ((int, int) thing in enemyLocation)
            {
                if (target == enemyLocation[counter])
                {
                    Console.Write($"An enemy was spotted at {enemyLocation[counter]}");
                }
                counter++;
            }
            if (level == 1)
            {
                return 3;
            }
            return 0;
        }
        public enum MagicCannonElement { Fire, Ice, Criogenic, Blaze }
        public enum cannonLocation { Left, Center, Right, Upper, Super }
        public enum cannonTypes { Basic, Magic, Auto, Ink, Super }
    }
    public class Text
    {
        static public void ChangeColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Other
    {
        public static (int, int) Targeting((int, int) target, cannonLocation id, bool changeTarget, bool hasCannon)
        {
            (int, int) newTarget;
            if (hasCannon == false)
            {
                //If the Player does not have this cannon yet just end
                Console.Write("You do not have this cannon yet \n");
                return (0, 0);
            }
            if (changeTarget == false)
            {
                if (target.Item1 <= -51 && target.Item2 <= -51)
                {
                    Console.Write($"The cannon at the {id} station has no target \n");
                }
                else
                {
                    Console.Write($"The cannon at the {id} station is targeting {target}");
                }
            }

            if (changeTarget == true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("What is the X cordanate you want to target?\n");
                        newTarget.Item1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("What is the Y cordanate you want to target?\n");
                        newTarget.Item2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"You are Now Targeting {newTarget}\n");
                        if (newTarget.Item1 > 50)
                        {
                            Console.Write("Your X is too big, please try again\n");
                        }
                        else if (newTarget.Item1 < -50)
                        {
                            Console.Write("Your X is too Small, please try again\n");
                        }
                        else if (newTarget.Item2 > 50)
                        {
                            Console.Write("Your Y is too big, please try again\n");
                        }
                        else if (newTarget.Item2 < -50)
                        {
                            Console.Write("Your Y is too Small, please try again\n");
                        }
                        else
                        {
                            return newTarget;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.Write("Please input a number \n");
                    }
                }
            }


            return (0, 0);
        }
        public static List<enemyTypes> GenerateEnemyStep1(int roundNumber){
            List<enemyTypes> newEnemys = new List<enemyTypes>();
            string[] fileStep1 = File.ReadAllLines("Enemys Tracker.txt");
            string[] fileStep2 = fileStep1[roundNumber - 1].Split(" ");
            try{
                int catapult  = Convert.ToInt32(fileStep2[0]);
                int airship   = Convert.ToInt32(fileStep2[1]);
                int Manticore = Convert.ToInt32(fileStep2[2]);
            }catch (FormatException){
                Console.Write("OOPS! We had a problem generating enemys");
            }catch (Exception){
                Console.Write("We had a general problem");
            }
            


            if (newEnemys.Count == 0){
                newEnemys.Add(enemyTypes.Default);
            }
            return newEnemys;
        }
        public static (int, int, enemyTypes) GenerateEnemyStep2(){

            return(1,1, enemyTypes.Default);
        }
        public enum enemyTypes { Default, Catapult, Airship, The_Manticore}   
    }

    public class Settings
    {
        public static void AdvancedCityHP(int[] cityPartsHp, int[] cannonHP)
        {
            ChangeColor("\nConsolas ", ConsoleColor.DarkBlue);
            ChangeColor("Main Wall: ", ConsoleColor.White);
            //Main Wall
            if (cityPartsHp[0] < 3)
            {
                ChangeColor($"{cityPartsHp[0]}", ConsoleColor.Red);
            }
            else if (cityPartsHp[0] <= 5)
            {
                ChangeColor($"{cityPartsHp[0]}", ConsoleColor.Yellow);
            }
            if (cityPartsHp[0] > 5)
            {
                ChangeColor($"{cityPartsHp[0]}", ConsoleColor.Green);
            }
            //Secondary wall
            ChangeColor("/10 ", ConsoleColor.White);
            ChangeColor("\nConsolas ", ConsoleColor.DarkBlue);
            ChangeColor("Secondary Wall: ", ConsoleColor.White);
            if (cityPartsHp[1] < 3)
            {
                ChangeColor($"{cityPartsHp[1]}", ConsoleColor.Red);
            }
            else if (cityPartsHp[1] <= 5)
            {
                ChangeColor($"{cityPartsHp[1]}", ConsoleColor.Yellow);
            }
            if (cityPartsHp[1] > 5)
            {
                ChangeColor($"{cityPartsHp[1]}", ConsoleColor.Green);
            }
            //City Center
            ChangeColor("/10 ", ConsoleColor.White);
            ChangeColor("\nConsolas ", ConsoleColor.DarkBlue);
            ChangeColor("City Center: ", ConsoleColor.White);
            if (cityPartsHp[2] < 2)
            {
                ChangeColor($"{cityPartsHp[2]}", ConsoleColor.Red);
            }
            else if (cityPartsHp[2] <= 3)
            {
                ChangeColor($"{cityPartsHp[2]}", ConsoleColor.Yellow);
            }
            if (cityPartsHp[2] > 3)
            {
                ChangeColor($"{cityPartsHp[2]}", ConsoleColor.Green);
            }
            ChangeColor("/5 ", ConsoleColor.White);
            //City Hp
            ChangeColor("\nConsolas ", ConsoleColor.DarkBlue);
            ChangeColor("Total Hp: ", ConsoleColor.White);
            int totalHp = 0;
            foreach (int thing in cityPartsHp)
            {
                totalHp = totalHp + thing;
            }
            if (totalHp > 15)
            {
                ChangeColor($"{totalHp}", ConsoleColor.Green);
            }
            else if (totalHp > 5)
            {
                ChangeColor($"{totalHp}", ConsoleColor.Yellow);
            }
            else
            {
                ChangeColor($"{totalHp}", ConsoleColor.Red);
            }
            ChangeColor("/25", ConsoleColor.White);

            //Upper cannon tower
            ChangeColor("\n  Upper Cannon Tower: ", ConsoleColor.White);
            if (cannonHP[3] < 2)
            {
                ChangeColor($"{cannonHP[3]}", ConsoleColor.Red);
            }
            else if (cannonHP[3] <= 3)
            {
                ChangeColor($"{cannonHP[3]}", ConsoleColor.Yellow);
            }
            if (cannonHP[3] > 3)
            {
                ChangeColor($"{cannonHP[3]}", ConsoleColor.Green);
            }
            ChangeColor("/5 ", ConsoleColor.White);
            //Right cannon tower
            ChangeColor("\n  Right Cannon Tower: ", ConsoleColor.White);
            if (cannonHP[2] < 2)
            {
                ChangeColor($"{cannonHP[2]}", ConsoleColor.Red);
            }
            else if (cannonHP[2] <= 3)
            {
                ChangeColor($"{cannonHP[2]}", ConsoleColor.Yellow);
            }
            if (cannonHP[2] > 3)
            {
                ChangeColor($"{cannonHP[2]}", ConsoleColor.Green);
            }
            ChangeColor("/5 ", ConsoleColor.White);
            //Center cannon tower
            ChangeColor("\n  Center Cannon Tower: ", ConsoleColor.White);
            if (cannonHP[1] < 2)
            {
                ChangeColor($"{cannonHP[1]}", ConsoleColor.Red);
            }
            else if (cannonHP[1] <= 3)
            {
                ChangeColor($"{cannonHP[1]}", ConsoleColor.Yellow);
            }
            if (cannonHP[1] > 3)
            {
                ChangeColor($"{cannonHP[1]}", ConsoleColor.Green);
            }
            ChangeColor("/5 ", ConsoleColor.White);
            //left cannon tower
            ChangeColor("\n  Left Cannon Tower: ", ConsoleColor.White);
            if (cannonHP[0] < 2)
            {
                ChangeColor($"{cannonHP[0]}", ConsoleColor.Red);
            }
            else if (cannonHP[0] <= 3)
            {
                ChangeColor($"{cannonHP[0]}", ConsoleColor.Yellow);
            }
            if (cannonHP[0] > 3)
            {
                ChangeColor($"{cannonHP[0]}", ConsoleColor.Green);
            }
            ChangeColor("/5 \n", ConsoleColor.White);
        }
        public static void BasicCityHp(int cityHP, int manHP)
        {
            ChangeColor("Consolas: ", ConsoleColor.DarkBlue);
            if (cityHP > 15)
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
            Console.Write($"/25 ");
        }
        public static void AdvancedEnemyHp(List<int> enemyHp)
        {
            int index = 0;
            Console.Write("\n");
            foreach (int thing in enemyHp)
            {
                Console.Write("Manticore: ");
                ChangeColor($"{enemyHp[index]}", ConsoleColor.Red);
                Console.Write("/10 \n");
                index++;
            }
        }
    }
}