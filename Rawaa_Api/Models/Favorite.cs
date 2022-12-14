using System;
using System.Collections.Generic;

namespace Rawaa_Api.Models
{
    public partial class Favorite
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public DateTime? SavedOn { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
