﻿using Microsoft.AspNetCore.Http;
using PlagiarismChecker.Core.Service.Interface;
using PlagiarismChecker.Data;
using PlagiarismChecker.Model.Dto;
using PlagiarismChecker.Model.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlagiarismChecker.Core.Service.Implementation
{
    public class FileService : IFileService
    {

        private readonly AppDbContext _db;

        public FileService(AppDbContext db)
        {
            _db = db;
        }
        public async Task<List<FileUploadResponse>> UploadFile(List<IFormFile> files)
        {
            var uploadedFiles = new List<FileUploadResponseData>();

            try
            {
                foreach (var item in files)
                {
                    string name = item.FileName.Replace(@"\\\\", @"\\");

                    if (item.Length > 0)
                    {
                        var memoryStream = new MemoryStream();

                        try
                        {
                            await item.CopyToAsync(memoryStream);

                            // Upload check if less than 2mb!
                            if (memoryStream.Length < 2097152)
                            {
                                var file = new FileUploadDto()
                                {
                                    FileName = Path.GetFileName(name),
                                    FileSize = memoryStream.Length,
                                    UploadedDate = DateTime.Now,
                                    StudentName = "Joshua",
                                    FileContent = memoryStream.ToArray()
                                };

                                _db.Documents.Add(file);

                                await _db.SaveChangesAsync();

                                uploadedFiles.Add(new FileUploadResponseData()
                                {
                                    Id = file.Id,
                                    Status = "OK",
                                    FileName = Path.GetFileName(name),
                                    ErrorMessage = "",
                                });
                            }
                            else
                            {
                                uploadedFiles.Add(new FileUploadResponseData()
                                {
                                    Id = 0,
                                    Status = "ERROR",
                                    FileName = Path.GetFileName(name),
                                    ErrorMessage = "File " + item + " failed to upload"
                                });
                            }
                        }
                        finally
                        {
                            memoryStream.Close();
                            memoryStream.Dispose();
                        }
                    }
                }
                return new FileUploadResponse() { Data = uploadedFiles, ErrorMessage = "" };
            }
            catch (Exception ex)
            {
                return new FileUploadResponse() { ErrorMessage = ex.Message.ToString() };
            }
        }
    }
}
