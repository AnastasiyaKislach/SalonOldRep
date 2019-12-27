using System;

namespace Salon.Services.Models
{
	public class Appointment : IModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Phone { get; set; }

		public DateTime Date { get; set; }

		public string Details { get; set; }

		public bool IsApprove { get; set; }

		public DateTime ApprovedDate { get; set; }

		public int[] Dresses { get; set; }
	}
}
