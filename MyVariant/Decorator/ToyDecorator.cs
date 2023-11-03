namespace MyVariant;

public class ToyDecorator : BaseDecorator
{
    private Toy toy;

    public ToyDecorator(Toy toy)
    {
        this.toy = toy;
    }

    public override void Inspect()
    {
        base.Inspect();
        Console.WriteLine($"There is {toy.Describe()} on it");
    }
}
