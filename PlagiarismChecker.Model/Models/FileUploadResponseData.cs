using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagiarismChecker.Model.Models
{
    public class FileUploadResponseData
    {
        public string Id { get; set; } 
        public string Status { get; set; }
        public string FileName { get; set; }
        public string ErrorMessage { get; set; }
    }
}
