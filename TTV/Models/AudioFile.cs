using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TTV.Models
{
    public class AudioFile
    {
        public int audioID { get; set; }

        public string fileName { get; set; }

        public Nullable<int> fileSize { get; set; }

        public string filePath { get; set; }
    }
}