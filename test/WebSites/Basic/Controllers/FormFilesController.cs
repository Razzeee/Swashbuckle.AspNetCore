using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic.Controllers
{
    [Route("files")]
    public class FormFilesController
    {
        [HttpPost("single")]
        public async Task<IActionResult> PostFile(IFormFile file)
        {
            throw new NotImplementedException();
        }

        [HttpPost("multiple")]
        public async Task<IActionResult> PostFiles(IFormFileCollection files)
        {
            throw new NotImplementedException();
        }

        [HttpPost("form-with-file")]
        public async Task<IActionResult> PostFormWithFile([FromForm]FormWithFile formWithFile)
        {
            throw new NotImplementedException();
        }
    }

    public class FormWithFile
    {
        public string Name { get; set; }

        public IFormFile File { get; set; }
    }
}