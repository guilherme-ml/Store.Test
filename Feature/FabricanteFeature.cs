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
            var postFabricante = await Post<RetornoFabricante>(Endpoints.BaseURI, Endpoints.Fabricante, FabricantePostReturn("Teste", "Teste.com", 1));
            Assert.True(postFabricante.NomeFabricante != null);

            var getFabricante = await Get<RetornoFabricante>(Endpoints.BaseURI, Path.Combine(Endpoints.Fabricante, postFabricante.Id.ToString()));
            Assert.NotNull(getFabricante.NomeFabricante);

            var putFabricante = await Put<RetornoFabricante>(Endpoints.BaseURI, Endpoints.Fabricante, FabricantePostReturn("TesteTeste", "TesteTeste.com", 2));
            Assert.NotNull(putFabricante.NomeFabricante);

            var deleteFabricante = await Delete<RetornoFabricante>(Endpoints.BaseURI, Path.Combine(Endpoints.Fabricante, postFabricante.Id.ToString()));
            Assert.NotNull(deleteFabricante.NomeFabricante);
        }
    }
}
