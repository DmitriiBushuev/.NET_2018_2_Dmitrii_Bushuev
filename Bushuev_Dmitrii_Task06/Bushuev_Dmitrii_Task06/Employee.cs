using System;

namespace Bushuev_Dmitrii_Task06
{
    internal class Employee : User
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
    }
}
