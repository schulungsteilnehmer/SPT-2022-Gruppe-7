

/*
 * Created by SharpDevelop.
 * User: schulung
 * Date: 03.05.2022
 * Time: 09:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Zeugnis
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Zeugnis David-Gymnasium 2022");
			
			// TODO: Implement Functionality Here
			
			double Ergebnis=0;
			
			
		
			
			Console.WriteLine("Name:");
			Console.ReadLine();
			Console.WriteLine("Klasse:");
			Console.ReadLine();
			Console.WriteLine("Datum:");
			Console.ReadLine();
			
			double[] faecher = new double[8];
			
			String[] faecherNamen = {"Deutsch", "Mathe", "Englisch", "Zweite Fremdsprache", "Politik", "Physik", "Chemie", "Sport"};
			
			Console.WriteLine("Deutsch");
			faecher[0] = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Mathe:");
			faecher[1]= Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Englisch:");
			faecher[2]= Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Zweite Fremdsprache:");
			faecher[3]= Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Politik:");
			faecher[4]= Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Physik:");
			faecher[5]= Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Chemie:");
			faecher[6]= Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Sport:");
			faecher[7]= Convert.ToDouble(Console.ReadLine());
			
			
				Console.WriteLine("Leistungskurs 1:");
				String lk1 = Console.ReadLine();
				
				int i = 0;
				while (faecherNamen[i].Equals(lk1) == false) {
					i++;
				}
				Ergebnis += faecher[i];
				
				
				String lk2=Console.ReadLine();
				Console.WriteLine("Leistungskurs 2:");
				Console.ReadLine();
				
				i= 0;
				while (faecherNamen[i].Equals(lk2)==false) {
					i++;
				}
				Ergebnis += faecher[i];
			
				
				i=0;
				while(i <= 7) {
					Ergebnis += faecher[i];
					i++;
				}
				
				
				
			
		
		
			
		
			if(Ergebnis<5)
			{
				Console.WriteLine("Schüler wird nicht versetzt");
			}
			
			
			
			
			Console.Read();
		}
	}
}