//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SQL.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class mountains
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mountains()
        {
            this.podgotovka = new HashSet<podgotovka>();
            this.pyt = new HashSet<pyt>();
        }
    
        public int cod_mountains { get; set; }
        public string name_mountains { get; set; }
        public int cod_stran { get; set; }
        public int Cod_ascent { get; set; }
    
        public virtual ascent ascent { get; set; }
        public virtual strana strana { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<podgotovka> podgotovka { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pyt> pyt { get; set; }
    }
}