
using HotChocolate.Types.Descriptors;
using MechanicPartDAL;
using System.Reflection;

namespace MechanicPartWEB.Extensions
{
    public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        protected override void OnConfigure(
           IDescriptorContext context,
           IObjectFieldDescriptor descriptor,
           MemberInfo member)
        {
            descriptor.UseDbContext<TaskManagerDbContext>();
        }
    }




}
