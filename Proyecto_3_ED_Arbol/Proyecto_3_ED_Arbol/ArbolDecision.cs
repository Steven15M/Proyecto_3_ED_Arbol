using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarytree
{
    internal class ArbolDecision
    {
        public string pregunta;
        public ArbolDecision si;
        public ArbolDecision no;
        public string respuesta;

        public ArbolDecision(string pregunta)
        {
            this.pregunta = pregunta;
            si = null;
            no = null;
            respuesta = null;
        }
        public ArbolDecision()
        {
        }

        // Clase para el árbol de decisión
        public class DecisionTree
        {
            private ArbolDecision root;

            public DecisionTree(ArbolDecision rootNode)
            {
                root = rootNode;
            }

            // Método para realizar la evaluación de la decisión
            public string EvaluarDecision()
            {
                ArbolDecision current = root;

                while (current != null)
                {
                    Console.WriteLine(current.pregunta);
                    string respuesta = Console.ReadLine().ToLower();

                    if (respuesta == "si")
                    {
                        if (current.si != null)
                        {
                            current = current.si;
                        }
                        else
                        {
                            return current.respuesta;
                        }
                    }
                    else if (respuesta == "no")
                    {
                        if (current.no != null)
                        {
                            current = current.no;
                        }
                        else
                        {
                            return current.respuesta;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Respuesta inválida. Por favor, responda 'si' o 'no'.");
                    }
                }

                return null;
            }

        }


        // Método para preguntar al usuario si desea continuar
        public void PreguntarContinuar(ArbolDecision root)
        {
            Console.WriteLine("¿Desea hacer otra consulta o salir? Responda 'si' o 'no'.");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta == "si")
            {
                new DecisionTree(root).EvaluarDecision(); // Reiniciar la consulta
            }
            else
            {
                Console.WriteLine("¡Hasta luego!");
            }
        }

        // Método para iniciar la consulta
        public void IniciarConsulta(ArbolDecision root)
        {
            Console.WriteLine("¡Bienvenido al consultorio digital de síntomas!");
            Console.WriteLine("Responde 'si' o 'no' a las siguientes preguntas para iniciar la consulta:");
            new DecisionTree(root).EvaluarDecision();
        }


        public void arbol_sintomas()
        {
            ArbolDecision root = new ArbolDecision("¿Tiene congestión nasal?");
            root.si = new ArbolDecision("¿Tiene dolor de garganta?");
            root.si.no = new ArbolDecision("20% Gripe, 20% Resfriado, 25% Sinusitis, 20% Alergia");
            root.si.si = new ArbolDecision("¿Tiene fatiga?");
            root.si.si.no = new ArbolDecision("¿Tiene estornudos?");
            root.si.si.no.si = new ArbolDecision("¿Tiene tos?");
            root.si.si.no.si.si = new ArbolDecision("¿Tiene leve malestar?");
            root.si.si.no.si.si.si = new ArbolDecision("100% Resfriado, 40% Alergia, 40% Gripe, 25% Sinusitis");
            root.si.si.no.si.si.no = new ArbolDecision("80% Resfriado, 40% Alergia, 40% Gripe, 25% Sinusitis");
            root.si.si.no.si.no = new ArbolDecision("¿Tiene picason de ojos?");
            root.si.si.no.si.no.si = new ArbolDecision("¿Tiene erupciones cutáneas?");
            root.si.si.no.si.no.si.si = new ArbolDecision("¿Tiene sibilancias?");
            root.si.si.no.si.no.si.si.si = new ArbolDecision("100% Alergia, 60% Resfriado, 40% Gripe, 25% Sinusitis");
            root.si.si.no.si.no.si.si.no = new ArbolDecision("80% Alergia, 60% Resfriado, 40% Gripe, 25% Sinusitis");
            root.si.si.no.si.no.si.no = new ArbolDecision("60% Alergia, 60% Resfriado, 40% Gripe, 25% Sinusitis");
            root.si.si.no.si.no.no = new ArbolDecision("¿60% Resfriado, 40% Gripe, 40% Alergia 25% Sinusitis?");
            root.si.si.no.no = new ArbolDecision("¿Tiene dolor facial?");
            root.si.si.no.no.no = new ArbolDecision("40% Gripe, 40% Resfriado, 25% Sinusitis, 20% Alergia");
            root.si.si.no.no.si = new ArbolDecision("¿Tiene presión en los senos paranasales?");
            root.si.si.no.no.si.no = new ArbolDecision("50% Sinusitis, 40% Gripe, 40% Resfriado, 20% Alergia");
            root.si.si.no.no.si.si = new ArbolDecision("¿Tiene secrecion nasal?");
            root.si.si.no.no.si.si.no = new ArbolDecision("75% Sinusitis, 40% Resfriado, 40% Gripe, 20% Alergia");
            root.si.si.no.no.si.si.si = new ArbolDecision("100% Sinisitis, 40% Resfriado, 40% Gripe, 20% Alergia");
            root.si.si.si = new ArbolDecision("¿Tiene Fiebre?");
            root.si.si.si.no = new ArbolDecision("20% Bronquitis, 60% Gripe, 25% Sinisitis, 40% Resfriado, 20% Alergia");
            root.si.si.si.si = new ArbolDecision("¿Tiene dolor de cabeza?");
            root.si.si.si.si.no = new ArbolDecision("80% Gripe, 20% Bronquitis, 25% Sinisitis, 40% Resfriado, 20% Alergia");
            root.si.si.si.si.si = new ArbolDecision("100% Gripe 20% bornquitis, 25% Sinisitis, 40% Resfriado, 20% Alergia");
            root.no = new ArbolDecision("¿Tiene tos persistente?");
            root.no.si = new ArbolDecision("¿Tiene producción de esputo?");
            root.no.si.no = new ArbolDecision("20% Bronquitis");
            root.no.si.si = new ArbolDecision("¿Tiene dificultad para respirar?");
            root.no.si.si.no = new ArbolDecision("40% Bronquitis");
            root.no.si.si.si = new ArbolDecision("¿Tiene dolor de pecho?");
            root.no.si.si.si.no = new ArbolDecision("60% Bronquitis");
            root.no.si.si.si.si = new ArbolDecision("¿Tiene fatiga?");
            root.no.si.si.si.si.no = new ArbolDecision("80% Bronquitis");
            root.no.si.si.si.si.si = new ArbolDecision("100% Bronquitis, 20% Gripe");
            root.no.no = new ArbolDecision("Diagnóstico final: Usted no esta enfermo");

            DecisionTree tree = new DecisionTree(root);

            // evaluar el árbol de decisión
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("          ¡Bienvenido al consultorio digital de síntomas!");
            Console.WriteLine("");
            Console.WriteLine("__________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("Responde 'si' o 'no' a las siguientes preguntas. Desea iniciar? No=Salir:");
            string respuestaInicioConsulta = Console.ReadLine().ToLower();

            if (respuestaInicioConsulta == "si")
            {
                string mejorOpcion = tree.EvaluarDecision();

            }
            else if (respuestaInicioConsulta == "no")
            {
                Console.WriteLine("Gracias por visitarnos. Hasta luego :)");
            }
            else if (respuestaInicioConsulta == "")
            {
                Console.WriteLine("¿Desea volver a hacer otra consulta o salir? Responda 'si' o 'no'.");
                string respuestaFinal = Console.ReadLine().ToLower();
                if (respuestaFinal == "si")
                {
                    arbol_sintomas();
                }
                else
                {
                    Console.WriteLine("Hasta luego :)");
                }
            }
            else
            {
                Console.WriteLine("Respuesta inválida. Por favor, responda 'si' o 'no'.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArbolDecision arbol = new ArbolDecision();
                arbol.arbol_sintomas();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("¿Desea volver a hacer otra consulta o salir? Responda 'si' o 'no'.");
                string respuestaFinal = Console.ReadLine().ToLower();
                if (respuestaFinal == "si")
                {
                    Main(args); // reiniciar la consulta
                }
                else
                {
                    Console.WriteLine("Hasta luego :)");
                }
            }
        }
    }
}
