using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Metadata;

namespace OrganicStore.Models
{
    public class products
    {
        /*id, p_name, details, category, s_price, o_price, img*/
        public int id { get; set; }

        public string p_name { get; set; }

        public string details { get; set; }

        public string category { get; set; }

        public float s_price { get; set; }

        public float o_price { get; set; }

        public Blob img { get; set; }      

    }
 }