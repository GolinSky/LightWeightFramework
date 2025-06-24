namespace LightWeightFramework.Components
{
    public abstract class Component : IComponent
    {
        string IEntity.Id => GetType().Name;
    }
}