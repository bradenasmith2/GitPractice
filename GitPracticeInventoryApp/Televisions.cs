﻿using System;
using System.Diagnostics;
using System.Drawing;

namespace GitPracticeInventoryApp
{
	public class Televisions
	{
		public string Brand;
		public int Size;
		public double Price;

		public Televisions(string brand, int size, double price)
		{
			Brand = brand;
			Size = size;
			Price = price;
		}
    }
}
