using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.business.Abstract
{
    public interface IActorService
    {
        Actor GetById(int id);
        List<Actor> GetAll();
        void Create(Actor entity);
        void Update(Actor entity);
        void Delete(Actor entity);
        List<Actor> GetTop5Movies();
        public Actor GetActorWithFull(int actorId);
        public List<Actor> GetActorsWithFull();
    }
}
