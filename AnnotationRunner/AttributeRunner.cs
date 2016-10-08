using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AttributeRunner
{
    public abstract class AttributeRunner<AttributeType>
        where AttributeType : Attribute
    {
        public event EventHandler<AttributeEventArgs> OnBeforeRunMethod;

        public AttributeRunner(AttributeType attribute)
        {
            AttributeClass = attribute;
        }

        public AttributeType AttributeClass
        {
            get;
        }

        private void OnBeforeRun(object sender, AttributeEventArgs e)
        {
            if(OnBeforeRunMethod != null)
            {
                OnBeforeRunMethod(this, e);
            }
        }

        protected void Run(Object obj)
        {
            try
            {
                MethodInfo[] methods = obj.GetType().GetMethods().
                    Where(m => m.GetCustomAttributes(typeof(AttributeType), false).Length > 0).ToArray();

                foreach (MethodInfo method in methods)
                {
                    AttributeType attribute = method.GetCustomAttributes(typeof(Attribute), false).FirstOrDefault() as AttributeType;

                    OnBeforeRun(this, new AttributeEventArgs() { FoundAttribute = attribute });

                    method.Invoke(this, null);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"The Method could not be run. Ensure that the method takes no parameters.\nError message:{ex}");
            }

        }
    }
}
