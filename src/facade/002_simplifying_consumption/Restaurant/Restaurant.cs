using System;

namespace Project
{
    public interface IRestaurant
    {
        void Serve(ICustomer customer);
    }

    public class Restaurant : IRestaurant
    {
        public void Serve(ICustomer customer)
        {
            throw new NotImplementedException();
        }
    }
}
