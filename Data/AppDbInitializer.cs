using DB_Context.Models;
using E_commerce_Mvc_app.Models;

namespace E_commerce_Mvc_app.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<CompanyContext>();

                context.Database.EnsureCreated();

                if (!context.Department.Any())
                {
                    context.Department.AddRange(new List<Department>()
                    {
                        new Department()
                        {
                            Name = "Genie informatique"
                        },
                        new Department()
                        {
                            Name = "Genie mecanique"
                        },
                        new Department()
                        {
                            Name = "Genie economique"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Employee.Any())
                {

                }
            }
        }
    }
}
