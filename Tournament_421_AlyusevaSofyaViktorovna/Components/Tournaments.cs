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
    
    public partial class Tournaments
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tournaments()
        {
            this.Match = new HashSet<Match>();
            this.Request = new HashSet<Request>();
        }
    
        public int IdTour { get; set; }
        public string Name { get; set; }
        public System.DateTime DateTimeStart { get; set; }
        public string GameName { get; set; }
        public int PlayersAmount { get; set; }
        public decimal Prize { get; set; }
        public Nullable<int> MinPlayerLvl { get; set; }
        public string Region { get; set; }
        public string ExcludeCharWeapon { get; set; }
        public Nullable<int> IdCategory { get; set; }
        public Nullable<int> IdStatus { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Match> Match { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Request { get; set; }
        public virtual TournamentStatus TournamentStatus { get; set; }
    }
}
