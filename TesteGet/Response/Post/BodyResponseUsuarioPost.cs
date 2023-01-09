using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TesteGet.Response.Post
{
    public class BodyResponseUsuarioPost
    {
        [DataMember(Name = "message")]
        public string message { get; set; }

        [DataMember(Name = "_id")]
        public string _id { get; set; }

    }
}
