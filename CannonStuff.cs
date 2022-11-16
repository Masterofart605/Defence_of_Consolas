using static cannon.Modes;
using static cannon.Text;


namespace cannon
{
    public class Modes
    {
        public static int MagicCannon(int cannonTurn, int level, cannonElement element, cannonLocation location)
        {
            Console.Write($"The Cannon at {location} Station has a ");//basic charge...
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
                    if (element == cannonElement.Fire)
                    {
                        changeColor("Fire",ConsoleColor.Red);
                        Console.Write($" Charge. \n");
                        return 3;
                        //Ice charge
                    }
                    else if (element == cannonElement.Ice)
                    {
                        changeColor("Frost",ConsoleColor.Cyan);
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
                    if (element == cannonElement.Fire)
                    {
                        changeColor("Flash",ConsoleColor.Yellow);
                        Console.Write("-");
                        changeColor("Burn",ConsoleColor.Red);
                        Console.Write($" charge. \n");
                    }
                    else
                    {
                        //Double Charge Ice
                        changeColor("Flash",ConsoleColor.Yellow);
                        Console.Write("-");
                        changeColor("Freeze",ConsoleColor.Cyan);
                        Console.Write($" charge. \n");
                    }
                    return 15;
                    //Thunder Charge
                }
                else if (cannonTurn % 5 == 0)
                {
                    changeColor("Thunder",ConsoleColor.Yellow);
                    Console.Write($" Charge. \n");
                    return 5;
                    //Fire/Ice charge
                }
                else if (cannonTurn % 3 == 0)
                {
                    //Fire charge
                    if (element == cannonElement.Fire)
                    {
                        changeColor("Fire",ConsoleColor.Red);
                        Console.Write($" Charge. \n");
                        return 3;
                        //Ice charge
                    }
                    else
                    {
                        changeColor("Frost",ConsoleColor.Cyan);
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
                            if (element == cannonElement.Fire)
                            {
                                //Hyrdo, Thunder, Fire
                                changeColor("Fire ",ConsoleColor.Red);
                                changeColor("Storm",ConsoleColor.Magenta);
                                Console.Write($" charge. \n");
                                return 150;
                            }
                            if (element == cannonElement.Ice)
                            {
                                //Hyrdo, Thunder, Ice
                                changeColor("Snow",ConsoleColor.Cyan);
                                changeColor(" Storm",ConsoleColor.Magenta);
                                Console.Write($" charge. \n");
                                return 150;
                            }
                        }
                        //Thunder Hydro
                        changeColor("Storm",ConsoleColor.Magenta);
                        Console.Write($" charge. \n");
                        return 50;
                    }
                    //Hyrdo Fire/Ice combinations
                    if (cannonTurn % 3 == 0)
                    {
                        //Thunder Fire Charge
                        if (element == cannonElement.Fire)
                        {
                            changeColor("Steam",ConsoleColor.DarkRed);
                            Console.Write($" charge. \n");
                            return 30;
                        }
                        //Thunder Ice Charge
                        if (element == cannonElement.Ice)
                        {
                            changeColor("Glacier",ConsoleColor.DarkCyan);
                            Console.Write($" charge. \n");
                            return 30;
                        }
                    }
                    //Hydro charge
                    changeColor("Hydro",ConsoleColor.Blue);
                    Console.Write($" Charge. \n");
                    return 10;
                }
                //All level 3 Thunder Charges
                if (cannonTurn % 5 == 0)
                {
                    if (cannonTurn % 3 == 0)
                    {
                        //Double Fire charge
                        if (element == cannonElement.Fire)
                        {
                            changeColor("Flash",ConsoleColor.Yellow);
                            Console.Write("-");
                            changeColor("Burn",ConsoleColor.Red);
                            Console.Write($" charge. \n");
                        }
                        if (element == cannonElement.Ice)
                        {
                            //Double Charge Ice
                            changeColor("Flash",ConsoleColor.Yellow);
                            Console.Write("-");
                            changeColor("Freeze",ConsoleColor.White);
                            Console.Write($" charge. \n");
                        }
                        return 15;
                    }
                    //Thunder Charge
                    changeColor("Thunder",ConsoleColor.Yellow);
                    Console.Write($" Charge. \n");
                    return 5;
                }
                //Level 2 Charges
                if (cannonTurn % 3 == 0)
                {
                    //Fire Charge
                    if (element == cannonElement.Fire)
                    {
                        changeColor("Fire",ConsoleColor.Red);
                        Console.Write($" Charge. \n");
                        return 3;
                        //Ice charge
                    }
                    else if (element == cannonElement.Ice)
                    {
                        changeColor("Frost",ConsoleColor.Cyan);
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
                                changeColor("F",ConsoleColor.Blue);
                                changeColor("i",ConsoleColor.Cyan);
                                changeColor("n",ConsoleColor.Green);
                                changeColor("a",ConsoleColor.Yellow);
                                changeColor("l",ConsoleColor.Red);
                                changeColor("i",ConsoleColor.Magenta);
                                changeColor("t",ConsoleColor.Blue);
                                changeColor("y",ConsoleColor.Cyan);
                                changeColor(" B",ConsoleColor.Green);
                                changeColor("l",ConsoleColor.Yellow);
                                changeColor("a",ConsoleColor.Red);
                                changeColor("s",ConsoleColor.Magenta);
                                changeColor("t",ConsoleColor.Blue);
                                Console.Write(". \n");
                                return 10000;
                            }
                            if (element == cannonElement.Ice)
                            {
                                changeColor("Fire",ConsoleColor.Red);
                                changeColor(" Storm",ConsoleColor.Yellow);
                                Console.Write($" + charge. \n");
                                return 750;
                            }
                            if (element == cannonElement.Fire)
                            {
                                changeColor("Snow",ConsoleColor.Cyan);
                                changeColor(" Storm",ConsoleColor.Yellow);
                                Console.Write($" + charge. \n");
                                return 750;
                            }
                        }
                        //Triple element Storm (Crio, Hydro, fire)
                        if (cannonTurn % 3 == 0)
                        {
                            changeColor("Tripple Element",ConsoleColor.Magenta);
                            changeColor("Storm",ConsoleColor.Yellow);
                            Console.Write($" charge. \n");
                            return 450;
                        }
                        //Crio-Hydro
                        if (element == cannonElement.Fire)
                        {
                            changeColor("Glacier",ConsoleColor.DarkCyan);
                            Console.Write($" + charge. \n");
                        }
                        //Blaze-Hydro
                        if (element == cannonElement.Ice)
                        {
                            changeColor("Steam",ConsoleColor.DarkRed);
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
                            changeColor("Tripple Element ",ConsoleColor.Magenta);
                            changeColor("Shock",ConsoleColor.Yellow);
                            Console.Write($" charge. \n");
                            return 225;
                        }
                        //Blaze thunder
                        if (element == cannonElement.Ice)
                        {
                            changeColor("Flash",ConsoleColor.Yellow);
                            Console.Write("-");
                            changeColor("Burn",ConsoleColor.Red);
                            Console.Write($" + charge. \n");
                        }
                        //crio thunder
                        if (element == cannonElement.Fire)
                        {
                            changeColor("Flash",ConsoleColor.Yellow);
                            Console.Write("-");
                            changeColor("Freeze",ConsoleColor.Cyan);
                            Console.Write(" +");
                            Console.Write($" charge. \n");
                        }
                        return 50;
                    }
                    //Crio/Blase and Fire/Water
                    if (cannonTurn % 3 == 0)
                    {
                        changeColor("Frost",ConsoleColor.Cyan);
                        Console.Write("-");
                        changeColor("Burn",ConsoleColor.Red);
                        Console.Write($" Charge. \n");
                        return 30;
                    }

