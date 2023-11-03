namespace MyVariant;

public class GarlandDecorator : BaseDecorator
{
    public override void Inspect()
    {
        base.Inspect();
        Console.WriteLine("There is a garland on it");
        Shine();
    }

    private void Shine()
    {
        Console.WriteLine("The garlang is shining");
    }
}
