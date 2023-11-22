namespace VergaraRuben_DI1aEv
{
    internal class Record
    {
        public string Name { get; }
        public byte Age { get; }
        public byte Score{ get; }

        public Record(string name, byte age, byte score)
        {
            this.Name = name;
            this.Age = age;
            this.Score = score;
        }


        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}, {nameof(Score)}: {Score}";
        }

        protected bool Equals(Record other)
        {
            return Name == other.Name && Age == other.Age && Score == other.Score;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Record)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age, Score);
        }
    }
}
