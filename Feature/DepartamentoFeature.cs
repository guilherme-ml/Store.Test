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
    public class DepartamentoFeature : BaseTest
    {
        [Fact]
        public async Task TestDepartamento()
        {
            var postDepartamento = await Post<RetornoDepartamento>(Endpoints.BaseURI, Endpoints.Departamento, DepartamentoPostReturn("Teste", 1, 5));
            Assert.True(postDepartamento.NomeDepartamento != null);

            var getDepartamento = await Get<RetornoDepartamento>(Endpoints.BaseURI, Path.Combine(Endpoints.Departamento, postDepartamento.Id.ToString()));
            Assert.NotNull(getDepartamento.NomeDepartamento);

            var putDepartamento = await Put<RetornoDepartamento>(Endpoints.BaseURI, Endpoints.Departamento, DepartamentoPostReturn("TesteTeste", 1, 8));
            Assert.NotNull(putDepartamento.NomeDepartamento);

            var deleteDepartamento = await Delete<RetornoDepartamento>(Endpoints.BaseURI, Path.Combine(Endpoints.Departamento, postDepartamento.Id.ToString()));
            Assert.NotNull(deleteDepartamento.NomeDepartamento);
        }
    }
}
