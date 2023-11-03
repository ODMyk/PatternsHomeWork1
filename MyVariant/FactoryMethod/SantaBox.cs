namespace MyVariant;

public class SantaBox : ToyBox
{
    public SantaBox()
    {
        ToysCount = 1;
    }
    public override Toy MakeToy()
    {
        return new SantaToy();
    }
}