                    //Crio Charge
                    if (element == cannonElement.Fire)
                    {
                        changeColor("Criogenic",ConsoleColor.DarkCyan);
                        Console.Write($" charge. \n");
                        return 15;
                    }
                    //Blaze Charge
                    if (element == cannonElement.Ice)
                    {
                        changeColor("Blaze",ConsoleColor.DarkRed);
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
                            if (element == cannonElement.Fire)
                            {
                                //Hyrdo, Thunder, Fire
                                changeColor("Fire ",ConsoleColor.Red);
                                changeColor("Storm",ConsoleColor.Magenta);
                                Console.Write($" charge. \n");
                                return 150;
                            }
                            if (element == cannonElement.Ice)
                            {
                                //Hyrdo, Thunder, Ice
                                changeColor("Snow ",ConsoleColor.Cyan);
                                changeColor("Storm",ConsoleColor.Magenta);
                                Console.Write($" charge. \n");
                                return 150;
                            }
                        }
                        //Thunder Hydro
                        changeColor("Storm",ConsoleColor.Magenta);
                        Console.Write($" charge. \n");
                        return 50;
                    }
                    //Hyrdo Fire/Ice combinations
                    if (cannonTurn % 3 == 0)
                    {
                        //Thunder Fire Charge
                        if (element == cannonElement.Fire)
                        {
                            changeColor("Steam",ConsoleColor.DarkRed);
                            Console.Write($" charge. \n");
                            return 30;
                        }
                        //Thunder Ice Charge
                        if (element == cannonElement.Ice)
                        {
                            changeColor("Glacier",ConsoleColor.DarkCyan);
                            Console.Write($" charge. \n");
                            return 30;
                        }
                    }
                    //Hydro charge
                    changeColor("Hydro",ConsoleColor.Blue);
                    Console.Write($" Charge. \n");
                    return 10;
                }
                //All level 3 Thunder Charges
                if (cannonTurn % 5 == 0)
                {
                    if (cannonTurn % 3 == 0)
                    {
                        //Double Fire charge
                        if (element == cannonElement.Fire)
                        {
                            changeColor("Flash",ConsoleColor.Yellow);
                            Console.Write("-");
                            changeColor("Burn",ConsoleColor.Red);
                            Console.Write($" charge. \n");
                        }
                        if (element == cannonElement.Ice)
                        {
                            //Double Charge Ice
                            changeColor("Flash",ConsoleColor.Yellow);
                            Console.Write("-");
                            changeColor("Freeze",ConsoleColor.Cyan);
                            Console.Write($" Charge. \n");
                        }
                        return 15;
                    }
                    //Thunder Charge
                    changeColor("Thunnder",ConsoleColor.Yellow);
                    Console.Write($" Charge. \n");
                    return 5;
                }
                //Level 2 Charges
                if (cannonTurn % 3 == 0)
                {
                    //Fire Charge
                    if (element == cannonElement.Fire)
                    {
                        changeColor("Fire",ConsoleColor.Red);
                        Console.Write($" Charge. \n");
                        return 3;
                        //Ice charge
                    }
                    else if (element == cannonElement.Ice)
                    {
                        changeColor("Frost",ConsoleColor.Cyan);
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
        public enum cannonElement {Fire, Ice, Criogenic, Blaze}
        public enum cannonLocation {Left, Center, Right, Upper}
    }
    public class Text{
        static public void changeColor(string text, ConsoleColor color){
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
     }
     public class Other{
        public static (int,int) Targeting((int,int) target, cannonLocation id, bool changeTarget, bool hasCannon){
            (int,int) newTarget;
            if (hasCannon == false){
                //If the Player does not have this cannon yet just end
                Console.Write("You do not have this cannon yet \n");
                return (0,0);
            }
            if (changeTarget ==  false){
                if (target.Item1 <= -51 && target.Item2 <= -51){
                    Console.Write($"The cannon at the {id} station has no target \n");
                }else{
                    Console.Write($"The cannon at the {id} station is targeting {target}");
                }
            }

            if (changeTarget == true){
                while(true){
                    try{
                        Console.Write("What is the X cordanate you want to target?\n");
                        newTarget.Item1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("What is the Y cordanate you want to target?\n");
                        newTarget.Item2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write($"You are Now Targeting {newTarget}\n");
                        if((newTarget.Item1 > 50 || newTarget.Item1 > 50) || (newTarget.Item1 < -50 || newTarget.Item2 < -50)){
                            Console.Write("One of your numbers is larger that 50 or smaller than -50 please try again\n");
                        }else{
                            return newTarget;
                        }
                    }catch (FormatException){
                        Console.Write("Please input a number \n");
                    }
                }
            }


            return (0,0);
        }
     }
    
}