namespace Service.API.Repositories
{
    public interface ISecretSantaRepository
    {
        public Task<List<int>> GetPersonsListAsync();
    }
}
