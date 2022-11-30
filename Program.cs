using static cannon.Modes;
using static cannon.Text;
using static cannon.Other;

namespace MyApp {
internal class Program
{
    static void Main(string[] args)
    {
        (int,int) manPlace = shipPlacer(); /*locationAssignAndGuess(1);*/
        Console.Clear();
        e();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Defender Of Consolas ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"The City is under attack it is time to fight back! \n");
        battle(manPlace);
        
    }


    static void e()
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
    static (int,int) shipPlacer()
        {
            Random random = new Random();
            int ship1 = random.Next(-50, 51);
            int ship2 = random.Next(-50,51);
            return (ship1,ship2);
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
                Console.Write($"Press 1 change settings, or press 0 to advance. \n");
                input = Convert.ToInt32(Console.ReadLine());
                break;
            }catch{
                Console.WriteLine($"That is not a valid input");
            }
        }
        if (input == 1){
            while (true){
                try{
                    Console.Write($"1:Change Cannon Target \n2:Toggle Advanced HP view \n3:Toggle Advanced Enemy view \n4:Toggle extra missed shot guide \n5:Upgrade Cannons\n");
                    input = Convert.ToInt32(Console.ReadLine());
                    break;
                }catch{
                    Console.WriteLine($"That is not a valid input");
                }
            }
        }
        return input;
    } 
    static void radarPing(List<(int,int)> enemyPlacement, int index){
            changeColor("The Radar detected ",ConsoleColor.DarkGray);
            changeColor("The Manticore ",ConsoleColor.Red);
            changeColor("in the [",ConsoleColor.DarkGray);
            if(enemyPlacement[index].Item1 > 0){
                changeColor("+",ConsoleColor.Green);
            }
            if(enemyPlacement[index].Item1 < 0){
                changeColor("-",ConsoleColor.Red);
            }
            changeColor(",",ConsoleColor.DarkGray);
            if(enemyPlacement[index].Item2 > 0){
                changeColor("+",ConsoleColor.Green);
            }
            if(enemyPlacement[index].Item2 < 0){
                changeColor("-",ConsoleColor.Red);
            }
            changeColor("] quadrent \n",ConsoleColor.DarkGray);
    }
    static void battle((int,int) manPlace)
        {
            //Determin the power of magic cannon
            int cannonTurn = 1;
            //The Hp of the different parts of the city
            //{Main Wall, Secondary Wall, City Center}
            int cityHP = 25;
            int[] cityPartsHp = new int[3]{10,10,5};
            //All of the enemy settings
            List<(int,int)> enemyPlacement = new List<(int,int)>();
            List<int> enemyHp = new List<int>();
            /*Test the enemy location on the radar*/ 
                (int,int) imMad = (30,30); 
                enemyPlacement.Add(imMad); 
                enemyHp.Add(10);
                imMad = (-15,20);
                enemyPlacement.Add(imMad);
                enemyHp.Add(10);
            

            int manHP = 10;
            //to determin what the player is doing
            int playerChoise;
            //The Cannon Data 
            //{left,center,right,upper,super}
            bool[] hasCannon = new bool[] {false,false,true,false,false}; 
            /*DON'T CHANGE*/cannonLocation[] cannonLookup = new cannonLocation[] {cannonLocation.Left,cannonLocation.Center,cannonLocation.Right,cannonLocation.Upper,cannonLocation.Super};
            (int,int)[] cannonTarget = new (int,int)[] {(0,0),(0,0),(0,0),(0,0),(0,0)};
            int[] cannonHP = new int[] {5,5,5,5,0};
            int[] cannonLevel = new int[] {1,1,2,1,0};
            cannonTypes[] curentCannonType = new cannonTypes[] {cannonTypes.Basic,cannonTypes.Basic,cannonTypes.Basic,cannonTypes.Basic};
            int[] cannonDamage = new int[] {0,0,0,0};
            //settings {City HP, Enemy HP view, Extra Missed Shot guide}
            bool[] viewSettings = new bool[] {false,false,true};
            int upgradePoints = 0;
            Random random = new Random();
            int damage = 0;

            //This is where the game loop starts
            while (cityHP > 0 && manHP > 0)
            {
                //this is the first line, the ones that displasy the health of consolas and the mantacore.
                //this is if advancced Hp view is not checked
                Console.WriteLine($"----------------------------------------");
                Console.Write($"Status: Round: {cannonTurn} ");
                if (viewSettings[0] == false){
                    //Veiw City Hp basic
                    changeColor("Consolas: ",ConsoleColor.DarkBlue);
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
                
                    changeColor("Manticore: ",ConsoleColor.Red);
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
                //This group is what displays when advanced hp is true
                if (viewSettings[0] == true){
                    //Veiw city hp advanced
                    changeColor("\nConsolas ",ConsoleColor.DarkBlue);
                    changeColor("Main Wall: ",ConsoleColor.White);
                    //Main Wall
                    if(cityPartsHp[0] < 3){
                        changeColor($"{cityPartsHp[0]}",ConsoleColor.Red);
                    }else if(cityPartsHp[0] <= 5){
                        changeColor($"{cityPartsHp[0]}",ConsoleColor.Yellow);
                    }if(cityPartsHp[0] > 5){
                        changeColor($"{cityPartsHp[0]}",ConsoleColor.Green);
                    }
                    //Secondary wall
                    changeColor("/10 ",ConsoleColor.White);
                    changeColor("\nConsolas ",ConsoleColor.DarkBlue);
                    changeColor("Secondary Wall: ",ConsoleColor.White);
                    if(cityPartsHp[1] < 3){
                        changeColor($"{cityPartsHp[1]}",ConsoleColor.Red);
                    }else if(cityPartsHp[1] <= 5){
                        changeColor($"{cityPartsHp[1]}",ConsoleColor.Yellow);
                    }if(cityPartsHp[1] > 5){
                        changeColor($"{cityPartsHp[1]}",ConsoleColor.Green);
                    }
                    //City Center
                    changeColor("/10 ",ConsoleColor.White);
                    changeColor("\nConsolas ",ConsoleColor.DarkBlue);
                    changeColor("City Center: ",ConsoleColor.White);
                    if(cityPartsHp[2] < 2){
                        changeColor($"{cityPartsHp[2]}",ConsoleColor.Red);
                    }else if(cityPartsHp[2] <= 3){
                        changeColor($"{cityPartsHp[2]}",ConsoleColor.Yellow);
                    }if(cityPartsHp[2] > 3){
                        changeColor($"{cityPartsHp[2]}",ConsoleColor.Green);
                    }
                    changeColor("/5 ",ConsoleColor.White);
                    //City Hp
                    changeColor("\nConsolas ",ConsoleColor.DarkBlue);
                    changeColor("Total Hp: ",ConsoleColor.White);
                    int totalHp = 0;
                    foreach(int thing in cityPartsHp){
                        totalHp = totalHp + thing;
                    }
                    if(totalHp > 15){
                        changeColor($"{totalHp}",ConsoleColor.Green);
                    }else if(totalHp > 5){
                        changeColor($"{totalHp}",ConsoleColor.Yellow);
                    }else{
                        changeColor($"{totalHp}",ConsoleColor.Red);
                    }
                    changeColor("/25",ConsoleColor.White);

                    //Upper cannon tower
                    changeColor("\n  Upper Cannon Tower: ",ConsoleColor.White);
                    if(cannonHP[3] < 2){
                        changeColor($"{cannonHP[3]}",ConsoleColor.Red);
                    }else if(cannonHP[3] <= 3){
                        changeColor($"{cannonHP[3]}",ConsoleColor.Yellow);
                    }if(cannonHP[3] > 3){
                        changeColor($"{cannonHP[3]}",ConsoleColor.Green);
                    }
                    changeColor("/5 ",ConsoleColor.White);
                    //Right cannon tower
                    changeColor("\n  Right Cannon Tower: ",ConsoleColor.White);
                    if(cannonHP[2] < 2){
                        changeColor($"{cannonHP[2]}",ConsoleColor.Red);
                    }else if(cannonHP[2] <= 3){
                        changeColor($"{cannonHP[2]}",ConsoleColor.Yellow);
                    }if(cannonHP[2] > 3){
                        changeColor($"{cannonHP[2]}",ConsoleColor.Green);
                    }
                    changeColor("/5 ",ConsoleColor.White);
                    //Center cannon tower
                    changeColor("\n  Center Cannon Tower: ",ConsoleColor.White);
                    if(cannonHP[1] < 2){
                        changeColor($"{cannonHP[1]}",ConsoleColor.Red);
                    }else if(cannonHP[1] <= 3){
                        changeColor($"{cannonHP[1]}",ConsoleColor.Yellow);
                    }if(cannonHP[1] > 3){
                        changeColor($"{cannonHP[1]}",ConsoleColor.Green);
                    }
                    changeColor("/5 ",ConsoleColor.White);
                    //left cannon tower
                    changeColor("\n  Left Cannon Tower: ",ConsoleColor.White);
                    if(cannonHP[0] < 2){
                        changeColor($"{cannonHP[0]}",ConsoleColor.Red);
                    }else if(cannonHP[0] <= 3){
                        changeColor($"{cannonHP[0]}",ConsoleColor.Yellow);
                    }if(cannonHP[0] > 3){
                        changeColor($"{cannonHP[0]}",ConsoleColor.Green);
                    }
                    changeColor("/5 \n",ConsoleColor.White);


                    //The Manticore
                    changeColor("Manticore: ",ConsoleColor.Red);
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

                //this is the second line where we show what state the cannon is at.
                //as well as what cordanents that are being targeted.
                //Index is used for all for each loops to help cycle trough all indexes in the array
                int index = 0;
                int index2 = 0;
                foreach (bool thing in hasCannon){
                    if(hasCannon[index] == true && cannonHP[index] > 0){
                        //Currently this only checks if the cannon is a magic cannon type
                        if (curentCannonType[index] == cannonTypes.Magic){
                            //outputs cannon damage baised on the cannon's level and the turn number and stores it in the damage array
                            cannonDamage[index] = MagicCannon(cannonTurn, cannonLevel[index], MagicCannonElement.Fire, cannonLookup[index]);
                        }
                        if (curentCannonType[index] == cannonTypes.Basic){
                            cannonDamage[index] = BasicCannon(cannonLevel[index], cannonLookup[index]);
                        }
                        Console.Write($"Target: {cannonTarget[index]}   \n");
                    }
                    index++;
                }

                //The Radar ping showing where the manticore is
                index = 0;
                foreach((int,int) thing in enemyPlacement){
                    radarPing(enemyPlacement,index);
                    index++;
                }
                

                //the player does something
                playerChoise = takeinput();



                //Advanced Hp
                if (playerChoise == 2){
                    if (viewSettings[0] == true){
                        viewSettings[0] = false;
                    }else{
                    viewSettings[0] = true;
                    }
                    playerChoise = takeinput();
                }
                //Enemy View
                if (playerChoise == 3){
                    if (viewSettings[1] == true){
                        viewSettings[1] = false;
                    }else{
                    viewSettings[1] = true;
                    }
                    playerChoise = takeinput();
                }
                //Extra Missed Sot guide
                if (playerChoise == 4){
                    if (viewSettings[2] == true){
                        viewSettings[2] = false;
                    }else{
                    viewSettings[2] = true;
                    }
                    playerChoise = takeinput();
                }

                //Upgrade Cannons
                if (playerChoise == 5){
                    while(true){
                        try{
                            int cost = 0;
                            Console.Write($"You have ");
                            changeColor($"{upgradePoints}",ConsoleColor.Blue);
                            changeColor(" Upgrade Points",ConsoleColor.Yellow);
                            Console.Write(" what would you like to upgrade? \n");
                            index = 0;
                            foreach(cannonLocation thing in cannonLookup){
                                //If it has a show what cannon has, else say empty
                                Console.Write($" {index+1}:");
                                if(hasCannon[index] == true){
                                    //basic cannons show up as white can only go to level three
                                    if(curentCannonType[index] == cannonTypes.Basic){
                                        if (cannonLevel[index] <= 2){
                                            Console.Write($"Basic, Level:{cannonLevel[index]}     (Level Up:{Math.Pow(cannonLevel[index],2)*5})(Upgrade:(Magic:{(Math.Pow(cannonLevel[index],2)*5)*2}|Ink:??|) \n");
                                        }else{
                                            Console.Write($"Basic, Level:{cannonLevel[index]}     (Upgrade(Magic:??|Ink:??|) \n");
                                        } 
                                    }
                                    if(curentCannonType[index] == cannonTypes.Magic){
                                        //Change color of the word magic depending on level
                                        if(cannonLevel[index] <= 2){
                                            changeColor("Magic",ConsoleColor.DarkMagenta);
                                        }else if (cannonLevel[index] > 2){
                                            changeColor("Magic",ConsoleColor.Magenta);
                                        }
                                        Console.Write($", Level:{cannonLevel[index]}     (Level Up:{Math.Pow((cannonLevel[index]+1),3)*4}) \n");
                                        
                                    }
                                }else{
                                    changeColor("Empty  Station",ConsoleColor.DarkGray);
                                    Console.Write("     (Basic:1)\n");
                                }
                                index++;
                            }
                            playerChoise = Convert.ToInt32(Console.ReadLine());
                        }catch(FormatException){
                            Console.WriteLine($"That is not a valid input");
                        }
                    }
                }

                //The Player Selects to change the target of a cannon
                if (playerChoise == 1){
                    while(true){
                        try{
                            Console.Write($"Which cannon do you want to change? \n 0:finish \n");
                            int selectNumber = 1;
                            int increment = 0;
                            foreach(bool entry in hasCannon){
                                if(entry == true){
                                    changeColor($" {selectNumber}:{cannonLookup[increment]} \n",ConsoleColor.White);
                                }else{
                                    changeColor($" {selectNumber}:{cannonLookup[increment]} \n",ConsoleColor.DarkGray);
                                }
                                selectNumber++;
                                increment++;
                            }
                            playerChoise = Convert.ToInt32(Console.ReadLine());
                            cannonLocation wichCannonDoYouWantToChange = cannonLocation.Left;
                            switch (playerChoise){
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
                            if (playerChoise != 0){
                                Targeting(cannonTarget[playerChoise-1],wichCannonDoYouWantToChange,false,hasCannon[playerChoise-1]);
                                if(hasCannon[playerChoise-1] == true){
                                    (int,int) newCannonTarget = Targeting((0,0),wichCannonDoYouWantToChange,true,true);
                                    cannonTarget[playerChoise-1] = newCannonTarget;
                                }
                            }else{
                                break;
                            }
                        }catch (FormatException){
                            Console.WriteLine($"That is not a valid input");
                        }
                    }
                }

                

                
                Console.Write($"---------------------------------------- \n");
                //This is the line where we determin if the cannon hit.
                index = 0;
                foreach((int,int) entry in cannonTarget){
                    //The "If" checks if a cannon exists and has more that 0 hp for the selected area
                    if(hasCannon[index] == true && cannonHP[index] > 0){
                        bool[] shotRelitiveToEnemy = new bool[4] {false,false,false,false};
                        Console.Write($"{cannonLookup[index]} cannon's round ");
                        index2 = 0;
                        foreach((int,int)thing in enemyPlacement){
                            if (enemyPlacement[index2] == entry)
                            {
                                Console.Write("was a ");
                                changeColor("Direct Hit",ConsoleColor.Magenta);
                                Console.Write("!");
                                Console.Write($" This did {cannonDamage[index]} Damage! \n");
                                enemyHp[index2] = enemyHp[index2] - cannonDamage[index];
                            }

                            if (enemyPlacement[index2].Item1 > entry.Item1)
                            {
                                changeColor("fell to the left",ConsoleColor.DarkYellow);
                                //Console.Write(" of ");
                                //changeColor("The Manticore",ConsoleColor.DarkRed);
                                //Console.Write(". \n");
                                shotRelitiveToEnemy[0] = true;
                            }

                            if (enemyPlacement[index2].Item1 < entry.Item1)
                            {
                                changeColor("fell to the right",ConsoleColor.DarkYellow);
                                //Console.Write(" of ");
                                //changeColor("The Manticore",ConsoleColor.DarkRed);
                                //Console.Write(". \n");
                                shotRelitiveToEnemy[1] = true;
                            }
                            Console.Write(" and ");
                            if (enemyPlacement[index2].Item2 > entry.Item2)
                            {
                                changeColor("fell short", ConsoleColor.DarkYellow);
                                Console.Write(" of ");
                                changeColor(" The Manticore", ConsoleColor.DarkRed);
                                Console.Write(". \n");
                                shotRelitiveToEnemy[2] = true;
                            }
                            
                            if (enemyPlacement[index2].Item2 < entry.Item2)
                            {
                                changeColor("overshot", ConsoleColor.DarkYellow);
                                changeColor(" The Manticore", ConsoleColor.DarkRed);
                                Console.Write(". \n");
                                shotRelitiveToEnemy[3] = true;
                            }

                            if (damage == 10000)
                            {
                                enemyHp[index2] = 0;
                            }
                        
                            //Show the relitive possition of the missed shot
                            if (viewSettings[2] == true){
                                if(shotRelitiveToEnemy[0] == true){
                                    if(shotRelitiveToEnemy[3] == true){
                                        changeColor(" *",ConsoleColor.Green);
                                        changeColor("\n  M\n",ConsoleColor.Red); 
                                    }else if(shotRelitiveToEnemy[2] == true){
                                        changeColor("  M",ConsoleColor.Red);
                                        changeColor("\n *\n",ConsoleColor.Green);
                                    }else{
                                        changeColor(" *",ConsoleColor.Green);
                                        changeColor("M\n",ConsoleColor.Red);
                                    }
                                }else if(shotRelitiveToEnemy[1] == true){
                                    if(shotRelitiveToEnemy[3] == true){
                                        changeColor("   *",ConsoleColor.Green);
                                        changeColor("\n  M\n",ConsoleColor.Red);
                                    }else if(shotRelitiveToEnemy[2] == true){
                                        changeColor("  M",ConsoleColor.Red);
                                        changeColor("\n   *\n",ConsoleColor.Green);
                                    }else{
                                        changeColor(" M",ConsoleColor.Red);
                                        changeColor("*\n",ConsoleColor.Green);
                                    }
                                }else if(shotRelitiveToEnemy[2]==true){
                                    changeColor("  M",ConsoleColor.Red);
                                    changeColor("\n  *\n",ConsoleColor.Green);
                                }else if(shotRelitiveToEnemy[3]==true){
                                    changeColor("  *",ConsoleColor.Green);
                                    changeColor("\n  M\n",ConsoleColor.Red);
                                }
                            }
                        }
                    }
                    index++;
                }




                cannonTurn++;
                // The Manticore strikes back
                if (manHP > 0)
                {
                    int hit = random.Next(1,6);
                    int cHit = random.Next(0,3);
                    if (cityPartsHp[0] != 0)
                    {
                        switch(hit){
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
                    else if(cityPartsHp[1] != 0)
                    {
                        switch(hit){
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
                        switch(hit){
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
                    foreach (int part in cityPartsHp){
                        cityHP = part + cityHP;
                    }

                }
            }


            if (manHP <= 0 && cityHP <= 0)
            {
                Console.Write("The wall of ");
                changeColor("Consolas ",ConsoleColor.DarkBlue);
                Console.Write("Was destroyed. But at least so was ");
                changeColor("The Manticore",ConsoleColor.DarkRed);
                Console.Write(".");
            }
            else if (manHP <= 0)
            {
                changeColor("Congradulations!",ConsoleColor.Green);
                Console.Write(" You destroyed ");
                changeColor("The Manticore",ConsoleColor.DarkRed);
                Console.Write(", the city of ");
                changeColor("Consolas ",ConsoleColor.DarkBlue);
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