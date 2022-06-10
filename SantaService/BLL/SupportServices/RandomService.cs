namespace BLL.SupportServices
{
    /// <summary>
    ///     random generator
    /// </summary>
    public static class RandomService
    {
        /// <summary>
        ///     get single random number
        /// </summary>
        /// <param name="diap">count of persons</param>
        /// <returns></returns>
        public static int GetRandomPerson(int diap)
        {
            return Randoms.FastestInt32.Next(diap);
        }
    }
}