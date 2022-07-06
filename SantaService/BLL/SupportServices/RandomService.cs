using MersenneTwister;

namespace BLL
{
    /// <summary>
    ///     random generator
    /// </summary>
    public class RandomService : IRandomService
    {
        /// <summary>
        ///     get single random number
        /// </summary>
        /// <param name="diap">count of persons</param>
        /// <returns></returns>
        public async Task<int> GetRandomPerson(int diap)
        {
            return  Randoms.FastestInt32.Next(diap);
        }

        //TODO:
        //-allocate list 
        //-generate 10 random int digits
        //-for each generated digit put it into list
        //-retun list
        public async Task<List<int>> SandboxRandom()
        {
            throw new NotImplementedException();
        }
    }
}