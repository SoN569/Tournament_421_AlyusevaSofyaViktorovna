//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tournament_421_AlyusevaSofyaViktorovna.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupUser
    {
        public int IdGroupUser { get; set; }
        public Nullable<int> IdGroup { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual Users Users { get; set; }
    }
}
