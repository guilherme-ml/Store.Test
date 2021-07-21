using Store.Test.Base;
using Store.Test.Dtos.ReturnCep;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Store.Test.Feature
{
    public class CaracteristicaFeature : BaseTest
    {
        [Fact]
        public async Task TestCaracteristica()
        {
            var postCaracteristica = await Post<RetornoCaracteristica>(Endpoints.BaseURI, Endpoints.Caracteristica, CaracteristicaPostReturn("Nome aleatorio", 1));
            Assert.True(postCaracteristica.NomeCaracteristica != null);

            var getCaracteristica = await Get<RetornoCaracteristica>(Endpoints.BaseURI, Path.Combine(Endpoints.Caracteristica, postCaracteristica.Id.ToString()));
            Assert.NotNull(getCaracteristica.NomeCaracteristica);

            var putCaracteristica = await Put<RetornoCaracteristica>(Endpoints.BaseURI, Endpoints.Caracteristica, CaracteristicaPostReturn("Teste", 2));
            Assert.NotNull(putCaracteristica.NomeCaracteristica);

            var deleteCaracteristica = await Delete<RetornoCaracteristica>(Endpoints.BaseURI, Path.Combine(Endpoints.Caracteristica, postCaracteristica.Id.ToString()));
            Assert.NotNull(deleteCaracteristica.NomeCaracteristica);

        }
    }
}
