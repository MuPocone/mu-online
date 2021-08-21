using System;

namespace MuOnline.Infrastruture.Application.Core
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
        public Guid AggregateId { get; protected set; }
        public DateTime DataCriacao { get; protected set; }

        protected Entity()
        { 
            DataCriacao = DateTime.Now;
        }
    }
}