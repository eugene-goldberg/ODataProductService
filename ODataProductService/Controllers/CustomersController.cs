using ODataProductService.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData;

namespace ODataProductService.Controllers
{
    public class CustomersController : ODataController
    {
        NORTHWNDContext db = new NORTHWNDContext();
        private bool CustomerExists(string key)
        {
            return db.Customers.Any(c => c.CustomerID == key);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public IQueryable<Customer> Get()
        {
            return db.Customers;
        }
        [EnableQuery]
        public SingleResult<Customer> Get([FromODataUri] string key)
        {
            IQueryable<Customer> result = db.Customers.Where(c => c.CustomerID == key);
            return SingleResult.Create(result);
        }
    }
}