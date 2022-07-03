using System;
using AgendaSecretario.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace AgendaSecretario.Class
{
    public class AgendaCollection : IAgendaCollection
    {
        internal MongoDBConexion _repository = new MongoDBConexion();
        private IMongoCollection<Agenda> Collection;

        public AgendaCollection()
        {
            Collection = _repository.db.GetCollection<Agenda>("Agenda");
        }

        public void DeleteAgenda(Agenda agenda)
        {
            throw new NotImplementedException();
        }

        public Agenda GetAgendaById(string id)
        {
            throw new NotImplementedException();
        }

        public List<Agenda> GetAllAgenda()
        {
            var query = Collection.
                            Find(new BsonDocument()).ToListAsync();
            return query.Result; throw new NotImplementedException();
        }

        public void InsertAgenda(Agenda agenda)
        {
            Collection.InsertOneAsync(agenda);
        }

        public void UpdateAgenda(Agenda agenda)
        {
            throw new NotImplementedException();
        }
    }
}

