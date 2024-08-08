// See https://aka.ms/new-console-template for more information
public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public List<string> Items { get; set; }
    public double TotalAmount { get; set; }
}

public class OrderProcessor
{
    public void Process(Order order)
    {
        // Logic to process the order
    }
}

public class OrderRepository
{
    public void Save(Order order)
    {
        // Logic to save the order to the database
    }
}

//Open/Closed Principle
public abstract class Discount
{
    public abstract double Calculate(double totalAmount);
}

public class NoDiscount : Discount
{
    public override double Calculate(double totalAmount)
    {
        return totalAmount;
    }
}

public class PercentageDiscount : Discount
{
    private readonly double _percentage;

    public PercentageDiscount(double percentage)
    {
        _percentage = percentage;
    }

    public override double Calculate(double totalAmount)
    {
        return totalAmount - (totalAmount * _percentage / 100);
    }
}

//Liskov Substitution Principle
public class OrderProcessor2
{
    public void Process(Order order, Discount discount)
    {
        double discountedTotal = discount.Calculate(order.TotalAmount);
       
    }
}
//Interface Segregation Principle
public interface IOrderProcessor
{
    void Process(Order order);
}

public interface IOrderRepository
{
    void Save(Order order);
}

public class OnlineOrderProcessor : IOrderProcessor
{
    public void Process(Order order)
    {
        // Process online order
    }
}

public class StoreOrderRepository : IOrderRepository
{
    public void Save(Order order)
    {
        // Save order to the store database
    }
}

//Dependency Inversion Principle
public class OrderService
{
    private readonly IOrderProcessor _orderProcessor;
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderProcessor orderProcessor, IOrderRepository orderRepository)
    {
        _orderProcessor = orderProcessor;
        _orderRepository = orderRepository;
    }

    public void HandleOrder(Order order)
    {
        _orderProcessor.Process(order);
        _orderRepository.Save(order);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Order order = new Order
        {
            OrderId = 1,
            CustomerName = "John Doe",
            Items = new List<string> { "Item1", "Item2" },
            TotalAmount = 100.0
        };

        IOrderProcessor orderProcessor = new OnlineOrderProcessor();
        IOrderRepository orderRepository = new StoreOrderRepository();

        OrderService orderService = new OrderService(orderProcessor, orderRepository);
        orderService.HandleOrder(order);

        Console.WriteLine("Order processed successfully.");
    }
}

