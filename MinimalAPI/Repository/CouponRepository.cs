using MinimalCouponAPI.Repository.IRepository;

namespace MinimalCouponAPI.Repository;

public class CouponRepository : ICouponRepository
{
    private readonly ApplicationDbContext _db;
    public CouponRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public async Task<ICollection<Coupon>> GetAllAsync()
    {
        return await _db.Coupons.ToListAsync();

    }
    public async Task<Coupon> GetAsync(int id)
    {
        return await  _db.Coupons.FirstOrDefaultAsync(el=> el.Id == id);
    }
    public async Task<Coupon> GetAsync(string name)
    {
        return await _db.Coupons.FirstOrDefaultAsync(el => el.Name.ToLower()  == name.ToLower());
    }
    public async Task CreateAsync(Coupon coupon)
    {
         _db.Coupons.Add(coupon);
    }
    public async Task UpdateAsync(Coupon coupon)
    {
        _db.Coupons.Update(coupon);
    }
    public async Task RemoveAsync(Coupon coupon)
    {
          _db.Coupons.Remove(coupon);
    }
    public async Task SaveAsync()
    {
        await _db.SaveChangesAsync();
    }
}
