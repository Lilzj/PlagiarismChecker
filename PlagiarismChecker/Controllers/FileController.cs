using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlagiarismChecker.Core.Service.Interface;
using PlagiarismChecker.Model.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlagiarismChecker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {

        private readonly IFileService _fileService;
        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost("UploadFiles")]
        public async Task<IActionResult> UploadFiles([FromForm] FileUploadDto reg)
        {
            var uploadResponse = await _fileService.UploadFile(reg);
            if (uploadResponse.ErrorMessage != "")
                return BadRequest(new { error = uploadResponse.ErrorMessage });
            return Ok(uploadResponse);
        }
    }
}
