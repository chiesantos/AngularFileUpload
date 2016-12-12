using AutoMapper;
using PetSureFileUpload.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetSureFileUpload.WebApi.App_Start
{
    public class AutoMapperBootstrapper
    {

        public static void Run()
        {
            RunAutoMapper();
        }

        private static void RunAutoMapper()
        {
            Mapper.CreateMap<Pets, PetDTO>();
            Mapper.CreateMap<PetDTO, Pets>();

            Mapper.CreateMap<FileUploads, FileUploadDTO>();
            Mapper.CreateMap<FileUploadDTO, FileUploads>();
        }

    }
}