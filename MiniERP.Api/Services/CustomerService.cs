using BorealERP.Api.Entities;
using BorealERP.Api.Repositories.Interfaces;
using BorealERP.Api.Services.Interfaces;

namespace BorealERP.Api.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _repository;

    public CustomerService(ICustomerRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Customer>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Customer?> GetByIdAsync(int id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task CreateAsync(Customer customer)
    {
        customer.IsActive = true;
        await _repository.AddAsync(customer);
    }

    public async Task UpdateAsync(int id, Customer customer)
    {
        var existing = await _repository.GetByIdAsync(id);

        if (existing == null)
            throw new Exception("Customer not found");

        existing.Name = customer.Name;
        existing.Email = customer.Email;
        existing.Phone = customer.Phone;
        existing.CPF_CNPJ = customer.CPF_CNPJ;

        await _repository.UpdateAsync(existing);
    }

    public async Task DeleteAsync(int id)
    {
        var customer = await _repository.GetByIdAsync(id);

        if (customer == null)
            throw new Exception("Customer not found");

        customer.IsActive = false;

        await _repository.UpdateAsync(customer);
    }
}
