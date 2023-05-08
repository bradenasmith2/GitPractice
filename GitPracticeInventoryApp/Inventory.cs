
using System;
namespace GitPracticeInventoryApp
{
	public class Inventory
	{
		public List<Televisions> Televisions;
		public List<Computers> Computers;

		public Inventory()
		{
			Televisions = new List<Televisions>();
			Computers = new List<Computers>();
		}

		public void AddComputerToListOfComputers(Computers computer)
		{
			Computers.Add(computer);
		}

		public void AddTelevisionToListOfTelevisions(Televisions television)
		{
			Televisions.Add(television);
		}

		public void GetListOfComputers()
		{
			foreach (var pc in Computers)
			{
				Console.WriteLine($"{pc.Brand} costs ${pc.Price}");
			}
		}

		public void GetListOfTelevisions()
		{
			foreach (var tv in Televisions)
			{
				Console.WriteLine($"{tv.Brand} is {tv.Size} inches, and costs ${tv.Price}");
			}
		}
	}
}

