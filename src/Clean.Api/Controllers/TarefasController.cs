using Clean.Application.Abstractions.Handlers.Tarefas;
using Clean.Domain.Entities;

using Microsoft.AspNetCore.Mvc;

namespace Clean.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefasController : ControllerBase
    {
        private readonly IAddTarefaHandler _addTarefaHandler;
        private readonly IDeleteTarefaHandler _deleteTarefaHandler;
        private readonly IGetAllHandler _getAllTarefaHandler;
        private readonly IGetTarefaHandler _getTarefaHandler;
        private readonly IUpdateTarefaHandler _updateTarefaHandler;

        public TarefasController(IAddTarefaHandler addTarefaHandler,
            IDeleteTarefaHandler deleteTarefaHandler,
            IGetAllHandler getAllTarefaHandler,
            IGetTarefaHandler getTarefaHandler,
            IUpdateTarefaHandler updateTarefaHandler)
        {
            _addTarefaHandler = addTarefaHandler;
            _deleteTarefaHandler = deleteTarefaHandler;
            _getAllTarefaHandler = getAllTarefaHandler;
            _getTarefaHandler = getTarefaHandler;
            _updateTarefaHandler = updateTarefaHandler;
        }


        [HttpPost]
        public IActionResult Post([FromBody] Tarefa tarefa)
        {
            var result = _addTarefaHandler.Handle(tarefa);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Tarefa tarefa)
        {
            var result = _updateTarefaHandler.Handle(tarefa);
            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] Guid id)
        {
            _deleteTarefaHandler.Handle(id);
            return NoContent();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute] Guid id)
        {
            var result = _getTarefaHandler.Handle(id);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _getAllTarefaHandler.Handle();
            return Ok(result);
        }
    }
}