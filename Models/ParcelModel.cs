using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVP_RJCode.Models
{
    public class ParcelModel
    {
        private string parcelId;
        private string address;
        private string productTypeId;
        private string productTypeName;

        [DisplayName("Parcel Id")]
        [Required(ErrorMessage = "Parcel Id is required")]
        public string ParcelId
        { 
            get => parcelId; 
            set => parcelId = value; 
        }
        
        [DisplayName("Address")]
        [Required(ErrorMessage = "Address is required")]
        public string Address
        {
            get => address;
            set => address = value;
        }

        [DisplayName("Product Type Id")]
        [Required(ErrorMessage = "Product Type Id is required")]
        public string ProductTypeId
        { 
            get => productTypeId; 
            set => productTypeId = value; 
        }

        [DisplayName("Product Type Name")]
        [Required(ErrorMessage ="Product Type name is required")]
        [StringLength(40, MinimumLength =3, ErrorMessage = "Product type name must be between 3 and 40 characters")]
        public string ProductTypeName
        { 
            get => productTypeName; 
            set => productTypeName = value; 
        }
    }
}
