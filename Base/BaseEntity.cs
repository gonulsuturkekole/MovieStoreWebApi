using System.IO;

namespace MovieStoreWebApi.Base
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
