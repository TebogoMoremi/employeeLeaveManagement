namespace employeeLeaveManagement.Data
{
    public class LeaveType:BaseEntity
    {
       
        //leave type e,g vacation etc.
        public string  Name { get; set; }
        public int DefaultsDays { get; set; }



    }
}
