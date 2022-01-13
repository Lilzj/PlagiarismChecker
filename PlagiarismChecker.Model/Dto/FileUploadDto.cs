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
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime UploadedDate { get; set; }
    }
}
