namespace homework1_bootcampC_.Models
{
    public class Orders
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCountry { get; set; }

        // Her sipariş bir çalışana ait olabilir
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
