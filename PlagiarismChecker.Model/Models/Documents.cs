using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlagiarismChecker.Models
{
    public class Documents
    {
        public string DocumentsId { get; set; } = Guid.NewGuid().ToString();
        public string StudentName { get; set; }
        public string FileName { get; set; }
        public int FileSize { get; set; }
        public string FileContent { get; set; }
        public DateTime UploadedDate { get; set; } = DateTime.Now;

    }
}
