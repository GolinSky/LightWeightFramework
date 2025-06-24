using LightWeightFramework.ViewComponents;

namespace LightWeightFramework.Views
{
    public interface IView
    {
        ViewComponent[] ViewComponents { get; }
    }
}