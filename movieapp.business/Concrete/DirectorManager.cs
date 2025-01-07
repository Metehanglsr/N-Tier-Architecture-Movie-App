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
    public class DirectorManager : IDirectorService
    {
        private IDirectorRepository _directorRepository;
        public DirectorManager(IDirectorRepository directorRepository)
        {
            _directorRepository = directorRepository;
        }
        public void Create(Director entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Director entity)
        {
            throw new NotImplementedException();
        }

        public List<Director> GetAll()
        {
            throw new NotImplementedException();
        }

        public Director GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Director> GetDirectorsWithFull()
        {
            return _directorRepository.GetDirectorsWithFull();
        }

        public Director GetDirectorWithFull(int directorId)
        {
            return _directorRepository.GetDirectorWithFull(directorId);
        }

        public void Update(Director entity)
        {
            throw new NotImplementedException();
        }
    }
}
