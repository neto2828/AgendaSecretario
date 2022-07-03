using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AgendaSecretario.Models
{
    public class Agenda
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string AgendaTitulo { get; set; }
        public string AgendaMunicipio { get; set; }
        public DateTime AgendaFecha { get; set; }
        public string AgendaUrl { get; set; }
        public string AgendaEstatus { get; set; }
        public string AgendaEmbedded { get; set; }

    }
}