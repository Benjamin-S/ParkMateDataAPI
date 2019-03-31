using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SearchApi.Models;

namespace SearchApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController
    {
        private readonly AddressContext _context;

        public AddressController(AddressContext context)
        {
            _context = context;
        }


        // GET: api/Address
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddressItem>>> GetAddressItems()
        {
            return await _context.AddressItems.ToListAsync();
        }

        // GET: api/Address/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AddressItem>> GetAddressItem(int id)
        {
            var todoItem = await _context.AddressItems.FindAsync(id);

            if (todoItem == null)
            {
                return new NotFoundObjectResult(id);
            }

            return todoItem;
        }
    }
}