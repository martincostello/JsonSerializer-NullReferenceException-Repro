using System.IO;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Xunit;

namespace JsonSerializer_NullReferenceException_Repro
{
    public static class Repro
    {
        [Fact]
        public static async Task ReadAsync_Does_Not_Throw()
        {
            // Arrange
            var json = @"{
  ""A"": """",
  ""B"": 1,
  ""C"": false,
  ""D"": {
    ""A"": """",
    ""B"": 2,
    ""C"": ""2019-04-21T08:22:35.8241219+00:00"",
    ""D"": ""2019-04-21T09:07:35.8241219+00:00"",
    ""E"": ""2019-04-21T09:12:35.8241219+00:00"",
    ""F"": false
  },
  ""E"": {
    ""A"": 1,
    ""B"": """",
    ""C"": """",
    ""D"": null,
    ""E"": null,
    ""F"": null,
    ""G"": null,
    ""H"": """",
    ""I"": false,
    ""J"": false,
    ""K"": 0,
    ""L"": true,
    ""M"": true,
    ""N"": false,
    ""O"": false,
    ""P"": null,
    ""Q"": null,
    ""R"": false,
    ""S"": false,
    ""T"": null,
    ""U"": null
  },
  ""F"": {
    ""A"": null,
    ""B"": [],
    ""C"": 0.0,
    ""D"": 0.0,
    ""E"": null,
    ""F"": null
  },
  ""G"": null,
  ""H"":{
    ""A"": """",
    ""B"": 0,
    ""C"": [
      {
        ""A"": 0,
        ""B"": 0,
        ""C"": null,
        ""D"": """",
        ""E"": """",
        ""F"": """",
        ""G"": """",
        ""H"": 0.0,
        ""I"": 0.0,
        ""J"": [],
        ""K"": [],
        ""L"": [],
        ""M"": [],
        ""N"": []
      }
    ],
    ""D"": [],
    ""E"": 0.0,
    ""F"": 0.0,
    ""G"": 0.0,
    ""H"": 0.0,
    ""I"": 0.0,
    ""J"": 0.0,
    ""K"": [],
    ""L"": null
  },
  ""I"": {
    ""A"": """",
    ""B"":null
  },
  ""J"": """",
  ""K"": false,
  ""L"": false,
  ""M"": false,
  ""N"": null,
  ""O"": null,
  ""P"": {
    ""A"": """",
    ""B"": """",
    ""C"": """",
    ""D"": """",
    ""E"": """"
  }
}";

            var buffer = Encoding.UTF8.GetBytes(json);
            var utf8Json = new MemoryStream(buffer);
            var options = new JsonSerializerOptions();

            // Act
            var model = await JsonSerializer.ReadAsync<RootObject>(utf8Json, options);

            // Assert
            Assert.NotNull(model);
        }
    }
}
