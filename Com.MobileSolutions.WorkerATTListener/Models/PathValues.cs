using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MobileSolutions.WorkerATTListener.Models
{
    public class PathValues
    {
        public string Path { get; set; }

        public string OutputPath { get; set; }

        public string ProcessedFilesPath { get; set; }

        public string FailedFiles { get; set; }

        public string CorruptFiles { get; set; }
    }
}
