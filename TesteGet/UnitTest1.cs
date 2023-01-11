using Newtonsoft.Json;
using RestSharp;
using TesteGet.Methodos.Post;
using NUnit.Framework.Internal;
using TesteGet.Utils;

namespace TesteGet
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           string _ID;

            UsuarioPost usuarioPost = new UsuarioPost();

            string jasonSerealizeObject = JsonConvert.SerializeObject(usuarioPost);
            RestClient client = new RestClient();
            RestRequest request = new RestRequest() {Resource = constants.Usuarios_Post, Method = Method. Post, RequestFormat = DataFormat.Json};

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("accept", "application/json");
            request.AddBody(jasonSerealizeObject);

            var response = client.ExecutePost(request);

            Log log = new Log();

            log.CurrentLog.Info(response);

           // BodyResponseUsuarioPost resposeUsuario = JsonConvert.DeserializeObject<BodyResponseUsuarioPost>(client.ExecutePost(request).Content);

        }
    }
}