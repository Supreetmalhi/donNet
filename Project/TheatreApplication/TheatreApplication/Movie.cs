using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatreApplication
{
    class Movie
    {
        List<string> Cast { get; set; }
        //Genre Genre { get; set; }
        int Length { get; }
        string Title { get; }
        int Year { get; }

        //Constructor
        public Movie(string title, int year, int length)
        {
            this.Title = title;
            this.Year = year;
            this.Length = length;
            this.Cast = new List<string>();
        }

        public AddActor(string actor)
        {

        }
        public SetGenre(Genre genre)
        {

        }
        public AddActor(string actor)
        {

        }
        public AddActor(string actor)
        {

        }
    }
}
