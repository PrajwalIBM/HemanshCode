using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using OrganicStore.Models;
using System.Data;
using Newtonsoft.Json;

namespace OrganicStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(products products)
        {
            products prod = new products();
            prod.id = products.id;
            prod.p_name = products.p_name;
            prod.details = products.details;
            prod.category = products.category;
            prod.o_price = products.o_price;
            prod.s_price = products.s_price;
             prod.img = products.img;
            List<products> res = prod.GetProducts();
            string productsJson = JsonConvert.SerializeObject(res);
            TempData["products"] = productsJson;
            /*ViewData["products"] = res;*/

            return RedirectToAction("Products","Home",res);            }
        /*public IActionResult Details()
        {
            List<Models.products> list = new List<Models.products>();
           

            try
            {
                using (SqlConnection con = new SqlConnection(ConnectionMod.getConnString()))
                {
                    con.Open();
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "Select * from products";
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows == false)
                            {
                                
                            }
                            while (reader.Read())
                            {
                                products pd = new Models.products();
                                pd.p_name = reader.GetString("p_name");
                                pd.details = reader.GetString("details");
                                pd.category = reader.GetString("category");
                                *//*pd.s_price = reader.GetDouble(reader.GetOrdinal("s_price"));
                                pd.o_price = reader.GetFloat(reader.GetOrdinal("o_price"));*//*

                                list.Add(pd);
                            }

                        }
                    }
                    *//*string sql = "SELECT * FROM products";
                    con.ConnectionString = ConnectionMod.getConnString();
                    
                    
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();

                    da.SelectCommand = new SqlCommand(sql, con);
                    
                    
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        var product = new Models.products();
                        product.p_name = row["p_name"].ToString();
                        product.details = row["details"].ToString();
                        product.category = row["category"].ToString();
                        product.s_price = (float)row["s_price"];
                        product.o_price = (float)row["o_price"];

                        list.Add(product);

                    }*//*
                }

                
                return RedirectToAction("Products","Home",list);
            }
            catch (Exception ex)
            {
               return View(ex.Message);
            }*/
        }
    }


