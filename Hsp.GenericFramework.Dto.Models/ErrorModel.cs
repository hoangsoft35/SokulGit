using System.Collections.Generic;

namespace Hsp.GenericFramework.Dto.Models
{
    public class ErrorModel<T>
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public T ObjectData {get;set;}
        public List<T> ListData { get; set; }

        
    }
    public class ErrorModel
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
