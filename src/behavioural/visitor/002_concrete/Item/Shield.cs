namespace Project
{
    public class Shield : IItem
    {
        private int _defense;
        public int Defense
        {
            get => _defense;
            set => _defense = value >= 0 && value <= 100 ? value : _defense;
        }

        private int _speed;
        public int Speed
        {
            get => _speed;
            set => _speed = value >= 0 && value <= 100 ? value : _speed;
        }

        public Shield(int defense, int speed)
        {
            Defense = defense;
            Speed = speed;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}