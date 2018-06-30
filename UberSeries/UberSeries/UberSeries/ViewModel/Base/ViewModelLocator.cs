using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace UberSeries.ViewModel.Base
{
    class ViewModelLocator
    {

        IContainer _container;
        ContainerBuilder _containerBuilder;

        static readonly ViewModelLocator _instance = new ViewModelLocator();
        public static ViewModelLocator Instance
        {
            get { return _instance; }
        }

        public ViewModelLocator()
        {
            _containerBuilder = new ContainerBuilder();
        }

        public T Resolve<T>()
        {
           return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public void Register<TInterface, TImprementaion>()
            where TImprementaion : TInterface
        {
            _containerBuilder.RegisterType<TImprementaion>().As<TInterface>();
        }

        public void Register<T>() where T : class
        {
            _containerBuilder.RegisterType<T>();
        }

        public void Build()
        {
            if (_container == null)
                _container = _containerBuilder.Build();
        }



    }
}
