global using NUnit.Framework;
using classlib;

namespace tests;

public class Tests
{
    Player ThePlayer = new Player();
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void PlayerMovement()
    {
        ThePlayer.MoveLeft();
        Assert.AreEqual((0,0),ThePlayer.CurrentLocation);
        ThePlayer.MoveRight();
        Assert.AreEqual((1,0),ThePlayer.CurrentLocation);
        ThePlayer.MoveRight();
        Assert.AreEqual((2,0),ThePlayer.CurrentLocation);
        ThePlayer.MoveLeft();
        Assert.AreEqual((1,0),ThePlayer.CurrentLocation);
        
    }
}