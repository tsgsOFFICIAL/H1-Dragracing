using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace H1_Dragracing
{
    public class Car
    {
        #region Fields
        private ConsoleColor color;
        private Engine engine;
        #endregion

        #region Properties
        /// <summary>
        /// The color of the car
        /// </summary>
        public ConsoleColor Color
        {
            get
            {
                return color;
            }
        }
        /// <summary>
        /// The engine of the car
        /// </summary>
        public Engine Engine
        {
            get
            {
                return engine;
            }
        }
        /// <summary>
        /// The type of engine
        /// </summary>
        public enum Engines
        {
            Jondamotor,
            Poyota
        }
        #endregion

        #region Constructors
        public Car(ConsoleColor color, Engines engine)
        {
            this.color = color;
            this.engine = new Engine(engine);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Change the eninge of the car
        /// </summary>
        /// <param name="engine">The type of engine to change to</param>
        public void ChangeEngine(Engines engine)
        {
            this.engine = new Engine(engine);
        }
        #endregion
    }
}
