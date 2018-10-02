﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Collections.ObjectModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace CarService
{
    class ErrorHandlerBehaviorAttribute : Attribute, IServiceBehavior
    {
        private Type _handlerType;
        public ErrorHandlerBehaviorAttribute(Type handlerType)
        {
            _handlerType = handlerType;
        }
        public void AddBindingParameters(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase, Collection<ServiceEndpoint> endpoints, BindingParameterCollection bindingParameters)
        {
            var handler = (IErrorHandler)Activator.CreateInstance(_handlerType);
            foreach (var item in serviceHostBase.ChannelDispatchers)
            {
                var chDisp = item as ChannelDispatcher;
                if (chDisp != null)
                {
                    chDisp.ErrorHandlers.Add(handler);
                }
            }
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            throw new NotImplementedException();
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            
        }
    }
}
