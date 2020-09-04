using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Dragracing
{
    public class Engine
    {
        #region Fields
        private string type;
        private int topSpeed;
        private double accelerationTime;
        private int accelerationLength;
        #endregion

        #region Properties
        /// <summary>
        /// The type of engine
        /// </summary>
        public string Type
        {
            get
            {
                return type;
            }
        }
        /// <summary>
        /// The top speed of the engine measured in km/h
        /// </summary>
        public int TopSpeed
        {
            get
            {
                return topSpeed;
            }
        }
        /// <summary>
        /// How long it takes for the engine to accelerate to topspeed
        /// </summary>
        public double AccelerationTime
        {
            get
            {
                return accelerationTime;
            }
        }
        /// <summary>
        /// How far the engine moves the car before reaching its topspeed
        /// </summary>
        public int AccelerationLenght
        {
            get
            {
                return accelerationLength;
            }
        }
        #endregion

        #region Constructors
        public Engine(Car.Engines engine)
        {
            type = Enum.GetName(typeof(Car.Engines), engine);

            switch (engine)
            {
                case Car.Engines.Jondamotor:
                    topSpeed = 280;
                    accelerationTime = 2.5;
                    accelerationLength = 50;
                    break;
                case Car.Engines.Poyota:
                    topSpeed = 330;
                    accelerationTime = 4;
                    accelerationLength = 100;
                    break;
            }
        }
        #endregion

        #region Methods

        #endregion
    }
}
