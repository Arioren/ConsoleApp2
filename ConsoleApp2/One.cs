using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.One;

namespace ConsoleApp2
{
    internal class One
    {
        public interface IPerson 
        {
           string  GetFullName();
            int GetAge();
        }

        public class Person: IPerson
        {
            private string firstName = string.Empty;
            private string lastName = string.Empty;
            private DateOnly birthDate;

       

            public string GetFullName() {return firstName+" "+ lastName; }
            public int GetAge() { return CalculateAge(); }

            private int CalculateAge() { return DateTime.Now.Year - birthDate.Year; }

        }

        public class Student : Person
        {
            private string role = "Student";
            public string GetRole() { return GenerateRole(); }
            private string GenerateRole() { return role; }

        }

        public class Teacher : Person
        {
            private string role = "Teacher";
            public string GetRole() { return GenerateRole(); }
            private string  GenerateRole() { return role; }


        }


        public interface IRepository<T>
        {
            void Add(T item);

            void remove(T item);
            T FindById(int id);

        }
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        public class UserRepository : IRepository<User>
        {
            private List<User> users = new List<User>();
            public void Add(User item)
            {
                users.Add(item);
            }

            public void remove(User item)
            {
                users.Remove(item);
            }
            public User FindById(int id)
            {
                return users.FirstOrDefault(u => u.Id == id);
            }
        }

        public class ProductRepository : IRepository<Product>
        {

            private List<Product> products = new List<Product>();
            public void Add(Product item)
            {
                products.Add(item);

            }

            public void remove(Product item)
            {
                products.Remove(item);
            }
            public Product FindById(int id)
            {
                return products.FirstOrDefault(p => p.Id == id);
            }
        }


        public interface IMovable
        {
            void MoveForward();

           void MoveBackward();
           

        }

        public interface IFlyable
        {
            void TakeOff();
            void Land();
        }

        public class FlyingCar: IFlyable, IMovable
        {
            private void StartEngine() { }

            private void StopEngine() { }


            public void MoveForward() { Console.WriteLine("work 5 1"); }

            public void MoveBackward() { Console.WriteLine("work 5 "); }


            public void TakeOff() { Console.WriteLine("work 5 3"); }
            public void Land() { Console.WriteLine("work 5 4"); }
        }


    }



}
