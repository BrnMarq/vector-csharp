using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vector
{
    public class Vector
    {
        // ---------------------- Property declarations ----------------------
        private Point _origin;
        private Point _end;
        private double _magnitude;

        // ---------------------- Constructor ----------------------
        public Vector(Point origin, Point end) {
            _origin = origin;
            _end = end;
            _magnitude = CalculateMagnitude();
        }

        // ---------------------- Origin handlers ----------------------
        public Point Origin {
            get {
                return _origin;
            }
            set {
                _origin = value;
                _magnitude = CalculateMagnitude();
            }
        }
        public void SetOrigin(float x, float y)
        {
            _origin = new Point(x, y);
            _magnitude = CalculateMagnitude();
        }

        // ---------------------- End handlers ----------------------
        public Point End {
            get {
                return _end;
            }
            set {
                _end = value;
                _magnitude = CalculateMagnitude();
            }
        }
        public void SetEnd(float x, float y)
        {
            _end = new Point(x, y);
            _magnitude = CalculateMagnitude();
        }

        // ---------------------- Magnitude handlers ----------------------
        public double Magnitude { get { return _magnitude;} }
        internal double CalculateMagnitude()
        {
            double firstTerm = Math.Pow(_end.X - _origin.X, 2);
            double secondTerm = Math.Pow(_end.Y - _origin.Y, 2);
            return Math.Sqrt(firstTerm + secondTerm);
        }

        // ---------------------- Overloaded Operators ----------------------
        public static Vector operator +(Vector vector1, Vector vector2)
        {
            float originX = vector1.Origin.X + vector2.Origin.X;
            float originY = vector1.Origin.Y + vector2.Origin.Y;
            float endX = vector1.End.X + vector2.End.X;
            float endY = vector1.End.Y + vector2.End.Y;

            Point newOrigin = new Point(originX, originY);
            Point newEnd = new Point(endX, endY);

            return new Vector(newOrigin, newEnd);
        }
        public static Vector operator -(Vector vector1, Vector vector2)
        {
            float originX = vector1.Origin.X - vector2.Origin.X;
            float originY = vector1.Origin.Y - vector2.Origin.Y;
            float endX = vector1.End.X - vector2.End.X;
            float endY = vector1.End.Y - vector2.End.Y;

            Point newOrigin = new Point(originX, originY);
            Point newEnd = new Point(endX, endY);

            return new Vector(newOrigin, newEnd);
        }
        public static Vector operator *(float multiplier, Vector vector)
        {
            float originX = multiplier * vector.Origin.X;
            float originY = multiplier * vector.Origin.Y;
            float endX = multiplier * vector.End.X;
            float endY = multiplier * vector.End.Y;

            Point newOrigin = new Point(originX, originY);
            Point newEnd = new Point(endX, endY);

            return new Vector(newOrigin, newEnd);
        }
        public static double operator *(Vector vector1, Vector vector2)
        {
            double vector1X = vector1.End.X - vector1.Origin.X;
            double vector1Y = vector1.End.Y - vector1.Origin.Y;
            double vector2X = vector2.End.X - vector2.Origin.X;
            double vector2Y = vector2.End.Y - vector2.Origin.Y;


            return (vector1X + vector2X) * (vector1Y + vector2Y);
        }
    }
}
