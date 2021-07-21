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
    public class GrupoFeature : BaseTest
    {
        [Fact]
        public async Task TestGrupo()
        {
            var postResponse = await Post<RetornoGrupo>(Endpoints.BaseURI, Endpoints.Grupo, GrupoPostReturn("Nome aleatorio", 1));
            Assert.True(postResponse.NomeGrupo != null);

            var getResponse = await Get<RetornoGrupo>(Endpoints.BaseURI, Path.Combine(Endpoints.Grupo, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.NomeGrupo);

            var putResponse = await Put<RetornoGrupo>(Endpoints.BaseURI, Endpoints.Grupo, GrupoPostReturn("Nome aleatorio", 2));
            Assert.NotNull(putResponse.NomeGrupo);

            var deleteResponse = await Delete<RetornoGrupo>(Endpoints.BaseURI, Path.Combine(Endpoints.Grupo, postResponse.Id.ToString()));
            Assert.NotNull(deleteResponse.NomeGrupo);
        }
    }
}
