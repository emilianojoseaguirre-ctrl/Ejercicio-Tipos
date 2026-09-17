//------------------------------------------------------------------------------
// <copyright file="Movie.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

namespace Ucu.Poo.Repositories
{

    public class Movie
    {

        public Movie(string name, int year)
        {
            this.Name = name;
            this.Year = year;
        }


        public string Name { get; set; }

        public int Year { get; set; }
    }
}
