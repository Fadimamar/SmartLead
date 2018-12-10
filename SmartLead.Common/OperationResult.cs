using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLead.Common
{
   public class OperationResults<T>
    {
        public T Result { get; set; }
        public string Message { get; set; }

        public OperationResults(T result, string message)
        {
            this.Result = result;
            this.Message = message;
        }
    }
}

