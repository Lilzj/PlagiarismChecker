using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlagiarismChecker.Models
{
    public class Documents
    {
        public string DocumentsId { get; set; } = Guid.NewGuid().ToString();
        public string StudentId { get; set; } = Guid.NewGuid().ToString();
        public string StudentName { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
        public byte[] FileContent { get; set; }
        public DateTime UploadedDate { get; set; } = DateTime.Now;

    }
}
