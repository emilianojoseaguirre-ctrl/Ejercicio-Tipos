//------------------------------------------------------------------------------
// <copyright file="MoviesCatalog.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections;

namespace Ucu.Poo.Repositories
{

    public class MoviesCatalog
    {
        private ArrayList movies = new ArrayList();


        public void Add(Movie movie)
        {
            if (movie != null)
            {
                this.movies.Add(movie);
            }
        }


        public void Remove(Movie movie)
        {
            this.movies.Remove(movie);
        }

        public Movie Find(Predicate<Movie> criteria)
        {
            foreach (Movie movie in this.movies)
            {
                if (criteria(movie))
                {
                    return movie;
                }
            }

            return null;
        }
    }
}
