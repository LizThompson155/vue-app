using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Liz.VueApp.Books
{
    [Table("BcBook")]
    public class Book : FullAuditedEntity, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public string Title { get; set; }        
        public string Author { get; set; }
    }
}
