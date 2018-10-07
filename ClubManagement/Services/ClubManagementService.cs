using ClubManagement;
using ClubManagement.Data;
using ClubManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace C
{
    public class ClubManagementService : IClubManagementService
    {
        private ClubManagementDbContext dbContext;

        public ClubManagementService(ClubManagementDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool AddClub(Club club)
        {
            try
            {
                this.dbContext.Clubs.Add(club);
                this.dbContext.SaveChanges();
            }
            catch(SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool AddClubCenter(ClubCenter clubCenter)
        {
            try
            {
                this.dbContext.ClubCenters.Add(clubCenter);
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool AddManger(Manager manager)
        {
            try
            {
                this.dbContext.Managers.Add(manager);
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool AddMembership(Membership membership)
        {
            try
            {
                this.dbContext.MemberShips.Add(membership);
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool AddPerson(Person person)
        {
            try
            {
                this.dbContext.People.Add(person);
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool DeleteClub(Club club)
        {
            try
            {
                var clubToDelete = this.dbContext.Clubs.SingleOrDefault(c => c.ClubId == club.ClubId);
                this.dbContext.Entry(clubToDelete).State = EntityState.Deleted;
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool DeleteClubCenter(ClubCenter clubCenter)
        {
            try
            {
                var clubCenterToDelete = this.dbContext.ClubCenters.SingleOrDefault(c => c.ClubCenterId == clubCenter.ClubCenterId);
                this.dbContext.Entry(clubCenterToDelete).State = EntityState.Deleted;
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool DeleteManager(Manager manager)
        {
            try
            {
                var managerToDelele = this.dbContext.Managers.SingleOrDefault(m => m.ManagerId == manager.ManagerId);
                this.dbContext.Entry(managerToDelele).State = EntityState.Deleted;
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool DeleteMembership(Membership membership)
        {
            try
            {
                var membershipToDelele = this.dbContext.MemberShips.SingleOrDefault(m => m.MembershipId == membership.MembershipId);
                this.dbContext.Entry(membershipToDelele).State = EntityState.Deleted;
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool DeletePerson(Person person)
        {
            try
            {
                var personToDelele = this.dbContext.People.SingleOrDefault(p => p.PersonId == person.PersonId);
                this.dbContext.Entry(personToDelele).State = EntityState.Deleted;
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public Club GetClub(int id)
        {
            try
            {
                return this.dbContext.Clubs.SingleOrDefault(c => c.ClubId == id);
            }
            catch (SqlException sqlException)
            {
                return null;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public ClubCenter GetClubCenter(int id)
        {
            try
            {
                return this.dbContext.ClubCenters.SingleOrDefault(c => c.ClubCenterId == id);
            }
            catch (SqlException sqlException)
            {
                return null;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public IEnumerable<ClubCenter> GetClubCenters()
        {
            try
            {
                return this.dbContext.ClubCenters.ToList();
            }
            catch (SqlException sqlException)
            {
                return null;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public IEnumerable<Club> GetClubs()
        {
            try
            {
                return this.dbContext.Clubs.ToList();
            }
            catch (SqlException sqlException)
            {
                return null;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public Manager GetManager(int id)
        {
            try
            {
                return this.dbContext.Managers.SingleOrDefault(m => m.ManagerId == id);
            }
            catch (SqlException sqlException)
            {
                return null;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public IEnumerable<Manager> GetManagers()
        {
            try
            {
                return this.dbContext.Managers.ToList();
            }
            catch (SqlException sqlException)
            {
                return null;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public Membership GetMembership(int id)
        {
            try
            {
                return this.dbContext.MemberShips.SingleOrDefault(m => m.MembershipId == id);
            }
            catch (SqlException sqlException)
            {
                return null;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public IEnumerable<Membership> GetMemberships()
        {
            try
            {
                return this.dbContext.MemberShips.ToList();
            }
            catch (SqlException sqlException)
            {
                return null;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public IEnumerable<Person> GetPeople()
        {
            try
            {
                return this.dbContext.People.ToList();
            }
            catch (SqlException sqlException)
            {
                return null;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public Person GetPerson(int id)
        {
            try
            {
                return this.dbContext.People.SingleOrDefault(p => p.PersonId == id);
            }
            catch (SqlException sqlException)
            {
                return null;
            }
            catch (Exception exception)
            {
                return null;
            }
        }

        public bool UpdateClub(Club club)
        {
            try
            {
                var clubToUpdate = this.dbContext.Clubs.SingleOrDefault(c => c.ClubId ==  club.ClubId);
                clubToUpdate.ClubName = club.ClubName;
                clubToUpdate.ClubCenter = club.ClubCenter;
                clubToUpdate.Managers = club.Managers;
                clubToUpdate.Memberships = club.Memberships;
                clubToUpdate.OpenDate = club.OpenDate;

                this.dbContext.Entry(clubToUpdate).State = EntityState.Modified;
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool UpdateClubCenter(ClubCenter clubCenter)
        {
            try
            {
                var clubCenterToUpdate = this.dbContext.ClubCenters.SingleOrDefault(c => c.ClubCenterId == clubCenter.ClubCenterId);
                clubCenterToUpdate.Club = clubCenter.Club;
                clubCenterToUpdate.Location = clubCenter.Location;

                this.dbContext.Entry(clubCenterToUpdate).State = EntityState.Modified;
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool UpdateManager(Manager manager)
        {
            try
            {
                var managerToUpdate = this.dbContext.Managers.SingleOrDefault(m => m.ManagerId == manager.ManagerId);
                managerToUpdate.Clubs = manager.Clubs;
                managerToUpdate.FirstName = manager.FirstName;
                managerToUpdate.LastName = manager.LastName;
                managerToUpdate.Phone = manager.Phone;

                this.dbContext.Entry(managerToUpdate).State = EntityState.Modified;
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool UpdateMembership(Membership membership)
        {
            try
            {
                var membershipToUpdate = this.dbContext.MemberShips.SingleOrDefault(c => c.MembershipId == membership.MembershipId);
                membershipToUpdate.ExpireDate = membership.ExpireDate;
                membershipToUpdate.Club = membership.Club;
                membershipToUpdate.ClubId = membership.ClubId;
                membershipToUpdate.Person = membership.Person;
                membershipToUpdate.PersonId = membership.PersonId;
                membershipToUpdate.RegistrationFee = membership.RegistrationFee;

                this.dbContext.Entry(membershipToUpdate).State = EntityState.Modified;
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }

        public bool UpdatePerson(Person person)
        {
            try
            {
                var personToUpdate = this.dbContext.People.SingleOrDefault(p => p.PersonId == person.PersonId);
                personToUpdate.Email = person.Email;
                personToUpdate.FirstName = person.FirstName;
                personToUpdate.LastName = person.LastName;
                personToUpdate.Memberships = person.Memberships;
                personToUpdate.Phone = person.Phone;
                personToUpdate.RegistrationDate = person.RegistrationDate;

                this.dbContext.Entry(personToUpdate).State = EntityState.Modified;
                this.dbContext.SaveChanges();
            }
            catch (SqlException sqlException)
            {
                return false;
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;
        }
    }
}