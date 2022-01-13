using Microsoft.AspNetCore.Http;
using PlagiarismChecker.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagiarismChecker.Core.Service.Interface
{
    public interface IFileService
    {
        Task<List<FileUploadResponse>> UploadFile(List<IFormFile> files);
    }
}
