using System;
using Mkh.Module.Abstractions;

namespace Mkh.Mod.SiteManager.Core.Infrastructure;

public class ModuleServicesConfigurator : IModuleServicesConfigurator
{
    public void Configure(ModuleConfigureContext context)
    {
        //注入当前模块中特有的服务
    }
}