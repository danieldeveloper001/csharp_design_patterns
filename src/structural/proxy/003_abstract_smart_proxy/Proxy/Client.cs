namespace Project
{
    public class Client
    {
        private IService _service;

        public Client(IService service)
        {
            _service = service;
        }

        public bool Operation(string parameter)
        {
            return _service.Operation(parameter);
        }
    }
}