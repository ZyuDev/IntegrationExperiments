using System;
using System.Collections.Generic;
using System.Text;

namespace IntegrationExperiments.Shared
{
    public class ResponseDto<T>
    {
        public int Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
