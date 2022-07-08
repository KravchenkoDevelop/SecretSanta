namespace Service.API.Repositories
{
    public class SecretSantaRepository : ISecretSantaRepository
    {
        private IRandomService _random;

        public SecretSantaRepository(IRandomService random)
        {
            _random = random;
        }

        public Task<List<int>> GetPersonsListAsync()
        {
            return _random.SandboxRandom();
        }
    }
}
