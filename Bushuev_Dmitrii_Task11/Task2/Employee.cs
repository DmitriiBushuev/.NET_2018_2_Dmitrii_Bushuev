using System;

namespace Task2
{
    internal class Employee : User, IEquatable<Employee>
    {
        public Employee(DateTime birthDay, string firstName, string middleName, string lastName, DateTime dateEnterWork, string workPosition)
            : base(birthDay, firstName, middleName, lastName)
        {
            if (string.IsNullOrEmpty(workPosition))
            {
                throw new InvalidOperationException("Не задано служебное положение!");
            }

            if (dateEnterWork > DateTime.Now)
            {
                throw new InvalidOperationException("Дата приёма на работу не может быть в будущем!");
            }


            if (dateEnterWork.Year < birthDay.Year + 14 || (dateEnterWork.Year == birthDay.Year + 14 && dateEnterWork.DayOfYear < birthDay.DayOfYear))
            {
                throw new InvalidOperationException("Моложе 14 нельзя официально трудоустроиться!");
            }


            long ticks2 = (DateTime.Now - dateEnterWork).Ticks;
            WorkExperience = new DateTime(ticks2).Year - 1;

            this.workPosition = workPosition;
        }

        string workPosition;

        public string WorkPosition
        {
            get
            {
                return workPosition;
            }

            set
            {
                if (string.IsNullOrEmpty(workPosition))
                {
                    throw new InvalidOperationException("Не задано служебное положение!");
                }
                workPosition = value;
            }
        }

        public double WorkExperience
        {
            get;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, стаж работы: {WorkExperience} лет/год(а), должность: {workPosition} ";
        }

        //Переопределение для интерфейса
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (!(obj is Employee employee))
                return false;

            return Equals(employee);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashcode = WorkPosition.GetHashCode() +
                    WorkExperience.GetHashCode() +
                    BirthDay.GetHashCode() +
                    FirstName.GetHashCode() +
                    MiddleName.GetHashCode() +
                    LastName.GetHashCode();
                return hashcode;
            }
        }

        public bool Equals(Employee employee)
        {
            return BirthDay == employee.BirthDay
                && FirstName == employee.FirstName
                && MiddleName == employee.MiddleName
                && LastName == employee.LastName
                && WorkExperience == employee.WorkExperience
                && WorkPosition == employee.WorkPosition;
        }
    }
}

