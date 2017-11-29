/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 9/17/2017
 * Time: 6:30 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace FileReader
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			 try
	         {
	            // Create an instance of StreamReader to read from a file.
	            // The using statement also closes the StreamReader.
	            using (StreamReader sr = new StreamReader(@"C:\VB Documents\General\sample.txt"))
	            {
	               string line;
	               int ch=0,emptychar=0,tabchar =0;
	               string[] result;
	               int words = 0;
	               
	               // Read and display lines from the file until 
	               // the end of the file is reached. 
	               while (!sr.EndOfStream)
	               {

	               	 ch = sr.Read();
	               	 
	               	 if( char.IsWhiteSpace(((char)ch)))
	               	 {
	               	 	//Console.Write("whitespace character is " +  ch);
	               	 	if(ch==13)
	               	 		emptychar +=1;
	               	   else if(ch==9)
	               	 	tabchar+=1;
	               	 	         	 			
	               	 }
	  				 Console.Write((char)ch);
	             
	               }
	               
	                 Console.WriteLine("whitespace blank is " + emptychar);
	                 Console.WriteLine("whitespace tab is " + tabchar);
	                 
	               Console.WriteLine();
	         
	            }
	         }
	         catch (Exception e)
	         {
	            
	            // Let the user know what went wrong.
	            Console.WriteLine("The file could not be read:");
	            Console.WriteLine(e.Message);
	         }
	         
	         Console.ReadKey();
	
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void ReadLines()
		{
		
			try
	         {
	            // Create an instance of StreamReader to read from a file.
	            // The using statement also closes the StreamReader.
	            using (StreamReader sr = new StreamReader(@"C:\VB Documents\General\sample.txt"))
	            {
	               string line;
	               string[] result;
	               int words = 0;
	               
	               // Read and display lines from the file until 
	               // the end of the file is reached. 
	               while ((line = sr.ReadLine()) != null)
	               {
	                              
	                 result =line.Split('\t');
	                 words+= result.Length + 1;
	                
	               	 Console.Write(line);
	               	 Console.WriteLine(result.Length + 1);
	               	 Console.ReadLine();
					            
	               }
	               Console.WriteLine();
	               Console.WriteLine(words);
	            }
	         }
	         catch (Exception e)
	         {
	            
	            // Let the user know what went wrong.
	            Console.WriteLine("The file could not be read:");
	            Console.WriteLine(e.Message);
	         }
	         
	         Console.ReadKey();
		}
	}
}