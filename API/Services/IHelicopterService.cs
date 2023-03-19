namespace API.Services
{
    public interface IHelicopterService
    {
        Task<Helicopter>? Get(int id);
        Task<List<Helicopter>>? GetAll();
        Task<int?> Create(Helicopter helicopter);
        Task<Helicopter>? Update(int id, Helicopter request);
        Task<Boolean>? Delete(int id);
    }
}

