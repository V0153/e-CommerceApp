using e_CommerceApp.EntitiyLayer.BaseClasses;
using System.ComponentModel;

namespace e_CommerceApp.EntitiyLayer.Entities
{
    public class Category : BaseEntity
    {
        [DisplayName("Adı")]
        public string Name { get; set; }
        [DisplayName("Açıklama")]
        public string? Description { get; set; }
        [DisplayName("Sıra No")]
        public int OrderNo { get; set; }
    }
}
