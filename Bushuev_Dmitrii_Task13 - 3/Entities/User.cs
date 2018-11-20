using System;
using System.Collections.Generic;

namespace Entities
{
    public class User
    {
        public User(DateTime birthDate, string firstName, string lastName)
        {

            if (string.IsNullOrEmpty(firstName) || firstName.Length > 50)
            {
                throw new InvalidOperationException("Имя не задано или более 50 знаков!");
            }

            if (string.IsNullOrEmpty(lastName) || lastName.Length > 50)
            {
                throw new InvalidOperationException("Фамилия не задана или более 50 знаков!");
            }

            if ((DateTime.Now.Year - birthDate.Year) > 150 || DateTime.Now < birthDate)
            {
                throw new InvalidOperationException("Дата рождения не может быть в будущем.\n Вам не должно быть более 150 лет.");
            }

            this.birthDate = birthDate;
            this.firstName = firstName;
            this.lastName = lastName;
        }
        HashSet<string> userAwards = new HashSet<string>();
        public string firstName;
        public string lastName;
        public DateTime birthDate;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(firstName) || firstName.Length > 50)
                {
                    throw new InvalidOperationException("Имя не задано или более 50 знаков!");
                }
                else
                {
                    firstName = value;
                }
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
                if (string.IsNullOrEmpty(lastName) || lastName.Length > 50)
                {
                    throw new InvalidOperationException("Фамилия не задана или более 50 знаков!");
                }
                else
                {
                    lastName = value;
                }
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                if ((DateTime.Now.Year - value.Year) > 150 || DateTime.Now < birthDate)
                {
                    throw new InvalidOperationException("Дата рождения не может быть в будущем.\n Вам не должно быть более 150 лет.");
                }
                else
                {
                    birthDate = value;
                }
            }
        }

        public int UserAge
        {
            get
            {
                long ticks = (DateTime.Now - BirthDate).Ticks;
                return new DateTime(ticks).Year - 1;
            }
        }

        public int IdUser => GetHashCode();

        public override string ToString()
        {
            return $"{LastName} {FirstName}, дата рождения: {BirthDate.ToShortDateString()}, {UserAge} лет/год(а) ";
        }

        public override int GetHashCode()
        { 
            return FirstName?.GetHashCode() ?? 0 + LastName?.GetHashCode() ?? 0 + BirthDate.GetHashCode();
        }

        public void AddAward(string newAward)
        {
            userAwards.Add(newAward);
        }

        public void AddAwards(IEnumerable<string> newAwards)
        {


            foreach (string item in newAwards)
            {
                userAwards.Add(item);
            }
        }

        public string UserAwards
        {
            get
            {
                return string.Join(",", userAwards);
            }
        }

        public IEnumerable<string> GetAwards()
        {
            return userAwards;
        }

        public void ClearAwards()
        {
            userAwards.Clear();
        }

        public void DeleteAward(string awardForDelete)
        {
            userAwards.Remove(awardForDelete);
        }
    }
}