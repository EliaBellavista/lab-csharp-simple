namespace Properties
{
    using System;

    /// <summary>
    /// The class models a card.
    /// </summary>
    public class Card
    {
        private readonly string _seed;
        private readonly string _name;
        private readonly int _ordinal;

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="name">the name of the card.</param>
        /// <param name="seed">the seed of the card.</param>
        /// <param name="ordinal">the ordinal number of the card.</param>
        public Card(string name, string seed, int ordinal)
        {
            this._name = name;
            this._ordinal = ordinal;
            this._seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="tuple">the informations about the card as a tuple.</param>
        internal Card(Tuple<string, string, int> tuple) : this(tuple.Item1, tuple.Item2, tuple.Item3)
        {
        }

        // TODO improve
        public string GetSeed() => _seed;

        // TODO improve
        public string GetName() => _name;

        // TODO improve
        public int GetOrdinal() => _ordinal;

        /// <inheritdoc cref="object.ToString"/>
        public override string ToString()
        {
            // TODO understand string interpolation
            return $"{this.GetType().Name}(Name={this.GetName()}, Seed={this.GetSeed()}, Ordinal={this.GetOrdinal()})";
        }

        public override bool Equals(object obj)
        {
            return obj is Card card &&
                   _seed == card._seed &&
                   _name == card._name &&
                   _ordinal == card._ordinal;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_seed, _name, _ordinal);
        }

        // TODO generate Equals(object obj)

        // TODO generate GetHashCode()


    }
}
