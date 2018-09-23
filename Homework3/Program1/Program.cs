using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Drawing;
using System.Numerics;

namespace Program1
{
	public class RandomGenerator
	{
		private static Random random;

		public static double Get()
		{
			if (random == null) random = new Random();
			return random.NextDouble() * short.MaxValue;
		}

		public static double Get(double min, double max)
		{
			return min + Get() % (max - min);
		}
	}

	public class ShapeFactory
	{
		public enum ShapeType
		{
			Rectangle,
			Square,
			Circle,
			Triangle,
		}

		public static IShape GetShape(ShapeType shapeType)
		{
			IShape shape = null;
			switch (shapeType)
			{
				case ShapeType.Rectangle:
					shape = new Rectangle
					(
						RandomGenerator.Get(),
						RandomGenerator.Get()
					);
					break;
				case ShapeType.Square:
					shape = new Square(RandomGenerator.Get());
					break;
				case ShapeType.Circle:
					shape = new Circle(RandomGenerator.Get());
					break;
				case ShapeType.Triangle:
					var a = RandomGenerator.Get();
					var b = RandomGenerator.Get();
					var max = Math.Max(a, b);
					var min = Math.Min(a, b);
					shape = new Triangle
					(
						a: a,
						b: b,
						c: RandomGenerator.Get(max - min, max + min)
					);
					break;
				default:
					Console.Error.WriteLine("unknown shape type encountered");
					break;
			}

			return shape;
		}

		public interface IShape
		{
			double GetArea();
		}

		public class Rectangle : IShape
		{
			public double Length { set; get; } = 0;
			public double Width { set; get; } = 0;

			public Rectangle()
			{
			}

			public Rectangle(double length, double width)
			{
				Length = length;
				Width = width;
			}

			public double GetArea() => Length * Width;
		}

		public class Square : Rectangle
		{
			public Square()
			{
			}

			public Square(double length) : base(length, length)
			{
			}
		}

		public class Circle : IShape
		{
			public double Radius { set; get; } = 0;

			public Circle()
			{
			}

			public Circle(double radius) => Radius = radius;

			public double GetArea() => Math.PI * Radius * Radius;
		}

		public class Triangle : IShape
		{
			public double A { set; get; } = 0;
			public double B { set; get; } = 0;
			public double C { set; get; } = 0;

			public Triangle()
			{
			}

			public Triangle(double a, double b, double c)
			{
				A = a;
				B = b;
				C = c;
			}

			public double GetArea()
			{
				var p = (A + B + C) / 2;
				return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			ShapeFactory.IShape shape = null;
			shape = ShapeFactory.GetShape(ShapeFactory.ShapeType.Rectangle);
			Console.WriteLine(shape.GetArea());
			shape = ShapeFactory.GetShape(ShapeFactory.ShapeType.Circle);
			Console.WriteLine(shape.GetArea());
			shape = ShapeFactory.GetShape(ShapeFactory.ShapeType.Square);
			Console.WriteLine(shape.GetArea());
			shape = ShapeFactory.GetShape(ShapeFactory.ShapeType.Triangle);
			Console.WriteLine(shape.GetArea());
		}
	}
}