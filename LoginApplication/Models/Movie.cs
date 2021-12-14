using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoginApplication.Models
{
    class Movie
    {
        private int _id;
        private String name;
        private String description;
        private String category;
        private DateTime date;

        public Movie(int id, string name, string description, string category, DateTime date)
        {
            this._id = id;
            this.name = name;
            this.description = description;
            this.category = category;
            this.date = date;
        }

        public int id { get => _id; set => _id = value; }
        public string _name { get => name; set => name = value; }
        public string _description { get => description; set => description = value; }
        public string _category { get => category; set => category = value; }
        public DateTime _date { get => date; set => date = value; }

        public override string ToString()
        {
            return "Categoría: " + category + ", Nombre: " + name +
                   " fecha " + date;
        }
    }
}
