using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Bakery.WebAPI.Data;
using Bakery.WebAPI.Models;

namespace Bakery.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoicesController: ControllerBase
    {   
        private readonly BakeryContext _context;

        public InvoicesController(BakeryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Invoice>> GetAll() =>
            _context.Invoices;

        [HttpGet("{id}")]
        public async Task<ActionResult<Invoice>> GetById(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);

            if (invoice == null)
            {
                return NotFound();
            }

            return invoice;
        }

        [HttpPost]
        public async Task<ActionResult<Invoice>> Create(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = invoice.Id }, invoice);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);

            if (invoice == null)
            {
                return NotFound();
            }

            _context.Invoices.Remove(invoice);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}