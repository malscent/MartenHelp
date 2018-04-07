using System;

namespace MartenHelp.Events
{
    public class Event
    {
        public int OrganizationId { get; set; }
        public int? UserId { get; set; }
        public int? ClientId { get; set; }
    }
}