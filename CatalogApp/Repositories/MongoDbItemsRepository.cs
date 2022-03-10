﻿using CatalogApp.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogApp.Repositories
{
	public class MongoDbItemsRepository : IItemsRepository
	{
		private const string databaseName = "catalog";
		private const string collectionName = "items";
		private readonly IMongoCollection<Item> itemsCollection;

		public MongoDbItemsRepository(IMongoClient mongoClient)
		{
			IMongoDatabase database = mongoClient.GetDatabase(databaseName);
			itemsCollection = database.GetCollection<Item>(collectionName);
		}

		public void CreateItem(Item item)
		{
			itemsCollection.InsertOne(item);
		}

		public void DeleteItem(Guid id)
		{
			throw new NotImplementedException();
		}

		public Item GetItem(Guid id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Item> GetItems()
		{
			return itemsCollection.Find(new BsonDocument()).ToList();
		}

		public void UpdateItem(Item item)
		{
			throw new NotImplementedException();
		}
	}
}
