using System;

namespace AutomaticCar
{
    public class Car
    {
        public Car(float initalGasLevel = 0)
        {
            GasLevel = initalGasLevel;
        }
        /// <summary>
        /// A mile is 10 kilometers
        /// </summary>
        private const float _gasUsagePerMile = 0.8f;

        /// <summary>
        /// Gas level in liters
        /// </summary>
        public float GasLevel { get; private set; }

        /// <summary>
        /// Size in liters
        /// </summary>
        public int GasTankSize => 80;

        /// <summary>
        /// Add gasAmount to the GasTank
        /// </summary>
        /// <param name="gasAmount">How much gas should be added in liters</param>
        public void FillGas(float gasAmount)
        {
            GasLevel += gasAmount;
        }

        /// <summary>
        /// Drive the car the give amount of kilometers this will drain the gas level
        /// </summary>
        /// <param name="distance">Distance in kilometers</param>
        public void Drive(int distance)
        {
            GasLevel -= distance * _gasUsagePerMile;
        }

        /// <summary>
        /// Calculates the max distance that the car can drive given the current amount
        /// of gas in the tank
        /// </summary>
        /// <returns>The distance that the car 
        /// can drive in kilometers, rounded down</returns>
        public int ProjectedMaxDistance()
        {
            return (int)Math.Ceiling(GasLevel * _gasUsagePerMile);
        }
    }
}
