using System;
using MongoDB.Bson;

namespace Servicios.Api.Libreria.Core.Entities
{
    public class Document : IDocument
    {
        public ObjectId Id { get; set; }

        public DateTime CreateDate => Id.CreationTime;
    }
}

