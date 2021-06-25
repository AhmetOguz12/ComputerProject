ing Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ComputerManager : IComputerService
    {

        IComputerDal _computerDal;

        public ComputerManager(IComputerDal computerDal)
        {
            _computerDal = computerDal;
        }
        public List<Computer> GetAll()
        {
            return _computerDal.GetAll();
        }
    }
}
