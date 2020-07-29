namespace Project
{
    public class Sword : IItem
    {
        private int _attack;
        public int Attack
        {
            get => _attack;
            set => _attack = value >= 0 && value <= 100 ? value : _attack;
        }

        private int _speed;
        public int Speed
        {
            get => _speed;
            set => _speed = value >= 0 && value <= 100 ? value : _speed;
        }

        public Sword(int attack, int speed)
        {
            Attack = attack;
            Speed = speed;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}