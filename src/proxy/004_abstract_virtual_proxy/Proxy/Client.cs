namespace Project
{
    public class Client
    {
        private IService _service;

        public Client(IService service)
        {
            _service = service;
        }

        public bool TryGet(int rowIndex, out string rowData)
        {
            return _service.TryGet(rowIndex, out rowData);
        }
    }
}