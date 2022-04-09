using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Servicios.Api.Libreria.Core.Entities
{
    #region Public Methods
    public class AutorEntity : Document
    {
        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("apellido")]
        public string Apellido { get; set; }

        [BsonElement("edad")]
        public string Edad { get; set; }

        [BsonElement("cargo")]
        public string Cargo { get; set; }

        [BsonElement("gradoAcademico")]
        public string GradoAcademico { get; set; }
    }

    #endregion Public Methods
}

