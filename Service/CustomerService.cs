using Ecommerce.Customers.ApplicationDbContext;
using Ecommerce.Customers.Model;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Customers.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _appDbContext;
        private readonly HttpClient _httpClient;

        public CustomerService(AppDbContext appDbContext, HttpClient httpClient)
        {
            _appDbContext = appDbContext;
            _httpClient = httpClient;
        }

        public async Task<IList<Customer>> GetAllAsync(string name, string password)
        {
            var r = new LoginDto()
            {
                username = name,
                password = password
            };
            var response = await _httpClient.PostAsJsonAsync("https://localhost:7144/api/Login/CheckUser", r, CancellationToken.None);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Invalid Data");
            }

            var result = await _appDbContext.Customers.ToListAsync();
            return result;

        }


    }
}
