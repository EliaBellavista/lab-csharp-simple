using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        // TODO: fill this class\
        public readonly double Real = 0;
        public readonly double Imaginary = 0;

        public Complex(double re, double im)
        {
            Real = re;
            Imaginary = im;
        }

        public double Modulus => Math.Sqrt((this.Real * this.Real) + (this.Imaginary * this.Imaginary));

        public double Phase => this.Imaginary;


        public Complex Plus(Complex n) => new Complex(Real + n.Real, Imaginary + n.Imaginary);
        public Complex Minus(Complex n) => new Complex(Real - n.Real, Imaginary - n.Imaginary);

        public Complex Complement()
        {
            return new Complex(this.Real, -(this.Imaginary));
        }

        public override String ToString() => $"{this.Real} {this.Imaginary}i";

        public override bool Equals(object obj)
        {
            return obj is Complex complex &&
                   Real == complex.Real &&
                   Imaginary == complex.Imaginary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Real, Imaginary);
        }
    }
}