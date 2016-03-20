﻿using System;

namespace Ecommerce.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime DtInclusao { get; set; }
        public DateTime? DtAlteracao { get; set; }

    }
}
