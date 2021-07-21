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
    public class CompraFeature : BaseTest
    {
        [Fact]
        public async Task TestCompra()
        {
            var postCompra = await Post<RetornoCompra>(Endpoints.BaseURI, Endpoints.Compra, CompraPostReturn("20.07.2021", 3, 1));
            Assert.True(postCompra.DtEHrCompra != null);

            var getCompra = await Get<RetornoCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Compra, postCompra.Id.ToString()));
            Assert.NotNull(getCompra.DtEHrCompra);

            var putCompra = await Put<RetornoCompra>(Endpoints.BaseURI, Endpoints.Compra, CompraPostReturn("30.07.2021", 2, 8));
            Assert.NotNull(putCompra.DtEHrCompra);

            var deleteResponse = await Delete<RetornoCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Compra, postCompra.Id.ToString()));
            Assert.NotNull(deleteResponse.DtEHrCompra);
        }
    }
}
