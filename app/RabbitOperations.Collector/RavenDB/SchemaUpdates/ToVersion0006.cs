﻿using System;
using NLog;
using RabbitOperations.Collector.Configuration.Interfaces;
using RabbitOperations.Collector.RavenDB.Indexes;
using RabbitOperations.Collector.RavenDB.Interfaces;
using Raven.Abstractions.Data;
using Raven.Client;
using Raven.Json.Linq;
using SouthsideUtility.Core.DesignByContract;

namespace RabbitOperations.Collector.RavenDB.SchemaUpdates
{
    public class ToVersion0006 : IUpdateSchemaVersion
    {
        private readonly ISettings settings;
        private readonly IDocumentStore store;
        public Logger logger = LogManager.GetCurrentClassLogger();

        public ToVersion0006(ISettings settings, IDocumentStore store)
        {
            Verify.RequireNotNull(settings, "settings");
            Verify.RequireNotNull(store, "store");

            this.settings = settings;
            this.store = store;
        }

        public int SchemaVersion
        {
            get { return 6; }
        }

        public void UpdateSchema()
        {
            logger.Info("Updating MessageDocumentSearch index");
            store.ExecuteIndexCreationOnDefaultTenant(new MessageDocument_Search());
        }
    }
}