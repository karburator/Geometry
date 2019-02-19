using System;
using Geometry;
using NUnit.Framework;

namespace Tests
{
	public class CircleTest
	{
		private double eps = 1e-7;
		
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void ZeroRadiusTest()
		{
			Assert.Catch<ArgumentException>(() => new Circle(0d));
		}


		[Test]
		public void NegativeRadiusTest()
		{
			Assert.Catch<ArgumentException>(() => new Circle(-1d));
		}


		[Test]
		public void LessMinRadiusTest()
		{
			Assert.Catch<ArgumentException>(() => new Circle(Circle.MinRadius - 1e7));
		}
		
		
		[Test]
		public void GetSquareTest()
		{
			var radius = 5;
			var circle = new Circle(radius);
			var expectedValue = Math.PI * Math.Pow(radius, 2d); 

			var square = circle.GetSquare();
			
			Assert.Less(Math.Abs(square-expectedValue), eps);
		}
	}
}