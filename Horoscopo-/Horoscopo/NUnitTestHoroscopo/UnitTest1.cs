using Horoscopo.Controllers;
using NUnit.Framework;

namespace NUnitTestHoroscopo
{
    public class TestHoroscopo
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGet()
        {
            //Arange=Preparaci�n
            int dia = 5;
            int mes = 7;
            string esperado = "Cancer: C�ncer deber� hacer muchos sacrificios en el 2021 para poder culminar tus proyectos postergados, independizarte, terminar estudios o cualquier otra actividad productiva. " +
                       "Es un tiempo de lucha, pero el 2021 ser� una �poca de muchas victorias. " +
                       "Tendr�s algunas molestias f�sicas que con deporte y una mejor dieta se solucionar�n." +
                       "En los primeros meses del a�o los proyectos se estancar�n un poco, pero con exigencia podr�s sacarlos adelante. " +
                       "Habr�n muchas oportunidades, pero cuidado con los resultados.En el amor se recomienda compenetrarse m�s con su pareja para fortalecer la relaci�n, y los solteros encontrar�n un nuevo amor que podr�a ser pasajero o con planes a futuro. ";

            HoroscopoController Hor = new HoroscopoController();

            //Act=Ejecuci�n

            string resultado = Hor.HoroscopoGet(dia, mes);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestPost()
        {
            //Arange=Preparaci�n
            int dia = 8;
            int mes = 12;
            string esperado = "Sagitario: Gran a�o para los Sagitario. " +
                       "Habr� una bonanza econ�mica con grandes ganancias y remuneraciones por diferentes actividades econ�micas. " +
                       "Eso si, deber�s administrar tu dinero responsablemente durante el primer trimestre del a�o, en especial con respecto a los gastos para no desperdiciar tu prosperidad. " +
                       "No descuides tu actividad f�sica, evita la comida chatarra y con condimentos. " +
                       "En el amor, ser� un buen momento para unirte m�s a tu pareja y con tus amigos, viviendo momentos de tranquilidad y reconciliaci�n. " +
                       "Los solteros encontrar�n aventuras y proyectos nuevos que irradiar�n alegr�a para atraer al ser amado.";

            HoroscopoController Hor = new HoroscopoController();

            //Act=Ejecuci�n

            string resultado = Hor.HoroscopoPost(dia, mes);

            //Assert=Verificaci�n
            Assert.AreEqual(esperado, resultado);

        }

    }
}