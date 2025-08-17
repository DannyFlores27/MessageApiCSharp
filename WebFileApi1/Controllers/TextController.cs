using WebFileApi1.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebFileApi1.Controllers
{
    [ApiController]
    [Route("api/text")]
    public class TextController : ControllerBase
    {
        // ✅ Ruta del archivo compartido
        private readonly string filePath = @"C:\Dev\learning\shared_api_example\texto.txt";
        [HttpPost]
        public IActionResult SaveText([FromBody] TextRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Content))
                return BadRequest(new { message = "El contenido no puede estar vacío." });

            try
            {
                System.IO.File.WriteAllText(filePath, request.Content);
                return Ok(new { message = "Texto guardado exitosamente." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al guardar el texto", error = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult GetText()
        {
            try
            {
                if (!System.IO.File.Exists(filePath))
                    return NotFound(new { message = "Archivo no encontrado." });

                var content = System.IO.File.ReadAllText(filePath);
                return Ok(new { content });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "Error al leer el texto", error = ex.Message });
            }
        }
    }
}
