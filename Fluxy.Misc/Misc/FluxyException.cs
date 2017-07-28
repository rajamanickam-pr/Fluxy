using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Fluxy.Misc
{
    [Serializable]
    public class FluxyException:Exception
    {
        public FluxyException()
        {

        }
        public FluxyException(string message)
            : base(message)
        {
        }

        public FluxyException(string messageFormat, params object[] args)
			: base(string.Format(messageFormat, args))
		{
		}

        protected FluxyException(SerializationInfo
            info, StreamingContext context)
            : base(info, context)
        {
        }

        public FluxyException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
