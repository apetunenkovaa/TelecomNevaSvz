//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace telecomNevaSvyaz
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConnectedServices
    {
        public int ConnectedServiceID { get; set; }
        public int SubscribersID { get; set; }
        public int ServicesID { get; set; }
        public Nullable<System.DateTime> ConnectionDate { get; set; }
    
        public virtual Contracts Contracts { get; set; }
        public virtual Service Service { get; set; }
    }
}
