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
        /// <summary>
        /// Start the race
        /// </summary>
        public void Start()
        {

        }
        /// <summary>
        /// Add a racer to the race
        /// </summary>
        /// <param name="name">The name of the racer</param>
        /// <param name="face">The facial expression of the racer</param>
        /// <param name="age">The age of the racer</param>
        /// <param name="car">The car the racer is driving</param>
        public void AddRacer(string name, byte age, byte number, Racer.Faces face, Car car)
        {
            racers.Add(new Racer(name, age, number, face, car));
        }
        /// <summary>
        /// Remove a racer from the race
        /// </summary>
        /// <param name="name">The racers name, CaSe SeNsItIvE</param>
        public void RemoveRacer(string name)
        {
            foreach (Racer racer in racers)
            {
                if (racer.Name.Equals(name))
                {
                    racers.Remove(racer);
                    return;
                }
            }
        }
        #endregion
    }
}
