namespace fabrk
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Заказ()
        {
            Заказанные_изделия = new HashSet<Заказанные_изделия>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Дата { get; set; }

        [Required]
        [StringLength(20)]
        public string тап_выполнения { get; set; }

        public int Заказчик { get; set; }

        public int Менеджер { get; set; }

        public decimal? Стоимость { get; set; }

        public virtual Пользователь Пользователь { get; set; }

        public virtual Пользователь Пользователь1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Заказанные_изделия> Заказанные_изделия { get; set; }
    }
}
