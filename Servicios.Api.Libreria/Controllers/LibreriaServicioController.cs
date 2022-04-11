using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Servicios.Api.Libreria.Core.Entities;
using Servicios.Api.Libreria.Repository;

namespace Servicios.Api.Libreria.Controllers
{
  /// <summary>
  ///  The Autores Controller
  /// </summary>
  [Route("api/v1/autores")]
  [ApiController]
  public class LibreriaServicioController : Controller
  {
    #region Contructors Section

    private readonly IAutorRepository _autorRepository;
    private readonly IMongoRepository<AutorEntity> _autorGenericoRepository;

    public LibreriaServicioController(
        IAutorRepository autorRepository,
        IMongoRepository<AutorEntity> autorGenericoRepository
        )
    {
      _autorRepository = autorRepository;
      _autorGenericoRepository = autorGenericoRepository;
    }

    #endregion Constructors Section

    #region Public Methods

    [HttpGet("list")]
    public async Task<ActionResult<Autor>> GetAutores()
    {
      var autores = await _autorRepository.GetAutores();
      return Ok(autores);
    }

    [HttpGet("listasync")]
    public async Task<ActionResult<AutorEntity>> GetAutorGenerico()
    {
      var autores = await _autorGenericoRepository.GetAll();
      return Ok(autores);
    }

    #endregion Public Methods
  }


}