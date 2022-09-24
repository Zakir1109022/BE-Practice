using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Entities
{
    public interface IDocument
    {
        [BsonId]
        string Id { get; set; }

    }
}
