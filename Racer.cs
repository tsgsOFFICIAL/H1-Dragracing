using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace H1_Dragracing
{
    public class Racer
    {
        #region Fields
        private Stopwatch trackTimer;
        private string name;
        private string face;
        private byte age;
        private byte number;
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
        /// The racers number
        /// </summary>
        public byte Number
        {
            get
            {
                return number;
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
        public Stopwatch TrackTimer
        {
            get
            {
                return trackTimer;
            }
        }
        /// <summary>
        /// The different faces to choose from
        /// </summary>
        public enum Faces
        {
            Happy,
            Sad,
            Neutral,
            Hopeless,
            Excited,
            Confused,
            Tired
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Initialises a new instance of the racer class
        /// </summary>
        /// <param name="name">What is the racer called?</param>
        /// <param name="face">What facial expression does the racer have?</param>
        /// <param name="age">How old is the racer?</param>
        /// <param name="car">What car does the racer drive?</param>
        public Racer(string name, byte age, byte number, Faces face, Car car)
        {
            trackTimer = new Stopwatch();
            this.name = name;

            ChangeFacialExpression(face);

            this.age = age;
            this.number = number;
            this.car = car;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Change the facial expression of the racer
        /// </summary>
        /// <param name="face">The type of face to switch to</param>
        public void ChangeFacialExpression(Faces face)
        {
            switch (face)
            {
                case Faces.Happy:
                    this.face = "^_^";
                    break;
                case Faces.Sad:
                    this.face = "~_~";
                    break;
                case Faces.Neutral:
                    this.face = "o_o";
                    break;
                case Faces.Hopeless:
                    this.face = "*_*";
                    break;
                case Faces.Excited:
                    this.face = "$_$";
                    break;
                case Faces.Confused:
                    this.face = "o_O";
                    break;
                case Faces.Tired:
                    this.face = "-_-";
                    break;
            }
        }
        #endregion
    }
}