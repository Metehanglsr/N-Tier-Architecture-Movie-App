using movieapp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.data.Abstract
{
    public interface IDirectorRepository : IRepository<Director>
    {
        public Director GetDirectorWithFull(int directorId);
        public List<Director> GetDirectorsWithFull();
    }
}