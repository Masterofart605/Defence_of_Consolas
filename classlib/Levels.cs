using classlib;

// public class Obstical
// {
//     public (int, int) location;
//     public passable canItBePassedThrough;
// }


public class Wall
{
    public passable canItBePassedThrough = passable.No;
}
/// <summary>Floors that can be stood on. </summary>
public class Platform
{
    public (int,int) location;
    public passable canItBePassedThrough = passable.No;
}

public class FloorSpikes
{
    public passable canItBePassedThrough = passable.No;
}

public class Level
{
    Level(Player player){

    }
    List<Platform> AllPlatforms;
    public int[][] LevelMap;
    public void AddPlatform(Platform newPlatform){
        AllPlatforms.Add(newPlatform);
    }
}







public enum passable{No, Right, Left, Top, Bottom, Sides, UpDown, Yes}