sing DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Conrete
{
    public class InMemoryComputerDal : IComputerDal
    {
        List<Computer> _computers;

        public InMemoryComputerDal()
        {
            _computers = new List<Computer> {
                new Computer{ComputerName = "Laptop1", ComputerBrand = "Bilgin1", ComputerId = 1, ComputerPrice = 5000},
                new Computer{ComputerName = "Laptop2", ComputerBrand = "Bilgin2" , ComputerId = 2, ComputerPrice = 2000},
                new Computer{ComputerName = "Laptop3", ComputerBrand = "Bilgin3" , ComputerId = 1, ComputerPrice = 1000},
                

            };
        }
            
        public void Add(Computer computer)
        {
            _computers.Add(computer);
        }

        public void Delete(Computer computer)
        {
            Computer computerToDelete = _computers.SingleOrDefault(c => c.ComputerId == computer.ComputerId);


            _computers.Remove(computerToDelete);
        }

        public List<Computer> GetAll()
        {
            return _computers;
        }

        public void Update(Computer computer)
        {
            Computer computerToUpdate = _computers.SingleOrDefault(c => c.ComputerId == computer.ComputerId);
            computerToUpdate.ComputerName = computer.ComputerName;
            computerToUpdate.ComputerBrand = computer.ComputerBrand;
            computerToUpdate.ComputerPrice = computer.ComputerPrice;
           
        }
    }
}
