using Blazor.Context;
using Blazor.Database;

namespace Blazor.Get_Way
{
    public class ProductGetWay
    {
        ProductDbContext db = new ProductDbContext();



        // ---------------------- Insert

        public bool Insert(Product product)
        {
            try
            {
                db.Products.Add(product);

                int rowCount = db.SaveChanges();

                if (rowCount > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {

                throw;
            }
        }



        // --------------- Get All Products

        public List<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }



        // --------------- Get By Id

        public Product GetById(int id)
        {
            return db.Products.FirstOrDefault(p => p.Id == id);
        }


        // ---------------- Update
        public bool Update(Product product)
        {
            try
            {
                db.Products.Update(product);

                int rowCount = db.SaveChanges();

                if (rowCount > 0)
                {
                    return true;
                }

                return false;

            }
            catch (Exception)
            {

                throw;
            }
        }



        // ------------------------ Delete

        public bool Delete(int id)
        {
            var product = db.Products.FirstOrDefault(p => p.Id==id);
            db.Products.Remove(product);

            int rowDeleted = db.SaveChanges();

            return rowDeleted > 0;
           
        }
    }
}
