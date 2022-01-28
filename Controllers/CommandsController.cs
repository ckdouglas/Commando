using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Commando.Models;
using Commando.Data;

namespace Commando.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandoRepo _commandoRepo;
        public CommandsController(ICommandoRepo commandoRepo)
        {
            _commandoRepo = commandoRepo;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAll()
        {
            return Ok(_commandoRepo.GetAppCommands());
        }

        [HttpGet("{id}")]
        public ActionResult<Command> GetById([FromRoute] int Id)
        {
            return Ok(_commandoRepo.GetCommandById());
        }
    }
}