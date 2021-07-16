using Store.Test.Base;
using Store.Test.Dtos.ReturnCep;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Store.Test.Feature
{
    public class ClientesFeature : BaseTest
    {
        [Fact]
        public async Task TestClientes()
        {
            var postResponse = await Post<RetornoCliente>(Endpoints.BaseURI, Endpoints.Cliente, ClientesPostReturn("Nome aleatorio", "Rua 1", "0918", "8055", "Jarda","154156","15165"));
            Assert.True(postResponse.NomeCliente != null);

            var getResponse = await Get<RetornoCliente>(Endpoints.BaseURI, Path.Combine(Endpoints.Cliente, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.NomeCliente);

            var putResponse = await Put<RetornoCliente>(Endpoints.BaseURI, Endpoints.Cliente, ClientesPostReturn("Nome aleatorio", "Rua 101", "0918", "8055", "Jarda", "154156", "15165"));
            Assert.NotNull(putResponse.NomeCliente);

            var deleteResponse = await Delete<RetornoCliente>(Endpoints.BaseURI, Path.Combine(Endpoints.Cliente, postResponse.Id.ToString()));
            Assert.NotNull(deleteResponse.NomeCliente);

        }
    }
}
