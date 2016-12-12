using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetSureFileUpload.WebApi.Models
{
    public partial class FileUploadDTO
    {
        public long FileID { get; set; }
        public long PetID { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public string OriginalFileName { get; set; }

        public string Path { get; set; }
        public byte[] FileCopy { get; set; }

        public virtual PetDTO Pets { get; set; }
    }
}