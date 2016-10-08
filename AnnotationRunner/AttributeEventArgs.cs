using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeRunner
{
    public class AttributeEventArgs: EventArgs
    {
        public Attribute FoundAttribute
        {
            get;
            set;
        } = null;
    }
}
