using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.ServiceModel.Configuration;
namespace CarService
{
    class ErrorHandlerConfigElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get
            {
                return typeof(MainErrorHandlerBehavior);
            }
        }

        protected override object CreateBehavior()
        {
            return new MainErrorHandlerBehavior(Type.GetType(this["handlerType"].ToString()));
        }
        [ConfigurationProperty("handlerType", IsKey = true, IsRequired = true)]
        public string HandlerType
        {
            get
            {
                return (string)this["handlerType"];
            }
            set
            {
                this["handlerType"] = value;
            }
        }

    }
}
