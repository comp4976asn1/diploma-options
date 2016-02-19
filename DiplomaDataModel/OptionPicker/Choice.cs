using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DiplomaDataModel
{
    public class Choice
    {
        [Key]
        public int ChoiceId { get; set; }

        [ForeignKey("YearTerm")]
        public int? YearTermId { get; set; }
        [ForeignKey("YearTermId")]
        [DisplayName("Term")]
        public YearTerm YearTerm { get; set; }

        [MaxLength(9)]
        [DisplayName("Student Id")]
        public string StudentId { get; set; }
        [Required(ErrorMessage ="First Name is required.")]
        [MaxLength(40, ErrorMessage ="First name cannot exceed 40 characters.")]
        [DisplayName("First Name")]
        public string StudentFirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [MaxLength(40, ErrorMessage = "Last name cannot exceed 40 characters.")]
        [DisplayName("Last Name")]
        public string StudentLastName { get; set; }

        [ForeignKey("FirstOption")]
        public int? FirstChoiceOptionId { get; set; }
        [ForeignKey("FirstChoiceOptionId")]
        [DisplayName("First Option")]
        public Option FirstOption { get; set; }

        [ForeignKey("SecondOption")]
        public int? SecondChoiceOptionId { get; set; }
        [ForeignKey("SecondChoiceOptionId")]
        [DisplayName("Second Option")]
        public Option SecondOption { get; set; }

        [ForeignKey("ThirdOption")]
        public int? ThirdChoiceOptionId { get; set; }
        [ForeignKey("ThirdChoiceOptionId")]
        [DisplayName("Third Option")]
        public Option ThirdOption { get; set; }

        [ForeignKey("FourthOption")]
        public int? FourthChoiceOptionId { get; set; }
        [ForeignKey("FourthChoiceOptionId")]
        [DisplayName("Fourth Option")]
        public Option FourthOption { get; set; }

        private DateTime _SelectionDate = DateTime.MinValue;

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyy}")]
        public DateTime SelectionDate
        {
            get
            {
                return (_SelectionDate == DateTime.MinValue) ? DateTime.Now : _SelectionDate;
            }
            set { _SelectionDate = value; }
        }
    }
}