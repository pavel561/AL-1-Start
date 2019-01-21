using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
	public class Practice
	{
		/// <summary>
		/// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
		/// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
		/// </summary>
		public static void A_L1_P1_OOP()
		{
			//Circle circle = new Circle(10);
			//Circle circle2 = new Circle(20);

			//Square square = new Square(5);
			//Square square2 = new Square(25);

			var figureArr = new Figure[3,10];
			for(int i = 0; i < 10; i++)
			{
				figureArr[0, i] = new Circle(i + 1);
			}
			for (int i = 0; i < 10; i++)
			{
				figureArr[1, i] = new Square(i + 1);
			}
			for (int i = 0; i < 10; i++)
			{
				figureArr[2, i] = new Triangle(i + 1);
			}


			//var arr = new Figure[] { circle, circle2, square, square2 };
			Console.WriteLine("{0,3} | {1,20} | {2,20} | {3,20}","", "Площадь круга",
								"Площадь квадрата",
								"Площадь треугольника");
			Console.WriteLine("________________________________________" +
				"__________________________");
			for (int j = 0; j<10; j++)
			{
				Console.WriteLine("{0,3} | {1,20} | {2,20} | {3,20}", j+1, (figureArr[0, j].CalculateArea()),
								(figureArr[1, j].CalculateArea()),
								(figureArr[2, j].CalculateArea()));
			}
			Console.ReadLine();
		}
		public class Figure
		{
			public virtual double CalculateArea()
			{
				throw new NotImplementedException();
			}
			
		}
		public class Circle:Figure
		{
			private double radius;

			public Circle(float radius)
			{
				this.radius = radius;
			}
			public override double CalculateArea()
			{
				return Math.PI* radius * radius;
			}
		}

		public class Square:Figure
		{
			private double a;

			public Square(float a)
			{
				this.a = a;
			}
			public override double CalculateArea()
			{
				return a * a;
			}
		}
		//Будем вычислять площадь Равностороннего треугольника, т.к. для
		//равнобедренного требуется знать 2 параметра (основание и высоту)
		public class Triangle : Figure	
		{
			private double a;   //Основание треугольника
			//private double h;   //Высота треугольника

			public Triangle(float a)
			{
				this.a = a;
				//this.h = h;
			}
			public override double CalculateArea()
			{
				return (double) a*a*Math.Sqrt(3)/4;
			}
		}


		/// <summary>
		/// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
		/// Продемонстрировать использование в коде. 
		/// </summary>
		public static void A_L1_P6_OperatorsOverloading()
        {
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {            
        }        
    }
}
