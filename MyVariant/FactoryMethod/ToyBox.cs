namespace MyVariant;

public abstract class ToyBox
{
    protected int ToysCount;
    public Toy GetToy()
    {
        if (ToysCount == 0) throw new Exception();
        ToysCount--;
        return MakeToy();
    }

    public abstract Toy MakeToy();
}
