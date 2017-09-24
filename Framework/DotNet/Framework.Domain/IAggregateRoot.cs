using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Domain
{
    public interface IAggregateRoot : IEntity
    {
        int Id { get; set; }
    }
}
