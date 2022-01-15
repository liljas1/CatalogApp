using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp.Settings
{
	public class MongoDbSettings
	{
		public string Host { get; set; }
		public int Port { get; set; }

		public string CollectionString 
		{
			get 
			{
				return $"mongodb://{Host}:{Port}";
			} 
		}
	}
}
