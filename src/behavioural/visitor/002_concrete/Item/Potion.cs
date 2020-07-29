namespace Project
{
    public class Potion : IItem
    {
        private int _magic;
        public int Magic
        {
            get => _magic;
            set => _magic = value >= 0 && value <= 100 ? value : _magic;
        }

        public Potion(int magic)
        {
            Magic = magic;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}