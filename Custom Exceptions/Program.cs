using System;
using System.Runtime.Serialization;

namespace Custom_Exceptions
{
    [Serializable]
    class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException()
        { }

        public UserAlreadyLoggedInException(string message)
        : base(message)
        { }

        public UserAlreadyLoggedInException(string message, Exception innerException)
        : base(message, innerException)
        { }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
        : base(info, context)
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("User is already logged in.");
            }
            catch (UserAlreadyLoggedInException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}
