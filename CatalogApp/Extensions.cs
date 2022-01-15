using CatalogApp.Dtos;
using CatalogApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp
{
	public static class Extensions
	{
		// Operates on the current item
		public static ItemDto AsDto(this Item item)
		{
			return new ItemDto
			{
				Id = item.Id,
				Name = item.Name,
				Price = item.Price,
				CreatedDate = item.CreatedDate
			};
		}
	}
}
