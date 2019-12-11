using System;

namespace spital
{
    internal class RandomGenerator
    {
        private static RandomGenerator _instance;

        /// <summary>
        /// Constructor
        /// </summary>
        private RandomGenerator() { }

        public static RandomGenerator Instance
        {
            get
            {
                if (_instance == null)
                {
                    
                    _instance = new RandomGenerator();
                  
                }

                return _instance;
            }
        }

        /// <summary>
        /// Generates a random float number between the two parameters
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>Return a float number between parameters</returns>
        internal float Generate(float v1, float v2)
        {
            Random r = new Random();
            float generate = (float)(r.NextDouble() * (v2 - v1)) + v1;
            return generate;
        }
    }
}