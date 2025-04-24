public class OrderHandlerFacade
{
    private readonly OrderProcessor_Old _oldProcessor;
    private readonly OrderProcessor_New _newProcessor;
    private readonly bool _useNewSystem;

    public OrderHandlerFacade(bool useNewSystem = false)
    {
        _oldProcessor = new OrderProcessor_Old();
        _newProcessor = new OrderProcessor_New();
        _useNewSystem = useNewSystem;
    }

    public void ProcessOrder(Order order)
    {
        if (_useNewSystem)
        {
            _newProcessor.ProcessOrder(order);
        }
        else
        {
            _oldProcessor.ProcessOrder(order);
        }
    }
} 