using Challenge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Transaction = Challenge.Models.Transaction;

namespace Challenge.Controllers
{
    public class TransactionsController : Controller
    {
        private readonly ChallengeContext _context;
        private readonly IConfiguration configuration;
        public TransactionsController(ChallengeContext context, IConfiguration configuration)
        {
            _context = context;
            this.configuration = configuration;
        }

        public IActionResult Transaction()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Transaction transaction)
        {

            // Por default
            transaction.Iduser = 1;
            _context.Add(transaction);
            await _context.SaveChangesAsync();
            return View();
        }

    }
}
