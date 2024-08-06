// See https://aka.ms/new-console-template for more information
using static ConsoleApp2.One;
Console.WriteLine("Hello, World!");


Teacher Teacher = new Teacher();
Student Student = new Student();

Console.WriteLine(Teacher.GetAge());
Console.WriteLine(Teacher.GetFullName());
Console.WriteLine(Teacher.GetRole());
Console.WriteLine(Student.GetRole());



//question 2

Console.WriteLine(Student.GetRole());
Console.WriteLine(Student.GetAge());
//Console.WriteLine(operation2.CalculateAge()); error

//question 3
List<IPerson> persons = new List<IPerson>();
persons.Add(Teacher);
persons.Add(Student);

foreach (IPerson person in persons)
{
    if (person is Student)
    {
        Console.WriteLine(Student.GetAge());
    }
    else
    {
        Console.WriteLine(Student.GetFullName());
    }
}

//question 4
UserRepository myUserRepository = new UserRepository();
ProductRepository myProductRepository = new ProductRepository();

myUserRepository.Add(new User { Id = 1, Name = "ari"});
myProductRepository.Add(new Product { Id = 2, Name = "heli" });

Console.WriteLine(myUserRepository.FindById(1));
Console.WriteLine(myProductRepository.FindById(2));

//question 5

FlyingCar flyingCar = new FlyingCar();

flyingCar.Land();
flyingCar.TakeOff();
flyingCar.MoveBackward();
flyingCar.MoveBackward();

