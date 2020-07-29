using System;
using System.Collections.Generic;
using System.Text;

namespace Neurotech.Application.EventSourcedNomalizers
{
    public class RegisterResultData
    {
        public string OperationCode { get; set; }

        public string StatusCode { get; set; }

        public string Message { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public ResultData Result { get; set; }

    }
}
