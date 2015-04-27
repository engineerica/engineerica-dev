using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Credits.
	/// </summary>
	public static partial class Credit
	{
		
		/// <summary>
		/// Saves credit.  This action requires authentication.
		/// </summary>
		/// <param name="@user">The Id of the user to add credit.</param>
		/// <param name="@amount">The amount of credits.</param>


		public static ActionResult Save(Guid @user, decimal @amount
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "credit.save", new {@user, @amount
});
		}

		
		/// <summary>
		/// Saves credit
		/// </summary>
		/// <param name="@user">The Id of the user to add credit.</param>
		/// <param name="@amount">The amount of credits.</param>
		/// <param name="@id">The id of the credit save (leave empty to create a new one).</param>
		/// <param name="@paidamount">The amount paid by the user.</param>
		/// <param name="@validfrom">The date when it starts being valid.</param>
		/// <param name="@validto">The date when it ends being valid.</param>
		/// <param name="@discountmethod">One of the discount credit methods: visit, minutes, full-hours, partial-hours.</param>
		/// <param name="@notes">Admin notes</param>
		/// <param name="@rulesjson">The validations rules in JSON format.</param>
		/// <param name="@sourceplanid">The Id of the plan used to create the credit.</param>


		public static ActionResult Save(Guid @user, decimal @amount, Guid @id, decimal @paidamount, DateTime @validfrom, DateTime @validto, string @discountmethod, string @notes, string @rulesjson, Guid @sourceplanid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "credit.save", new {@user, @amount, @id, @paidamount, @validfrom, @validto, @discountmethod, @notes, @rulesjson, @sourceplanid
});
		}

		

	}
}


