using Autofac;
using Autofac.Integration.WebApi;
using AutoMapper;
using PetSureFileUpload.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace PetSureFileUpload.WebApi.App_Start
{
    public class Bootstrapper
    {

        public static void Run()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.Register<PetController>(
                c => new PetController(Mapper.Engine));
            builder.Register<FileUploadController>(
                c => new FileUploadController(Mapper.Engine));

            var container = builder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);

            ConfigureAutoMapper();
        }

        private static void ConfigureAutoMapper()
        {
            AutoMapperBootstrapper.Run();
        }

    }
}