﻿using System.Collections.Generic;
using System;

namespace EFCoreCRUD.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string Text { get; set; }
        public DateTime PublishedData { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
