Data Access
        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

              public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }



        Generate new type =>Core Entities/IDto


         //BUSÝNESS
        AUTOFAC 165M
        AUTOFAC Extrass (Dynamic.Proxy)
       DependecyResolver Baðýmlýlýk Çözümleyicilerimiz Burda Autofac

