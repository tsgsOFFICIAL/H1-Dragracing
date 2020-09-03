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
        public Race()
        {
            racers = new List<Racer>();
        }
        #endregion

        #region Methods

        #endregion
    }
}
