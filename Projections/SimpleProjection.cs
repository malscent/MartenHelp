using System;
using MartenHelp.Events;

namespace MartenHelp.Projections
{
    public class SimpleProjection
    {
        public Guid Id { get; set; }
        public int OrganizationId { get; set; }
        public int? UserId { get; set; }
        public int? ClientId { get; set; }

        public void Apply(Event e)
        {
            this.OrganizationId = e.OrganizationId;
            this.UserId = e.UserId;
            this.ClientId = e.ClientId;
        }
    }
}