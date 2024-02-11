using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClientPartDAL.Interfaces
{
    public interface ISeeder<T> where T : class
    {
        void Seed(EntityTypeBuilder<T> builder);


    }
}
