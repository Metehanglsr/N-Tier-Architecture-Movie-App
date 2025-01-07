using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.business.Abstract
{
    public interface IDirectorService
    {
        Director GetById(int id);
        List<Director> GetAll();
        void Create(Director entity);
        void Update(Director entity);
        void Delete(Director entity);
        public Director GetDirectorWithFull(int directorId);
        public List<Director> GetDirectorsWithFull();
    }
}
