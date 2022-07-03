using System;
using MongoDB.Driver;

namespace AgendaSecretario.Class
{



    public class MongoDBConexion
    {
        
            public MongoClient client;

        public IMongoDatabase db;

        public MongoDBConexion()
        {
            client = new MongoClient("mongodb+srv://nestor:Stonecold29@cluster0.nsh1d.mongodb.net/?retryWrites=true&w=majority");
            db = client.GetDatabase("Agenda");
        }
        }
    }


