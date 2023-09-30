using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BossAz
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerSurname { get; set; }
        public string WorkerCity { get; set; }
        public string WorkerPhone { get; set; }
        public int WorkerAge { get; set; }
        public List<CV> WorkerCVs { get; set; }
        public string WorkerUserName { get; set; }
        public string WorkerPassword { get; set; }
    }




    public class CV
    {
        public string Specialty { get; set; }
        public string School { get; set; }
        public string University { get; set; }
        public List<string> Skills { get; set; }
        public List<string> Companies { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Dictionary<string, string> Languages { get; set; }
        public bool HasDegree { get; set; }

    }

    public class Employer
    {
        public int EmployerId { get; set; }
        public string EmployerName { get; set; }
        public string EmployerSurname { get; set; }
        public string EmployerPhone { get; set; }
        public int EmployerAge { get; set; }
        public List<Vacancy> EmployerVacancies { get; set; }
        public string EmployerUserName { get; set; }
        public string EmployerPassword { get; set; }

        public List<CV> PostedCv { get; set; }
    }

    public class Vacancy
    {
        public int VacancyId { get; set; }
        public string? VacancyName { get; set; }
        public string? VacancyInfo { get; set; }
        public double VacancySalary { get; set; }


    }

    public class UserData
    {
        public List<Worker> Workers { get; set; }
        public List<Employer> Employers { get; set; }
    }

    public class LogEntry
    {
        public DateTime Timestamp { get; set; }
        public string Message { get; set; }
    }

    public class JsonDataManager
    {
        private static string UserDataFilePath = "users.json";
        private static string LogFilePath = "log.json";

        public static UserData LoadUserData()
        {
            if (File.Exists(UserDataFilePath))
            {
                string json = File.ReadAllText(UserDataFilePath);
                return JsonConvert.DeserializeObject<UserData>(json);
            }
            return new UserData();
        }

        public static void SaveUserData(UserData userData)
        {
            string json = JsonConvert.SerializeObject(userData);
            File.WriteAllText(UserDataFilePath, json);
        }


        public static void AddLogEntry(string message)
        {
            List<LogEntry> logEntries = new List<LogEntry>();

            if (File.Exists(LogFilePath))
            {
                string json = File.ReadAllText(LogFilePath);
                logEntries = JsonConvert.DeserializeObject<List<LogEntry>>(json);
            }

            logEntries = logEntries ?? new List<LogEntry>();
            logEntries.Add(new LogEntry
            {
                Timestamp = DateTime.Now,
                Message = message
            });

            string updatedJson = JsonConvert.SerializeObject(logEntries);
            File.WriteAllText(LogFilePath, updatedJson);
        }
    }

}
