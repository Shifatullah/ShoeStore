using Framework.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Products.Domain
{
    public class AuditInfo : IValueObject
    {
        public DateTimeOffset CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public DateTimeOffset ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }

        public DateTimeOffset DeletedOn { get; set; }
        public string DeletedBy { get; set; }
    }
}
