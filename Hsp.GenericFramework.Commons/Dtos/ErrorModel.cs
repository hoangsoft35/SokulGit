using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hsp.GenericFramework.Commons.Dtos
{
    public class ErrorModel<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public T ObjectData {get;set;}
        public List<T> ListData { get; set; }
    }
}
