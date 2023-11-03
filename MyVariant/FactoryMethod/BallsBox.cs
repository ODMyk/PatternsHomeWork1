namespace MyVariant;

public class BallsBox : ToyBox
{
    public BallsBox() {
        ToysCount = 3;
    }
    public override Toy MakeToy()
    {
        return new BallToy();
    }
}
