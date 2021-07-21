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
   public class CategoriaFeature : BaseTest
   {
        [Fact]
        public async Task TestCategoria()
        {
            var postResponse = await Post<RetornoCategoria>(Endpoints.BaseURI, Endpoints.Categories, CategoriaPostReturn("Nome categoria1", 1, 8, 5));
            Assert.True(postResponse.NomeCategoria != null);

            var getResponse = await Get<RetornoCategoria>(Endpoints.BaseURI, Path.Combine(Endpoints.Categories, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.NomeCategoria);

            var putResponse = await Put<RetornoCategoria>(Endpoints.BaseURI, Endpoints.Categories, CategoriaPostReturn("Teste", 6, 2, 3));
            Assert.NotNull(putResponse.NomeCategoria);

            var deleteResponse = await Delete<RetornoCategoria>(Endpoints.BaseURI, Path.Combine(Endpoints.Categories, postResponse.Id.ToString()));
            Assert.NotNull(deleteResponse.NomeCategoria);

        }
    }
}
