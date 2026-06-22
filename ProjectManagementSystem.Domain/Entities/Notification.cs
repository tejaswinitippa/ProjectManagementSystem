using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectManagementSystem.Domain.Common;

namespace ProjectManagementSystem.Domain.Entities;

public class Notification : BaseEntity
{
    public string Message { get; set; } = string.Empty;

    public bool IsRead { get; set; }

    public Guid UserId { get; set; }
}
