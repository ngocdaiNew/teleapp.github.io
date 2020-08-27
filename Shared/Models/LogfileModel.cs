using System;
using System.Collections.Generic;
using System.Text;

namespace TeleApp.Shared.Models
{
    public class LogfileModel
    {
        public Int64 Id { get; set; }
        public Int64 CustomerId { get; set; }
        public int Type { get; set; }
        public string Phone { get; set; }
        public string Staff { get; set; }
        public int Status { get; set; }
        public Int64 CreateTime { get; set; }
        public string RecordFile { get; set; }
        public string CustomerName { get; set; }
        public string Project { get; set; }
        public int DurationTime { get; set; }
        public string PhoneReceiver { get; set; }
        public string DeviceId { get; set; }
        public string Group { get; set; }
        public int Company { get; set; }
        public DateTime createdAt { get; set; }
    }
}
