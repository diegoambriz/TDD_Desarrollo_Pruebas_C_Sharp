using System;
using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDeImpuestosTest
{
    /*Requerimientos
     + Obtener el IVA a partir del monto de una reserva
     + Obtener el impuesto sobre hospedaje a partir del monto una reserva
     + Obtener el monto total de la reserva
        Impuestos a considerar: IVA e ISH
        %IVA = 16%, ISH = 3% Monto de Reserva = $1550
    */
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void ImpuestosTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci= new CalculadoraDeImpuestos();

            //Act
            decimal iva = ci.ObtenerIva(1550.00m);

            //Assert
            //IVA 16%
            //Monto Reserva = $1550
            //1550 * .16 = 248.00
            Assert.AreEqual(248.00m, iva);
        }

        [TestMethod]
        public void ISHTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);

            //Assert
            //ISH 3%
            //Monto Reserva = $1550
            //1550 * .03 = 46.50
            Assert.AreEqual(46.50m, ish);
        }

        [TestMethod]
        public void MontoTotalReservaTest()
        {
            //Arrange
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            //Act
            decimal iva = ci.ObtenerIva(1550.00m);
            decimal ish = ci.ObtenerISH(1550.00m, 0.03m);
            decimal montoTotalReserva = ci.ObtenerMontoTotalReserva(iva,ish,1550m);

            //Assert
            //IVA = $248
            //ISH = $46.50
            //Monto Reserva = $1550
            //$1550 + $248 + $46.60 = $1844.50
            Assert.AreEqual(1844.50m, montoTotalReserva);
        }
    }
}
