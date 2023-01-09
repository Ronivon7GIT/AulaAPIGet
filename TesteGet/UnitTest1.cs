using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using TesteGet.Methodos.Post;
using TesteGet.Response.Post;

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
            RestRequest request = new RestRequest() {Resource = constants.Usuarios_Post, Method = Method.Post, RequestFormat = DataFormat.Json};

            request.AddParameter("application/json", ParameterType.RequestBody);

            request.AddBody(jasonSerealizeObject);
            var response = client.ExecutePost(request);

           // BodyResponseUsuarioPost resposeUsuario = JsonConvert.DeserializeObject<BodyResponseUsuarioPost>(client.ExecutePost(request).Content);

        }
    }
}