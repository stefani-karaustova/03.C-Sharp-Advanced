using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    class Box<T>
    {
        public Box(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }

        public override string ToString()
        {
            Type valueType = this.Value.GetType();

            return $"{valueType.FullName}: {this.Value}";
        }
    }
}
