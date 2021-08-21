using System;

namespace MuOnline.Domain.Entities.Mu
{
    public class MembStat
    {
        public string memb___id { get; set; }
        public byte ConnectStat { get; set; }
        public string ServerName { get; set; }
        public string IP { get; set; }
        public DateTime? ConnectTM { get; set; }
        public DateTime? DisConnectTM { get; set; }
    }
}