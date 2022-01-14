using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagiarismChecker.Model.Dto
{
    public class FileUploadDto
    {
        public string StudentName { get; set; }
        public List<IFormFile> file { get; set; }
    }
}
