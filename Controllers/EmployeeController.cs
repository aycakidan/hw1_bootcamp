//using Microsoft.AspNetCore.Mvc;

//public class EmployeeController : Controller
//{
//    private readonly DbContext _context;

//    public EmployeeController(DbContext context)
//    {
//        _context = context;
//    }

//    public ActionResult Index()
//    {
//        var employees = _context.Employees.ToList();
//        return View(employees);
//    }

//    public ActionResult EmployeeOrders(int id)
//    {
//        var employee = _context.Employees.Find(id);
//        if (employee == null)
//        {
//            return NotFound();
//        }

//        var orders = _context.Orders.Where(o => o.EmployeeID == id).ToList();
//        return View(orders);
//    }
//}
