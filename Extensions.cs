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

		public static void ShouldBeOfType<T>(object check) {if (check.GetType () == typeof(T)) Assert.Pass (); else Assert.Fail ("object of type: {0} should be of type: {1}", check.GetType (), typeof(T)); }

		public static void ShouldBeGreaterThan<T>(this T arg, T limit) where T : IComparable { if (arg.CompareTo (limit) > 0) Assert.Pass (); else Assert.Fail ("{0} should be greater than {1}", arg, limit); }
		public static void ShouldBeLessThan<T>(this T arg, T limit) where T : IComparable { if (arg.CompareTo (limit) < 0) Assert.Pass (); else Assert.Fail ("{0} hould be less than {1}", arg, limit); }
		public static void ShouldEqual<T>(this T arg, T limit) where T : IComparable { if (arg.CompareTo (limit) == 0) Assert.Pass (); else Assert.Fail ("0} should equal {1}", arg, limit); }
		public static void ShouldNotEqual<T>(this T arg, T limit) where T : IComparable { if (arg.CompareTo (limit) != 0) Assert.Pass (); else Assert.Fail ("0} should not equal {1}", arg, limit); }
	}
}

