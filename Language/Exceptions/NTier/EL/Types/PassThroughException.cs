using System.Runtime.Serialization;

namespace EL.Types
{
    public class PassThroughException : BaseException, ISerializable
   { 
      public PassThroughException()
         : base()
      { 
         // Add implementation (if required)
      }

      public PassThroughException(string message)
         : base(message)
      { 
         // Add implemenation (if required)
      }

      public PassThroughException(string message, System.Exception inner)
         : base(message, inner)
      { 
         // Add implementation
      }

      protected PassThroughException(SerializationInfo info, StreamingContext context)
         : base(info, context)
      { 
         //Add implemenation
      }
   }
}
