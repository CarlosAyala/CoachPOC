using Coach.Module.Login.Views;
using DryIoc;
using Prism.DryIoc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coach.Module.Login
{
    class LoginModule : IModule
    {
        private readonly IContainer _container;
        public LoginModule(IContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {
            _container.RegisterTypeForNavigation<LoginPage>();
        }
    }
}
