using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult Post([FromBody]CreateProjectModel createProject)
        {
            //Após criar o objeto, retornará o código 201 e mandará para a Action GetById
            return CreatedAtAction(nameof(GetById), new {id = createProject.Id}, createProject);
        }


        //Devemos receber o id, para ver qual item será atualizado
        //Devemos receber o item atualizado, para atualizar o BD
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscar, se não existir, notFound

            return NoContent();
        }
    }
}
