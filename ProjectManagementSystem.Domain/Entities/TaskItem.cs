using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystem.Domain.Common;
using ProjectManagementSystem.Domain.Enums;
using TaskStatus = ProjectManagementSystem.Domain.Enums.TaskStatus;

namespace ProjectManagementSystem.Domain.Entities;

public class TaskItem : BaseEntity
{
    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public TaskPriority Priority { get; set; }

    public TaskStatus Status { get; set; }

    public DateTime DueDate { get; set; }

    public Guid AssignedUserId { get; set; }

    public Guid ProjectId { get; set; }
}