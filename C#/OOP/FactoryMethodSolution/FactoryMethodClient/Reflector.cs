using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib.Factory;

namespace FactoryMethodClient
{
    class Reflector
    {
        public IAutoFactory GetAutoFactory()
        {
            string AppConfigInput = ConfigurationManager.AppSettings["factory"];
            string[] libAndClassName = AppConfigInput.Split(',');
            Assembly assembly = new Assembly.Load(libAndClassName[0]);
            Type type = assembly.GetType(libAndClassName[1]);
            IAutoFactory factory = type.InvokeMember("GetInstance", BindingFlags.InvokeMethod);
            return factory;
        }
    }
}
