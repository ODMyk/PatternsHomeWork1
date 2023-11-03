namespace MyVariant;

public class SimpleChristmasTree
{
    private IComponent tree;
    private bool HasGarland;

    public SimpleChristmasTree()
    {
        tree = new ChristmasTree();
        HasGarland = false;
    }

    public void AddToy(Toy toy)
    {
        Wrap(new ToyDecorator(toy));
    }

    public void AddGarland()
    {
        if (HasGarland)
        {
            return;
        }
        HasGarland = true;
        Wrap(new GarlandDecorator());
    }

    private void Wrap(BaseDecorator decorator)
    {
        decorator.SetComponent(tree);
        tree = decorator;
    }

    public void Inspect() { tree.Inspect(); }
}
