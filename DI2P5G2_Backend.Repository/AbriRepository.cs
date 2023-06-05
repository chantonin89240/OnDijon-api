using DI2P5G2_Backend.EntitiesContext;
using DI2P5G2_Backend.Entity;
using DI2P5G2_Backend.Repository.Interfaces;
using System.Text.Json;

namespace DI2P5G2_Backend.Repository
{
    public class AbriRepository : IAbriRepository
    {
        private DI2P5G2_BackendDbContext _context;

        public AbriRepository(DI2P5G2_BackendDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Abris>> FindAll()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://data.metropole-dijon.fr/api/records/1.0/search/?dataset=divia_park_velo&q=");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JsonDocument jsonAbris = JsonDocument.Parse(responseBody);
            JsonElement root = jsonAbris.RootElement;
            JsonElement studentsElement = root.GetProperty("records");

            List<Abris> listAbris = new List<Abris>();

            int count = studentsElement.GetArrayLength();

            for (int i = 0; i < count; i++)
            {
                var fields = studentsElement[i].GetProperty("fields");

                Abris newAbris = new Abris();
                newAbris.DataSetId = studentsElement[i].GetProperty("datasetid").GetString();
                newAbris.RecordId = studentsElement[i].GetProperty("recordid").GetString();
                newAbris.Extensible = fields.GetProperty("extensible").GetString();
                newAbris.Quartier = fields.GetProperty("quartier").GetString();
                newAbris.Nom = fields.GetProperty("nom").GetString();
                newAbris.Aire = fields.GetProperty("aire").GetInt16();
                newAbris.GeoPointLat = fields.GetProperty("geo_point_2d")[0].GetDecimal();
                newAbris.GeoPointLon = fields.GetProperty("geo_point_2d")[1].GetDecimal();
                newAbris.NbPlaces = fields.GetProperty("nb_places").GetInt16();
                newAbris.CodComm = fields.GetProperty("codcomm").GetString();
                
                listAbris.Add(newAbris);
            }

            return listAbris;
        }

        public async Task<Abris> Find(string id)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://data.metropole-dijon.fr/api/records/1.0/search/?dataset=divia_park_velo&q=recordid=" + id);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            JsonDocument jsonAbris = JsonDocument.Parse(responseBody);
            JsonElement root = jsonAbris.RootElement;
            JsonElement studentsElement = root.GetProperty("records");


            var fields = studentsElement[0].GetProperty("fields");
            Abris newAbris = new Abris();

            newAbris.DataSetId = studentsElement[0].GetProperty("datasetid").GetString();
            newAbris.RecordId = studentsElement[0].GetProperty("recordid").GetString();
            newAbris.Extensible = fields.GetProperty("extensible").GetString();
            newAbris.Quartier = fields.GetProperty("quartier").GetString();
            newAbris.Nom = fields.GetProperty("nom").GetString();
            newAbris.Aire = fields.GetProperty("aire").GetInt16();
            newAbris.GeoPointLat = fields.GetProperty("geo_point_2d")[0].GetDecimal();
            newAbris.GeoPointLon = fields.GetProperty("geo_point_2d")[1].GetDecimal();
            newAbris.NbPlaces = fields.GetProperty("nb_places").GetInt16();
            newAbris.CodComm = fields.GetProperty("codcomm").GetString();

            return newAbris;
        }

    }
}
