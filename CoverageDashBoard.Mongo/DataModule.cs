﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CoverageDashboard.Core;
using CoverageDashboard.Core.Dependency;
using CoverageDashboard.Core.Modules;
using  System.Configuration;
using CoverageDashboard.Core.Configuration;

namespace CoverageDashboard.Mongo
{
    [DependsOn(typeof(CoreModule))]
    public class DataModule : MainModule
    {
        public override void PreInitialize()
        {
            IocManager.Register<IMongoDbModuleConfiguration, MongoDbModuleConfiguration>();
            Configuration.DefaultNameOrConnectionString = ConfigurationManager.AppSettings["connectionString"].ToString();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
