using DryIoc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coach.Module.Sync
{
    class SyncModule : IModule
    {
        private readonly IContainer _container;
        public SyncModule(IContainer container)
        {
            _container = container;
        }

        public void Initialize()
        {

        }
    }
}
