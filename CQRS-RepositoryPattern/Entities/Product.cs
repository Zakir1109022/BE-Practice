using BE_Practice.Configuration;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_Practice.Entities
{
    [BsonCollection("product")]
    public class Product:Document
    {
        public string name { get; set; }
        public int price { get; set; }
    }
}
