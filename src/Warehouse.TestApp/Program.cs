using Warehouse.Domain.Entities;
using Warehouse.Domain.Repository;

InMemoryRepository inMemoryRepository = new InMemoryRepository();

inMemoryRepository.AddProduct(new Product(){ Id = Guid.NewGuid(), Name = "Maslo", Price = 4.99, CreatedOn = DateTime.Now });
inMemoryRepository.AddProduct(new Product(){ Id = Guid.NewGuid(), Name = "Chleb", Price = 5.55, CreatedOn = DateTime.Now });

Console.WriteLine(inMemoryRepository.GetProducts());