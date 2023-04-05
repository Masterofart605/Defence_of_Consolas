using static Utilities.Cannons;
using static Utilities.Text;
using static Utilities.Other;
using static Utilities.Settings;



namespace classlib;
public class Cannon
{
    private cannonLocation place {get;}
    public int HP {get; set;} = 10;
    public (int,int) target {get; set;} = (0,0);
    public Cannon(cannonLocation _place){
        place = _place;
    }
    public void ChangeTarget((int,int) newTarget){
        target = newTarget;
    }
    public int CalculateDamage(){
        return 0;
    }
}


public class BasicCannon:Cannon{

}
