using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace BossAz
{
   partial  class Program
    {


        static UserData userData = new UserData
        {
            Workers = new List<Worker>(),
            Employers = new List<Employer>()
        };


        static int selectedIndex = 0;
        static int totalOptions = 3;


        static void RegisterWorker()
        {
            Console.Clear();
            Console.WriteLine($@"
                                       ____  _____  ___  ___      __    ____ 
                                      (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                       ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                      (____/(_____)(___/(___/  (__)(__)(____)


 ");
            Console.WriteLine("\t\t\t\tWorker Register");

            Worker worker = new Worker();

            Console.Write("\t\t\t\tName: ");
            worker.WorkerName = Console.ReadLine();

            Console.Write("\t\t\t\tSurname: ");
            worker.WorkerSurname = Console.ReadLine();

            Console.Write("\t\t\t\tCity: ");
            worker.WorkerCity = Console.ReadLine();

            Console.Write("\t\t\t\tTelephone Number: ");
            worker.WorkerPhone = Console.ReadLine();

            Console.Write("\t\t\t\tAge: ");
            worker.WorkerAge = int.Parse(Console.ReadLine());

            Console.Write("\t\t\t\tUsername: ");
            worker.WorkerUserName = Console.ReadLine();

            Console.Write("\t\t\t\tPassword: ");
            worker.WorkerPassword = Console.ReadLine();

            worker.WorkerCVs = new List<CV>();
;

            userData.Workers.Add(worker);
            JsonDataManager.SaveUserData(userData);

            string logMessage = $"[{DateTime.Now}] Worker {worker.WorkerName} {worker.WorkerSurname} registered.";
            JsonDataManager.AddLogEntry(logMessage);

            Console.WriteLine("\t\t\t\tWorker Registered Successfully");
            System.Threading.Thread.Sleep(1000);
        }


        static void RegisterEmployer()
        {
            Console.Clear();
            Console.WriteLine($@"
                                       ____  _____  ___  ___      __    ____ 
                                      (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                       ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                      (____/(_____)(___/(___/  (__)(__)(____)


 ");
            Console.WriteLine("\t\t\t\tRegister Employer");

            Employer employer = new Employer();

            Console.Write("\t\t\t\tName: ");
            employer.EmployerName = Console.ReadLine();

            Console.Write("\t\t\t\tSurname: ");
            employer.EmployerSurname = Console.ReadLine();

            Console.Write("\t\t\t\tTelephone Number: ");
            employer.EmployerPhone = Console.ReadLine();

            Console.Write("\t\t\t\tAge: ");
            employer.EmployerAge = int.Parse(Console.ReadLine());

            Console.Write("\t\t\t\tUsername: ");
            employer.EmployerUserName = Console.ReadLine();

            Console.Write("\t\t\t\tPassword: ");
            employer.EmployerPassword = Console.ReadLine();


            employer.EmployerVacancies = new List<Vacancy>();
            employer.PostedCv = new List<CV>();

            userData.Employers.Add(employer);
            JsonDataManager.SaveUserData(userData);

            string logMessage = $"[{DateTime.Now}] Employer {employer.EmployerName} {employer.EmployerSurname} registered.";
            JsonDataManager.AddLogEntry(logMessage);

            Console.WriteLine("\t\t\t\tEmployer Registered Successfully");
            System.Threading.Thread.Sleep(1000);
        }

        static void RegisterMenu()
        {
            int registrationChoice = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($@"
                                      ____  _____  ___  ___      __    ____ 
                                     (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                      ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                     (____/(_____)(___/(___/  (__)(__)(____)


");

                if (registrationChoice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 1. Worker Register ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t   2. Employer Register");
                    Console.WriteLine("\t\t\t\t   3. Exit To Main Menu");
                }
                else if (registrationChoice == 2)
                {
                    Console.WriteLine("\t\t\t\t   1. Worker Register");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 2. Employer Register");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t   3. Exit To Main Menu");
                }
                else if (registrationChoice == 3)
                {
                    Console.WriteLine("\t\t\t\t   1. Worker Register");
                    Console.WriteLine("\t\t\t\t   2. Employer Register");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 3. Exit To Main Menu");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("\t\t\t\t   1. Worker Register");
                    Console.WriteLine("\t\t\t\t   2. Employer Register");
                    Console.WriteLine("\t\t\t\t   3. Exit To Main Menu");

                }

                ConsoleKeyInfo registrationKeyInfo = Console.ReadKey();

                if (registrationKeyInfo.Key == ConsoleKey.UpArrow && registrationChoice > 1)
                {
                    registrationChoice--;
                }
                else if (registrationKeyInfo.Key == ConsoleKey.DownArrow && registrationChoice < 3)
                {
                    registrationChoice++;
                }
                else if (registrationKeyInfo.Key == ConsoleKey.Enter)
                {
                    if (registrationChoice == 1)
                    {
                        RegisterWorker();
                    }
                    else if (registrationChoice == 2)
                    {
                        RegisterEmployer();
                    }
                    else if (registrationChoice == 3)
                    {
                        break;
                    }

                }
                else if (registrationKeyInfo.Key != ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
        static void LoginMenu()
        {
            int loginChoice = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($@"
                                              ____  _____  ___  ___      __    ____ 
                                             (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                              ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                             (____/(_____)(___/(___/  (__)(__)(____)


        ");

                if (loginChoice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 1. Login Worker");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t   2. Login Employer");
                    Console.WriteLine("\t\t\t\t   3. Exit to Main Menu");
                }
                else if (loginChoice == 2)
                {
                    Console.WriteLine("\t\t\t\t   1. Login Worker");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 2. Login Employer");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t   3. Exit to Main Menu");
                }
                else if (loginChoice == 3)
                {
                    Console.WriteLine("\t\t\t\t   1. Login Worker");
                    Console.WriteLine("\t\t\t\t   2. Login Employer");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 3. Exit to Main Menu");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.WriteLine("\t\t\t\t   1. Login Worker");
                    Console.WriteLine("\t\t\t\t   2. Login Employer");
                    Console.WriteLine("\t\t\t\t   3. Exit to Main Menu");

                }

                ConsoleKeyInfo loginKeyInfo = Console.ReadKey();

                if (loginKeyInfo.Key == ConsoleKey.UpArrow && loginChoice > 1)
                {
                    loginChoice--;
                }
                else if (loginKeyInfo.Key == ConsoleKey.DownArrow && loginChoice < 3)
                {
                    loginChoice++;
                }
                else if (loginKeyInfo.Key == ConsoleKey.Enter)
                {
                    if (loginChoice == 1)
                    {
                        LoginWorker();
                        System.Threading.Thread.Sleep(1000);
                        break;
                    }
                    else if (loginChoice == 2)
                    {
                        LoginEmployer();
                        System.Threading.Thread.Sleep(1000);
                        break;
                    }
                    else if (loginChoice == 3)
                    {
                        break;
                    }

                }
                else if (loginKeyInfo.Key != ConsoleKey.Escape)
                {
                    break;
                }
            }
        }

        static void LoginWorker()
        {
            Console.Clear();
            Console.WriteLine($@"
                                       ____  _____  ___  ___      __    ____ 
                                      (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                       ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                      (____/(_____)(___/(___/  (__)(__)(____)


 ");
            Console.WriteLine("Worker Login");

            Console.Write("Username: ");
            string userName = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            List<Worker> workers = JsonDataManager.LoadUserData().Workers;

            Worker authenticatedWorker = workers.FirstOrDefault(worker => worker.WorkerUserName == userName && worker.WorkerPassword == password);

            if (authenticatedWorker != null)
            {
                Console.WriteLine("Login Successful");
                System.Threading.Thread.Sleep(1000);
                WorkerMenu(authenticatedWorker);

                string logMessage = $"[{DateTime.Now}] Worker {authenticatedWorker.WorkerName} {authenticatedWorker.WorkerSurname} logged in.";
                JsonDataManager.AddLogEntry(logMessage);
            }
            else
            {
                Console.WriteLine("Wrong Username Or Password");

                string logMessage = $"[{DateTime.Now}] Worker login attempt with username: {userName} failed.";
                JsonDataManager.AddLogEntry(logMessage);
            }
        }

        static void LoginEmployer()
        {
            Console.Clear();
            Console.WriteLine($@"
                                       ____  _____  ___  ___      __    ____ 
                                      (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                       ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                      (____/(_____)(___/(___/  (__)(__)(____)


 ");
            Console.WriteLine("Employer Login");

            Console.Write("Username: ");
            string userName = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            List<Employer> employers = JsonDataManager.LoadUserData().Employers;

            Employer authenticatedEmployer = employers.FirstOrDefault(employer => employer.EmployerUserName == userName && employer.EmployerPassword == password);

            if (authenticatedEmployer != null)
            {
                Console.WriteLine("Login Successful");
                System.Threading.Thread.Sleep(1000);
                EmployerMenu(authenticatedEmployer);

                string logMessage = $"[{DateTime.Now}] Employer {authenticatedEmployer.EmployerName} {authenticatedEmployer.EmployerSurname} logged in.";
                JsonDataManager.AddLogEntry(logMessage);
            }
            else
            {
                Console.WriteLine("Wrong Username Or Password");

                string logMessage = $"[{DateTime.Now}] Employer login attempt with username: {userName} failed.";
                JsonDataManager.AddLogEntry(logMessage);
            }
        }

        static void EmployerMenu(Employer employer)
        {
            int Employerchoice = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($@"
                                              ____  _____  ___  ___      __    ____ 
                                             (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                              ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                             (____/(_____)(___/(___/  (__)(__)(____)


        ");

                if (Employerchoice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 1. Create Vacancy ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t   2. Show All Vacancy");
                    Console.WriteLine("\t\t\t\t   3. Show Posted Cv");
                    Console.WriteLine("\t\t\t\t   4. Exit To Last Menu");
                }
                else if (Employerchoice == 2)
                {
                    Console.WriteLine("\t\t\t\t   1. Create Vacancy");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 2. Show All Vacancy");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t   3. Show Posted Cv");
                    Console.WriteLine("\t\t\t\t   4. Exit To Last Menu");
                }
                else if (Employerchoice == 3)
                {
                    Console.WriteLine("\t\t\t\t   1. Create Vacancy");
                    Console.WriteLine("\t\t\t\t   2. Show All Vacancy");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t+> 3. Show Posted Cv");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t   4. Exit To Last Menu");
                }
                else if (Employerchoice == 4)
                {
                    Console.WriteLine("\t\t\t\t   1. Create Vacancy");
                    Console.WriteLine("\t\t\t\t   2. Show All Vacancy");
                    Console.WriteLine("\t\t\t\t   3. Show Posted Cv");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 4. Exit To Last Menu");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("\t\t\t\t   1. Create Vacancy");
                    Console.WriteLine("\t\t\t\t   2. Show All Vacancy");
                    Console.WriteLine("\t\t\t\t   3. Show Posted Cv");
                    Console.WriteLine("\t\t\t\t   4. Exit To Last Menu");
                }

                ConsoleKeyInfo Employerkeyinfo = Console.ReadKey();

                if (Employerkeyinfo.Key == ConsoleKey.UpArrow && Employerchoice > 1)
                {
                    Employerchoice--;
                }
                else if (Employerkeyinfo.Key == ConsoleKey.DownArrow && Employerchoice < 4)
                {
                    Employerchoice++;
                }
                else if (Employerkeyinfo.Key == ConsoleKey.Enter)
                {
                    if (Employerchoice == 1)
                    {
                        CreateVacancy(employer);
                        break;
                    }
                    else if (Employerchoice == 2)
                    {
                        ShowAllVacancy(employer);
                        break;
                    }
                    else if (Employerchoice == 3)
                    {
                        ShowPostedCv(employer);
                        break;
                    }
                    else if (Employerchoice == 4)
                    {
                        break;
                    }

                }
                else if (Employerkeyinfo.Key != ConsoleKey.Escape)
                {
                    break;
                }

            }

        }
        static void CreateVacancy(Employer employer)
        {
            Console.WriteLine($@"
                                       ____  _____  ___  ___      __    ____ 
                                      (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                       ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                      (____/(_____)(___/(___/  (__)(__)(____)


 ");
            Console.WriteLine("Create Vacancy");
            if (employer.EmployerVacancies == null)
            {
                employer.EmployerVacancies = new List<Vacancy>();
            }
            Vacancy newVacancy = new Vacancy();

            Console.Write("Enter Vacancy Name: ");
            newVacancy.VacancyName = Console.ReadLine();

            Console.Write("Enter Vacancy Info: ");
            newVacancy.VacancyInfo = Console.ReadLine();

            Console.Write("Enter Vacancy Salary: ");
            double salary;
            if (double.TryParse(Console.ReadLine(), out salary))
            {
                newVacancy.VacancySalary = salary;
            }
            else
            {
                Console.WriteLine("Invalid Salary. Vacancy creation failed.");
                return;
            }

            employer.EmployerVacancies.Add(newVacancy);

            
            string json = File.ReadAllText("users.json");
            UserData userData = JsonConvert.DeserializeObject<UserData>(json);

            
            Employer existingEmployer = userData.Employers.FirstOrDefault(e => e.EmployerId == employer.EmployerId);
            if (existingEmployer != null)
            {
                existingEmployer.EmployerVacancies = employer.EmployerVacancies;
            }

          
            string updatedJson = JsonConvert.SerializeObject(userData);
            File.WriteAllText("users.json", updatedJson);

            Console.WriteLine("Vacancy created successfully!");
        }

        static void ShowAllVacancy(Employer employer)
        {
            Console.WriteLine($@"
                                       ____  _____  ___  ___      __    ____ 
                                      (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                       ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                      (____/(_____)(___/(___/  (__)(__)(____)


 ");
            Console.WriteLine("Show All Vacancy");

            if (employer.EmployerVacancies == null || employer.EmployerVacancies.Count == 0)
            {
                Console.WriteLine("No vacancies found.");
                return;
            }

            foreach (var vacancy in employer.EmployerVacancies)
            {
                Console.WriteLine($"Vacancy ID: {vacancy.VacancyId}");
                Console.WriteLine($"Vacancy Name: {vacancy.VacancyName}");
                Console.WriteLine($"Vacancy Info: {vacancy.VacancyInfo}");
                Console.WriteLine($"Vacancy Salary: {vacancy.VacancySalary}");
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void ShowPostedCv(Employer employer)
        {
            Console.WriteLine($@"
                                       ____  _____  ___  ___      __    ____ 
                                      (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                       ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                      (____/(_____)(___/(___/  (__)(__)(____)


 ");
            Console.WriteLine("Show Posted Cv");

            if (employer.PostedCv == null || employer.PostedCv.Count == 0)
            {
                Console.WriteLine("No CVs posted.");
                return;
            }

            foreach (var cv in employer.PostedCv)
            {
                Console.WriteLine($"Specialty: {cv.Specialty}");
                Console.WriteLine($"School: {cv.School}");
                Console.WriteLine($"University: {cv.University}");
                Console.WriteLine("Skills:");
                foreach (var skill in cv.Skills)
                {
                    Console.WriteLine(skill);
                }
                Console.WriteLine("Companies:");
                foreach (var company in cv.Companies)
                {
                    Console.WriteLine(company);
                }
                Console.WriteLine($"Start Date: {cv.StartDate}");
                Console.WriteLine($"End Date: {cv.EndDate}");
                Console.WriteLine("Languages:");
                foreach (var language in cv.Languages)
                {
                    Console.WriteLine($"{language.Key}: {language.Value}");
                }
                Console.WriteLine($"Has Degree: {cv.HasDegree}");
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        static void WorkerMenu(Worker worker)
        {
            int WorkerChoice = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($@"
                                              ____  _____  ___  ___      __    ____ 
                                             (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                              ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                             (____/(_____)(___/(___/  (__)(__)(____)


        ");

                if (WorkerChoice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 1. Create CV ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t   2. Show All CVs");
                    Console.WriteLine("\t\t\t\t   3. CV Application");
                    Console.WriteLine("\t\t\t\t   4. Exit To Last Menu");
                }
                else if (WorkerChoice == 2)
                {
                    Console.WriteLine("\t\t\t\t   1. Create CV");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 2. Show All CVs");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t   3. CV Application");
                    Console.WriteLine("\t\t\t\t   4. Exit To Last Menu");
                }
                else if (WorkerChoice == 3)
                {
                    Console.WriteLine("\t\t\t\t   1. Create CV");
                    Console.WriteLine("\t\t\t\t   2. List All CVs");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 3. CV Application");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\t\t\t\t   4. Exit To Last Menu");
                }
                else if (WorkerChoice == 4)
                {
                    Console.WriteLine("\t\t\t\t   1. Create CV");
                    Console.WriteLine("\t\t\t\t   2. List All CVs");
                    Console.WriteLine("\t\t\t\t   3. CV Application");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t=> 4. Exit To Last Menu");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("\t\t\t\t   1. Create CV");
                    Console.WriteLine("\t\t\t\t   2. List All CVs");
                    Console.WriteLine("\t\t\t\t   3. CV Application");
                    Console.WriteLine("\t\t\t\t   4. Exit To Last Menu");
                }

                ConsoleKeyInfo Workerkeyinfo = Console.ReadKey();

                if (Workerkeyinfo.Key == ConsoleKey.UpArrow && WorkerChoice > 1)
                {
                    WorkerChoice--;
                }
                else if (Workerkeyinfo.Key == ConsoleKey.DownArrow && WorkerChoice < 4)
                {
                    WorkerChoice++;
                }
                else if (Workerkeyinfo.Key == ConsoleKey.Enter)
                {
                    if (WorkerChoice == 1)
                    {
                        CreateCV(worker);
                    }
                    else if (WorkerChoice == 2)
                    {
                        ShowAllCVs(worker);
                    }
                    else if (WorkerChoice == 3)
                    {
                        CVApplication(worker);
                        break;
                    }
                    else if (WorkerChoice == 4)
                    {
                        break;
                    }

                }
                else if (Workerkeyinfo.Key != ConsoleKey.Escape)
                {
                    break;
                }

            }



        }
        static void CreateCV(Worker worker)
        {
            Console.Clear();
            Console.WriteLine($@"
                                              ____  _____  ___  ___      __    ____ 
                                             (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                              ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                             (____/(_____)(___/(___/  (__)(__)(____)


        ");
            Console.WriteLine("Create CV");

            if (worker.WorkerCVs == null)
            {
                worker.WorkerCVs = new List<CV>();
            }

            CV cv = new CV();

            Console.Write("Specialty: ");
            cv.Specialty = Console.ReadLine();

            Console.Write("School: ");
            cv.School = Console.ReadLine();

            Console.Write("University: ");
            cv.University = Console.ReadLine();

            Console.Write("Skills (comma-separated): ");
            string skillsInput = Console.ReadLine();
            cv.Skills = skillsInput.Split(',').Select(skill => skill.Trim()).ToList();

            Console.Write("Companies (comma-separated): ");
            string companiesInput = Console.ReadLine();
            cv.Companies = companiesInput.Split(',').Select(company => company.Trim()).ToList();

            Console.Write("Start Date (YYYY-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
            {
                cv.StartDate = startDate;
            }
            else
            {
                Console.WriteLine("Invalid date format. CV creation failed.");
                System.Threading.Thread.Sleep(1000);
                return;
            }

            Console.Write("End Date (YYYY-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
            {
                cv.EndDate = endDate;
            }
            else
            {
                Console.WriteLine("Invalid date format. CV creation failed.");
                System.Threading.Thread.Sleep(1000);
                return;
            }

            cv.Languages = new Dictionary<string, string>();
            while (true)
            {
                Console.Write("Language (press Enter to finish): ");
                string language = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(language))
                {
                    break;
                }

                Console.Write("Level: ");
                string level = Console.ReadLine();

                cv.Languages[language] = level;
            }

            Console.Write("Do you have a degree? (true/false): ");
            if (bool.TryParse(Console.ReadLine(), out bool hasDegree))
            {
                cv.HasDegree = hasDegree;
            }
            else
            {
                Console.WriteLine("Invalid input for degree. CV creation failed.");
                System.Threading.Thread.Sleep(1000);
                return;
            }

            worker.WorkerCVs.Add(cv);
            string json = File.ReadAllText("users.json");
            UserData userData = JsonConvert.DeserializeObject<UserData>(json);


            Worker existingEWorker = userData.Workers.FirstOrDefault(e => e.WorkerId == worker.WorkerId);
            if (existingEWorker != null)
            {
                existingEWorker.WorkerCVs = worker.WorkerCVs;
            }


            string updatedJson = JsonConvert.SerializeObject(userData);
            File.WriteAllText("users.json", updatedJson);
            Console.WriteLine("CV created successfully.");
            System.Threading.Thread.Sleep(1000);
        }

        static void CVApplication(Worker worker)
        {
            Console.Clear();
            Console.WriteLine($@"
                                       ____  _____  ___  ___      __    ____ 
                                      (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                       ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                      (____/(_____)(___/(___/  (__)(__)(____)


 ");
            Console.WriteLine("CV Application");

            bool VacanciesTrueOrFalse = true;
            UserData userData = JsonDataManager.LoadUserData();
            List<Employer> employers = userData.Employers;

            Console.WriteLine("Vacancies:");
            for (int i = 0; i < employers.Count; i++)
            {
                var employer = employers[i];
                Console.WriteLine($"Employer ID: {i + 1}");
                Console.WriteLine($"Employer Name: {employer.EmployerName}");
                Console.WriteLine();
                Console.WriteLine("Vacancies:");
                if (employer.EmployerVacancies == null || employer.EmployerVacancies.Count == 0)
                {
                    Console.WriteLine("No vacancies found.");
                    VacanciesTrueOrFalse = false;
                }
                else
                {
                    for (int j = 0; j < employer.EmployerVacancies.Count; j++)
                    {
                        var vacancy = employer.EmployerVacancies[j];
                        Console.WriteLine($"Vacancy ID: {j + 1}");
                        Console.WriteLine($"Vacancy Name: {vacancy.VacancyName}");
                        Console.WriteLine($"Vacancy Info: {vacancy.VacancyInfo}");
                        Console.WriteLine($"Vacancy Salary: {vacancy.VacancySalary}");
                        Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }

            Console.Write("Select an employer by entering their ID (or 0 to exit): ");
            if (int.TryParse(Console.ReadLine(), out int employerId))
            {
                if (employerId >= 1 && employerId <= employers.Count && VacanciesTrueOrFalse)
                {
                    var selectedEmployer = employers[employerId - 1];

                    Console.Clear();
                    Console.WriteLine($"Vacancies from {selectedEmployer.EmployerName}:");
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < selectedEmployer.EmployerVacancies.Count; i++)
                    {
                        var vacancy = selectedEmployer.EmployerVacancies[i];
                        Console.WriteLine($"ID: {i + 1}");
                        Console.WriteLine($"Name: {vacancy.VacancyName}");
                        Console.WriteLine($"Info: {vacancy.VacancyInfo}");
                        Console.WriteLine($"Salary: {vacancy.VacancySalary}");
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                    Console.Write("Select a vacancy by entering its ID (or 0 to cancel): ");
                    if (int.TryParse(Console.ReadLine(), out int vacancyId))
                    {
                        if (vacancyId >= 1 && vacancyId <= selectedEmployer.EmployerVacancies.Count)
                        {
                            var selectedVacancy = selectedEmployer.EmployerVacancies[vacancyId - 1];
             

                            foreach (var cv in worker.WorkerCVs)
                            {
                                selectedEmployer.PostedCv.Add(cv);
                            }
                            string json = File.ReadAllText("users.json");
                            UserData userDataa = JsonConvert.DeserializeObject<UserData>(json);


                            Employer Existpostedcv = userDataa.Employers.FirstOrDefault(e => e.EmployerId == selectedEmployer.EmployerId);
                            if (Existpostedcv != null)
                            {
                                Existpostedcv.PostedCv = selectedEmployer.PostedCv;
                            }


                            string updatedJson = JsonConvert.SerializeObject(userDataa);
                            File.WriteAllText("users.json", updatedJson);
                            Console.WriteLine("CV application successful.");
                        }
                        else if (vacancyId == 0)
                        {
                            Console.WriteLine("Application canceled.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid vacancy ID.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                }
                else if (employerId == 0)
                {
                    Console.WriteLine("Application canceled.");
                }
                else
                {
                    Console.WriteLine("Invalid employer ID Or Dont Have Vacancies.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            System.Threading.Thread.Sleep(1000);
        }

        static void ShowAllCVs(Worker worker)
        {
            Console.Clear();
            Console.WriteLine($@"
                                              ____  _____  ___  ___      __    ____ 
                                             (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                              ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                             (____/(_____)(___/(___/  (__)(__)(____)


        ");
            Console.WriteLine("Show All CVs");

            if (worker.WorkerCVs.Count == 0)
            {
                Console.WriteLine("You have no CVs.");
            }
            else
            {
                int index = 1;
                foreach (var cv in worker.WorkerCVs)
                {
                    Console.WriteLine($"CV {index}:");
                    Console.WriteLine($"Specialty: {cv.Specialty}");
                    Console.WriteLine($"School: {cv.School}");
                    Console.WriteLine($"University: {cv.University}");
                    Console.WriteLine($"Skills: {string.Join(", ", cv.Skills)}");
                    Console.WriteLine($"Companies: {string.Join(", ", cv.Companies)}");
                    Console.WriteLine($"Start Date: {cv.StartDate.ToString("yyyy-MM-dd")}");
                    Console.WriteLine($"End Date: {cv.EndDate.ToString("yyyy-MM-dd")}");
                    Console.WriteLine("Languages:");
                    foreach (var language in cv.Languages)
                    {
                        Console.WriteLine($"  {language.Key}: {language.Value}");
                    }
                    Console.WriteLine($"Has Degree: {cv.HasDegree}");
                    Console.WriteLine();
                    index++;
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void START()
        {

            while (true)
            {

                Console.Clear();
                Console.WriteLine($@"
                                      ____  _____  ___  ___      __    ____ 
                                     (  _ \(  _  )/ __)/ __)    /__\  (_   )
                                      ) _ < )(_)( \__ \\__ \   /(__)\  / /_ 
                                     (____/(_____)(___/(___/  (__)(__)(____)


");

                for (int i = 0; i < totalOptions; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("=> ");
                    }


                    switch (i)
                    {
                        case 0:
                            Console.WriteLine("\t\t\t\t\t1. Login ");
                            break;
                        case 1:
                            Console.WriteLine("\t\t\t\t\t2. Register ");
                            break;
                        case 2:
                            Console.WriteLine("\t\t\t\t\t3. Exit");
                            break;
                    }


                    Console.ForegroundColor = ConsoleColor.White;
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();


                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    selectedIndex = (selectedIndex - 1 + totalOptions) % totalOptions;
                }

                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    selectedIndex = (selectedIndex + 1) % totalOptions;
                }

                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    int choice = selectedIndex + 1;
                    switch (choice)
                    {
                        case 1:
                            LoginMenu();
                            break;
                        case 2:
                            RegisterMenu();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;

                    }
                }

            }

        }
        static void Main()
        {
            START();
        }
    }
}