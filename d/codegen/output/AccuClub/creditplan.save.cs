using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Creditplans.
	/// </summary>
	public static partial class Creditplan
	{
		
		/// <summary>
		/// Saves a credit plan.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the membership plan</param>
		/// <param name="@amount">The amount of credits.</param>
		/// <param name="@paymentamount">The amount that the user must pay.</param>
		/// <param name="@discountmethod">One of the discount credit methods: visit, minutes, full-hours, partial-hours.</param>


		public static ActionResult Save(string @name, decimal @amount, decimal @paymentamount, string @discountmethod
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "creditplan.save", new {@name, @amount, @paymentamount, @discountmethod
});
		}

		
		/// <summary>
		/// Saves a credit plan
		/// </summary>
		/// <param name="@name">The name of the membership plan</param>
		/// <param name="@amount">The amount of credits.</param>
		/// <param name="@paymentamount">The amount that the user must pay.</param>
		/// <param name="@discountmethod">One of the discount credit methods: visit, minutes, full-hours, partial-hours.</param>
		/// <param name="@id">The id of the credit save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the membership plan</param>
		/// <param name="@salesnotes">Sale point notes or comments.</param>
		/// <param name="@rulesjson">The validations rules in JSON format.</param>
		/// <param name="@validfor">Valid for, format example: 1h, 2d, 3w, 1m, 1y.</param>


		public static ActionResult Save(string @name, decimal @amount, decimal @paymentamount, string @discountmethod, Guid @id, string @description, string @salesnotes, string @rulesjson, string @validfor
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "creditplan.save", new {@name, @amount, @paymentamount, @discountmethod, @id, @description, @salesnotes, @rulesjson, @validfor
});
		}

		

	}
}


