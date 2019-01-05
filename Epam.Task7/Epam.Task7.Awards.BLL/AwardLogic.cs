using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Awards.BLL.Interface;
using Epam.Task7.DAL;
using Epam.Task7.DAL.Interfaces;
using Epam.Task7.Entities;

namespace Epam.Task7.Awards.BLL
{
    public class AwardLogic : IAwardLogic
    {
        private readonly IAwardDao awardDao;

        public AwardLogic(IAwardDao inpAwardDao)
        {
            this.awardDao = inpAwardDao;
        }

        public void Add(Award award)
        {
            this.awardDao.Add(award);
        }

        public void Delete(int id)
        {
            this.awardDao.Delete(id);
        }

        public Award GetById(int id)
        {
            return this.awardDao.GetById(id);
        }

        public void AddAwardToUser(int awardId, int userId)
        {
            this.awardDao.AddAwardToUser(awardId, userId);
        }

        public Dictionary<int, List<int>> GetDictOfAwardsAndUsers()
        {
            return this.awardDao.GetDictOfAwardsAndUsers();
        }

        public IEnumerable<Award> GetAll()
        {
            return this.awardDao.GetAll();
        }
    }
}
