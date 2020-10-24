using System;
using Volo.Abp.Guids;

namespace MyMessenger.EntityFramework.Seeds.Utils
{
    public class SeedGuidGenerator : IGuidGenerator
    {
        private static int seedValue = 0;

        public static SeedGuidGenerator Instance => new SeedGuidGenerator();

        public Guid Create()
        {
            seedValue++;
            string padded = seedValue.ToString().PadLeft(32, '0');
            return new Guid(padded);
        }
    }
}
