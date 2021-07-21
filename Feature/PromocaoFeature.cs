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
    public class PromocaoFeature : BaseTest
    {
        [Fact]
        public async Task TestPromocao()
        {
            var postResponse = await Post<RetornoPromocao>(Endpoints.BaseURI, Endpoints.Promocao, PromocaoPostReturn("Nome aleatorio", DateTime.Now , DateTime.Now));
            Assert.True(postResponse.NomePromo != null);

            var getResponse = await Get<RetornoPromocao>(Endpoints.BaseURI, Path.Combine(Endpoints.Promocao, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.NomePromo);

            var putResponse = await Put<RetornoPromocao>(Endpoints.BaseURI, Endpoints.Promocao, PromocaoPostReturn("TesteTeste", DateTime.Now, DateTime.Now));
            Assert.NotNull(putResponse.NomePromo);

            var deleteResponse = await Delete<RetornoPromocao>(Endpoints.BaseURI, Path.Combine(Endpoints.Promocao, postResponse.Id.ToString()));
            Assert.NotNull(deleteResponse.NomePromo);
        }
    }
}
