using GeneralBusMessages.Message;
using MassTransit;

namespace MechanicPartWEB.MessageBroker.Concumers
{
    public class MechanicTaskConsumer : IConsumer<MechanicsTasks>
    {
        public Task Consume(ConsumeContext<MechanicsTasks> context)
        {
            throw new NotImplementedException();
        }
    }
}
