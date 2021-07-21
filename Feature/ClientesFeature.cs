using Store.Test.Base;
using Store.Test.Dtos.ReturnCep;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Store.Test.Feature
{
    public class ClientesFeature : BaseTest
    {
        [Fact]
        public async Task TestClientes()
        {
            var postClientes = await Post<RetornoCliente>(Endpoints.BaseURI, Endpoints.Cliente, ClientesPostReturn("Nome aleatorio", "Rua 1", "0918", "8055", "Jarda","154156","15165"));
            Assert.True(postClientes.NomeCliente != null);

            var getClientes = await Get<RetornoCliente>(Endpoints.BaseURI, Path.Combine(Endpoints.Cliente, postClientes.Id.ToString()));
            Assert.NotNull(getClientes.NomeCliente);

            var putClientes = await Put<RetornoCliente>(Endpoints.BaseURI, Endpoints.Cliente, ClientesPostReturn("Nome aleatorio", "Rua 101", "0918", "8055", "Jarda", "154156", "15165"));
            Assert.NotNull(putClientes.NomeCliente);

            var deleteClientes = await Delete<RetornoCliente>(Endpoints.BaseURI, Path.Combine(Endpoints.Cliente, postClientes.Id.ToString()));
            Assert.NotNull(deleteClientes.NomeCliente);

        }
    }
}