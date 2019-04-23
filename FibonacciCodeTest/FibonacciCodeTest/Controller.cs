using System;
using System.Collections.Generic;
using System.Text;

namespace ForTheRecordNet
{
    /// <summary>
    /// Singleton Controller object. Used to control the timer and output of given input's from the user. There can only ever be one controller.
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Singleton instance object
        /// </summary>
        private static Controller _instance = null;

        // Instance properties

        private Dictionary<int, int> _inputs = new Dictionary<int, int>();

        private Controller()
        {

        }

        public static Controller GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Controller();
            }

            return _instance;
        }

        /// <summary>
        /// Number of seconds between outputed numbers.
        /// </summary>
        public int Seconds { get; set; }

        public void AddInput(int input)
        {
            if (_inputs.ContainsKey(input))
                _inputs[input]++;
            else
                _inputs.Add(input, 1);
        }
    }
}
