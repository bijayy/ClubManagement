using ClubManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement
{
    public interface IClubManagementService
    {
        //Person
        bool AddPerson(Person person);

        Person GetPerson(int id);

        IEnumerable<Person> GetPeople();

        bool DeletePerson(Person person);

        bool UpdatePerson(Person person);


        //Club
        bool AddClub(Club club);

        Club GetClub(int id);

        IEnumerable<Club> GetClubs();

        bool DeleteClub(Club club);

        bool UpdateClub(Club club);

        //Club Center
        bool AddClubCenter(ClubCenter clubCenter);

        ClubCenter GetClubCenter(int id);

        IEnumerable<ClubCenter> GetClubCenters();

        bool DeleteClubCenter(ClubCenter clubCenter);

        bool UpdateClubCenter(ClubCenter clubCenter);

        //Managers
        bool AddManger(Manager manager);

        Manager GetManager(int id);

        IEnumerable<Manager> GetManagers();

        bool DeleteManager(Manager manager);

        bool UpdateManager(Manager manager);

        //Membership
        bool AddMembership(Membership membership);

        Membership GetMembership(int id);

        IEnumerable<Membership> GetMemberships();

        bool DeleteMembership(Membership membership);

        bool UpdateMembership(Membership membership);
    }
}
