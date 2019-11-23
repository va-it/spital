using System;

namespace spital
{
    internal class RandomGenerator
    {
        private static RandomGenerator instance;

        //constructor
        private RandomGenerator()
        {
            
        }

        //properties
        public static RandomGenerator Instance
        {
            get
            {

                if (instance == null)
                {
                    
                    instance = new RandomGenerator();
                  
                }
                  Generate(float v1, float v2)
                {
               
                      Random r = new Random();
                    float rDouble = (r.NextDouble() * (v2 - v1)) + v1;
                }
                return instance;
                
            }
        }

        


        
    }
}