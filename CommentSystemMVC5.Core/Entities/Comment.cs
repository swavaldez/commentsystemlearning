namespace CommentSystemMVC5.Core
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;    

    [Table("cmt.Comment")]
    public partial class Comment
    {
        public int CommentId { get; set; }

        public int? EntryId { get; set; }

        [Column("Comment")]
        [Required]
        [StringLength(5000)]
        public string CommentText { get; set; }

        public DateTime CreatedDate { get; set; }

        public int account_id { get; set; }

        public int ParentCommentId { get; set; }

        public bool Enabled { get; set; }

        public DateTime? DisabledDate { get; set; }
    }
}
