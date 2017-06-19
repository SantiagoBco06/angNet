using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using White.Data;
using White.Models;
using System.Collections;

namespace White.Controllers
{
    [Route("api/[controller]")]
    public class ActorController : Controller
    {

        private readonly ActorContext _context;

        public ActorController(ActorContext context)
        {
            _context = context;
        }

        [HttpGet("[action]")]
        public IEnumerable<Actor> Index()
        {
            Console.WriteLine(" Initializing Search ListActors... ");
            IEnumerable<Actor> actors = _context.Actors;

            return actors;
        }

        [HttpGet("[action]")]
        public IEnumerable<Customer> ListCustomer()
        {
            Console.WriteLine(" Inicializando busqueda... ");
            IEnumerable<Customer> customers = _context.Customers;

            Console.WriteLine(" Initializing Search ListCustomers... ");
            IEnumerable<Address> addresses = _context.Addresses;
            
            return customers;
        }

    }
}