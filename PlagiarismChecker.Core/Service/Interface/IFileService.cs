using Microsoft.AspNetCore.Http;
using PlagiarismChecker.Model.Dto;
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
        Task<FileUploadResponse> UploadFile(FileUploadDto reg);
        Task<>
    }
}
