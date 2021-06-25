using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IComputerDal
    {
        List<Computer> GetAll();

        void Add(Computer computer);
        void Update(Computer computer);
        void Delete(Computer computer);


    }
}