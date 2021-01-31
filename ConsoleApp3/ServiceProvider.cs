using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ServiceProvider
    {
        private Dictionary<string, object> services = new Dictionary<string, object>();
        private List<string> aliases = new List<string>();

        public void AddSingleton(string Alias)
        {
            aliases.Add(Alias);
        }
        public void AddSingleton<T>()
        {
            aliases.Add(typeof(T).FullName);
        }
        public object GetService(string Alias) {
            object service;
            if (services.TryGetValue(Alias, out service)) {
                return service;
            }
            if (TryCreateService(Alias, out service)) {
                return service;
            }
            
            throw new Exception("Service has been not found");
        }
        private bool TryCreateService(string Alias, out object service) {
            service = new object();
            if (!aliases.Contains(Alias)) {
                return false;
            }
            Type serviceType = Type.GetType(Alias);
            ConstructorInfo constructor = serviceType.GetConstructors().First();
            ParameterInfo[] parameterInfos = constructor.GetParameters();
            List<object> parameters = new List<object>();
            foreach (ParameterInfo info in parameterInfos) {
                object parameter = GetService(info.ParameterType.FullName);
                parameters.Add(parameter);
            }
            service = constructor.Invoke(parameters.ToArray());
            services.Add(Alias, service);

            return true;
        }
        public object GetService(Type type) {
            return GetService(type.FullName);
        }
        public T GetService<T>() {
            object service = GetService(typeof(T));
            if (service is T) {
                return (T)service;
            }
            throw new Exception("Service has wrong type");
        }
    }
}
