﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Transitions
{
	/// <summary>
	/// Manages transitions for double properties.
	/// </summary>
	internal class ManagedTypeDouble : IManagedType
	{
		#region IManagedType Members

		/// <summary>
		///  Returns the type managed by this class.
		/// </summary>
		public Type GetManagedType()
		{
			return typeof(double);
		}

		/// <summary>
		/// Returns a copy of the double passed in.
		/// </summary>
		public object Copy(object o)
		{
			double d = (double)o;
			return d;
		}

		/// <summary>
		/// Returns the value between start and end for the percentage passed in.
		/// </summary>
		public object GetIntermediateValue(object start, object end, double percentage)
		{
			double dStart = Convert.ToDouble(start);
            double dEnd = Convert.ToDouble(end);
			return Utility.Interpolate(dStart, dEnd, percentage);
		}

		#endregion
	}
}
