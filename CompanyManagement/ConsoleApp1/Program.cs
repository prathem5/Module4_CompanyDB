using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace ConsoleApp1
{/* [Table(Name = "Company")]
    public class Company
    {
        private int CompanyId;
        [Column(IsPrimaryKey = true, Storage = "CompanyID", IsDbGenerated = true)]
        public int Companyid
        {
            get
            {
                return this.CompanyId;
            }
            set
            {
                this.CompanyId = value;
            }
        }
        private string CompanyName;
        [Column(Storage = "CompanyName")]
        public string Companyname
        {
            get
            {
                return this.CompanyName;
            }
            set
            {
                this.CompanyName = value;
            }
        }
        private string CompanyLocation;
        [Column(Storage = "CompanyLocation")]
        public string Companylocation
        {
            get { return this.CompanyLocation; }
            set { this.CompanyLocation = value; }
        }
    }*/
    class Program
    {
        public string checkCompulsoryCompanyColumn()
        {
            Company company = new Company();

            if (string.IsNullOrEmpty(company.CompanyName))
            {
                return "Company Name Missing";
            }
            else
            {
                return "All field present";

            }
        }
        public void InsertCompany(string name, string loc)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Company companyobj = new Company();
            //companyobj.CompanyID = 123;
            companyobj.CompanyName = name;
            companyobj.CompanyAddress = loc;
            string checkColumn = checkCompulsoryCompanyColumn();
            if (checkColumn != "All field present")
            {
                throw new Exception(checkColumn);

            }
            dc.Companies.InsertOnSubmit(companyobj);
            dc.SubmitChanges();
        }
        public string checkCompulsoryProjectColumn()
        {
            Project project = new Project();

            if (string.IsNullOrEmpty(project.ProjectName))
            {
                return "Project Name Missing";
            }
            else
            {
                return "All field present";

            }
        }
        public void InsertProject(int id, string name, int budget, int statusId, int clientId)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Project projectObj = new Project();

            projectObj.ProjectName = name;
            projectObj.ProjectBudget = budget;
            projectObj.StatusID = statusId;
            projectObj.ClientID = clientId;
            string checkColumn = checkCompulsoryProjectColumn();
            if (checkColumn != "All field present")
            {
                throw new Exception(checkColumn);

            }
            dc.Projects.InsertOnSubmit(projectObj);
            dc.SubmitChanges();
        }
        public string checkCompulsoryTechnologyColumn()
        {
            TechnologyMaster tech = new TechnologyMaster();

            if (string.IsNullOrEmpty(tech.TechName))
            {
                return "Tech Name Missing";
            }
            else
            {
                return "All field present";

            }
        }
        public void insertTechnology(int id, string name, int cost)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            TechnologyMaster technologyMaster = new TechnologyMaster();
            technologyMaster.TechID = id;
            technologyMaster.TechName = name;
            technologyMaster.TechCost = cost;
            string checkColumn = checkCompulsoryTechnologyColumn();
            if (checkColumn != "All field present")
            {
                throw new Exception(checkColumn);

            }
            dc.TechnologyMasters.InsertOnSubmit(technologyMaster);
            dc.SubmitChanges();

        }
        public string checkCompulsoryDepartmentColumn()
        {
            DepartmentMaster departmentMaster = new DepartmentMaster();

            if (string.IsNullOrEmpty(departmentMaster.DepartmentName))
            {
                return "Department Name Missing";
            }
            else
            {
                return "All field present";

            }
        }
        public void insertDepartment(int id, string name, int companyid)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            DepartmentMaster department = new DepartmentMaster();
            department.DepartmentID = id;
            department.DepartmentName = name;
            department.CompanyID = companyid;
            string checkColumn = checkCompulsoryDepartmentColumn();
            if (checkColumn != "All field present")
            {
                throw new Exception(checkColumn);

            }
            dc.DepartmentMasters.InsertOnSubmit(department);
            dc.SubmitChanges();
        }
        public string checkCompulsoryEmployeeColumn()
        {
            Employee employee = new Employee();

            if (string.IsNullOrEmpty(employee.EmployeeName))
            {
                return "Employee Name Missing";
            }
            else
            {
                return "All field present";

            }
        }
        public void insertEmployee(int id, string name, string address, DateTime dateOfjoin, DateTime dateOfleave, int salary, int deptid)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Employee employee = new Employee();
            employee.EmployeeID = id;
            employee.EmployeeName = name;
            employee.EmployeeAddress = address;
            employee.EmployeeJoined = dateOfjoin;
            employee.EmployeeLeaved = dateOfleave;
            employee.EmployeeSalary = salary;
            employee.DepartmentID = deptid;


            string checkColumn = checkCompulsoryEmployeeColumn();
            if (checkColumn != "All field present")
            {
                throw new Exception(checkColumn);

            }
            dc.Employees.InsertOnSubmit(employee);
            dc.SubmitChanges();
        }
        public void insertProject(int Id, string name, int budget, int clientID, int statusId)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Project project = new Project();
            project.ProjectID = Id;
            project.ProjectName = name;
            project.ProjectBudget = budget;
            project.ClientID = clientID;
            project.StatusID = statusId;
            dc.Projects.InsertOnSubmit(project);
            dc.SubmitChanges();

        }
        public void insertTask(int id, string name, int statusID)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Task task = new Task();
            task.TaskID = id;
            task.TaskName = name;
            task.StatusID = statusID;
            dc.Tasks.InsertOnSubmit(task);
            dc.SubmitChanges();
        }
        public void insertStatus(int id, string name)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            StatusMaster status = new StatusMaster();
            status.StatusID = id;
            status.StatusName = name;
            dc.StatusMasters.InsertOnSubmit(status);
            dc.SubmitChanges(); }
        public void insertEmployeeProjectMap(int id, int employeeID, int projectID) {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            EmployeeProjectMap employeeProject = new EmployeeProjectMap();
            employeeProject.EmployeeProjectMapID = id;
            employeeProject.EmployeeID = employeeID;
            employeeProject.ProjectID = projectID;
            dc.EmployeeProjectMaps.InsertOnSubmit(employeeProject);
            dc.SubmitChanges();
        }
        public void insertEmployeeTaskMap(int ID, int employeeId, int taskId)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            EmployeeTaskMap employeeTask = new EmployeeTaskMap();
            employeeTask.EmployeeTaskMapID = ID;
            employeeTask.EmployeeID = employeeId;
            employeeTask.TaskID = taskId;
            dc.EmployeeTaskMaps.InsertOnSubmit(employeeTask);
            dc.SubmitChanges();
        }
        public void insertProjectTaskMap(int id, int projectId, int taskId)

        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            ProjectTaskMap projectTask = new ProjectTaskMap();
            projectTask.ProjectTaskMapID = id;
            projectTask.ProjectID = projectId;
            projectTask.TaskID = taskId;
            dc.ProjectTaskMaps.InsertOnSubmit(projectTask);
            dc.SubmitChanges();

        }
        public void insertTechProjectMap(int Id,int techID,int projectId){
            DataClasses1DataContext dc = new DataClasses1DataContext();
            TechProjectMap techProject = new TechProjectMap();
            techProject.TechProjectMapID = Id;
            techProject.TechID = techID;
            techProject.ProjectID= projectId;
            dc.TechProjectMaps.InsertOnSubmit(techProject);
            dc.SubmitChanges();

        }
        public void insertTechTaskMap(int Id, int techId,int taskId)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            TechTaskMap techTask = new TechTaskMap();
            techTask.TechTaskMapID = Id;
            techTask.TechID =techId;
            techTask.TaskID =taskId;
        }


        public void getAllProjects()
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                Table<Project> projects = dc.GetTable<Project>();
                var projectQuery = from p in projects select p.ProjectName;
                foreach (string p in projectQuery)
                {
                    Console.WriteLine(p);
                }
            }
            public void getAllTechologies()
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                Table<TechnologyMaster> technologies = dc.GetTable<TechnologyMaster>();
                var techlist = from t in technologies select t.TechName;
                foreach (string t in techlist)
                {
                    Console.WriteLine(t);
                }
            }

            static void Main(string[] args)
            {
            }
        } }

