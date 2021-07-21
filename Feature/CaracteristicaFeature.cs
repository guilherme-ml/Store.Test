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
   public class CaracteristicaFeature : BaseTest
    {
        [Fact]
        public async Task TestCaracteristica()
        {
            var postResponse = await Post<RetornoCaracteristica>(Endpoints.BaseURI, Endpoints.Caracteristica, CaracteristicaPostReturn("Nome aleatorio", 1));
            Assert.True(postResponse.NomeCaracteristica != null);

            var getResponse = await Get<RetornoCaracteristica>(Endpoints.BaseURI, Path.Combine(Endpoints.Caracteristica, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.NomeCaracteristica);

            var putResponse = await Put<RetornoCaracteristica>(Endpoints.BaseURI, Endpoints.Caracteristica, CaracteristicaPostReturn("Teste", 2));
            Assert.NotNull(putResponse.NomeCaracteristica);

            var deleteResponse = await Delete<RetornoCaracteristica>(Endpoints.BaseURI, Path.Combine(Endpoints.Caracteristica, postResponse.Id.ToString()));
            Assert.NotNull(deleteResponse.NomeCaracteristica);

        }
    }
}
