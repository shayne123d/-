//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPets.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Shop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop()
        {
            this.Collect = new HashSet<Collect>();
            this.Goods = new HashSet<Goods>();
        }
    
        public int ShopId { get; set; }

        [Required(ErrorMessage = "请输入店铺名")]
        public string ShopName { get; set; }

        public string ShopImg { get; set; }

        [Required(ErrorMessage = "请输入客服电话")]
        public string CustomerService { get; set; }


        public string ShopEmail { get; set; }

        [Required(ErrorMessage = "请输入身份验证")]
        [RegularExpression(@"^\d{15}$|^\d{18}$|^\d{17}(\d|X|x)$", ErrorMessage = "身份证格式不正确")]
        public string SellerIdCard { get; set; }

        public Nullable<int> UserId { get; set; }
        public string StarLevel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collect> Collect { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Goods> Goods { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
