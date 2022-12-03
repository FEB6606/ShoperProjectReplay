using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoper.Entities
{
    public class ProductImage
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; } //Foreign Key
        public byte[] Image { get; set; } //Byte şeklinde yazacak.
        public Product Product { get; set; }
    }
}
