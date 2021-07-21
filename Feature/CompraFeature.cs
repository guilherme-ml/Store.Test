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
            var postResponse = await Post<RetornoCompra>(Endpoints.BaseURI, Endpoints.Compra, CompraPostReturn("20.07.2021", 3, 1));
            Assert.True(postResponse.DtEHrCompra != null);

            var getResponse = await Get<RetornoCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Compra, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.DtEHrCompra);

            var putResponse = await Put<RetornoCompra>(Endpoints.BaseURI, Endpoints.Compra, CompraPostReturn("30.07.2021", 2, 8));
            Assert.NotNull(putResponse.DtEHrCompra);

            var deleteResponse = await Delete<RetornoCompra>(Endpoints.BaseURI, Path.Combine(Endpoints.Compra, postResponse.Id.ToString()));
            Assert.NotNull(deleteResponse.DtEHrCompra);
        }
    }
}
