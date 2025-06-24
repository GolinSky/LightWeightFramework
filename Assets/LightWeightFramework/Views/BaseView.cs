using LightWeightFramework.ViewComponents;
using UnityEngine;

namespace LightWeightFramework.Views
{
    public abstract class BaseView: MonoBehaviour, IView
    {
        [SerializeField] protected ViewComponent[] viewComponents;

        public Transform Transform => transform;
        public ViewComponent[] ViewComponents => viewComponents;
    }
    
   
}