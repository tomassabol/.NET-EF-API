using System;

namespace API.Services
{
    public class HelicopterService : IHelicopterService
    {

        private static List<Helicopter> helicopters = new List<Helicopter>
        {
            new Helicopter{Id = 1, Model = "helicopter" }
        };

        public Helicopter? Get(int id)
        {
            Helicopter helicopter = helicopters.Find(x => x.Id == id);

            if (helicopter is null)
            {
                return null;
            }

            return helicopter;
        }

        public List<Helicopter>? GetAll()
        {
            if (helicopters.Count == 0)
            {
                return null;
            }
            return helicopters;

        }

        public List<Helicopter>? Create(Helicopter helicopter)
        {
            helicopters.Add(helicopter);
            return helicopters;
        }

        public List<Helicopter>? Update(int id, Helicopter request)
        {
            Helicopter helicopter = helicopters.Find(x => x.Id == id);


            if (helicopter is null)
            {
                return null;
            }

            helicopter.Model = request.Model;
            return (helicopters);
        }

        public List<Helicopter>? Delete(int id)
        {
            Helicopter helicopter = helicopters.Find(x => x.Id == id);

            if (helicopter is null)
            {
                return null;
            }

            helicopters.Remove(helicopter);
            return helicopters;
        }
    }
}

