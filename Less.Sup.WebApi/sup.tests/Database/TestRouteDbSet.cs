using System.Linq;
using Less.Sup.WebApi.Models;

namespace Less.Sup.WebApi.Tests.Database
{
    class TestRouteDbSet : TestDbSet<Route>
    {
        public override Route Find(params object[] keyValues)
        {
            return this.SingleOrDefault(route => route.Id == (int)keyValues.Single());
        }
    }
}
