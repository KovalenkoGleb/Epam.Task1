using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL.Interfaces;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public class AwardSQLDao : IAwardDao
    {
        private static Dictionary<int, List<int>> awardIdUsersIDs = ReadAwardToUserStorage();        

        private string _connectionString;

        public AwardSQLDao()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public void Add(Award award)
        {
            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "AddAward";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterTitle = new SqlParameter("@Title", award.Title);
                command.Parameters.Add(parameterTitle);

                SqlParameter parameterurl = new SqlParameter("@url", award.url);
                command.Parameters.Add(parameterurl);                

                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
            }
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
            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DeleteAward";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);

                sqlConnection.Open();
                var reader = command.ExecuteNonQuery();
                return true;
            }
        }

        public IEnumerable<Award> GetAll()
        {
            var result = new List<Award>();
            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "SELECT * FROM [dbo].[Award]";
                command.CommandType = CommandType.Text;
                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(
                        new Award
                        {
                            Id = (int)reader["Id"],
                            Title = (string)reader["Title"],
                            url = (string)reader["url"],                            
                        });
                }
            }

            return result;
        }

        public Award GetById(int id)
        {
            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "GetAwardById";
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter parameterId = new SqlParameter("@Id", id);
                command.Parameters.Add(parameterId);

                sqlConnection.Open();
                var reader = command.ExecuteReader();

                Award result = new Award();
                while (reader.Read())
                {
                    result =
                        new Award
                        {
                            Id = (int)reader["Id"],
                            Title = (string)reader["Title"],
                            url = (string)reader["url"],                           
                        };
                }

                return result;
            }
        }

        public Dictionary<int, List<int>> GetDictOfAwardsAndUsers()
        {
            return awardIdUsersIDs;
        }

        public void SaveAwardStorage()
        {
            throw new NotImplementedException();
        }

        public void SaveAwardToUserStorage()
        {
            throw new NotImplementedException();
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
    }
}
