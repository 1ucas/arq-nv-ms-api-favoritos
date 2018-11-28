using FavoritosApi.Models.Interfaces;
using FavoritosApi.Repos;
using FavoritosApi.Serivces;
using SimpleInjector;

namespace FavoritosApi.Injector
{
    public class InjectorDependency
    {
        private static Container _container;

        public static void Iniciar()
        {
            if (_container != null)
                _container.Dispose();

            _container = new Container();
            _container.Register<IFavoritosService, FavoritosService>();
            _container.Register<IFavoritosRepo, FavoritosRepo>();


            _container.Verify();
        }
        public static T ObterInstancia<T>() where T : class
        {
            return _container.GetInstance<T>();
        }

        public static Container Container
        {
            get
            {
                return _container;
            }
        }
    }
}