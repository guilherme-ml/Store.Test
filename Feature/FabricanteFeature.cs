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
    public class FabricanteFeature : BaseTest
    {
        [Fact]
        public async Task TestFabricante()
        {
            var postResponse = await Post<RetornoFabricante>(Endpoints.BaseURI, Endpoints.Fabricante, FabricantePostReturn("Teste", "Teste.com", 1));
            Assert.True(postResponse.NomeFabricante != null);

            var getResponse = await Get<RetornoFabricante>(Endpoints.BaseURI, Path.Combine(Endpoints.Fabricante, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.NomeFabricante);

            var putResponse = await Put<RetornoFabricante>(Endpoints.BaseURI, Endpoints.Fabricante, FabricantePostReturn("TesteTeste", "TesteTeste.com", 2));
            Assert.NotNull(putResponse.NomeFabricante);

            var deleteResponse = await Delete<RetornoFabricante>(Endpoints.BaseURI, Path.Combine(Endpoints.Fabricante, postResponse.Id.ToString()));
            Assert.NotNull(deleteResponse.NomeFabricante);
        }
    }
}
