namespace MyVariant;

public abstract class BaseDecorator : IComponent
{
    private IComponent wrapee;

    public void SetComponent(IComponent component)
    {
        wrapee = component;
    }

    public virtual void Inspect()
    {
        wrapee.Inspect();
    }
}
