using System.Collections.Generic;

namespace Hsp.GenericFramework.Dto.Models
{
    public class ErrorModel<T>
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public T ObjectData {get;set;}
        public List<T> ListData { get; set; }

        
    }
    public class ErrorModel
    {
        public int Code { get; set; }
        public string Message { get; set; }
    }
}
