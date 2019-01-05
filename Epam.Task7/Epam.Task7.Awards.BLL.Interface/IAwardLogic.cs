using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Entities;

namespace Epam.Task7.Awards.BLL.Interface
{
    public interface IAwardLogic
    {
        void Add(Award user);

        void Delete(int id);

        Award GetById(int id);

        IEnumerable<Award> GetAll();

        void AddAwardToUser(int awardId, int userId);

        Dictionary<int, List<int>> GetDictOfAwardsAndUsers();
    }
}
