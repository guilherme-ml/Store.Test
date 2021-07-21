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
            var postCategoria = await Post<RetornoCategoria>(Endpoints.BaseURI, Endpoints.Categories, CategoriaPostReturn("Nome categoria1", 1, 8, 5));
            Assert.True(postCategoria.NomeCategoria != null);

            var getCategoria = await Get<RetornoCategoria>(Endpoints.BaseURI, Path.Combine(Endpoints.Categories, postCategoria.Id.ToString()));
            Assert.NotNull(getCategoria.NomeCategoria);

            var putCategoria = await Put<RetornoCategoria>(Endpoints.BaseURI, Endpoints.Categories, CategoriaPostReturn("Teste", 6, 2, 3));
            Assert.NotNull(putCategoria.NomeCategoria);

            var deleteCategoria = await Delete<RetornoCategoria>(Endpoints.BaseURI, Path.Combine(Endpoints.Categories, postCategoria.Id.ToString()));
            Assert.NotNull(deleteCategoria.NomeCategoria);

        }
    }
}
