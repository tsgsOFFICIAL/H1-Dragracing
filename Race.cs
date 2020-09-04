using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Dragracing
{
    public class Race
    {
        #region Fields
        private List<Racer> racers;
        private int distance;

        #endregion

        #region Properties
        /// <summary>
        /// A List containing all the racers
        /// </summary>
        public List<Racer> Racers
        {
            get
            {
                return racers;
            }
        }
        /// <summary>
        /// The distance the racers must drive
        /// </summary>
        public int Distance
        {
            get
            {
                return distance;
            }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// This initialises a new instance of the class Race, giving it a default distance of 400m if nothing else is specified!
        /// </summary>
        public Race()
        {
            racers = new List<Racer>();
            distance = 400;
        }
        /// <summary>
        /// This initialises a new instance of the class Race, giving it a distance as specified in passed argument
        /// </summary>
        public Race(int distance)
        {
            racers = new List<Racer>();
            this.distance = distance;
        }
        #endregion

        #region Methods

        #endregion
    }
}
