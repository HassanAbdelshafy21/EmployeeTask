using System;
namespace test
{
    class test 
    {
        static void Main(String[]args)
        {
            int id;
            string department;
            double workinghours;
            Console.WriteLine("enter the employee Id");
            id= int.Parse(Console.ReadLine());
            Console.WriteLine("enter the department name");
            department = Console.ReadLine();
            Console.WriteLine("enter the working hours");
            workinghours=double.Parse(Console.ReadLine());
            Employee myemployee = new Employee(id,department,workinghours);
            Person myperson = new Person();
            myemployee.getemployee();
            myperson.GetPerson();
        }
    }
    class Person
    {
        public string Name;
        public string Adderss  ;
        public int National_ID;
        public Person(string name, string adderss, int national_id)
        {
            this.Name= name;
            this.Adderss= adderss;
            this.National_ID = national_id;
        }
        public Person(){

        }
        public void GetPerson()
        {
            Console.WriteLine("I am Person ");
        }
    }
     class student : Person{

     }

     class Employee{
         public int Id;
         public string Department;
         public double Workinghours;
         
         public Employee(int id, string department, double workinghours){
             this.Id=id;
             this.Department= department;
             this.Workinghours=workinghours;
         }
         public Employee(){

         }

          public double thesalary()
        {
            double hourrate = 50;
            double result = 0;
            if(Workinghours>=50){
            return result = 50*hourrate;
            }
            else
            {
                return result = Workinghours*hourrate;
            }
        }
            public void getemployee(){
             Console.WriteLine("---------------------------");
             Console.WriteLine("the id :"+this.Id);
             Console.WriteLine("the department :"+this.Department);
             Console.WriteLine("the working hours : "+this.Workinghours);
             Console.WriteLine("the salary of the employee :"+ thesalary());
         }
     }
     
}