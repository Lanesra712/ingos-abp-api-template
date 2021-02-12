﻿//-----------------------------------------------------------------------
// <copyright file= "IngosAbpTemplateAppModule.cs">
//     Copyright (c) Danvic.Wang All rights reserved.
// </copyright>
// Author: Danvic.Wang
// Created DateTime: 2021/2/11 10:16:36
// Modified by:
// Description: Application Module
//-----------------------------------------------------------------------

using IngosAbpTemplate.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;

namespace IngosAbpTemplate.HttpApi
{
    [DependsOn(typeof(IngosAbpTemplateApplicationModule),
        typeof(AbpAspNetCoreMvcModule),
        typeof(AbpSwashbuckleModule)
    )]
    public class IngosAbpTemplateAppModule : AbpModule
    {
        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            var app = context.GetApplicationBuilder();
            var env = context.GetEnvironment();

            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseRouting();

            app.UseConfiguredEndpoints();
        }
    }
}