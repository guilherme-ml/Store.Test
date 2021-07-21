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
            var postGrupo = await Post<RetornoGrupo>(Endpoints.BaseURI, Endpoints.Grupo, GrupoPostReturn("Nome aleatorio", 1));
            Assert.True(postGrupo.NomeGrupo != null);

            var getGrupo = await Get<RetornoGrupo>(Endpoints.BaseURI, Path.Combine(Endpoints.Grupo, postGrupo.Id.ToString()));
            Assert.NotNull(getGrupo.NomeGrupo);

            var putGrupo = await Put<RetornoGrupo>(Endpoints.BaseURI, Endpoints.Grupo, GrupoPostReturn("Nome aleatorio", 2));
            Assert.NotNull(putGrupo.NomeGrupo);

            var deleteGrupo = await Delete<RetornoGrupo>(Endpoints.BaseURI, Path.Combine(Endpoints.Grupo, postGrupo.Id.ToString()));
            Assert.NotNull(deleteGrupo.NomeGrupo);
        }
    }
}
