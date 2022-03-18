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
                            DepartmentName= "genie mecanique"
                        },
                        new Department()
                        {
                           DepartmentName= "genie informatique"
                        },
                        new Department()
                        {
                            DepartmentName = "genie industriel"
                        },
                          new Department()
                        {
                            DepartmentName= "genie mathematiques"
                        },
                        new Department()
                        {
                           DepartmentName= "genie physique"
                        },
                        new Department()
                        {
                            DepartmentName = "genie chimie"
                        }
                    }) ;
                    context.SaveChanges();
                }

                if (!context.Employee.Any())
                {

                }
            }
        }
    }
}
