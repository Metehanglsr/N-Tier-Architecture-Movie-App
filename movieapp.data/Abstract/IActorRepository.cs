using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.data.Abstract
{
    public interface IActorRepository : IRepository<Actor>
    {
        public Actor GetActorWithFull(int actorId);
        public List<Actor> GetActorsWithFull();
    }
}