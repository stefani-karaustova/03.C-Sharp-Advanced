using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
{
    public class Box<T>
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
