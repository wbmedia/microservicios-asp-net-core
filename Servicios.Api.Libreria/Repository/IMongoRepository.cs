using System.Collections.Generic;
using System.Threading.Tasks;
using Servicios.Api.Libreria.Core.Entities;

namespace Servicios.Api.Libreria.Repository
{
    #region Public Interface

    /// <summary>
    /// The IMongo Repository T Document
    /// </summary>
    /// <typeparam name="TDocument"></typeparam>
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        Task<IEnumerable<TDocument>> GetAll();
    }

    #endregion Public Interface
}

