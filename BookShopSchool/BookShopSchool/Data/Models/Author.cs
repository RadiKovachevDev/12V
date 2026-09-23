using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopSchool.Data.Models
{
    public class Author
    {
        public Author()
        {
            this.AuthorsBooks = new HashSet<AuthorBook>();
        }

        public int Id {  get; set; }

        [Required]
        [MaxLength]

        public string FirstName {  get; set; }
        [Required] [MaxLength(30)][MinLength(3)]
        public string LastName { get; set; }
        [Required][MaxLength(30)][MinLength(3)]
        public string Email { get; set; }
        [Required]
        public string Phone {  get; set; }
        [Required]

        public ICollection<AuthorBook> AuthorBooks { get; set; }
    }
}
