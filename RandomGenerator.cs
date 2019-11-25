﻿using System;

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

                return instance;
            }
        }

        internal float Generate(float v1, float v2)
        {
            Random r = new Random();
            float generate = (float)(r.NextDouble() * (v2 - v1)) + v1;
            return generate;
        }
    }
}