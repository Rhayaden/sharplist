namespace Sharplist.Shows
{
    public abstract class Show
    {
        public abstract int Id { get; }
        public abstract string Year { get; }
        public abstract string Title { get; }
        public abstract string Category { get; }
        public virtual string Presentation => "";
        public override string ToString() => $"{Title} ({Year})";
        public override bool Equals(object obj)
        {
            return obj is Show show && Id == show.Id;
        }
        public override int GetHashCode()
        {
            return Id;
        }
    }
}