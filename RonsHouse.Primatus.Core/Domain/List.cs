using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace RonsHouse.Primatus.Core.Domain
{
	public class List
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime CreatedOn { get; set; }
		public List<ListItem> Items { get; set; }

		public List(string name)
		{
			this.Name = name;
			this.Items = new List<ListItem>();
			this.CreatedOn = DateTime.Now;
		}

		public override string ToString()
		{
			return JsonConvert.SerializeObject(this);
		}

		public static List ToObject(string json)
		{
			return JsonConvert.DeserializeObject<List>(json);
		}
	}

	public class ListItem
	{
		public string Item { get; set; }
		public string Description { get; set; }
		public DateTime CreatedOn { get; set; }

		public ListItem(string item, string description)
		{
			this.Item = item;
			this.Description = description;
			this.CreatedOn = DateTime.Now;
		}
	}
}
