using LightWeightFramework.Model;
using UnityEngine;

namespace LightWeightFramework.Components.ViewComponents
{
    public abstract class ViewComponent:MonoBehaviour
    {
        public virtual IModelObserver ModelObserver { get; private set; }
    }


}