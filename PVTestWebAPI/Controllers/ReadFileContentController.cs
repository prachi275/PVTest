using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PVTest2021;

namespace PVTestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadFileContentController : ControllerBase
    {
        public IActionResult Get()
        {
            try
            {
                string path = AppContext.BaseDirectory.ToString();
                //string[] files = File.ReadAllLines(path);
                ReturnAllTextFormFile returnAllTextFormFile = new();
                byte[] files = ReturnAllTextFormFile.ReturnallTextformFile(path, "\\data\\testfile.txt");
                var fileContent = System.Text.Encoding.UTF8.GetString(files);
                return Content(fileContent);
            }
            catch (Exception)
            {

                return Content("Error occured while reading file");
                throw;
            }
        }

    }
}
