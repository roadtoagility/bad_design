using EntrevistaApp.Application.Abstraction.Questao.Querys;
using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using EntrevistaApp.Application;
using EntrevistaApp.Application.Abstraction.Questao.Commands;

namespace EntrevistaApp.API.Controllers.Questao
{
    [ApiController]
    [Route("[controller]/api")]
    public class QuestaoController : ControllerBase
    {
        private IMediator _mediator
        {
            get;
        }

        public QuestaoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPut("CriarQuestao")]
        public async Task<object> CriarQuestao([FromBody][Required] CriarQuestaoCommand model)
        {
            var response = await _mediator.Send(model);
            return response;
        }

        [HttpPost("AtualizarQuestao")]
        public async Task<object> AtualizarQuestao([FromBody][Required] AtualizarQuestaoCommand model)
        {
            var response = await _mediator.Send(model);
            return response;
        }

        [HttpDelete("DeleteQuestao")]
        public async Task<object> DeleteQuestao([FromBody][Required] DeleteQuestaoCommand model)
        {
            var response = await _mediator.Send(model);
            return response;
        }

        [HttpGet("ListarQuestao")]
        public async Task<object> ListarQuestao([FromQuery][Required] ListarQuestaoRequest model)
        {
            var response = await _mediator.Send(model.ToQuery());
            return response;
        }

        [HttpGet("PesquisarQuestoes")]
        public async Task<object> PesquisarQuestoes([FromQuery][Required] PesquisarQuestoesRequest model)
        {
            var response = await _mediator.Send(model.ToQuery());
            return response;
        }

        [HttpGet("DetalharQuestoes")]
        public async Task<object> DetalharQuestoes([FromQuery][Required] DetalharQuestoesRequest model)
        {
            var response = await _mediator.Send(model.ToQuery());
            return response;
        }

        [HttpGet("InativarQuestao")]
        public async Task<object> InativarQuestao([FromQuery][Required] InativarQuestaoRequest model)
        {
            var response = await _mediator.Send(model.ToQuery());
            return response;
        }
    }
}