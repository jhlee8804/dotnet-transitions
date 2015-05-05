using System;
using System.Collections.Generic;
using System.Text;

namespace Transitions
{
    internal class ManagedTypeFloat : IManagedType
    {
        #region IManagedType Members

        /// <summary>
        /// Returns the type we're managing.
        /// </summary>
        public Type GetManagedType()
        {
            return typeof(float);
        }

        /// <summary>
        /// Returns a copy of the float passed in.
        /// </summary>
        public object Copy(object o)
        {
            float f = (float)o;
            return f;
        }

        /// <summary>
        /// Returns the interpolated value for the percentage passed in.
        /// </summary>
        public object GetIntermediateValue(object start, object end, double percentage)
        {
            float fStart = (float)Convert.ToDouble(start);
            float fEnd = (float)Convert.ToDouble(end);
            return Utility.Interpolate(fStart, fEnd, percentage);
        }

        #endregion
    }
}
