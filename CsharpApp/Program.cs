//string fName = Console.ReadLine();

//string mName = Console.ReadLine(), lName = Console.ReadLine(); 
//int age =Convert.ToInt32( Console.ReadLine());


//string fullName = fName + " "+ mName + " " + lName;

//Console.WriteLine("full name: " + fullName + "his age: "+age.ToString());

//using CsharpApp;

//string sName = Console.ReadLine();

//int sum = 0;
//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine($"please enter mark{i+1}!");
//    int mark = Convert.ToInt32(Console.ReadLine());
//    sum += mark;
//}




//int m1 = Convert.ToInt32(Console.ReadLine()),
//    m2 = Convert.ToInt32(Console.ReadLine()),
//    m3 = Convert.ToInt32(Console.ReadLine());

//Student student = new Student();
//student.StudentName = sName;
//student.mark1 = m1;
//student.mark2 = m2;
//student.mark3 = m3;

//Console.WriteLine(student.GetAvgName("abd",90,80,100));



<<<<<<< HEAD
//using CsharpApp;
//using System.Runtime.CompilerServices;

//List<Employee> employees = new List<Employee>
//{
//    new Employee
//    {
//        id = 1,
//        name="ALI",
//        HiringDate = DateTime.Now,
//        Salary = 1000,



//    },new Employee
//    {
//        id = 2,
//        name="ahmad",
//        HiringDate = DateTime.Now,
//        Salary = 500
//    },new Employee
//    {
//        id = 3,
//        name="omar",
//        HiringDate = DateTime.Now,
//        Salary = 800
//    }
//};

//Console.WriteLine("id \tname\tHiring Date\t salary");
//Console.WriteLine("-- \t----\t-----------\t ------");

//for (int i = 4; i < 7; i++)
//{
//    Employee emp = new Employee();
//    emp.id = Convert.ToInt32(Console.ReadLine());
//       emp.name = Console.ReadLine();
//        emp.HiringDate = DateTime.Now;
//        emp.Salary = Convert.ToInt32(Console.ReadLine());
//        emp.sscfunction();
//    employees.Add(emp);


//}


//foreach (Employee emp in employees)
//{
//    Console.WriteLine($"{emp.id} \t {emp.name} \t {emp.HiringDate.ToShortDateString()} \t {emp.Salary}\t {emp.ssc}");

//    //best practise
//    //make an obj then emp.Add(obj)
//}

////employees[0].sscfunction(employees[0].Salary);



using CsharpApp;

users user = new users();

user.username = Console.ReadLine();
user.password = Console.ReadLine();
Console.WriteLine(user.login());



List<Employee> employees = new List<Employee>
{
    new Employee
    {
        id = 1,
        name="ALI",
        HiringDate = DateTime.Now,
        Salary = 1000
    },new Employee
    {
        id = 2,
        name="ahmad",
        HiringDate = DateTime.Now,
        Salary = 500
    },new Employee
    {
        id = 3,
        name="omar",
        HiringDate = DateTime.Now,
        Salary = 800
    }
};

Console.WriteLine("id \tname\tHiring Date\t salary");
Console.WriteLine("-- \t----\t-----------\t ------");

for (int i = 4; i < 7; i++)
{
    employees.Add(new Employee
    {
        id = Convert.ToInt32(Console.ReadLine()),
        name = Console.ReadLine(),
        HiringDate = DateTime.Now,
        Salary = Convert.ToInt32(Console.ReadLine())
    });




}

foreach (Employee emp in employees)
{
    Console.WriteLine($"{emp.id} \t {emp.name} \t {emp.HiringDate.ToShortDateString()} \t {emp.Salary}\t {emp.ssc} \t {emp.sscfunction()}");

    //best practise
    //make an obj then emp.Add(obj)
}

//employees[0].sscfunction(employees[0].Salary);



