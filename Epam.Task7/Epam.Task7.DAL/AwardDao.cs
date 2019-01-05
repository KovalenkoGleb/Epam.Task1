using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL.Interfaces;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public class AwardDao : IAwardDao
    {  
        private static Dictionary<int, List<int>> awardIdUsersIDs = ReadAwardToUserStorage();

        private static Dictionary<int, Award> repoAwards = ReadAwardStorage();

        public Dictionary<int, List<int>> GetDictOfAwardsAndUsers()
        {
            return awardIdUsersIDs;
        }

        public void SaveAwardToUserStorage()
        {
            using (StreamWriter sw = new StreamWriter("AwardToUsersStorage.txt"))
            {
                foreach (var item in awardIdUsersIDs)
                {
                    sw.WriteLine($"{item.Key}");
                    for (int i = 0; i < item.Value.Count; i++)
                    {
                        sw.Write($"{item.Value[i]} ");
                    }

                    sw.Write($"{Environment.NewLine}");
                }
            }
        }

        public void SaveAwardStorage()
        {
            using (StreamWriter sw = new StreamWriter("AwardStorage.txt"))
            {
                foreach (var award in repoAwards)
                {
                    sw.WriteLine($"{award.Value.Id}{Environment.NewLine}{award.Value.Title}");
                }
            }
        }

        public void Add(Award award)
        {
            int lastId = repoAwards.Any()
                ? repoAwards.Keys.Max()
                : 0;
            award.Id = ++lastId;

            repoAwards.Add(award.Id, award);
        }

        public void AddAwardToUser(int awardId, int userId)
        {
            if (!awardIdUsersIDs.ContainsKey(awardId))
            {
                awardIdUsersIDs.Add(awardId, new List<int>());
            }

            if (!awardIdUsersIDs[awardId].Contains(userId))
            {
                awardIdUsersIDs[awardId].Add(userId);
            }
        }

        public bool Delete(int id)
        {
            return repoAwards.Remove(id);
        }

        public Award GetById(int id)
        {
            if (repoAwards.TryGetValue(id, out var award))
            {
                return award;
            }

            return null;
        }

        public IEnumerable<Award> GetAll()
        {
            return repoAwards.Values;
        }

        private static Dictionary<int, Award> ReadAwardStorage()
        {
            Dictionary<int, Award> tempRepo = new Dictionary<int, Award>();

            if (!File.Exists("AwardStorage.txt"))
            {
                return tempRepo;
            }

            using (StreamReader sr = new StreamReader("AwardStorage.txt"))
            {
                while (!sr.EndOfStream)
                {
                    int sid = int.Parse(sr.ReadLine());
                    string sname = sr.ReadLine();

                    Award tempAward = new Award
                    {
                        Id = sid,
                        Title = sname,
                    };

                    tempRepo.Add(sid, tempAward);
                }
            }

            return tempRepo;
        }

        private static Dictionary<int, List<int>> ReadAwardToUserStorage()
        {
            Dictionary<int, List<int>> tempRepo = new Dictionary<int, List<int>>();

            if (!File.Exists("AwardToUsersStorage.txt"))
            {
                return tempRepo;
            }

            using (StreamReader sr = new StreamReader("AwardToUsersStorage.txt"))
            {
                while (!sr.EndOfStream)
                {
                    int aid = int.Parse(sr.ReadLine());
                    string uids = sr.ReadLine();
                    var nums = uids
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(n => int.Parse(n));
                    List<int> templist = new List<int>();
                    foreach (int i in nums)
                    {
                        templist.Add(i);
                    }

                    tempRepo.Add(aid, templist);
                }
            }

            return tempRepo;
        }
    }
}