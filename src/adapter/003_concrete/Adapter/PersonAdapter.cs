using System;

namespace Project
{
    public abstract class PersonAdapter
    {
        protected Person _person;

        public PersonAdapter(Person person)
        {
            _person = person;
        }
    }
}
