using LightWeightFramework.Components.ViewComponents;
using LightWeightFramework.Model;

namespace LightWeightFramework.Components
{
    public interface IView
    {
        ViewComponent[] ViewComponents { get; }
    }
}