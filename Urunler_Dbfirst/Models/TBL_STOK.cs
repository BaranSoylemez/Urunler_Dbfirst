//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Urunler_Dbfirst.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_STOK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_STOK()
        {
            this.TBL_DOZ = new HashSet<TBL_DOZ>();
        }
    
        public int S_ID { get; set; }
        public Nullable<int> STOK_ADI { get; set; }
        public string SERİ_NO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_DOZ> TBL_DOZ { get; set; }
        public virtual TBL_URUN TBL_URUN { get; set; }
    }
}
