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
            var postResponse = await Post<RetornoDepartamento>(Endpoints.BaseURI, Endpoints.Departamento, DepartamentoPostReturn("Teste", 1, 5));
            Assert.True(postResponse.NomeDepartamento != null);

            var getResponse = await Get<RetornoDepartamento>(Endpoints.BaseURI, Path.Combine(Endpoints.Departamento, postResponse.Id.ToString()));
            Assert.NotNull(getResponse.NomeDepartamento);

            var putResponse = await Put<RetornoDepartamento>(Endpoints.BaseURI, Endpoints.Departamento, DepartamentoPostReturn("TesteTeste", 1, 8));
            Assert.NotNull(putResponse.NomeDepartamento);

            var deleteResponse = await Delete<RetornoDepartamento>(Endpoints.BaseURI, Path.Combine(Endpoints.Departamento, postResponse.Id.ToString()));
            Assert.NotNull(deleteResponse.NomeDepartamento);
        }
    }
}
