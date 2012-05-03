using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleCSharpProject {
	public class BuilderExample {
		public static readonly Uri DefaultDestination = new Uri("http://www.purple.com/");
		public static readonly string DefaultName = "Purple.com Test Site";
		public static readonly DateTime DefaultPublishDate = DateTime.Now;

		protected Uri destination;
		protected string name;
		protected DateTime publishDate;

		public Uri Destination { get { return destination; } }
		public string Name { get { return name; } }
		public DateTime PublishDate { get { return publishDate; } }

		public BuilderExample WithDefaults() {
			destination = DefaultDestination;
			name = DefaultName;
			publishDate = DefaultPublishDate;
			return this;
		}

		public BuilderExample WithDestination(string url) {
			destination = new Uri(url);
			return this;
		}

		public BuilderExample WithName(string name) {
			this.name = name;
			return this;
		}

		public BuilderExample WithPublishDate(DateTime date) {
			publishDate = date;
			return this;
		}



	}
}
