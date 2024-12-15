using LightWeightFramework.Components.ViewComponents;
using LightWeightFramework.Model;
using UnityEngine;

namespace LightWeightFramework.Components
{
    public abstract class BaseView: MonoBehaviour, IView
    {
        [SerializeField] protected ViewComponent[] viewComponents;

        public Transform Transform => transform;
        public ViewComponent[] ViewComponents => viewComponents;
    }
    
   
}