namespace JupiterStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {  
            private StoreDbContext context;

            public EFStoreRepository(StoreDbContext ct) {
            context = ct;
            }
            public IQueryable<Product> Products => context.Products;
        
    }
}
