using System.Runtime.Serialization;

namespace EL.Types
{
    public class BusinessLogicCustomException : BaseException, ISerializable
   {
      public BusinessLogicCustomException()
         : base()
      {
         // Add implementation (if required)
      }

      public BusinessLogicCustomException(string message)
         : base(message)
      { 
         // Add Implementation (if required)
      }

      public BusinessLogicCustomException(string message, System.Exception inner)
         : base(message, inner)
      { 
         // Add implementation (if required)
      }

      protected BusinessLogicCustomException(SerializationInfo info, StreamingContext context)
         : base(info, context)
      { 
         // Add implementation (if required)
      }
   }
}
