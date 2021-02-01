using System.Collections.Generic;

namespace OpenDataRdwNL.Models
{
    public class OpenDataRdwNlOptions
    {
        public string OpenDataRdwNlServiceAddress { get; set; }
        public OpenDataRdwNlLanguage OpenDataRdwNlLanguage { get; set; } = OpenDataRdwNlLanguage.En;
        public string AppToken { get; set; }
    }
}