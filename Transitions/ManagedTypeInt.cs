using System;
using System.Collections.Generic;
using System.Text;

namespace Transitions
{
    /// <summary>
    /// Manages transitions for int properties.
    /// </summary>
    internal class ManagedTypeInt : IManagedType
    {
		#region IManagedType Members

		/// <summary>
		/// Returns the type we are managing.
		/// </summary>
		public Type GetManagedType()
		{
			return typeof(int);
		}

		/// <summary>
		/// Returns a copy of the int passed in.
		/// </summary>
		public object Copy(object o)
		{
			int value = (int)o;
			return value;
		}

		/// <summary>
		/// Returns the value between the start and end for the percentage passed in.
		/// </summary>
		public object GetIntermediateValue(object start, object end, double percentage)
		{
			int iStart = Convert.ToInt32(start);
			int iEnd = Convert.ToInt32(end);
			return Utility.Interpolate(iStart, iEnd, percentage);
		}

		#endregion
	}
}
