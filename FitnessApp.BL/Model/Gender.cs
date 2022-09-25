using System;
using FitnessApp.BL.Model;

namespace FitnessApp.BL.Model
{
    /// <summary>
    /// Gender
    /// </summary>

    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Name
        /// </summary>
        
        public string Name { get; }

        /// <summary>
        /// Create a new gender
        /// </summary>
        /// <param name="name">Gender name</param>
        /// <exception cref="ArgumentNullException"></exception>
        
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name is not NULL or WHITE SPACE");
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

