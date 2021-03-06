using System.Collections.Generic;
using RabbitOperations.Collector.Models;
using RabbitOperations.Collector.Web.Modules.Api.V1;
using RabbitOperations.Domain;

namespace RabbitOperations.Collector.RavenDB.Query.Interfaces
{
    public interface IBasicSearch
    {
        SearchResult<MessageSearchResult> Search(SearchModel searchModel);
        MessageDocument Get(int id);
    }
}