using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleCSharpProject {
	public class Class1 {
		public string MyName { get; set; }
		public int MyValue { get; set; }

		public Class1(string Name, int Value) {
			MyName = Name;
			MyValue = Value;
		}
	}
}
