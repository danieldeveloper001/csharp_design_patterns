using System;

namespace Project
{
    class RequestPipeline
    {
        private IHandler _handler;

        public RequestPipeline()
        {
            var logHandler = new LogHandler();
            var authorizationHandler = new AuthorizationHandler();
            var requestHandler = new RequestHandler();

            logHandler.Next = authorizationHandler;
            authorizationHandler.Next = requestHandler;

            _handler = logHandler;
        }

        public void Process(Request request, User user)
        {
            _handler.Handle(request, user);
        }
    }
}
