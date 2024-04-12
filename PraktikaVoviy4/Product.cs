//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PraktikaVoviy4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductCostHistories = new HashSet<ProductCostHistory>();
            this.ProductMaterials = new HashSet<ProductMaterial>();
            this.ProductSales = new HashSet<ProductSale>();
        }
    
        public int ID { get; set; }
        public string Title { get; set; }
        public Nullable<int> ProductTypeID { get; set; }
        public string ArticleNumber { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Nullable<int> ProductionPersonCount { get; set; }
        public Nullable<int> ProductionWorkshopNumber { get; set; }
        public decimal MinCostForAgent { get; set; }
    
        public virtual ProductType ProductType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductCostHistory> ProductCostHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductMaterial> ProductMaterials { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductSale> ProductSales { get; set; }
    }
}
