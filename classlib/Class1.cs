using static Utilities.Text;



namespace classlib;

public class ScreenDisplay{
    ConsoleColor ScreenColor = ConsoleColor.White;
    public int[][] displayArray = new int[11][]{
        new int[]{9,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,9,10},
        new int[]{7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,10},
        new int[]{7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,10},
        new int[]{7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,10},
        new int[]{7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,10},
        new int[]{7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,10},
        new int[]{7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,10},
        new int[]{7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,10},
        new int[]{7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,10},
        new int[]{7,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,7,10},
        new int[]{9,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,8,9,10}
    };
    


    public void display(){
        Console.Clear();
        string[] displayArray = new string[]
        {$"+------------------------------------------------+",
         $"|                                                |",
         $"|                                                |",
         $"|                                                |",
         $"|                                                |",
         $"|                                                |",
         $"|                                                |",
         $"|                                                |",
         $"|                                                |",
         $"|                                                |",
         $"+------------------------------------------------+"};
        int increment = 0;
        foreach(string thing in displayArray)
        {
            Console.WriteLine(displayArray[increment]);
            increment++;
        }
    }
    public void AdvancedDisplay(Player player){
        Console.Clear();
        
        
        int increment1 = 0;
        int increment2 = 0;
        displayArray[player.CurrentLocation.Item2][player.CurrentLocation.Item1] = 1;
        foreach(int[] thing in displayArray)
        {
            foreach(int thinger in thing)
            {
                if (increment2 < 51){
                switch(displayArray[increment1][increment2]){
                    case 10:
                    Console.Write("\n");
                    break;
                    case 9:
                    Console.Write("+");
                    break;
                    case 8:
                    Console.Write("-");
                    break;
                    case 7:
                    Console.Write("|");
                    break;
                    case 1:
                    ChangeTextColor2("0",ConsoleColor.Yellow);
                    break;
                    case 0:
                    Console.Write(" ");
                    break;
                    default:
                    Console.Write("E");
                    break;                    
                }
                }
                increment2++;
            }
            increment1++;
            increment2 = 0;
        }
        displayArray[player.CurrentLocation.Item2][player.CurrentLocation.Item1] = 0;
        Console.WriteLine($"{player.CurrentLocation.Item1},{player.CurrentLocation.Item2}");
    }
}

public class Player{
    public Player((int,int)Spawn){
        SpawnLocation = Spawn;
        CurrentLocation = Spawn;
    }
    public Player(){
        SpawnLocation = (1,1);
        CurrentLocation = (1,1);
    }
    public (int,int) SpawnLocation;
    public (int,int) CurrentLocation;
    public void MoveLeft()
    {
        if(CheckLeftWall() == false){
        CurrentLocation.Item1--;
        Fall();
        }
    }
    public void MoveRight()
    {
        if(CheckRightWall() == false){
        CurrentLocation.Item1++;
        Fall();
        }
    }
    public void Jump()
    {
        if(CheckRoof() == false){
            CurrentLocation.Item2--;
        }
        if(CheckRoof() == false){
            CurrentLocation.Item2--;
        }
        
    }
    
    public void Fall(){
        if(CheckFloor() == false){
            CurrentLocation.Item2++;
        }
    }
    private bool CheckLeftWall(){
        if (CurrentLocation.Item1 - 1 < 1){
            return true;
        }else{
            return false;
        }
    }
    private bool CheckRightWall(int rightWall = 48){
        if (CurrentLocation.Item1 + 1 > rightWall){
            return true;
        }else{
            return false;
        }
    }
    private bool CheckFloor(int floor = 9){
        if (CurrentLocation.Item2 + 1 > floor){
            return true;
        }else{
            return false;
        }
    }
    private bool CheckRoof(){
        if (CurrentLocation.Item2 <= 1){
            return true;
        }else{
            return false;
        }
    }

}


