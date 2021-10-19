using Dominio.Models;
using MongoDB.Driver;
using System;

namespace Dados.Context
{
    public static class MongoContext
    {
        public static readonly string ConnectionString = Environment.GetEnvironmentVariable("ConnectionStrings:ConexaoMongo", EnvironmentVariableTarget.Process);

        public static IMongoDatabase BancoDeDados
        {
            get
            {
                IMongoClient client = new MongoClient(ConnectionString);
                return client.GetDatabase("sample_training");
            }
        }

        public static IMongoCollection<Grade> Grades
        {
            get
            {
                return BancoDeDados.GetCollection<Grade>("grades");
            }
        }

        public static IMongoCollection<Route> Routes
        {
            get
            {
                return BancoDeDados.GetCollection<Route>("routes");
            }
        }

        public static IMongoCollection<Inspection> Inspections
        {
            get
            {
                return BancoDeDados.GetCollection<Inspection>("inspections");
            }
        }

        public static IMongoCollection<Zip> Zips
        {
            get
            {
                return BancoDeDados.GetCollection<Zip>("zips");
            }
        }
    }
}