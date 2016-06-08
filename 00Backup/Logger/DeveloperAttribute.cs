using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGE.Utilities
{
    [AttributeUsage(AttributeTargets.All)]
    public class DeveloperAttribute : Attribute
    {
        // Private fields.
        private string name;
        private string loggingName;

        // This constructor defines two required parameters: name and level.

        public DeveloperAttribute(string name, string loggingName)
        {
            this.name = name; 
            this.loggingName = loggingName;
        }

        // Define Name property.
        // This is a read-only attribute.

        public virtual string Name
        {
            get { return name; }
        }

        public virtual string LoggingName
        {
            get { return loggingName; }
        }


    }
}
