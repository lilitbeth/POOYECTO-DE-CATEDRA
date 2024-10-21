using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOYECTO_DE_CATEDRA
{
    public class Pedidos
    {
        //atributos que generan el codigo de pedido
        private static int contador = 1;
        public string CodPedido { get; set; }

        public DateTime FechaPedido { get; set; }

        //atributos y propiedades para cada tipo de pupusa, ya que esta tiene subclasificacion en masa: masa de maiz y masa de arroz
        
        public int FrijolMaiz { get; set; }
        public int FrijolArroz { get; set; }

        public int QuesoMaiz { get; set; }
        public int QuesoArroz { get; set; }

        public int RevueltaMaiz { get; set; }
        public int RevueltaArroz { get; set; }

        public int PolloMaiz { get; set; }
        public int PolloArroz { get; set; }

        public int AyoteMaiz { get; set; }
        public int AyoteArroz { get; set; }

        public int ChicharronMaiz { get; set; }
        public int ChicharronArroz { get; set; }

        //atributos que ayudan a contabilizar cuantas pupusas hay en total por tipo de pupusa 
        public int cantFrijol { get; set; }
        public int cantQueso { get; set; }
        public int cantRevuelta { get; set; }
        public int cantPollo { get; set; }
        public int cantAyote { get; set; }
        public int cantChicharron { get; set; }

        //atributos que ayudan a contabilizar el subtotal por tipo de pupusa
        public double TotFrijol { get; set; }
        public double TotQueso { get; set; }
        public double TotRevuelta { get; set; }
        public double TotPollo { get; set; }
        public double TotAyote { get; set; }
        public double TotChicharron { get; set; }

        //atributo que suma el total en la compra de pupusas
        public double TotalPedido { get; set; }

        //constructor de Pedido que almacena los datos de pupusas
        public Pedidos(int frijolmaiz, int frijolarroz, int quesomaiz, int quesoarroz, int revueltamaiz, int revueltaarroz, int ayotemaiz, int ayotearroz, int pollomaiz, int polloarroz, int chicharronmaiz, int chicharronarroz)
        {       
                FrijolArroz = frijolarroz;
                FrijolMaiz = frijolmaiz;
                QuesoArroz = quesoarroz;
                QuesoMaiz = quesomaiz;
                RevueltaArroz = revueltaarroz;
                RevueltaMaiz = revueltamaiz;
                AyoteArroz = ayotearroz;
                AyoteMaiz = ayotemaiz;
                PolloArroz = polloarroz;
                PolloMaiz = pollomaiz;
                ChicharronArroz = chicharronarroz;
                ChicharronMaiz = chicharronmaiz;

                CantidadTipoPupusas();
                SubTotalTipo();
                Total();
        }

        //constructor de pedido que almacena la fecha del pedido
        public Pedidos(DateTime fechapedido)
        { 
            FechaPedido= fechapedido;
        }

        //constructor de pedido para llamar a métodos
        public Pedidos()
        { 
        }

        //metodo que calcula la cantidad de pupusas por su tipo
        private void CantidadTipoPupusas()
        {
            cantFrijol = FrijolMaiz + FrijolArroz;
            cantQueso = QuesoMaiz + QuesoArroz;
            cantRevuelta = RevueltaArroz + RevueltaMaiz;
            cantAyote = AyoteArroz + AyoteArroz;
            cantPollo = PolloArroz + PolloMaiz;
            cantChicharron = ChicharronArroz + ChicharronMaiz;
        }

        //metodo que calcula el subtotal por el tipo de pupusas
        private void SubTotalTipo()
        {
            TotFrijol = cantFrijol * 0.60;
            TotQueso = cantQueso * 0.75;
            TotRevuelta = cantRevuelta * 0.75;
            TotAyote = cantAyote * 0.75;
            TotPollo = cantPollo * 1.00;
            TotChicharron = cantChicharron * 0.75;
        }

        //metodo que calcula el total del pedido de pupusas
        public double Total()
        {
            TotalPedido = TotFrijol + TotQueso + TotRevuelta + TotAyote + TotPollo + TotChicharron;
            return TotalPedido;
        }
        //metodo que genera automaticamente el codigo del pedido

        public string GenerarCodPedido()
        {
            string codigoPedido = $"#{contador:D4}";
            contador++;
            return codigoPedido;
        }

        //metodo que retorna el resumen del pedido
        public string CadenaPedido()
        {
            string PupusasPedidas = string.Format("Frijol con queso {0}\n, Queso: {1}\n, Revueltas: {2}\n, Ayote: {3}\n, Pollo {4}\n, Chicharron con queso {5} ", cantFrijol, cantQueso, cantRevuelta, cantAyote, cantPollo, cantChicharron);
            return PupusasPedidas;
        }

        //método que retorna en string la fecha de realizacion del pedido
        public string CadenaFechaPedido()
        {
            string FechaPedidos = string.Format("Fecha y hora del pedido: {0}", FechaPedido);

            return FechaPedidos;
        }

    }
}
