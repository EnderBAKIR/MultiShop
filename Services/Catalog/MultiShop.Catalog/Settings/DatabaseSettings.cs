﻿namespace MultiShop.Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string CategoryCollectionName { get; set; }

        public string ProductCollectionName { get; set; }

        public string ProductDetailtCollectionName { get; set; }

        public string ProductImageCollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
