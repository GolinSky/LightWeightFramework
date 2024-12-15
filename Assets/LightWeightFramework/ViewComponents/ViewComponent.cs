using LightWeightFramework.Model;
using UnityEngine;

namespace LightWeightFramework.Components.ViewComponents
{
    public abstract class ViewComponent:MonoBehaviour
    {
        public virtual IModelObserver ModelObserver { get; protected set; }
        public virtual BaseView View { get; protected set; }
        
        public void SetView(BaseView view)
        {
            View = view;
        }
        
        public void SetModelObserver(IModelObserver modelObserver)
        {
            ModelObserver = modelObserver;
        }
        
        public virtual void Init()
        {
            OnInit();
        }
        
        public virtual void Dispose()
        {
            OnRelease();
        }

        protected virtual void OnInit(){}
        protected virtual void OnRelease(){}
        
        
    }


}