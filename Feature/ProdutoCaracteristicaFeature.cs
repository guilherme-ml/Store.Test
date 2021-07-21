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
    public class ProdutoCaracteristicaFeature : BaseTest
    {
        [Fact]
        public async Task TestProdutoCaracteristica()
        {
            var postProdutoCaracteristica = await Post<RetornoProdutoCaracteristicas>(Endpoints.BaseURI, Endpoints.Caracteristica, ProdutoCaracteristicaPostReturn("12", 1, 2));
            Assert.True(postProdutoCaracteristica.ValorCaracteristica != null);

            var getProdutoCaracteristica = await Get<RetornoProdutoCaracteristicas>(Endpoints.BaseURI, Path.Combine(Endpoints.Caracteristica, postProdutoCaracteristica.Id.ToString()));
            Assert.NotNull(getProdutoCaracteristica.ValorCaracteristica);

            var putProdutoCaracteristica = await Put<RetornoProdutoCaracteristicas>(Endpoints.BaseURI, Endpoints.Caracteristica, ProdutoCaracteristicaPostReturn("TesteTeste", 8, 6));
            Assert.NotNull(putProdutoCaracteristica.ValorCaracteristica);

            var delteProdutoCaracteristica = await Delete<RetornoProdutoCaracteristicas>(Endpoints.BaseURI, Path.Combine(Endpoints.Caracteristica, postProdutoCaracteristica.Id.ToString()));
            Assert.NotNull(delteProdutoCaracteristica.ValorCaracteristica);
        }
    }
}
