//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DT.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_TrangThaiSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_TrangThaiSanPham()
        {
            this.tb_SanPham = new HashSet<tb_SanPham>();
        }
    
        public int MaTTSP { get; set; }
        public string TenTTSP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_SanPham> tb_SanPham { get; set; }
    }
}
