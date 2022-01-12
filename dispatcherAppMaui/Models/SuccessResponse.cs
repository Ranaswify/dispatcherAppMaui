using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dispatcherAppMaui.Models
{
    internal class SuccessResponse
    {
        public bool isSucceeded { get; set; }
        public string methodName { get; set; }
        public Status status { get; set; }
        public Data data { get; set; }
    }
    internal class Status
    {
        public int code { get; set; }
        public string message { get; set; }
    }

    internal class Data
    {
        public string token { get; set; }
        public string userName { get; set; }
        public string name { get; set; }
        public List<string> roles { get; set; }
        public string userId { get; set; }
        public int teamId { get; set; }
        public int dispatcherId { get; set; }
        public int id { get; set; }
        public int lastState { get; set; }

        public int fK_SupportedLanguages_ID { get; set; }
        public int languageId { get; set; }

    }

}
