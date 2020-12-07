using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace CompanyManagementConsole
{
   /* [Table(Name = "Company")]
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
        public void InsertCompany()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Comapny companyobj = new Comapny();
            //companyobj.CompanyID = 123;
            companyobj.CompanyName = "Cennest Technology";
            companyobj.ComapanyLocation = "Mumbai";
            companyobj.CompanyOwner = "Daksh Sir";
            dc.Comapnies.InsertOnSubmit(companyobj);
            dc.SubmitChanges();
        }
        public void InsertProject(int id,string name , int budget,string statusId, int clientId)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Project projectObj = new Project();
            
            projectObj.ProjectName = name;
            projectObj.ProjectBudget = budget;
            projectObj.StatusID = statusId;
            projectObj.ClientID = clientId;
            
            
            dc.Projects.InsertOnSubmit(projectObj);
            dc.SubmitChanges();
        }
        public void insertTechnology(int id,string name, int cost)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            TechnologyMaster tech = new TechnologyMaster();
            tech.Tech_ID = id;
            tech.Tech_Name = name;
            tech.Tech_Cost = cost;
            dc.TechnologyMasters.InsertOnSubmit(tech);
            dc.SubmitChanges();

        }
        public void getAllProjects()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Table<Project> projects = dc.GetTable<Project>();
            var projectQuery = from p in projects select p.ProjectName;
            foreach(string p in projectQuery)
            {
                Console.WriteLine(p);
            }
        }
        public void getAllTechologies()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            Table<TechnologyMaster> technologies = dc.GetTable<TechnologyMaster>();
            var techlist = from t in technologies select t.Tech_Name;
            foreach( string t in techlist)
            {
                Console.WriteLine(t);
            }
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.getAllTechologies();
            Console.ReadLine();
        }
    }
}
