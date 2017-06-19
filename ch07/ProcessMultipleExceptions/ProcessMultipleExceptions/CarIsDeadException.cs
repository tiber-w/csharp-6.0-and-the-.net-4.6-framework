using System;
using System.Runtime.Serialization;

namespace ProcessMultipleExceptions
{
    // This custom exception describes the details of the car-is-dead condition.
    // (Remember, you can also simply extend Exception.)
    [Serializable]
    class CarIsDeadException : ApplicationException
    {
        //private string messageDetails = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }

        public CarIsDeadException()
        {
        }

        public CarIsDeadException(string message)
            : base(message)
        {
        }

        public CarIsDeadException(string message, Exception inner)
            : base(message, inner)
        {
        }

        public CarIsDeadException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public CarIsDeadException(string message, string cause, DateTime time)
            : base(message)
        {
            //messageDetails = message;
            CauseOfError = cause;
            ErrorTimeStamp = time;
        }

        // Override the Exception.Message property.
        //public override string Message
        //{
        //    get
        //    {
        //        return String.Format("Car Error Message: {0}", messageDetails);
        //    }
        //}
    }
}
