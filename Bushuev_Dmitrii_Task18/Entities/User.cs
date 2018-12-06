using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities
{
    public class User
    {
        public User()
        {

        }

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
        public List<Award> userAwards = new List<Award>();
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
                if (string.IsNullOrEmpty(value) || value.Length > 50)
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
                if (string.IsNullOrEmpty(value) || value.Length > 50)
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
                if ((DateTime.Now.Year - value.Year) > 150 || DateTime.Now < value)
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

        public int Id { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName}, дата рождения: {BirthDate.ToShortDateString()}, {UserAge} лет/год(а) ";
        }

        public override int GetHashCode()
        { 
            return FirstName?.GetHashCode() ?? 0 + LastName?.GetHashCode() ?? 0 + BirthDate.GetHashCode();
        }

        public void AddAward(Award newAward)
        {
            userAwards.Add(newAward);
        }

        public void AddAwards(IEnumerable<Award> newAwards)
        {          
            foreach (Award item in newAwards)
            {
                userAwards.Add(item);
            }
        }

        public void UpdateAwards(IEnumerable<Award> newAwards)
        {
            ClearAwards();
            AddAwards(newAwards);
        }

        public string UserAwards
        {
            get
            {
                return string.Join(",", userAwards);
            }
        }

        public IEnumerable<Award> GetAwards()
        {
            return userAwards;
        }

        public void ClearAwards()
        {
            userAwards.Clear();
        }

        public void DeleteAward(Award awardForDelete)
        {
            userAwards.Remove(awardForDelete);
        }
    }
}