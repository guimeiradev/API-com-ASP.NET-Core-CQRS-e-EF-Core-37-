using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Domain.Entities
{
    public abstract class EntityBase : IEquatable<EntityBase>
    {
        public EntityBase()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public bool Equals(EntityBase other)
        {
            // Aqui vai ser executado uma comparação entre duas entidades
            // dizendo se as duas são iguis ou nao e retornar true ou false.

            return Id == other.Id;
        }
    }
}
