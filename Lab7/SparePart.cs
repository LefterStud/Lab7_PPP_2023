using System.Text.RegularExpressions;

namespace Lab7
{
    /// <summary>
    /// A class that represents the properties of a certain spare part.
    /// </summary>
    public class SparePart
    {
        private string _name;
        private int _id;
        private int _cost;
        private int _weight;

        /// <summary>
        /// Creates a new instance of the SparePart class.
        /// </summary>
        /// <param name="name">Name of the spare part.</param>
        /// <param name="id">Id of the spare part.</param>
        /// <param name="cost">Cost of the spare part.</param>
        /// <param name="weight">Weight of the spare part.</param>
        public SparePart(string name, int id, int cost, int weight)
        {
            Name = name;
            Id = id;
            Cost = cost;
            Weight = weight;
        }

        /// <summary>
        /// Setter and getter for the _name field.
        /// Spare part`s name.
        /// </summary>
        public string Name
        {
            get => _name;
            init
            {
                if (!string.IsNullOrEmpty(value) && Regex.IsMatch(value, @"^[A-Za-z ]+$"))
                {
                    _name = value.Trim();
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Incorrect name of spare part!");
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _id field.
        /// Spare part`s id.
        /// </summary>
        public int Id
        {
            get => _id;
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Incorrect id of spare part!");
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _cost field.
        /// Spare part`s cost.
        /// </summary>
        public int Cost
        {
            get => _cost;
            set
            {
                if (value > 0)
                {
                    _cost = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Incorrect cost of spare part!");
                }
            }
        }

        /// <summary>
        /// Setter and getter for the _weight field.
        /// Spare part`s weight.
        /// </summary>
        public int Weight
        {
            get => _weight;
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Incorrect weight of spare part!");
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name};\n" +
                   $"Id: {Id};\n" +
                   $"Weight: {Weight};\n" +
                   $"Cost: {Cost};\n";
        }
    }
}
