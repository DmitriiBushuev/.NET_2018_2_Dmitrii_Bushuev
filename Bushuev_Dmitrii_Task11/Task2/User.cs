using System;

namespace Task2
{
    class User
    {
        public User(DateTime birthDay, string firstName, string middleName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new InvalidOperationException("Имя не задано!");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new InvalidOperationException("Фамилия не задана!");
            }

            BirthDay = birthDay;

            long ticks = (DateTime.Now - BirthDay).Ticks;
            UserAge = new DateTime(ticks).Year - 1;

            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
        }

        public string firstName;
        public string middleName;
        public string lastName;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(firstName))
                {
                    throw new InvalidOperationException("Имя не задано!");
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }

            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                if (string.IsNullOrEmpty(lastName))
                {
                    throw new InvalidOperationException("Фамилия не задана!");
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public DateTime BirthDay
        {
            get;
        }

        public int UserAge
        {
            get;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}, дата рождения: {BirthDay.ToShortDateString()}, {UserAge} лет/год(а) ";
        }
    }
}

