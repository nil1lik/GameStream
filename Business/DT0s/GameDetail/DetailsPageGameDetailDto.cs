﻿using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DT0s.GameDetail
{
    public class DetailsPageGameDetailDto
    {
        public int GameDetailId { get; set; }
        public int GameId { get; set; }
        public string Logo { get; set; }
        public string GameType { get; set; }
        public string Platform { get; set; }
        public double? Rate { get; set; }
        public long? DownloadQuantity { get; set; }
        public string DiskSize { get; set; }
        public string VideoUrl { get; set; }
        public string Description { get; set; }
        public string GameName { get; set; }
        public List<string> GameImages { get; set; }
    }

}