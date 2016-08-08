//
//
//  @ Project : Untitled
//  @ File Name : FinancialBusiness.cs
//  @ Date : 12/14/2013
//  @ Author : khoatd
//
//
using System;
using System.Data;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using DBManagement;

namespace com.lhk.transportsystem.Owner.Financial
{
	public class FinancialBusiness 
	{
		protected decimal _ticketRevenue ;
		protected decimal _orderRevenue ;
		protected decimal _totalRevenue ;
		protected decimal _totalExpenses ;
		public FinancialView UnspecifiedType1;
		public void GetOrderRevenue(int month, int year)
		{
		}
		public void GetTicketRevenue(int month, int year)
		{
		}
		public void GetExpenses(int month, int year)
		{
		}
	}
}
