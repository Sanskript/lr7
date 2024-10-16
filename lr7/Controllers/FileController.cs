using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace lr7.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            var fileContent = $"Ім'я: {firstName}\nПрізвище: {lastName}";
            var byteArray = Encoding.UTF8.GetBytes(fileContent);
            var stream = new System.IO.MemoryStream(byteArray);

            return File(stream, "text/plain", $"{fileName}.txt");
        }
    }
}
