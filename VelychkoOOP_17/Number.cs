using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelychkoOOP_17
{
    abstract class Number
    {
        public abstract Number Add(Number other);
        public abstract Number Subtract(Number other);
        public abstract Number Multiply(Number other);
        public abstract Number Divide(Number other);
        public abstract string ToString();
    }

    class Integer : Number
    {
        private int value;
        public Integer(int value) { this.value = value; }

        public override Number Add(Number other)
        {
            return new Integer(value + ((Integer)other).value);
        }

        public override Number Subtract(Number other)
        {
            return new Integer(value - ((Integer)other).value);
        }

        public override Number Multiply(Number other)
        {
            return new Integer(value * ((Integer)other).value);
        }

        public override Number Divide(Number other)
        {
            return new Integer(value / ((Integer)other).value);
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }

    class Real : Number
    {
        private double value;
        public Real(double value) { this.value = value; }

        public override Number Add(Number other)
        {
            return new Real(value + ((Real)other).value);
        }

        public override Number Subtract(Number other)
        {
            return new Real(value - ((Real)other).value);
        }

        public override Number Multiply(Number other)
        {
            return new Real(value * ((Real)other).value);
        }

        public override Number Divide(Number other)
        {
            return new Real(value / ((Real)other).value);
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
}
