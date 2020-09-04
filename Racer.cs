using System;
using System.Collections.Generic;
using System.Text;

namespace H1_Dragracing
{
    public class Racer
    {
        #region Fields
        private DateTime trackTime;
        private string name;
        private string face;
        private byte age;
        private Car car;

        #endregion

        #region Properties
        /// <summary>
        /// The name of the racer
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }
        /// <summary>
        /// The facial expression of the racer
        /// </summary>
        public string Face
        {
            get
            {
                return face;
            }
        }
        /// <summary>
        /// The age of the racer
        /// </summary>
        public byte Age
        {
            get
            {
                return age;
            }
        }
        /// <summary>
        /// The racers Car object
        /// </summary>
        public Car Car
        {
            get
            {
                return car;
            }
        }
        /// <summary>
        /// The track time is the time it took the racer to complete the track
        /// </summary>
        public DateTime TrackTime
        {
            get
            {
                return trackTime;
            }
        }
        #endregion

        #region Constructors
        public Racer()
        {

        }
        #endregion

        #region Methods

        #endregion
    }
}