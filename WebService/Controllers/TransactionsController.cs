﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebService.Models;

namespace WebService.Controllers
{
    public class TransactionsController : ApiController
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        public TransactionsController()
        {
            
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Transaction> GetTransactions()
        {
            return _context.Transactions;
        }
        
        // GET api/values/5
        [HttpGet]
        public Transaction GetTransaction(int id)
        {
            return _context.Transactions.FirstOrDefault(e => e.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Create(Transaction transaction)
        {
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }
    }
}
