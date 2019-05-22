﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectCadmium.Model.DomainClass
{
    public enum States
    {
        Draft = 0,
        WaitingApproval = 1,
        Approved = 2,
        Cancelled = 3,
        Archived = 4,
        Deleted = 5,
        Complete = 6
    }
}