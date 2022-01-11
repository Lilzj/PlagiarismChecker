using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlagiarismChecker.Models
{
    public class ComparisonHistory
    {
        public string COmparisonHistoryId { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }
        public string DocumentA { get; set; }
        public string DocumentB { get; set; }
        public string ResultDescription { get; set; }
        public int PercentageSimilarity { get; set; }
    }
}
