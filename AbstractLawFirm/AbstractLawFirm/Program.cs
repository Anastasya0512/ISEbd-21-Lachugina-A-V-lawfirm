using AbstractLawFirmLogic.BusinessLogics;
using AbstractLawFirmLogic.Interfaces;
using LawFirmListImplement.Implemets;
using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;

namespace AbstractLawFirm
{
    static class Program
    {
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IComponentStorage, ComponentStorage>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IOrderStorage, OrderStorage>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<IDocumentStorage, DocumentStorage>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<ComponentLogic>(new
           HierarchicalLifetimeManager());
            currentContainer.RegisterType<OrderLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<DocumentLogic>(new
           HierarchicalLifetimeManager());
            return currentContainer;
        }
    }
}

