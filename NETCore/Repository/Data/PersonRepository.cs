using Microsoft.EntityFrameworkCore;
using NETCore.Context;
using NETCore.Models;
using NETCore.ViewModel;
using System.Collections.Generic;
using System.Linq;
using static NETCore.Models.Person;

namespace NETCore.Repository.Data
{
    public class PersonRepository : GeneralRepository<MyContext, Person, string>
    {
        private readonly MyContext myContext;
        public PersonRepository(MyContext myContext) : base(myContext)
        {
            this.myContext = myContext;
        }
        public IEnumerable<PersonVM> GetPersonVMs()
        {
            var getPersonVMs = (from p in myContext.Persons
                                join a in myContext.Accounts on
                                p.NIK equals a.NIK
                                join prf in myContext.Profilings on
                                a.NIK equals prf.NIK
                                join e in myContext.Educations on
                                prf.EducationId equals e.EducationId
                                join u in myContext.Universities on
                                e.UniversityId equals u.UniversityId

                                select new PersonVM
                                {
                                    NIK = p.NIK,
                                    Token = p.Token,
                                    FullName = p.FirstName + " " + p.LastName,
                                    FirstName = p.FirstName,
                                    LastName = p.LastName,
                                    Phone = p.Phone,
                                    BirthDate = p.BirthDate,
                                    gender = (PersonVM.Gender)p.gender,
                                    Salary = p.Salary,
                                    Email = p.Email,
                                    //Password = a.Password,
                                    Degree = e.Degree,
                                    GPA = e.GPA,
                                    UniversityId = u.UniversityId
                                }).ToList();
            return getPersonVMs;
        }

        public PersonVM GetPersonVMs(string NIK)
        {
            var getPersonVMs = (from p in myContext.Persons
                                join a in myContext.Accounts on
                                p.NIK equals a.NIK
                                join prf in myContext.Profilings on
                                a.NIK equals prf.NIK
                                join e in myContext.Educations on
                                prf.EducationId equals e.EducationId
                                join u in myContext.Universities on
                                e.UniversityId equals u.UniversityId

                                //join ar in myContext.AccountRoles on a.NIK equals ar.AccountId
                                //join r in myContext.Roles on ar.RoleId equals r.RoleId

                                select new PersonVM
                                {
                                    NIK = p.NIK,
                                    FullName = p.FirstName + " " + p.LastName,
                                    FirstName = p.FirstName,
                                    LastName = p.LastName,
                                    Phone = p.Phone,
                                    BirthDate = p.BirthDate,
                                    /*gender = p.gender.getS,*/
                                    gender = (PersonVM.Gender)p.gender,
                                    Salary = p.Salary,
                                    Email = p.Email,
                                    //Password = a.Password,
                                    Degree = e.Degree,
                                    GPA = e.GPA,
                                    UniversityId = u.UniversityId,
                                    //Role = String.Concat(r.Name);
                                }).Where(p => p.NIK == NIK).First();
            return getPersonVMs;
        }

        //register
        public int Insert(PersonVM personVM)
        {
            try
            {
                /*myContext.per.Add(entity);*/
                /*Person person = new Person(personVM.NIK,
                                               personVM.FirstName,
                                               personVM.LastName,
                                               personVM.Phone,
                                               personVM.BirthDate,
                                               personVM.Salary,
                                               personVM.Email,
                                               (Gender)personVM.gender
                                               );*/
                Person person = new Person();
                person.Email = personVM.Email;
                if (isDuplicate(personVM.Email.ToString(), "Email") == true)
                {
                    return 100;
                }
                person.FirstName = personVM.FirstName;
                person.NIK = personVM.NIK;
                if (isDuplicate(personVM.NIK.ToString(), "NIK") == true)
                {
                    return 200;
                }
                person.LastName = personVM.LastName;
                person.Phone = personVM.Phone;
                if (isDuplicate(personVM.Phone.ToString(), "Phone") == true)
                {
                    return 300;
                }
                person.BirthDate = personVM.BirthDate;
                person.Salary = personVM.Salary;
                person.gender = (Gender)personVM.gender;
                myContext.Persons.Add(person);
                myContext.SaveChanges();

                Account account = new Account(personVM.NIK, BCrypt.Net.BCrypt.HashPassword(personVM.Password));
                myContext.Accounts.Add(account);
                myContext.SaveChanges();

                /*University university = new University("Temp Name");
                myContext.Universities.Add(university);*/

                Education education = new Education(personVM.Degree, personVM.GPA, personVM.UniversityId);
                myContext.Educations.Add(education);
                myContext.SaveChanges();

                AccountRole ar = new AccountRole
                {
                    AccountId = person.NIK,
                    RoleId = 1
                };
                myContext.AccountRoles.Add(ar);
                myContext.SaveChanges();

                Profiling profiling = new Profiling(personVM.NIK, education.EducationId);
                myContext.Profilings.Add(profiling);
                var insert = myContext.SaveChanges();

                //AccountRole ar = new AccountRole(personVM.NIK, education.EducationId);
                //myContext.Profilings.Add(profiling);
                //var insert = myContext.SaveChanges();

                return insert;
            }
            catch
            {
                throw new DbUpdateException();
            }
        }

        public bool isDuplicate(string word, string type)
        {
            var sql = $"SELECT * From Persons Where {type} = '{word}'";
            var data = myContext.Persons.FromSqlRaw(sql).FirstOrDefault();
            if (data != null)
            {
                return true;
            }
            return false;
        }
        //test
        public int Login(LoginVM loginVM)
        {
            //return 100 = email ga ketemu
            //return 200 = password salah
            //return 1 = login berhasil
            var checkEmail = myContext.Persons.Where(e => e.Email == loginVM.Email).FirstOrDefault();
            if (checkEmail == null)
            {
                return 100;
            }
            /*if(checkEmail)*/
            var account = myContext.Accounts.Where(n => n.NIK == checkEmail.NIK).FirstOrDefault();
            if (account == null)
            {
                return 100;
            }
            if (!BCrypt.Net.BCrypt.Verify(loginVM.Password, account.Password))
            {
                return 200; //Nambah Comment ini
            }
            return 1;
        }

        public string[] Roles(string email)
        {
            var all = (from p in myContext.Persons
                       join a in myContext.Accounts on p.NIK equals a.NIK
                       join b in myContext.AccountRoles on a.NIK equals b.AccountId
                       join c in myContext.Roles on b.RoleId equals c.RoleId
                       where p.Email == email
                       select new Role
                       {
                           Name = c.Name
                       }).ToList();
            
            string[] roles = new string[all.Count];

            for (int i = 0; i < all.Count; i++)
            {
                roles[i] = all[i].Name;
            }
            return roles;
        }
    }
}
