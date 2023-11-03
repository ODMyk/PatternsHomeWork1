using System;
namespace MyVariant;
class MainApp
{
    static void Main()
    {
        ToyBox firstBox = new SantaBox();
        ToyBox secondBox = new BallsBox();

        var tree = new SimpleChristmasTree();
        tree.AddToy(firstBox.GetToy());
        // tree.AddToy(firstBox.GetToy()); // Uncomment to get an exception because of trying to get a toy from an empty box
        tree.AddToy(secondBox.GetToy());
        tree.AddGarland();

        tree.Inspect();
    }
}
