using System;
using ConsoleAppProject.Models;
using ConsoleAppProject.Services;

namespace ConsoleAppProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HumanResourceManager humanresourcemanager=new HumanResourceManager();


            do
            { 
            Console.WriteLine("===============Xos Gelmisiniz==============");
            Console.WriteLine("1. Departameantlerin siyahisini gostermek:");
            Console.WriteLine("2. Departamenet yaratmaq");
            Console.WriteLine("3. Departmanetde deyisiklik etmek");
            Console.WriteLine("4. Iscilerin siyahisini gostermek:");
            Console.WriteLine("5. Departamentdeki iscilerin siyahisini gostermrek:");
            Console.WriteLine("6. Isci elave etmek:");
            Console.WriteLine("7. Isci uzerinde deyisiklik etmek:");
            Console.WriteLine("8. Departamentden isci silinmesi:");
            Console.WriteLine("9. Sistemden Cixis:\n");
            Console.WriteLine("Acilan Menu Pencerisnde Bir Secim Edin. Reqem Daxil Edin:");

            string choose = Console.ReadLine();
            int chooseNum;

            while (!int.TryParse(choose, out chooseNum) || chooseNum < 1 || chooseNum > 9)
            {
                Console.WriteLine("Duzgun Secim Edin:");
                choose = Console.ReadLine();
            }

            Console.Clear();

                switch (chooseNum)
                {
                    case 1:
                        ShowDepartments(ref humanresourcemanager);
                        break;
                    case 2:
                        CreateDepartment(ref humanresourcemanager);
                        break;
                    case 3:
                        EditDepartment(ref humanresourcemanager);
                        break;
                    case 4:
                        ShowAllEmployees(ref humanresourcemanager);
                        break;
                    case 5:
                        ShowDepartmentEmployees(ref humanresourcemanager);
                        break;
                    case 6:
                       AddEmployee(ref humanresourcemanager);
                        break;
                    case 7:
                        EditEmployee(ref humanresourcemanager);
                        break;
                    case 8:
                        RemoveEmployee(ref humanresourcemanager);
                        break;
                    case 9:
                        return;
                }

            } while (true);


            static void ShowDepartments(ref HumanResourceManager humanresourcemanager)
            {
                 if (humanresourcemanager.Departments.Length>0)
                {
                    humanresourcemanager.GetDepartments();
                }
                else
                Console.WriteLine("Hal hazirda yaradilmis Department yoxdur");
            }
            static void CreateDepartment(ref HumanResourceManager humanresourcemanager)
            {
                Console.WriteLine("Departament yaratmaq ucun asagidakilari daxil edin:");
                Console.WriteLine("Departamentin adi");
                string name=Console.ReadLine();
                while (name.Length<2)
                {
                    Console.WriteLine("Departament adi 2silvoldan az olmamalidir!yeniden daxil edin!");
                    name= Console.ReadLine();
                }
                Console.WriteLine("Departamentin maximal ishci sayini qeyd edin");
                string workerlimitstr = Console.ReadLine();
                int workerlimit;
                while (!int.TryParse(workerlimitstr,out workerlimit) || workerlimit<1)
                {
                    Console.WriteLine("Duzgun Limit teyin edin!");
                   workerlimitstr= Console.ReadLine();
                }
                Console.WriteLine("Departamentin maximal salary limit qeyd edin");
                string salarylimitstr = Console.ReadLine();
                double salarylimit;
                while (!double.TryParse(salarylimitstr, out salarylimit)||salarylimit<(workerlimit*250))
                {
                    Console.WriteLine("Duzgun SalaryLimit teyin edin!");
                    salarylimitstr= Console.ReadLine();
                }

                humanresourcemanager.AddDepartment(name, workerlimit, salarylimit);
                Console.WriteLine("Department ugurla yaradildi!");
            }
            static void EditDepartment(ref HumanResourceManager humanresourcemanager)
            {
                Console.WriteLine("Deyisiklik etmek istediyiniz Department adini qeyd edin!");
                string department = Console.ReadLine().Trim().ToUpper();
                foreach (Department item in humanresourcemanager.Departments)
                {
                    if (item.Name==department)
                    {
                        Console.WriteLine(item);
                        Console.WriteLine("Department-e yeni Name teyin edin edin:");
                        string name = Console.ReadLine(); 
                        while (name.Length < 2)
                        {
                            Console.WriteLine("Departament adi 2silvoldan az olmamalidir! Yeniden daxil edin!");
                            name = Console.ReadLine();
                        }
                        humanresourcemanager.EditDepartments(department, name);
                        return;
                    }
                    
                }
                Console.WriteLine("Daxil edilen adda department yoxdur! Duzgun daxil edin:");
            }
            static void ShowAllEmployees(ref HumanResourceManager humanresourcemanager)
            {
                foreach (Department department in humanresourcemanager.Departments)
                {
                    if (department.Employees.Length != null)
                    {
                        foreach (Employee item in department.Employees)
                        {
                            Console.WriteLine(item);
                        }
                        return;
                    }
                }
                 Console.WriteLine("Employee yoxdur!");
                                  
            }
            static void ShowDepartmentEmployees(ref HumanResourceManager humanresourcemanager)
            {
                Console.WriteLine("Gostermek istediyiniz Department adini qeyd edin!");
                string department = Console.ReadLine().Trim().ToUpper();
                foreach (Department item in humanresourcemanager.Departments)
                    if (item.Name==department)
                    {
                        foreach (Employee ishci in item.Employees)
                        {
                            Console.WriteLine(ishci);
                        }
                        return;
                    }
                Console.WriteLine("Daxil edilen adda Department yoxdur!");

            }
            static void AddEmployee(ref HumanResourceManager humanresourcemanager)
            {
                Console.WriteLine("Ishcini daxil etmek istediyiniz Department adini daxil edin!");
                string department = Console.ReadLine().Trim().ToUpper();
                foreach (Department item in humanresourcemanager.Departments)
                {
                    if (item.Name == department)
                    {
                        Console.WriteLine("Yeni ishcinin adini qeyd edin!");                        
                        string fullname = Console.ReadLine().Trim().ToUpper();
                        Console.WriteLine("Yeni ishcinin maasini qeyd edin!");
                        double salary = double.Parse(Console.ReadLine());
                        Console.WriteLine("Yeni ishcinin pozisiyasini qeyd edin!");
                        string position = Console.ReadLine().Trim().ToUpper();
                        humanresourcemanager.AddEmployee(fullname, position, salary, department);
                        return;
                    }
                }
                Console.WriteLine("Daxil edilen adda department yoxdur");
            }
            static void EditEmployee(ref HumanResourceManager humanresourcemanager)
            {
                Console.WriteLine("Deyishmek istediyiniz ishcinin nomresini daxil edin!");
                string no = Console.ReadLine().Trim().ToUpper();

                foreach (Department item in humanresourcemanager.Departments)
                {
                    foreach(Employee empl in item.Employees)
                    {
                        if (empl.No==no)
                        {
                            Console.WriteLine(empl);
                            Console.WriteLine("Ishcinin yeni maasini qeyd edin!");
                            double salary = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ishcinin yeni pozisiyasini qeyd edin!");
                            string position = Console.ReadLine().Trim().ToUpper();
                            humanresourcemanager.EditEmployee(no, empl.FullName, position, salary);
                            return;
                        }
                        
                        
                    }
                }
                Console.WriteLine("Bu nomreli ishci tapilmadi");
            }
            static void RemoveEmployee(ref HumanResourceManager humanresourcemanager)
            {
                Console.WriteLine("Ishcini silmek istediyiniz Department adini daxil edin!");
                string department = Console.ReadLine().Trim().ToUpper();
                foreach (Department item in humanresourcemanager.Departments)
                {
                    if (item.Name == department)
                    {
                        Console.WriteLine("SIlmek istediyiniz ishcinin nomresini daxil edin");
                        string no = Console.ReadLine().Trim().ToUpper();
                        humanresourcemanager.RemoveEmployee(no, department);
                        return;
                    }
                }
                Console.WriteLine("Daxil edilen adda department yoxdur");
            }
        }
    }
}
