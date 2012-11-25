using System.Collections.Generic;
using Newtonsoft.Json;

namespace ZendeskApi_v2.Models.Tickets
{
    public  class GroupTicketFieldResponse
    {
        [JsonProperty("ticket_fields")]
        public IList<TicketField> TicketFields { get; set; }
    }
}