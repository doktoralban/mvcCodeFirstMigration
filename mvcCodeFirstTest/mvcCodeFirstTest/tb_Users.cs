namespace mvcCodeFirstTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_mig1
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public bool isActive { get; set; }

		public DateTime BirthDate { get; set; }

		//[Column(TypeName = "varchar")]
		//[StringLength(500)]
		//public String Adress { get; set; }



	}
}
