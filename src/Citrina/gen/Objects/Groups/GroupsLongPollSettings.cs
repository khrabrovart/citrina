using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Citrina
{
    public class GroupsLongPollSettings
    {
        /// <summary>
        /// API version used for the events.
        /// </summary>
        public string ApiVersion { get; set; } 

        public GroupsLongPollEvents Events { get; set; } 

        /// <summary>
        /// Shows whether Long Poll is enabled.
        /// </summary>
        public bool? IsEnabled { get; set; } 
    }
}
