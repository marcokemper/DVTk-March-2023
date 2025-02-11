// ------------------------------------------------------
// Original author: Marco Kemper
// ------------------------------------------------------
// DVTk - The Healthcare Validation Toolkit (www.dvtk.org)
// Copyright � 2009 DVTk
// ------------------------------------------------------
// This file is part of DVTk.
//
// DVTk is free software; you can redistribute it and/or modify it under the terms of the GNU
// Lesser General Public License as published by the Free Software Foundation; either version 3.0
// of the License, or (at your option) any later version. 
// 
// DVTk is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even
// the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser
// General Public License for more details. 
// 
// You should have received a copy of the GNU Lesser General Public License along with this
// library; if not, see <http://www.gnu.org/licenses/>



using System;



namespace DvtkHighLevelInterface.Common.Other
{
	/// <summary>
    /// Represent the logical AND that is applied to two other boolean expressions.
	/// </summary>
	public class ConditionAnd: Condition
	{
        //
        // - Fields -
        //

        /// <summary>
        /// The first boolean expression, supplied in the constructor, on which the logical AND operator is applied.
        /// </summary>
		private Condition condition1 = null;

        /// <summary>
        /// The second boolean expression, supplied in the constructor, on which the logical AND operator is applied.
        /// </summary>
		private Condition condition2 = null;



        //
        // - Constructors -
        //

        /// <summary>
        /// Hide default constructor.
        /// </summary>
		private ConditionAnd()
		{
			// Do nothing.
		}

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="condition1">The first boolean expression on which the logical AND operator is applied.</param>
        /// <param name="condition2">The second boolean expression on which the logical AND operator is applied.</param>
		public ConditionAnd(Condition condition1, Condition condition2)
		{
			this.condition1 = condition1;
			this.condition2 = condition2;
		}



        //
        // - Methods -
        //

        /// <summary>
        /// Evaluates the boolean expression using the supplied instance.
        /// </summary>
        /// <param name="theObject">The supplied instance to evaluate the boolean expression with.</param>
        /// <returns>The result of evaluating the boolean expression with the supplied instance.</returns>
		public override bool Evaluate(Object theObject)
		{
			bool isConditionTrue = true;

			isConditionTrue = condition1.Evaluate(theObject);

			if (isConditionTrue)
			{
				isConditionTrue = condition2.Evaluate(theObject);
			}

			return(isConditionTrue);
		}
	}
}
