using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horoscopo.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
    public class HoroscopoController : Controller
    {
  

        [HttpGet]

        public string HoroscopoGet(int dia, int mes)
        {
            if (dia > 31 || dia < 1)
            {
                return "Error en la fecha";
            }
            if (mes > 12 || mes < 1)
            {
                return "Error en la fecha";
            }    

            if ((dia >= 21 && mes==3) || (dia <= 20 && mes ==4))
            {
                return "Aries:  Tiene un año de acontecimimentos importantes. " +
                       "Cada situacion debe ser afrontada con creatividad y llegaran muchas oportunidades a tu vida. " +
                       "Por otro lado, será un año ideal para construir o adquirir inmuebles llenos de oportunidades de inversión. " +
                       "En el amor, un milagro llegará a tu hogar desde el cielo. " +
                       " Deberás guardar tus fuerzas para el momento preciso en el amor y si identificas el momento adecuado, podrás tener un corazón pleno en el 2021. " +
                       "Las parejas deberán resolver sus dificultades con paciencia y los solteros tener calma y tomar decisiones cautelosas.";        
                
            }

            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            {
                return "Tauro:  Los Tauro experimentarán muchos cambios en el 2021 con respecto al amor, el trabajo y la rutina diaria. " +
                       "El año representará una etapa de estabilidad, constancia y perseverancia, donde se darán decisiones importantes para alcanzar el éxito anhelado. " +
                       "En la salud deberás hacer ejercicios y dieta, distender las tensiones y estar pendiente de algún familiar enfermo. " +
                       "El 2021 será un periodo de gran esfuerzo en el ámbito económico para los proyectos ya iniciados.Ten la capacidad y el impulso para crecer y progresar. " +
                       "También será positivo en el amor para todos, con estabilidad emocional para las parejas que tengan creatividad, mientras que los solteros deberán tener calma y paciencia.";

            }

            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            {
                return "Geminis: Lastimosamente, el 2021 será una época de tomar decisiones difíciles en el ámbito laboral y en las relaciones. " +
                       "Deberás tener cuidado todo el año con respecto a los gastos, pero será un año ideal para realizar actividades como yoga, meditación, arte y cualquier labor que tenga que ver con la creatividad y la imaginación. " +
                       "En la salud, aquellos con malestares crónicos deberán atenderse y no dejar el asunto para después.El primer trimestre será difícil con el dinero, pero con orden superarás todas las dificultades. " +
                       "En el amor, se recomienda mucha cautela y recordar que todo tiene solución." +
                       "Las parejas y las familias serán muy felices este año, pero los solteros deberán tener cuidado con los momentos de arrebato.";

            }

            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            {
                return "Cancer: Cáncer deberá hacer muchos sacrificios en el 2021 para poder culminar tus proyectos postergados, independizarte, terminar estudios o cualquier otra actividad productiva. " +
                       "Es un tiempo de lucha, pero el 2021 será una época de muchas victorias. " +
                       "Tendrás algunas molestias físicas que con deporte y una mejor dieta se solucionarán." +
                       "En los primeros meses del año los proyectos se estancarán un poco, pero con exigencia podrás sacarlos adelante. " +
                       "Habrán muchas oportunidades, pero cuidado con los resultados.En el amor se recomienda compenetrarse más con su pareja para fortalecer la relación, y los solteros encontrarán un nuevo amor que podría ser pasajero o con planes a futuro. ";

            }

            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            {
                return "Leo: Para el 2021 Leo romperá la rutina. Conocerás nuevas personas y tu conducta social será impredecible, tomando decisiones de manera impulsiva que podrían tener consecuencias indeseables. " +
                       "Mantén la calma en todo momento, no comas en exceso y cuídate del azúcar, pero tampoco te vayas al extremo de lastimarte con los ejercicios. " +
                       "Habrá un periodo de estabilización económica y será un año de orden con el dinero. " +
                       "Podrás resolver algunos trámites legales que te preocupaban y viajar sin riesgos con satisfacción profesional. " +
                       "En el amor, organiza tu vida sentimental, ya que vendrán momentos tensos, pero cualquier problema se podrá solucionar y recuperarás tu tranquilidad.";

            }

            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            {
                return "Virgo: Virgo podrá ser dueño de su propio destino en el 2021. " +
                       "Llegarás a hacerle frente a todos tus problemas y realizarás todas tus metas. " +
                       "Una increíble energía que llenará de esperanza y fe que te acompañará por todo el año. " +
                       "Sin embargo, deberás cuidar tu salud por algún malestar en las vías urinarias y es mejor visitar a un médico. " +
                       "Con el dinero, arriesgarás en algo que te gusta y puede que un nuevo camino se apertura para ti, pero es tiempo de ahorrar. " +
                       "Cuídate de los gastos imprudentes y de los amores clandestinos. Debes estar pendiente de tu pareja, manteniendo la llama viva y ser más detallista. " +
                       "Los solteros encontrarán una nueva relación.";

            }

            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            {
                return "Libra: Para Libra el 2021 será un año lleno de cambios que requerirán incluso un tiempo de mudanza. " +
                       "Buscarás la naturaleza para escapar del ruido y la contaminación." +
                       "Recuerda que tu salud es importante y no deberás programar ninguna operación quirúrgica o tomar una decisión importante a la ligera. " +
                       "La constancia brindará frutos a la larga y alcanzarás logros duraderos. " +
                       "Aprovecha la fuerza renovadora que encuentres en tu nuevo lugar para dejar que las cosas fluyan positivamente. " +
                       "Soluciona tus problemas familiares, sabes que el amor siempre estará de tu lado. " +
                       "Las pruebas serán difíciles en pareja, pero se solucionarán con inteligencia.";

            }

            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            {
                return "Escorpio: El estado mental de Escorpio será más metódico y disciplinado en el 2021. " +
                       "El año estará marcado por una tranquilidad y serenidad que necesitarán para poner en claro cualquier situación personal que necesite solución. " +
                       "Cuida tu hígado, tu estado de ánimo será clave para afrontar cualquier problema de salud. " +
                       "En el dinero, será un buen año para solucionar cualquier proyecto postergado y habrá un aumento en el negocio soñado." +
                       "Es una etapa buena para viajes de negocios. " +
                       "Por otro lado, refuerza tus relaciones familiares y con tu pareja, pero podrían haber alejamientos o peleas. " +
                       "Un viaje con amigos puede tener muchas sorpresas.";

            }

            if ((dia >= 23 && mes == 11) || (dia <= 22 && mes == 12))
            {
                return "Sagitario: Gran año para los Sagitario. " +
                       "Habrá una bonanza económica con grandes ganancias y remuneraciones por diferentes actividades económicas. " +
                       "Eso si, deberás administrar tu dinero responsablemente durante el primer trimestre del año, en especial con respecto a los gastos para no desperdiciar tu prosperidad. " +
                       "No descuides tu actividad física, evita la comida chatarra y con condimentos. " +
                       "En el amor, será un buen momento para unirte más a tu pareja y con tus amigos, viviendo momentos de tranquilidad y reconciliación. " +
                       "Los solteros encontrarán aventuras y proyectos nuevos que irradiarán alegría para atraer al ser amado.";
                }

            if ((dia >= 23 && mes == 12) || (dia <= 20 && mes == 1))
            {
                return "Capricornio: En el 2021 se podrán hacer realidad tus proyectos más ambiciosos, pero antes habrá un periodo muy difícil. " +
                       "Tendrás tendencia a sufrir algunos dolores reumáticos, problemas en los huesos o en las rodillas. " +
                       "Ten cuidado con tu alimentación y visita al médico si te encuentras con algún problema antes que empeore. " +
                       "Por el lado del dinero, será el momento ideal para comenzar nuevos proyectos y expandirte. " +
                       "Te sentirás estimulado y verás aumentadas tus capacidades para organizarte. " +
                       "En el amor habrá una tendencia al aislamiento, con las parejas favoreciéndose a la vida cotidiana y los solteros con ganas de viajar por la aventura.";

            }

            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            {
                return "Acuario: Acuario pasará por tiempos increíbles de renovación e innovación en el 2021. " +
                        "Habrán momentos de independencia y libertad en periodos importantes, por lo que deberás mantener la tranquilidad ante cualquier amenaza para tu salud. " +
                        "Ten cuidado con los problemas del corazón y la circulación." +
                        "Utiliza tu energía en este año para plantearte nuevas metas, pero a la vez ser humilde con tus logros. " +
                        "Habrán contratos y acuerdos. " +
                        "En el amor las decisiones deberán ser tomadas con la cabeza fría, en especial en pareja. " +
                        "Ten calma con las reacciones." +
                        "Los solteros podrán encontrar el amor, pero deberás esperar a que llegue la persona indicada. ";

            }

            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            {
                return "Piscis: Para los Piscis, el 2021 estará lleno de un cúmulo de situaciones favorables para casi todos sus asuntos. " +
                       "Será un año favorable para realizar viajes y se recomienda solucionar los temas legales para realizar planes de emprendimiento. " +
                       "En la salud, se recomienda no tomar en exceso y tener mucho cuidado con los medicamentos. " +
                       "En el dinero, se resolverán algunos viejos problemas y habrán muchas oportunidades de expansión y desarrollo. " +
                       "Los primeros seis meses estarán colmados de propuestas económicas y podrás alcanzar prosperidad. " +
                       "En el amor, las parejas deberán medir sus palabras y los solteros experimentarán cambios y transformaciones favorables, tal vez el retorno de un viejo amor.";

            }


            return "";
        }

      



        /*
        Aries 21 de marzo - 20 de abril
        Tauro 21 de abril - 20 de mayo
        Géminis 21 de mayo - 21 de junio
        Cancer 22 de junio - 22 de julio
        Leo 23 de julio - 23 de agosto
        Virgo 24 de agosto - 22 de septiembre
        Libra 23 de semptiembre - 22 de octubre
        Escorpio 23 de octubre - 22 de noviembre
        Sagitario 23 de noviembre - 21 de diciembre
        Capricornio 22 de diciembre - 20 de enero
        Acuario 21 de enero - 19 de febrero
        Piscis 20 de febrero - 20 de marzo
        */



        [HttpPost]
        public string HoroscopoPost([FromHeader] int dia, int mes)
        {

            if (dia > 31 || dia < 1)
            {
                return "Error en la fecha";
            }
            if (mes > 12 || mes < 1)
            {
                return "Error en la fecha";
            }

            if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
            {
                return "Aries:  Tiene un año de acontecimimentos importantes. " +
                       "Cada situacion debe ser afrontada con creatividad y llegaran muchas oportunidades a tu vida. " +
                       "Por otro lado, será un año ideal para construir o adquirir inmuebles llenos de oportunidades de inversión. " +
                       "En el amor, un milagro llegará a tu hogar desde el cielo. " +
                       " Deberás guardar tus fuerzas para el momento preciso en el amor y si identificas el momento adecuado, podrás tener un corazón pleno en el 2021. " +
                       "Las parejas deberán resolver sus dificultades con paciencia y los solteros tener calma y tomar decisiones cautelosas.";

            }

            if ((dia >= 21 && mes == 4) || (dia <= 20 && mes == 5))
            {
                return "Tauro:  Los Tauro experimentarán muchos cambios en el 2021 con respecto al amor, el trabajo y la rutina diaria. " +
                       "El año representará una etapa de estabilidad, constancia y perseverancia, donde se darán decisiones importantes para alcanzar el éxito anhelado. " +
                       "En la salud deberás hacer ejercicios y dieta, distender las tensiones y estar pendiente de algún familiar enfermo. " +
                       "El 2021 será un periodo de gran esfuerzo en el ámbito económico para los proyectos ya iniciados.Ten la capacidad y el impulso para crecer y progresar. " +
                       "También será positivo en el amor para todos, con estabilidad emocional para las parejas que tengan creatividad, mientras que los solteros deberán tener calma y paciencia.";

            }

            if ((dia >= 21 && mes == 5) || (dia <= 21 && mes == 6))
            {
                return "Geminis: Lastimosamente, el 2021 será una época de tomar decisiones difíciles en el ámbito laboral y en las relaciones. " +
                       "Deberás tener cuidado todo el año con respecto a los gastos, pero será un año ideal para realizar actividades como yoga, meditación, arte y cualquier labor que tenga que ver con la creatividad y la imaginación. " +
                       "En la salud, aquellos con malestares crónicos deberán atenderse y no dejar el asunto para después.El primer trimestre será difícil con el dinero, pero con orden superarás todas las dificultades. " +
                       "En el amor, se recomienda mucha cautela y recordar que todo tiene solución." +
                       "Las parejas y las familias serán muy felices este año, pero los solteros deberán tener cuidado con los momentos de arrebato.";

            }

            if ((dia >= 22 && mes == 6) || (dia <= 22 && mes == 7))
            {
                return "Cancer: Cáncer deberá hacer muchos sacrificios en el 2021 para poder culminar tus proyectos postergados, independizarte, terminar estudios o cualquier otra actividad productiva. " +
                       "Es un tiempo de lucha, pero el 2021 será una época de muchas victorias. " +
                       "Tendrás algunas molestias físicas que con deporte y una mejor dieta se solucionarán." +
                       "En los primeros meses del año los proyectos se estancarán un poco, pero con exigencia podrás sacarlos adelante. " +
                       "Habrán muchas oportunidades, pero cuidado con los resultados.En el amor se recomienda compenetrarse más con su pareja para fortalecer la relación, y los solteros encontrarán un nuevo amor que podría ser pasajero o con planes a futuro. ";

            }

            if ((dia >= 23 && mes == 7) || (dia <= 23 && mes == 8))
            {
                return "Leo: Para el 2021 Leo romperá la rutina. Conocerás nuevas personas y tu conducta social será impredecible, tomando decisiones de manera impulsiva que podrían tener consecuencias indeseables. " +
                       "Mantén la calma en todo momento, no comas en exceso y cuídate del azúcar, pero tampoco te vayas al extremo de lastimarte con los ejercicios. " +
                       "Habrá un periodo de estabilización económica y será un año de orden con el dinero. " +
                       "Podrás resolver algunos trámites legales que te preocupaban y viajar sin riesgos con satisfacción profesional. " +
                       "En el amor, organiza tu vida sentimental, ya que vendrán momentos tensos, pero cualquier problema se podrá solucionar y recuperarás tu tranquilidad.";

            }

            if ((dia >= 24 && mes == 8) || (dia <= 22 && mes == 9))
            {
                return "Virgo: Virgo podrá ser dueño de su propio destino en el 2021. " +
                       "Llegarás a hacerle frente a todos tus problemas y realizarás todas tus metas. " +
                       "Una increíble energía que llenará de esperanza y fe que te acompañará por todo el año. " +
                       "Sin embargo, deberás cuidar tu salud por algún malestar en las vías urinarias y es mejor visitar a un médico. " +
                       "Con el dinero, arriesgarás en algo que te gusta y puede que un nuevo camino se apertura para ti, pero es tiempo de ahorrar. " +
                       "Cuídate de los gastos imprudentes y de los amores clandestinos. Debes estar pendiente de tu pareja, manteniendo la llama viva y ser más detallista. " +
                       "Los solteros encontrarán una nueva relación.";

            }

            if ((dia >= 23 && mes == 9) || (dia <= 22 && mes == 10))
            {
                return "Libra: Para Libra el 2021 será un año lleno de cambios que requerirán incluso un tiempo de mudanza. " +
                       "Buscarás la naturaleza para escapar del ruido y la contaminación." +
                       "Recuerda que tu salud es importante y no deberás programar ninguna operación quirúrgica o tomar una decisión importante a la ligera. " +
                       "La constancia brindará frutos a la larga y alcanzarás logros duraderos. " +
                       "Aprovecha la fuerza renovadora que encuentres en tu nuevo lugar para dejar que las cosas fluyan positivamente. " +
                       "Soluciona tus problemas familiares, sabes que el amor siempre estará de tu lado. " +
                       "Las pruebas serán difíciles en pareja, pero se solucionarán con inteligencia.";

            }

            if ((dia >= 23 && mes == 10) || (dia <= 22 && mes == 11))
            {
                return "Escorpio: El estado mental de Escorpio será más metódico y disciplinado en el 2021. " +
                       "El año estará marcado por una tranquilidad y serenidad que necesitarán para poner en claro cualquier situación personal que necesite solución. " +
                       "Cuida tu hígado, tu estado de ánimo será clave para afrontar cualquier problema de salud. " +
                       "En el dinero, será un buen año para solucionar cualquier proyecto postergado y habrá un aumento en el negocio soñado." +
                       "Es una etapa buena para viajes de negocios. " +
                       "Por otro lado, refuerza tus relaciones familiares y con tu pareja, pero podrían haber alejamientos o peleas. " +
                       "Un viaje con amigos puede tener muchas sorpresas.";

            }

            if ((dia >= 23 && mes == 11) || (dia <= 22 && mes == 12))
            {
                return "Sagitario: Gran año para los Sagitario. " +
                       "Habrá una bonanza económica con grandes ganancias y remuneraciones por diferentes actividades económicas. " +
                       "Eso si, deberás administrar tu dinero responsablemente durante el primer trimestre del año, en especial con respecto a los gastos para no desperdiciar tu prosperidad. " +
                       "No descuides tu actividad física, evita la comida chatarra y con condimentos. " +
                       "En el amor, será un buen momento para unirte más a tu pareja y con tus amigos, viviendo momentos de tranquilidad y reconciliación. " +
                       "Los solteros encontrarán aventuras y proyectos nuevos que irradiarán alegría para atraer al ser amado.";
            }

            if ((dia >= 23 && mes == 12) || (dia <= 20 && mes == 1))
            {
                return "Capricornio: En el 2021 se podrán hacer realidad tus proyectos más ambiciosos, pero antes habrá un periodo muy difícil. " +
                       "Tendrás tendencia a sufrir algunos dolores reumáticos, problemas en los huesos o en las rodillas. " +
                       "Ten cuidado con tu alimentación y visita al médico si te encuentras con algún problema antes que empeore. " +
                       "Por el lado del dinero, será el momento ideal para comenzar nuevos proyectos y expandirte. " +
                       "Te sentirás estimulado y verás aumentadas tus capacidades para organizarte. " +
                       "En el amor habrá una tendencia al aislamiento, con las parejas favoreciéndose a la vida cotidiana y los solteros con ganas de viajar por la aventura.";

            }

            if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
            {
                return "Acuario: Acuario pasará por tiempos increíbles de renovación e innovación en el 2021. " +
                        "Habrán momentos de independencia y libertad en periodos importantes, por lo que deberás mantener la tranquilidad ante cualquier amenaza para tu salud. " +
                        "Ten cuidado con los problemas del corazón y la circulación." +
                        "Utiliza tu energía en este año para plantearte nuevas metas, pero a la vez ser humilde con tus logros. " +
                        "Habrán contratos y acuerdos. " +
                        "En el amor las decisiones deberán ser tomadas con la cabeza fría, en especial en pareja. " +
                        "Ten calma con las reacciones." +
                        "Los solteros podrán encontrar el amor, pero deberás esperar a que llegue la persona indicada. ";

            }

            if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
            {
                return "Piscis: Para los Piscis, el 2021 estará lleno de un cúmulo de situaciones favorables para casi todos sus asuntos. " +
                       "Será un año favorable para realizar viajes y se recomienda solucionar los temas legales para realizar planes de emprendimiento. " +
                       "En la salud, se recomienda no tomar en exceso y tener mucho cuidado con los medicamentos. " +
                       "En el dinero, se resolverán algunos viejos problemas y habrán muchas oportunidades de expansión y desarrollo. " +
                       "Los primeros seis meses estarán colmados de propuestas económicas y podrás alcanzar prosperidad. " +
                       "En el amor, las parejas deberán medir sus palabras y los solteros experimentarán cambios y transformaciones favorables, tal vez el retorno de un viejo amor.";

            }


            return "";

        }



    }
}
