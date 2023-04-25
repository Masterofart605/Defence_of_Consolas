using static Utilities.Text;



namespace classlib;

public class ScreenDisplay{
    ConsoleColor ScreenColor = ConsoleColor.White;
    
    
    


    public void display(){
        Console.Clear();
        string[] displayArray = new string[]
        {$"+-----------------------------------------------+",
         $"|                                               |",
         $"|                                               |",
         $"|                                               |",
         $"|                                               |",
         $"|                                               |",
         $"|                                               |",
         $"|                                               |",
         $"|                                               |",
         $"|                                               |",
         $"+-----------------------------------------------+"};
        int increment = 0;
        foreach(string thing in displayArray)
        {
            Console.WriteLine(displayArray[increment]);
            increment++;
        }
    }
}

public class Player{
    public (int,int) SpawnLocation = (0,0);
    public (int,int) CurrentLocation = (0,0);
    public void MoveLeft()
    {
        if(CheckIfNegativeOutOfBounds() == false){
        CurrentLocation = (CurrentLocation.Item1-1,CurrentLocation.Item2);
        }
    }
    public void MoveRight()
    {
        CurrentLocation = (CurrentLocation.Item1+1,CurrentLocation.Item2);  
    }
    public void Jump()
    {

    }
    private bool CheckIfNegativeOutOfBounds(){
        if (CurrentLocation.Item1 - 1 <= -1){
            return true;
        }else if (CurrentLocation.Item2 <= -1){
            return true;
        }else{
            return false;
        }
    }
}


