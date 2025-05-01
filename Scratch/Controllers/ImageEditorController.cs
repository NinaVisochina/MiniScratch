using Microsoft.AspNetCore.Mvc;
using Scratch.Models;

namespace Scratch.Controllers
{
    public class ImageEditorController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public ImageEditorController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        public IActionResult Editor()
        {
            return View(new UploadImageViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Editor(UploadImageViewModel model)
        {
            if (model.ImageFile != null && model.ImageFile.Length > 0)
            {
                var fileName = Path.GetFileName(model.ImageFile.FileName);
                var filePath = Path.Combine(_env.WebRootPath, "uploads", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.ImageFile.CopyToAsync(stream);
                }

                model.ImagePath = "/uploads/" + fileName;
            }

            return View(model);
        }
    }

}
