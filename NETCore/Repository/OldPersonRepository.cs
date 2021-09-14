using Microsoft.EntityFrameworkCore;
using NETCore.Context;
using NETCore.Models;
using NETCore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCore.Repository
{
    public class OldPersonRepository : IOldPersonRepository
    {
        private readonly MyContext myContext;
        public OldPersonRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }
        public int Delete(string NIK)
        {
            /*throw new NotImplementedException();*/
            var data = myContext.Persons.Find(NIK);
            if(data == null)
            {
                throw new ArgumentNullException();
            }
            myContext.Persons.Remove(data);
            return myContext.SaveChanges();
        }

        public IEnumerable<Person> Get()
        {
            if(myContext.Persons.ToList().Count == 0)
            {
                throw new ArgumentNullException();
            }
            return myContext.Persons.ToList();
            /*throw new NotImplementedException();*/
        }

        public Person Get(string NIK)
        {
            if(myContext.Persons.Find(NIK) != null)
            {
                return myContext.Persons.Find(NIK);
            }
            else
            {
                throw new ArgumentNullException();
            }
            /*throw new NotImplementedException();*/
            
        }

        public int Insert(Person person)
        {
            try
            {
                myContext.Persons.Add(person);
                var insert = myContext.SaveChanges();
                return insert;
            }
            catch
            {
                throw new DbUpdateException();
            }
            
            
        }

        public int Update(Person person)
        {
            /*var data = myContext.Persons.Find(NIK);*/
            /*if(data != null)
            {*/
            try
            {
                myContext.Entry(person).State = EntityState.Modified;
                return myContext.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
            /*}*/
            /*throw new NotImplementedException();*/
        }
    }
}
