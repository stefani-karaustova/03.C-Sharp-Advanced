using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class Box<T>
    {
        private List<T> elements;

        public Box()
        {
            this.elements = new List<T>();
        }

        public int Count => this.elements.Count;

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove()
        {
            var element = this.elements[this.Count - 1];
            this.elements.RemoveAt(this.Count - 1);

            return element;
        }
    }
}
