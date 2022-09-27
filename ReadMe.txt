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


         //BUSÝNESS 12.ders
        AUTOFAC 165M
        AUTOFAC Extrass (Dynamic.Proxy)
        Autofac dependecy Injection
       DependecyResolver Baðýmlýlýk Çözümleyicilerimiz Burda Autofac

       Fluent Validation - Jeremy Skinner

       Cross Cutting Concerns
