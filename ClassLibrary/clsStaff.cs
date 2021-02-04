using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public Int32 StaffID { get; set; }
        public string StaffName { get; set; }
        public string StaffAddress { get; set; }
        public DateTime StartDate { get; set; }
        public double Salary { get; set; }
        public bool Manager { get; set; }
    }
}