using Store.Test.Base;
using Store.Test.Dtos.Returns;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Store.Test.Feature
{
    public class SituacaoFeature : BaseTest
    {
        [Fact]
        public async Task TestSituacao()
        {
            var postSituacao = await Post<RetornoSituacao>(Endpoints.BaseURI, Endpoints.Situacao, SituacaoPostReturn("Teste 123", 1));
            Assert.True(postSituacao.DescSituacaoCompra != null);

            var getSituacao = await Get<RetornoSituacao>(Endpoints.BaseURI, Path.Combine(Endpoints.Situacao, postSituacao.Id.ToString()));
            Assert.NotNull(getSituacao.DescSituacaoCompra);

            var putSituacao = await Put<RetornoSituacao>(Endpoints.BaseURI, Endpoints.Situacao, SituacaoPostReturn("Teste", 2));
            Assert.NotNull(putSituacao.DescSituacaoCompra);

            var deleteSituacao = await Delete<RetornoSituacao>(Endpoints.BaseURI, Path.Combine(Endpoints.Situacao, postSituacao.Id.ToString()));
            Assert.NotNull(deleteSituacao.DescSituacaoCompra);

        }
    }
}