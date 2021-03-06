﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Transitions
{
	/// <summary>
	/// This class manages a linear transition. The percentage complete for the transition
	/// increases linearly with time.
	/// </summary>
    public class TransitionTypeLinear : ITransitionType
    {
        #region Public methods

        /// <summary>
        /// Constructor. You pass in the time (in milliseconds) that the
        /// transition will take.
        /// </summary>
        public TransitionTypeLinear(int transitionTime)
        {
			if (transitionTime <= 0)
			{
				throw new Exception("Transition time must be greater than zero.");
			}
			_transitionTime = transitionTime;
        }

        #endregion

		#region ITransitionMethod Members

		/// <summary>
		/// We return the percentage completed.
		/// </summary>
		public void OnTimer(int time, out double percentage, out bool completed)
		{
			percentage = (time / _transitionTime);
			if (percentage >= 1.0)
			{
				percentage = 1.0;
				completed = true;
			}
			else
			{
				completed = false;
			}
		}

		#endregion

		#region Private data

		private double _transitionTime = 0.0;

		#endregion
	}
}
