using EstudantesAPI.Entities;
using EstudantesAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EstudantesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AlunoController : ControllerBase
{
    private readonly IAlunoService _alunoService;

    public AlunoController(IAlunoService alunoService)
    {
        _alunoService = alunoService;
    }

    [HttpGet]
    public async Task<ActionResult> Get([FromQuery] int? matricula, [FromQuery] string? nome, [FromQuery] int? id)
    {
        if (matricula is not null)
            return Ok(await _alunoService.GetAlunoByMatricula((int)matricula));

        if (nome is not null)
            return Ok(await _alunoService.GetAlunoByName(nome));

        if (id is not null)
            return Ok(await _alunoService.GetAlunoById((int)id));

        return NotFound();
    }

    [HttpPost]
    public async Task<ActionResult> Create([FromBody] Aluno aluno)
    {
        var resultado = await _alunoService.SaveAluno(aluno);
        if (resultado is null) return BadRequest("Matricula já utilizada!");
        return Created($"/Aluno?id={resultado.Id}", resultado);
    }

    [HttpPut]
    public async Task<ActionResult> Update([FromQuery] int id, [FromBody] Aluno aluno)
    {
        var resultado = await _alunoService.UpdateAluno(id, aluno);
        if (resultado is null) return BadRequest("Matricula já utilizada!");
        return Ok(resultado);
    }
}
