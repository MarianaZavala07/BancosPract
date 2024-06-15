using Microsoft.AspNetCore.Mvc.Rendering;

namespace BancosPract.Models;


public class ServiciosModel
{
        public Guid Id { get; set; }
         public string Tipo { get; set; }
         public int NoCuentaS { get; set; }
         public string  NombreS{ get; set;}
         public decimal Costo { get; set; }
         public Guid? BancosId { get; set; }
         public BancosModel? bancosModel{ get; set; }
         //public string BancosName { get; set; }
         
        // public List<SelectListItem> ListBancos { get; set; }

        



}