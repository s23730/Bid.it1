﻿using System;
using Bid.it.Data;
using Bid.it.Models;
using Bid.it.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Bid.it.Services.Implementations
{
    public class AuctionDbService : IAuctionDbService
    {
        private readonly ApplicationDbContext _context;
        public AuctionDbService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<Auction>> GetAuctions()
        {
            return await _context.Auctions.ToListAsync();
        }
    }
}
