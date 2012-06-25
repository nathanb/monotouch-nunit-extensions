using System;
using NUnit.Framework;
using MonoTouch.NUnitExtensions;

namespace SampleSpec
{
	[TestFixture]
	public class when_testing_some_scenario_with_some_context : SpecBase 
	{
		bool result;

		public override void Given ()
		{
			//establish any defaults, initialization code (runs every test method)
			result = false;
		}

		public override void When ()
		{
			//invoke actual code being tested.
			result = true; //some action that may result in true. 
		}

		[Test]
		public void it_should_return_true(){ result.ShouldBeTrue(); }

		[Test]
		public void it_should_not_throw_an_exception() { error.ShouldBeNull (); }
	}
}