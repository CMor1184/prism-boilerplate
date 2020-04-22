﻿using MainModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using SharedModule;
using System;

namespace MainModule
{
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion(RegionNames.MainRegion, typeof(MainRegionView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}