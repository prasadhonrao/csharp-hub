using System.Runtime.Serialization;

namespace EL.Types
{
    public class DataAccessCustomException: BaseException, ISerializable
   {
      public DataAccessCustomException()
         : base()
      { 
         //Add Implementation
      }

      public DataAccessCustomException(string message)
         : base(message)
      { 
         //Add Implementation
      }

      public DataAccessCustomException(string message, System.Exception inner)
         : base(message, inner)
      { 
         //Add Implementation
      }

      protected DataAccessCustomException(SerializationInfo info, StreamingContext context)
         : base(info, context)
      { 
         //Add Implementation
      }
   }
}
