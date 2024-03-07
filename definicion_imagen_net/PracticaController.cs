using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace PracticaEval01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PracticaController : ControllerBase
    {
        [HttpGet]
        public Result Get()
        {
            var dbClient = new MongoClient(Environment.GetEnvironmentVariable("CONFIG_MONGODB_URL"));
            IMongoDatabase db = dbClient.GetDatabase("testdb");
            var cars = db.GetCollection<BsonDocument>("cars");

            var result = new Result
            {
                Version = "1",
                Entorno = Environment.GetEnvironmentVariable("Entorno") ?? "sin definir",
                List = cars.Find(new BsonDocument()).ToList()
            };
            return result;
        }
    }

    public class Result
    {
        public string? Version;
        public string? Entorno;
        public object? List;
    }
}
