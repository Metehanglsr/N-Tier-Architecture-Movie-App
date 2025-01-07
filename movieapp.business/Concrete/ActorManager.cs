using movieapp.business.Abstract;
using movieapp.data.Abstract;
using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.business.Concrete
{
    public class ActorManager : IActorService
    {
        private IActorRepository _actorRepository;
        public ActorManager(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
        public void Create(Actor entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Actor entity)
        {
            throw new NotImplementedException();
        }

        public List<Actor> GetActorsWithFull()
        {
            return _actorRepository.GetActorsWithFull();
        }

        public Actor GetActorWithFull(int actorId)
        {
            return _actorRepository.GetActorWithFull(actorId);
        }

        public List<Actor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Actor> GetTop5Movies()
        {
            throw new NotImplementedException();
        }

        public void Update(Actor entity)
        {
            throw new NotImplementedException();
        }
    }
}
