/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 8/20/2017
 * Time: 6:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VM.Yantra
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Block
	{
		public Block()
		{
			
		}
		
		protected string State;
		protected string GUID;
		protected string LinkGUID;
		protected string Checksum;
		protected string Priority;
		
			
		public enum ScopeType { Public=1, Pivate =2};
		protected ScopeType BlockType;
		
		protected VM.Yantra.BlockBase BaseType;
		protected VM.Yantra.BlockBase HostTransactionType;
		
		protected VM.Yantra.Timestamp Timestamp;
				
	}
}
