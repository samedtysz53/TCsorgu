using System.ComponentModel.DataAnnotations;

namespace TCsorgu.Models
{
    public class SearchModel
    {
        [Required(ErrorMessage ="Lütfen Tc kimlik numaranızı giriniz")]
        public string TC { get; set; }
        [Required(ErrorMessage = "Lütfen adınızı giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
        public string surname { get; set; }
        [Required(ErrorMessage = "Lütfen doğum yılınızı giriniz")]
        public string year { get; set; }
        public bool İsChecked { get; set; }

    }
}
