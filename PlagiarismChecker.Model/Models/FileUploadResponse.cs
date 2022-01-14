using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagiarismChecker.Model.Models
{
    public class FileUploadResponse
    {
        public string ErrorMessage { get; set; }
        public List<FileUploadResponseData> Data { get; set; }
    }
}
