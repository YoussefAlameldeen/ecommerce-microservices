using Ecommerce.Customers.Model;

namespace Ecommerce.Customers.Service
{
    public interface ICustomerService
    {
        public Task<IList<Customer>> GetAllAsync(string username, string password);
        //public void PostAsync(Customer customer);
    }

}



//    using Ecommerce.Products.AppDbContext;
//using Ecommerce.Products.Dtos;
//using Ecommerce.Products.Models;
//using Microsoft.EntityFrameworkCore;

//namespace Ecommerce.Products.Services
//    {
//        public class CustomerService : ICustomerService
//        {
//            private readonly ApplicationDbContext _context;
//            public CustomerService(ApplicationDbContext context)
//            {
//                _context = context;
//            }

//            public IEnumerable<Customer_Dto> GetCustomer()
//            {
//                var Customer = _context.Customers.Include(x => x.orders)
//                      .ThenInclude(x => x.products)
//                      .Include(x => x.ShoppingCart)
//                      .Include(x => x.cobons)
//                      .Select(x => new Customer_Dto
//                      {
//                          Name = x.Name,
//                          cobon_Dtos = x.cobons.Select(
//                              w => new Cobon_Dto
//                              {
//                                  Percentage = w.Percentage,
//                                  Title = w.Title
//                              }).ToList()
//                              ,
//                          Email = x.Email,
//                          Shopping_Dto = new Shopping_Dto
//                          {
//                              NumberOfItems = x.ShoppingCart.NumberOfItems
//                          },
//                          Content = x.Content,
//                          order_Dtos = x.orders.Select(o => new Order_Dto
//                          {
//                              Total_Price = o.Total_Price,
//                              product_Dtos = o.products.Select(f => new Product_Dto
//                              {
//                                  Description = f.Description,
//                                  Name = f.Name,
//                                  Stock_Quantity = f.Stock_Quantity,
//                              }).ToList()
//                          }).ToList()
//                      }).ToList();

//                return Customer;
//            }

//            public void PostCustomer(Customer_Dto customer)
//            {
//                var custom = new Customer
//                {
//                    Name = customer.Name,
//                    Email = customer.Email,
//                    Content = customer.Content,
//                    cobons = customer.cobon_Dtos.Select(x => new Cobon
//                    {
//                        Percentage = x.Percentage,
//                        Title = x.Title
//                    }).ToList(),
//                    orders = customer.order_Dtos.Select(o => new Order
//                    {
//                        Total_Price = o.Total_Price,
//                        products = o.product_Dtos.Select(f => new Product
//                        {
//                            Description = f.Description,
//                            Name = f.Name,
//                            Stock_Quantity = f.Stock_Quantity
//                        }).ToList()
//                    }).ToList(),
//                    ShoppingCart = new ShoppingCart
//                    {
//                        NumberOfItems = customer.Shopping_Dto.NumberOfItems
//                    }
//                };
//                throw new Exception("The Customer not valid");

//                _context.Customers.Add(custom);
//                _context.SaveChanges();

//            }
//        }
