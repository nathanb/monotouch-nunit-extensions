using System;
using System.Collections;
using NUnit.Framework;

namespace MonoTouch.NUnitExtensions
{
	public static class Extensions
	{
		public static void ShouldBeTrue(this bool expression) {if (expression) Assert.Pass (); else Assert.Fail ("should be true but is false."); }
		public static void ShouldBeFalse(this bool expression) {if (!expression) Assert.Pass (); else Assert.Fail ("should not be true but is."); }

		private static int count(IEnumerable list) {
			int count = 0;
			var spin = list.GetEnumerator ();
			while (spin.MoveNext ()) {
				count++;
			}
			return count;
		}
		public static void ShouldBeEmpty(this IEnumerable list) {
			//manually determin count. 
			int qty = count (list);
			if (qty == 0)
				Assert.Pass (); 
			else 
				Assert.Fail ("should be empty but contains {0} items.", qty); 
		}
		public static void ShouldNotBeEmpty(this IEnumerable list) {
			int qty = count (list);
			if (qty > 0) 
				Assert.Pass (); 
			else 
				Assert.Fail ("should contain items but is empty.");
		}

		public static void ShouldBeNull(this object value) {if (value == null) Assert.Pass (); else Assert.Fail ("should be null but is not."); }
		public static void ShouldNotBeNull(this object value) {if (value != null) Assert.Pass (); else Assert.Fail ("should not be null but is."); }

		public static void ShouldEqual(this object arg, object to) {if (arg.Equals (to)) Assert.Pass (); else Assert.Fail ("{0} should equal {1}", arg, to);}
		public static void ShouldNotEqual(this object arg, object to) {if (!arg.Equals (to)) Assert.Pass (); else Assert.Fail ("{0} should equal {1}", arg, to);}

		public static void ShouldBeGreaterThan(this int arg, int limit) { if (arg > limit) Assert.Pass (); else Assert.Fail ("{0} should be greater than {1}", arg, limit); }
		public static void ShouldBeLessThan(this int arg, int limit) {if (arg < limit) Assert.Pass (); else Assert.Fail ("{0} should be less than {1}", arg, limit);}
		public static void ShouldBeGreaterThanOrEqualTo(this int arg, int limit) {if (arg >= limit) Assert.Pass (); else Assert.Fail ("{0} should be greater than or equal to {1}", arg, limit);}
		public static void ShouldBeLessThanOrEqualTo(this int arg, int limit) {if (arg <= limit) Assert.Pass (); else Assert.Fail ("{0} should be less than or equal to {1}", arg, limit);}

		public static void ShouldBeGreaterThan(this double arg, double limit) { if (arg > limit) Assert.Pass (); else Assert.Fail ("{0} should be greater than {1}", arg, limit); }
		public static void ShouldBeLessThan(this double arg, double limit) {if (arg < limit) Assert.Pass (); else Assert.Fail ("{0} should be less than {1}", arg, limit);}
		public static void ShouldBeGreaterThanOrEqualTo(this double arg, double limit) {if (arg >= limit) Assert.Pass (); else Assert.Fail ("{0} should be greater than or equal to {1}", arg, limit);}
		public static void ShouldBeLessThanOrEqualTo(this double arg, double limit) {if (arg <= limit) Assert.Pass (); else Assert.Fail ("{0} should be less than or equal to {1}", arg, limit);}

		public static void ShouldBeGreaterThan(this decimal arg, decimal limit) { if (arg > limit) Assert.Pass (); else Assert.Fail ("{0} should be greater than {1}", arg, limit); }
		public static void ShouldBeLessThan(this decimal arg, decimal limit) {if (arg < limit) Assert.Pass (); else Assert.Fail ("{0} should be less than {1}", arg, limit);}
		public static void ShouldBeGreaterThanOrEqualTo(this decimal arg, decimal limit) {if (arg >= limit) Assert.Pass (); else Assert.Fail ("{0} should be greater than or equal to {1}", arg, limit);}
		public static void ShouldBeLessThanOrEqualTo(this decimal arg, decimal limit) {if (arg <= limit) Assert.Pass (); else Assert.Fail ("{0} should be less than or equal to {1}", arg, limit);}
	}
}

