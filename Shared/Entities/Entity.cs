using System;

namespace Shared.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
            CreatedAt = Guid.NewGuid();
        }

        public Guid Id { get; private set; }
        public Guid CreatedAt { get; private set; }

    }
}
