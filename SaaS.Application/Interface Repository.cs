using System;
using System.Collections.Generic;
using System.Text;

public interface ICustomerRepository
{
    Task<List<Customer>> GetAllAsync(Guid tenantId);
    Task AddAsync(Customer customer);
}