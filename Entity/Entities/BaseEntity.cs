﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entities
{
    public class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
