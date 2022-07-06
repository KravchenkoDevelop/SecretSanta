namespace BLL
{
    public interface IRandomService
    {
        Task<int> GetRandomPerson(int diap);

        Task<List<int>> SandboxRandom();


    }
}