/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 2/21/2018
 * Time: 7:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CryptoCurrency
{
	/// <summary>
	/// Description of MyClass.
	/// </summary>
	public class ICryptoCurrency
	{
		public string Account {get; set;}
		public string AccessKey {get; set;}
		public int Balance {get; set;}
				
	}
	
	public class CryptoCurrency:ICryptoCurrency
	{
		public int DepositCredit(int amount)
		{
			return Balance = Balance + amount;
		}
		
		public int withdrawDebit(int amount)
		{
			return Balance = Balance - amount;
			
		}
				
	}
	
  
}