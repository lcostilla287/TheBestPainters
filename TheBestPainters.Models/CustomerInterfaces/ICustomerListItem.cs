﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBestPainters.Models.PersonInterfaces;

namespace TheBestPainters.Models.CustomerInterfaces
{
    public interface ICustomerListItem : IPersonId, IContactInfo, IFullName
    {
    }
}