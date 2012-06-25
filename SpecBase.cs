using System;
using NUnit.Framework;

namespace MonoTouch.NUnitExtensions
{
	public abstract class SpecBase
	{
		protected Exception error;

		[SetUp]
		public void Initalize() {
			error = null;
			Settings.DebugEnabled = true;

			Given ();

			try {
				When ();
			} catch (Exception ex) {
				this.error = ex;
			}
		}

		[TearDown]
		public virtual void TearDown() {}

		public virtual void Given() {}

		public abstract void When();

	}
}

