using Microsoft.Practices.Unity;
using Mvc_Repository.Models;
using Mvc_Repository.Models.Interface;
using Mvc_Repository.Models.Repository;
using Mvc_Repository.Service;
using Mvc_Repository.Service.Interface;
using System.Web.Mvc;
using Unity.Mvc4;

namespace Mvc_Repository.Web
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();

      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();    
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
        var dbContext = new NORTHWNDEntities();

        //Repository
        container.RegisterType<IRepository<Categories>, GenericRepository<Categories>>(new InjectionConstructor(dbContext));
        container.RegisterType<IRepository<Products>, GenericRepository<Products>>(new InjectionConstructor(dbContext));

        //Service
        container.RegisterType<ICategoryService, CategoryService>();
        container.RegisterType<IProductService, ProductService>();
    }
  }
}