using API.Data;
using API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Services
{
    public class HelicopterService : IHelicopterService
    {
        private readonly DataContext _context;
        public HelicopterService(DataContext context)
        {
            _context = context;
        }

        public async Task<Helicopter>? Get(int id)
        {
            Helicopter? helicopter;
            try
            {
                helicopter = await _context.Helicopters.FindAsync(id);
            }
            catch (Exception)
            {
                return null;
            }

            return helicopter;
        }

        public async Task<List<Helicopter>>? GetAll()
        {
            List<Helicopter>? helicopters;
            try
            {
                helicopters = await _context.Helicopters.ToListAsync();
            }
            catch (Exception)
            {
                return null;
            }
            return helicopters;

        }

        public async Task<int?> Create(Helicopter helicopter)
        {
            int? result;
            try
            {
                await _context.Helicopters.AddAsync(helicopter);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return null;
            }
            return result;
        }

        public async Task<Helicopter>? Update(int id, Helicopter request)
        {
            Helicopter? helicopter;
            try
            {
                helicopter = await _context.Helicopters.FindAsync(id);
                helicopter.Model = request.Model;
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return null;
            }

            return helicopter;
        }

        public async Task<Boolean>? Delete(int id)
        {
            Helicopter? helicopter;
            try
            {
                helicopter = await _context.Helicopters.FindAsync(id);
                _context.Helicopters.Remove(helicopter);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

