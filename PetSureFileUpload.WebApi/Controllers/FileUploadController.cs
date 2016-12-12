using AutoMapper;
using PetSureFileUpload.WebApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSureFileUpload.WebApi.Controllers
{
    public class FileUploadController : ApiController
    {
        
        private readonly IMappingEngine _mapper;

        public FileUploadController(IMappingEngine mapper) {
            _mapper = mapper;
        }

        public void Upload(FileUploadDTO entity)
        {
            using (PetSureFileUploadContext db = new PetSureFileUploadContext())
            {
                entity.Path = System.Web.HttpContext.Current.Server.MapPath("~/Documents");
                string fileName = Path.GetFileNameWithoutExtension(entity.OriginalFileName);
                string fileExtension = Path.GetExtension(entity.OriginalFileName);
                string fullPath = entity.Path + "\\" + entity.OriginalFileName;
                entity.FileName = fullPath;

                FileUploads fileUploaded = _mapper.Map<FileUploads>(entity);
                db.FileUploads.Add(fileUploaded);
                db.SaveChanges();

                //Transfer document to server
                MemoryStream ms = new MemoryStream(entity.FileCopy);
                FileStream fs = File.OpenWrite(entity.FileName);
                ms.WriteTo(fs);
                fs.Flush();
                fs.Close();
                ms.Flush();
                ms.Close();
            }
        }
        
    }
}
