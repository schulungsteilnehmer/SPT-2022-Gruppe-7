

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
			string Name;
			string Datum;
			string Klasse;
			
		
			
			Console.Write("Name eingeben:");
			Name=Console.ReadLine();
			Console.Write("Klasse eingeben:");
			Klasse=Console.ReadLine();
			Console.Write("Datum eingeben:");
			Datum=Console.ReadLine();
			Console.Write("Fehltage:");
				Console.ReadLine();
				Console.Write("Unentschuldigte Fehltage:");
			int	Unentschuldigte_Fehltage=Convert.ToInt32(Console.ReadLine());
				
					if (Unentschuldigte_Fehltage>=31)
					{
						Console.WriteLine("Der Schüler wird nicht versetzt");
							Console.ReadLine();
					}
					
					if(Unentschuldigte_Fehltage<31)
					{
						Console.WriteLine("Der Schüler war oft genug anwesend");
						Console.ReadLine();
					}
					
				
			
					
			double[] faecher = new double[8];
			
			String[] faecherNamen = {"Deutsch", "Mathe", "Englisch", "Zweite Fremdsprache", "Politik", "Physik", "Chemie", "Sport"};
			
			Console.Write("Chemie:");
			faecher[0] = Convert.ToDouble(Console.ReadLine());
			if(Convert.ToInt32(faecher[0])>15)
			{
				Console.Write("Noten von 0-15 eintragen");
				Console.ReadKey();
			}
			
			Console.Write("Deutsch:");
			faecher[1]= Convert.ToDouble(Console.ReadLine());
			if(Convert.ToInt32(faecher[1])>15)
			{
				Console.Write("Noten von 0-15 eintragen");
				Console.ReadKey();
			}
			Console.Write("Englisch:");
			faecher[2]= Convert.ToDouble(Console.ReadLine());
			if(Convert.ToInt32(faecher[2])>15)
			{
				Console.Write("Noten von 0-15 eintragen");
				Console.ReadKey();
			}
			Console.Write("Mathe:");
			faecher[3]= Convert.ToDouble(Console.ReadLine());
			if(Convert.ToInt32(faecher[3])>15)
			{
				Console.Write("Noten von 0-15 eintragen");
				Console.ReadKey();
			}
			Console.Write("Physik:");
			faecher[4]= Convert.ToDouble(Console.ReadLine());
			if(Convert.ToInt32(faecher[4])>15)
			{
				Console.Write("Noten von 0-15 eintragen");
				Console.ReadKey();
			}
			Console.Write("Politik:");
			faecher[5]= Convert.ToDouble(Console.ReadLine());
			if(Convert.ToInt32(faecher[5])>15)
			{
				Console.Write("Noten von 0-15 eintragen");
				Console.ReadKey();
			}
			Console.Write("Sport:");
			faecher[6]= Convert.ToDouble(Console.ReadLine());
			if(Convert.ToInt32(faecher[6])>15)
			{
				Console.Write("Noten von 0-15 eintragen");
				Console.ReadKey();
			}
			Console.Write("Zweite Fremdsprache:");
			faecher[7]= Convert.ToDouble(Console.ReadLine());
			
			if(Convert.ToInt32(faecher[7])>15)
			{
				Console.Write("Noten von 0-15 eintragen");
				Console.ReadKey();
			}
			
		
			   
				Console.Write("Leistungskurs 1:");
				String lk1 = Console.ReadLine();
				
				int i = 0;
				while (faecherNamen[i].Equals(lk1) == false) {
					i++;
				}
				Ergebnis += faecher[i];
				
				
				String lk2=Console.ReadLine();
				Console.Write("Leistungskurs 2:");
				Console.ReadLine();
				
				i= 0;
				while (faecherNamen[i].Equals(lk2)==false && i < 7) {
					i++;
				}
				Ergebnis += faecher[i];
			
				
				i=0;
				while(i < 7) {
					Ergebnis += faecher[i];
					i++;
				}
				
				
				Ergebnis=Ergebnis/10;
				Ergebnis=(17-Ergebnis)/3;
				Console.WriteLine("Durchschnittliche Note;");
				Console.ReadKey();
				Console.Write("{0:F1}", Ergebnis);
				Console.ReadLine();
			
			
				int Unterkurs=0;
				for(int index=0;index<faecher.Length;index++)
				{
					if(faecher[index]<5)
					{
						Unterkurs++;
					}
				}
				if(Unterkurs>=2)
				{
					Console.WriteLine("Der Schüler wird aufgrund seiner hohen Anzahl an Unterkursen nicht versetzt");
					Console.Read();
				}
		
		      Console.WriteLine("=========Zeugnis========");
		      Console.WriteLine("Name: " +Name);
		      Console.WriteLine("Datum: "+Datum);
		      Console.WriteLine("Klasse: "+Klasse);
		      Console.WriteLine("========================");
		
		      
		      for(int e=0;e<faecherNamen.Length;e++)
		      {
		      	Console.WriteLine(faecherNamen[e]+ ": "+ faecher[e]);
		      }
		     
		      
		      Console.WriteLine("Durchschnittsnote "+"{0:F1}",Ergebnis);
		      
		      
		      Console.WriteLine("====================");
		      
		      if(Ergebnis>4)
		      {
		      	Console.WriteLine("Der Schüler wird nicht versetzt");
		      }
		      
		      if(Ergebnis<4)
		      {
		      	Console.WriteLine("Der Schüler wird versetzt");
		      }
			
			
			
			Console.ReadKey();
		}
	}
}