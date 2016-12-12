using AutoMapper;
using PetSureFileUpload.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PetSureFileUpload.WebApi.Controllers
{
    public class PetController : ApiController
    {

        private readonly IMappingEngine _mapper;

        public PetController(IMappingEngine mapper) {
            _mapper = mapper;
        }

        [HttpGet]
        public List<PetDTO> GetAll() {
            using (PetSureFileUploadContext db = new PetSureFileUploadContext())
            {
                List<Pets> records = new List<Pets>();
                records = db.Pets.ToList();
                return _mapper.Map<List<PetDTO>>(records);
            }
        }

        [HttpGet]
        public PetDTO GetNameById(long id)
        {
            using (PetSureFileUploadContext db = new PetSureFileUploadContext())
            {
                Pets record = new Pets();
                record = db.Pets.Where(x => x.PetID ==  id).FirstOrDefault();
                return _mapper.Map<PetDTO>(record);
            }
        }

    }
}
