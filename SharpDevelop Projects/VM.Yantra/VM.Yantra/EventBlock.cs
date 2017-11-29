/*
 * Created by SharpDevelop.
 * User: viprava
 * Date: 8/20/2017
 * Time: 7:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VM.Blockchain
{
	/// <summary>
	/// Description of EventBlock.
	/// Audit Data for every request from each server nodes for all and every transaction committed to server Hosts
	/// </summary>
	public class EventBlock: VM.Yantra.Block
	{
		public EventBlock()
		{
		}
		
		public enum AuditAction {NewRequest=1, Committed=2, Updated=3, Deleted=4, Archived=5}
		protected  AuditAction Action;
	}
}
