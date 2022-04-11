using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Servicios.Api.Libreria.Core;
using Servicios.Api.Libreria.Core.Entities;

namespace Servicios.Api.Libreria.Repository
{
  /// <summary>
  /// The Mongo repository generic
  /// </summary>
  /// <typeparam name="TDocument"></typeparam>
  public class MongoRepository<TDocument> : IMongoRepository<TDocument> where TDocument : IDocument
  {
    #region Private Constructor

    private readonly IMongoCollection<TDocument> _collection;

    public MongoRepository(IOptions<MongoSettings> options)
    {
      var client = new MongoClient(options.Value.ConnectionString);
      var db = client.GetDatabase(options.Value.Database);

      _collection = db.GetCollection<TDocument>(GetCollectionName(typeof(TDocument)));

    }

    #endregion Private Constructor

    #region Private Methods

    private protected string GetCollectionName(Type documentType)
    {
      return ((BsonCollectionAttribute)documentType.GetCustomAttributes(typeof(BsonCollectionAttribute), true).FirstOrDefault()).CollectionName;
    }

    #endregion Private Methods

    #region Public Methods

    public async Task<IEnumerable<TDocument>> GetAll()
    {
      return await _collection.Find(p => true).ToListAsync();
    }

    #endregion Public Methods
  }
}

