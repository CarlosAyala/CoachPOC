using DryIoc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coach.Module.Language
{
    class LanguageModule : IModule
    {
        private readonly IContainer _container;
        public LanguageModule(IContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {

        }
    }
}
