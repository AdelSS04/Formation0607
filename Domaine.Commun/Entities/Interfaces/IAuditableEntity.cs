﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaine.Commun.Entities
{
    public interface IAuditableEntity : ICreatedAuditEntity, IEditAuditEntity
    {


    }
}
