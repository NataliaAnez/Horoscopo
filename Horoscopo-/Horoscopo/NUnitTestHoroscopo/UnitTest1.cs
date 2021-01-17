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
            //Arange=Preparación
            int dia = 5;
            int mes = 7;
            string esperado = "Cancer: Cáncer deberá hacer muchos sacrificios en el 2021 para poder culminar tus proyectos postergados, independizarte, terminar estudios o cualquier otra actividad productiva. " +
                       "Es un tiempo de lucha, pero el 2021 será una época de muchas victorias. " +
                       "Tendrás algunas molestias físicas que con deporte y una mejor dieta se solucionarán." +
                       "En los primeros meses del año los proyectos se estancarán un poco, pero con exigencia podrás sacarlos adelante. " +
                       "Habrán muchas oportunidades, pero cuidado con los resultados.En el amor se recomienda compenetrarse más con su pareja para fortalecer la relación, y los solteros encontrarán un nuevo amor que podría ser pasajero o con planes a futuro. ";

            HoroscopoController Hor = new HoroscopoController();

            //Act=Ejecución

            string resultado = Hor.HoroscopoGet(dia, mes);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

        [Test]
        public void TestPost()
        {
            //Arange=Preparación
            int dia = 8;
            int mes = 12;
            string esperado = "Sagitario: Gran año para los Sagitario. " +
                       "Habrá una bonanza económica con grandes ganancias y remuneraciones por diferentes actividades económicas. " +
                       "Eso si, deberás administrar tu dinero responsablemente durante el primer trimestre del año, en especial con respecto a los gastos para no desperdiciar tu prosperidad. " +
                       "No descuides tu actividad física, evita la comida chatarra y con condimentos. " +
                       "En el amor, será un buen momento para unirte más a tu pareja y con tus amigos, viviendo momentos de tranquilidad y reconciliación. " +
                       "Los solteros encontrarán aventuras y proyectos nuevos que irradiarán alegría para atraer al ser amado.";

            HoroscopoController Hor = new HoroscopoController();

            //Act=Ejecución

            string resultado = Hor.HoroscopoPost(dia, mes);

            //Assert=Verificación
            Assert.AreEqual(esperado, resultado);

        }

    }
}