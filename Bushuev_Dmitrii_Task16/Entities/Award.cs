using System;

namespace Entities
{
    public class Award
    {
        public Award()
        {

        }

        public Award(string title, string description)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 50)
            {
                throw new InvalidOperationException("Имя награды не задано или более 50 знаков!");
            }

            if (description.Length > 250)
            {
                throw new InvalidOperationException("Описание награды не может быть более 250 символов!");
            }

            this.title = title;
            this.description = description;
        }
        public string title;
        public string description;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 50)
                {
                    throw new InvalidOperationException("Имя не задано или более 50 знаков!");
                }
                else
                {
                    title = value;
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 50)
                {
                    throw new InvalidOperationException("Описание награды не может быть более 250 символов!");
                }
                else
                {
                    description = value;
                }
            }
        }

        public int Id { get; set; }

        //public int IdAward => GetHashCode();

        public override int GetHashCode()
        {
            return Title?.GetHashCode() ?? 0 + Description?.GetHashCode() ?? 0;
        }
    }
}
