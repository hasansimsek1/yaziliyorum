using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Entities
{
    public class Topic: EntityBase
    {
        public string Name { get; set; }
        public string HtmlContent { get; set; }
        public string VideoUrl { get; set; }
        public string PresentationUrl { get; set; }
        public int Order { get; set; }
    }
}
