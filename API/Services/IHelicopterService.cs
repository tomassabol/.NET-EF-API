using System;
using Microsoft.AspNetCore.Mvc;

namespace API.Services
{
	public interface IHelicopterService
	{
        List<Helicopter>? GetAll();
        Helicopter? Get(int id);
        List<Helicopter>? Create(Helicopter helicopter);
        List<Helicopter>? Update(int id, Helicopter request);
        List<Helicopter>? Delete(int id);
    }
}

