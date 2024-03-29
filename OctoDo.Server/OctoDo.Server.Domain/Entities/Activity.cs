﻿namespace OctoDo.Server.Domain.Entities;
public class Activity : BaseEntity
{
    public string? Title { get; set; }
    public string? Description { get; set; }
    public Routine? Routine { get; set; }
    public int ScheduledHour { get; set; }
    public int ScheduledMinute { get; set; }
    public int DurationHours { get; set; }
    public int DurationMinutes { get; set; }
    public int DurationSeconds { get; set; }
}