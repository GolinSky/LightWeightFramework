using System.Collections.Generic;
using UnityEngine;

namespace LightWeightFramework.Model
{
    public abstract class Model:ScriptableObject, IModel
    {
        [SerializeField] protected List<Model> models;
   
        protected virtual void Awake()
        {
            foreach (Model innerModel in models)
            {
                AddModel(innerModel);
            }
        }
        public List<IModel> CurrentModels { get; } = new List<IModel>();
        
        public virtual TModelObserver GetModelObserver<TModelObserver>() where TModelObserver : IModelObserver
        {
            if (this is TModelObserver modelObserver) return modelObserver;
            
            return GetModelInternal<TModelObserver>();
        }

        public virtual TModelObserver GetModel<TModelObserver>() where TModelObserver : IModel
        {
            return GetModelInternal<TModelObserver>();
        }

        protected virtual TModelObserver GetModelInternal<TModelObserver>() 
        {
            foreach (var model in CurrentModels)
            {
                if (model is TModelObserver modelObserver)
                {
                    return modelObserver;
                }
            }

            return default;
        }

        protected virtual Model AddModel(Model model)
        {
            var instancedModel = Instantiate(model);
            CurrentModels.Add(instancedModel);
            return instancedModel;
        }
        
        protected virtual void AddInnerModels(params InnerModel[] model) 
        {
            foreach (InnerModel innerModel in model)
            {
                innerModel.Init();
                CurrentModels.Add(innerModel);
            }
        }
 
    }
}