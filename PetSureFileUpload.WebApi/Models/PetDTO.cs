using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetSureFileUpload.WebApi.Models
{
    public partial class PetDTO
    {
        public long PetID { get; set; }
        public string Name { get; set; }
        public bool Enable { get; set; }
    }
}