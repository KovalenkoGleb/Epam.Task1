using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL.Interfaces
{
    public interface IAwardDao
    {
        void Add(Award user);

        bool Delete(int id);

        Award GetById(int id);

        void SaveAwardStorage();

        void SaveAwardToUserStorage();

        void AddAwardToUser(int awardId, int userId);

        Dictionary<int, List<int>> GetDictOfAwardsAndUsers();

        IEnumerable<Award> GetAll();
    }
}
