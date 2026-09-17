//------------------------------------------------------------------------------
// <copyright file="CarsDatabase.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.Repositories
{
    public class Database<T>
    {

        private List<T> items = new List<T>();

        public void Add(T newItem)
        {
            if (newItem != null)
            {
                this.items.Add(newItem);
            }
        }

        public void Remove(T item)
        {
            this.items.Remove(item);
        }

        public T Find(Predicate<T> criteria)
        {
            foreach (T item in this.items)
            {
                if (criteria(item))
                {
                    return item;
                }
            }

            return default(T);
        }
    }
}
