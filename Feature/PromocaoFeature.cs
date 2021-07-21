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
            var postPromocao = await Post<RetornoPromocao>(Endpoints.BaseURI, Endpoints.Promocao, PromocaoPostReturn("Nome aleatorio", DateTime.Now , DateTime.Now));
            Assert.True(postPromocao.NomePromo != null);

            var getPromocao = await Get<RetornoPromocao>(Endpoints.BaseURI, Path.Combine(Endpoints.Promocao, postPromocao.Id.ToString()));
            Assert.NotNull(getPromocao.NomePromo);

            var putPromocao = await Put<RetornoPromocao>(Endpoints.BaseURI, Endpoints.Promocao, PromocaoPostReturn("TesteTeste", DateTime.Now, DateTime.Now));
            Assert.NotNull(putPromocao.NomePromo);

            var deletePromocao = await Delete<RetornoPromocao>(Endpoints.BaseURI, Path.Combine(Endpoints.Promocao, postPromocao.Id.ToString()));
            Assert.NotNull(deletePromocao.NomePromo);
        }
    }
}
