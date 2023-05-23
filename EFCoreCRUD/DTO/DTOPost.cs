using System;

namespace EFCoreCRUD.DTO
{
    public class DTOPost
    {
        public int AuthorId { get; set; }
        public string Text { get; set; }
        public DateTime PublishedData { get; set; }
    }
}
