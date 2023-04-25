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
        
    }
    public void MoveRight()
    {

    }
    public void Jump()
    {

    }
}