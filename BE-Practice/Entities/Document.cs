using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Entities
{
    public abstract class Document : IDocument
    {
        public string Id { get; set; }
    }
}
