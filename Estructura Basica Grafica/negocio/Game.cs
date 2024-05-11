using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using Estructura_Basica_Grafica.negocio;

using Estructura_Basica_Grafica.helper;

namespace Estructura_Basica_Grafica
{
    class Game : GameWindow
    {
        Escenario escenario;
        Objeto t2;
        Objeto eq1;
        Objeto florero;
        private float rotationAngle = 3f;
        float scaleFactor = 1.0f; // Factor de escala inicial
        float scaleSize = 0.001f;
        private static float xPosition = 0.04f; // Posición en el eje X
        private static float yPosition = 0.04f; // Posición en el eje Y
        private static float moveSpeed = 0.04f;  // Velocidad de movimiento

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {
            Run(60.0);
        }
        protected override void OnUpdateFrame(FrameEventArgs e)
        {

            KeyboardState input = Keyboard.GetState();
            if (input.IsKeyDown(Key.Escape))
            {
                Exit(); 
            }
        


            //TRANSFORMATIONS
            // rotar el objeto en función de las teclas
            if (input.IsKeyDown(Key.A))
            {
                escenario.Rotate(-rotationAngle, 0, 1, 0);
            }
            else if (input.IsKeyDown(Key.D))
            {
                
                escenario.Rotate(rotationAngle, 0, 1, 0);
            }
            else if (input.IsKeyDown(Key.W))
            {
             
                escenario.Rotate(rotationAngle, 1, 0, 0);
            }
            else if (input.IsKeyDown(Key.S))
            {
              
                escenario.Rotate(-rotationAngle, 1, 0, 0);
            }
            // Mover el objeto en función de las teclas
            if (input.IsKeyDown(Key.Left))
            {
                escenario.Translate(-0.04f, 0, 0);
            }
            else if (input.IsKeyDown(Key.Right))
            {
                escenario.Translate(0.04f, 0, 0);
            }
            else if (input.IsKeyDown(Key.Up))
            {
                escenario.Translate(0, 0.04f, 0);
            }
            else if (input.IsKeyDown(Key.Down))
            {
                escenario.Translate(0, -0.04f, 0);
            }
            //Escalar el objeto en función de las teclas
            else if (input.IsKeyDown(Key.Number1))
            {
                scaleFactor = scaleFactor + 0.001f;
                escenario.Scale(scaleFactor);
            }
            else if (input.IsKeyDown(Key.Number2))
            {
                scaleFactor = scaleFactor - 0.001f;
                escenario.Scale(scaleFactor);
            }

            /*------------------ OBJETOS ---------------------------------*/
            // rotar el objeto en función de las teclas
            if (input.IsKeyDown(Key.F))
            {
                escenario.Get("televisor").Rotate(-rotationAngle, 0, 1, 0, escenario.Get("televisor").center);
            }
            else if (input.IsKeyDown(Key.H))
            {
                escenario.Get("televisor").Rotate(rotationAngle, 0, 1, 0, escenario.Get("televisor").center);
            }
            else if (input.IsKeyDown(Key.T))
            {
                escenario.Get("televisor").Rotate(rotationAngle, 1, 0, 0, escenario.Get("televisor").center);
            }
            else if (input.IsKeyDown(Key.G))
            {
                escenario.Get("televisor").Rotate(-rotationAngle, 1, 0, 0, escenario.Get("televisor").center);
            }

            // Mover el objeto en función de las teclas
            if (input.IsKeyDown(Key.J))
            {
                escenario.Get("televisor").Translate(-xPosition, 0, 0);
               
            }
            else if (input.IsKeyDown(Key.L))
            {
                escenario.Get("televisor").Translate(xPosition, 0, 0);
                
            }
            else if (input.IsKeyDown(Key.I))
            {
                escenario.Get("televisor").Translate(0, yPosition, 0);
                
            }
            else if (input.IsKeyDown(Key.K))
            {
                escenario.Get("televisor").Translate(0, -yPosition, 0);
                
            }
            //Escalar el objeto en función de las teclas
            else if (input.IsKeyDown(Key.P))
            {
                scaleFactor = scaleFactor - 0.001f;
                escenario.Get("televisor").Scale(scaleFactor, escenario.Get("televisor").center);
                
            }
            else if (input.IsKeyDown(Key.O))
            {
                scaleFactor = scaleFactor + 0.001f;
                escenario.Get("televisor").Scale(scaleFactor, escenario.Get("televisor").center);
                
            }

            /*------------------ OBJETOS ---------------------------------*/
            // rotar el partes en función de las teclas
            if (input.IsKeyDown(Key.Z))
            {
                escenario.Get("televisor").Get("pantalla").Rotate(-rotationAngle, 0, 1, 0, escenario.Get("televisor").Get("pantalla").center);
            }
            else if (input.IsKeyDown(Key.V))
            {
                escenario.Get("televisor").Get("pantalla").Rotate(rotationAngle, 0, 1, 0, escenario.Get("televisor").Get("pantalla").center);
            }
            else if (input.IsKeyDown(Key.X))
            {
                escenario.Get("televisor").Get("pantalla").Rotate(rotationAngle, 1, 0, 0, escenario.Get("televisor").Get("pantalla").center);
            }
            else if (input.IsKeyDown(Key.C))
            {
                escenario.Get("televisor").Get("pantalla").Rotate(-rotationAngle, 1, 0, 0, escenario.Get("televisor").Get("pantalla").center);
            }

            // Mover el objeto en función de las teclas
            if (input.IsKeyDown(Key.B))
            {
                escenario.Get("televisor").Get("pantalla").Translate(-xPosition, 0, 0);
            }
            else if (input.IsKeyDown(Key.M))
            {
                escenario.Get("televisor").Get("pantalla").Translate(xPosition, 0, 0);
            }
            else if (input.IsKeyDown(Key.N))
            {
                escenario.Get("televisor").Get("pantalla").Translate(0, yPosition, 0);
            }
            else if (input.IsKeyDown(Key.Space))
            {
                escenario.Get("televisor").Get("pantalla").Translate(0, -yPosition, 0);
            }
            //Escalar el objeto en función de las teclas
            else if (input.IsKeyDown(Key.Number3))
            {
                scaleFactor = scaleFactor - 0.001f;
                escenario.Get("televisor").Scale(scaleFactor, escenario.Get("televisor").center);
            }
            else if (input.IsKeyDown(Key.Number4))
            {
                scaleFactor = scaleFactor + 0.001f;
                escenario.Get("televisor").Scale(scaleFactor, escenario.Get("televisor").center);
            }
            base.OnUpdateFrame(e);
        }
        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);

            escenario = new Escenario(new helper.VectorThree(0, 0, 0));
            t2 = new Objeto(new helper.VectorThree(0, 0, 0), 0.7f, 0.8f, 0.5f, 0.8f);
            eq1 = new Objeto(new helper.VectorThree(0.4f, -0.15f, 0), 0.6f, 0.8f, 0.5f, 0.8f);
            florero = new Objeto(new helper.VectorThree(-0.4f, -0.15f, 0), 0.6f, 0.8f, 0.5f, 0.8f);


            Color color = new Color(0.5, 0.5, 0.5);
            Color color2 = new Color(0.6, 0.8, 0.8);
            Color color3 = new Color(0.9, 0.9, 0.9);
            Color negro = new Color(0.1, 0.1, 0.1);
            Color verde = new Color(0.21, 0.74, 0.55);
            Color cafe = new Color(0.8, 0.28, 0.21);
            Color rojo = new Color(1, 0, 1);



            /********************** PARTE PANTALLA *****************/

            // OBJETO PANTALLA

            // PANTALLA FRONT
            List<helper.VectorThree> vertices = new List<helper.VectorThree>();
            vertices.Add(new helper.VectorThree(-0.3f, 0.2f, 0.1f));
            vertices.Add(new helper.VectorThree(0.3f, 0.2f, 0.1f));
            vertices.Add(new helper.VectorThree(0.3f, -0.2f, 0.1f));
            vertices.Add(new helper.VectorThree(-0.3f, -0.2f, 0.1f));


            // PANTALLA BACK
            List<helper.VectorThree> vertices_Back = new List<helper.VectorThree>();
            vertices_Back.Add(new helper.VectorThree(-0.3f, 0.2f, -0.1f));
            vertices_Back.Add(new helper.VectorThree(0.3f, 0.2f, -0.1f));
            vertices_Back.Add(new helper.VectorThree(0.3f, -0.2f, -0.1f));
            vertices_Back.Add(new helper.VectorThree(-0.3f, -0.2f, -0.1f));

            // PANTALLA TOP
            List<helper.VectorThree> vertices_Top = new List<helper.VectorThree>();
            vertices_Top.Add(new helper.VectorThree(-0.3f, 0.2f, 0.1f));
            vertices_Top.Add(new helper.VectorThree(0.3f, 0.2f, 0.1f));
            vertices_Top.Add(new helper.VectorThree(0.3f, 0.2f, -0.1f));
            vertices_Top.Add(new helper.VectorThree(-0.3f, 0.2f, -0.1f));

            // PANTALLA BOTTOM
            List<helper.VectorThree> vertices_Bottom = new List<helper.VectorThree>();
            vertices_Bottom.Add(new helper.VectorThree(0.3f, -0.2f, 0.1f));
            vertices_Bottom.Add(new helper.VectorThree(-0.3f, -0.2f, 0.1f));
            vertices_Bottom.Add(new helper.VectorThree(-0.3f, -0.2f, -0.1f));
            vertices_Bottom.Add(new helper.VectorThree(0.3f, -0.2f, -0.1f));

            // PANTALLA LEFT
            List<helper.VectorThree> vertices_Left = new List<helper.VectorThree>();
            vertices_Left.Add(new helper.VectorThree(-0.3f, 0.2f, 0.1f));
            vertices_Left.Add(new helper.VectorThree(-0.3f, 0.2f, -0.1f));
            vertices_Left.Add(new helper.VectorThree(-0.3f, -0.2f, -0.1f));
            vertices_Left.Add(new helper.VectorThree(-0.3f, -0.2f, 0.1f));

            // PANTALLA RIGTH
            List<helper.VectorThree> vertices_Rigth = new List<helper.VectorThree>();
            vertices_Rigth.Add(new helper.VectorThree(0.3f, 0.2f, 0.1f));
            vertices_Rigth.Add(new helper.VectorThree(0.3f, 0.2f, -0.1f));
            vertices_Rigth.Add(new helper.VectorThree(0.3f, -0.2f, -0.1f));
            vertices_Rigth.Add(new helper.VectorThree(0.3f, -0.2f, 0.1f));

            // PANTALLA CUADROS
            List<helper.VectorThree> vertices_cuadros = new List<helper.VectorThree>();
            vertices_cuadros.Add(new helper.VectorThree(-0.3f, 0.2f, 0.12f));
            vertices_cuadros.Add(new helper.VectorThree(-0.28f, 0.18f, 0.12f));
            vertices_cuadros.Add(new helper.VectorThree(0.28f, -0.18f, 0.12f));
            vertices_cuadros.Add(new helper.VectorThree(0.28f, -0.18f, 0.12f));

            Cara Front = new Cara(t2.width, t2.height, t2.depth, vertices, color);
            Cara BACK = new Cara(t2.width, t2.height, t2.depth, vertices_Back, color);
            Cara TOP = new Cara(t2.width, t2.height, t2.depth, vertices_Top, color);
            Cara BOTTOM = new Cara(t2.width, t2.height, t2.depth, vertices_Bottom, color);
            Cara LEFT = new Cara(t2.width, t2.height, t2.depth, vertices_Left, color);
            Cara RIGTH = new Cara(t2.width, t2.height, t2.depth, vertices_Rigth, color);
            Cara cuadro = new Cara(t2.width, t2.height, t2.depth, vertices_Rigth, negro);

            //PIE
            List<helper.VectorThree> vertices_pie_front = new List<helper.VectorThree>();
            //FRONT 
            vertices_pie_front.Add(new helper.VectorThree(-0.05f, -0.2f, 0.05f));
            vertices_pie_front.Add(new helper.VectorThree(0.05f, -0.2f, 0.05f));
            vertices_pie_front.Add(new helper.VectorThree(0.05f, -0.3f, 0.05f));
            vertices_pie_front.Add(new helper.VectorThree(-0.05f, -0.3f, 0.05f));

            //BACK 
            List<helper.VectorThree> vertices_pie_back = new List<helper.VectorThree>();
            vertices_pie_back.Add(new helper.VectorThree(-0.05f, -0.2f, -0.05f));
            vertices_pie_back.Add(new helper.VectorThree(0.05f, -0.2f, -0.05f));
            vertices_pie_back.Add(new helper.VectorThree(0.05f, -0.3f, -0.05f));
            vertices_pie_back.Add(new helper.VectorThree(-0.05f, -0.3f, -0.05f));

            //LEFT
            List<helper.VectorThree> vertices_pie_left = new List<helper.VectorThree>();
            vertices_pie_left.Add(new helper.VectorThree(-0.05f, -0.2f, 0.05f));
            vertices_pie_left.Add(new helper.VectorThree(-0.05f, -0.2f, -0.05f));
            vertices_pie_left.Add(new helper.VectorThree(-0.05f, -0.3f, -0.05f));
            vertices_pie_left.Add(new helper.VectorThree(-0.05f, -0.3f, 0.05f));

            //RIGTH
            List<helper.VectorThree> vertices_pie_right = new List<helper.VectorThree>();
            vertices_pie_left.Add(new helper.VectorThree(0.05f, -0.2f, 0.05f));
            vertices_pie_left.Add(new helper.VectorThree(0.05f, -0.2f, -0.05f));
            vertices_pie_left.Add(new helper.VectorThree(0.05f, -0.3f, -0.05f));
            vertices_pie_left.Add(new helper.VectorThree(0.05f, -0.3f, 0.05f));

            Cara FRONTPIE = new Cara(t2.width, t2.height, t2.depth, vertices_pie_front, color);
            Cara BACKPIE = new Cara(t2.width, t2.height, t2.depth, vertices_pie_back, color);
            Cara LEFTPIE = new Cara(t2.width, t2.height, t2.depth, vertices_pie_left, color);
            Cara RIGTHPIE = new Cara(t2.width, t2.height, t2.depth, vertices_pie_right, color);

            // PIE PISO

            // FRONT
            List<helper.VectorThree> vertices_pie_piso_front = new List<helper.VectorThree>();
            vertices_pie_piso_front.Add(new helper.VectorThree(-0.15f, -0.3f, 0.1f));
            vertices_pie_piso_front.Add(new helper.VectorThree(0.15f, -0.3f, 0.1f));
            vertices_pie_piso_front.Add(new helper.VectorThree(0.15f, -0.35f, 0.1f));
            vertices_pie_piso_front.Add(new helper.VectorThree(-0.15f, -0.35f, 0.1f));

            // BACK
            List<helper.VectorThree> vertices_pie_piso_back = new List<helper.VectorThree>();
            vertices_pie_piso_back.Add(new helper.VectorThree(-0.15f, -0.3f, -0.1f));
            vertices_pie_piso_back.Add(new helper.VectorThree(0.15f, -0.3f, -0.1f));
            vertices_pie_piso_back.Add(new helper.VectorThree(0.15f, -0.35f, -0.1f));
            vertices_pie_piso_back.Add(new helper.VectorThree(-0.15f, -0.35f, -0.1f));

            //TOP 
            List<helper.VectorThree> vertices_pie_piso_top = new List<helper.VectorThree>();
            vertices_pie_piso_top.Add(new helper.VectorThree(0.15f, -0.35f, 0.1f));
            vertices_pie_piso_top.Add(new helper.VectorThree(-0.15f, -0.35f, 0.1f));
            vertices_pie_piso_top.Add(new helper.VectorThree(-0.15f, -0.35f, -0.1f));
            vertices_pie_piso_top.Add(new helper.VectorThree(0.15f, -0.35f, -0.1f));

            //BOTTOM
            List<helper.VectorThree> vertices_pie_piso_bottom = new List<helper.VectorThree>();
            vertices_pie_piso_bottom.Add(new helper.VectorThree(-0.15f, -0.3f, -0.1f));
            vertices_pie_piso_bottom.Add(new helper.VectorThree(0.15f, -0.3f, -0.1f));
            vertices_pie_piso_bottom.Add(new helper.VectorThree(-0.15f, -0.35f, -0.1f));
            vertices_pie_piso_bottom.Add(new helper.VectorThree(0.15f, -0.35f, -0.1f));


            //LEFT
            List<helper.VectorThree> vertices_pie_piso_left = new List<helper.VectorThree>();
            vertices_pie_piso_left.Add(new helper.VectorThree(-0.15f, -0.3f, 0.1f));
            vertices_pie_piso_left.Add(new helper.VectorThree(-0.15f, -0.3f, -0.1f));
            vertices_pie_piso_left.Add(new helper.VectorThree(-0.15f, -0.35f, -0.1f));
            vertices_pie_piso_left.Add(new helper.VectorThree(-0.15f, -0.35f, 0.1f));


            //RIGTH
            List<helper.VectorThree> vertices_pie_piso_rigth = new List<helper.VectorThree>();
            vertices_pie_piso_rigth.Add(new helper.VectorThree(0.15f, -0.3f, 0.1f));
            vertices_pie_piso_rigth.Add(new helper.VectorThree(0.15f, -0.3f, -0.1f));
            vertices_pie_piso_rigth.Add(new helper.VectorThree(0.15f, -0.35f, -0.1f));
            vertices_pie_piso_rigth.Add(new helper.VectorThree(0.15f, -0.35f, 0.1f));

            Cara FRONTPIEPISO = new Cara(t2.width, t2.height, t2.depth, vertices_pie_piso_front, color);
            Cara BACKPIEPISO = new Cara(t2.width, t2.height, t2.depth, vertices_pie_piso_back, color);
            Cara LEFTPIEPISO = new Cara(t2.width, t2.height, t2.depth, vertices_pie_piso_left, color);
            Cara RIGTHPIEPISO = new Cara(t2.width, t2.height, t2.depth, vertices_pie_piso_rigth, color);
            Cara TOPPIEPISO = new Cara(t2.width, t2.height, t2.depth, vertices_pie_piso_top, color);
            Cara BOTTOMPIEPISO = new Cara(t2.width, t2.height, t2.depth, vertices_pie_piso_bottom, color);

            List<helper.VectorThree> vertices_pantalla = new List<helper.VectorThree>();
            vertices_pantalla.Add(new helper.VectorThree(-0.27f, 0.17f, 0.1f));
            vertices_pantalla.Add(new helper.VectorThree(0.27f, 0.17f, 0.1f));
            vertices_pantalla.Add(new helper.VectorThree(0.27f, -0.17f, 0.1f));
            vertices_pantalla.Add(new helper.VectorThree(-0.27f, -0.17f, 0.1f));

            Cara CaraPantalla = new Cara(t2.width, t2.height, t2.depth, vertices_pantalla, color3);



            /********************** PARTE EQUIPO *****************/

            // OBJETO EQUIPO1

            // EQUIPO1

            // FRONT EQUIPO1
            List<helper.VectorThree> vertices_equipo_front = new List<helper.VectorThree>();
            vertices_equipo_front.Add(new helper.VectorThree(-0.15f, 0.1f, 0.1f));
            vertices_equipo_front.Add(new helper.VectorThree(0.15f, 0.1f, 0.1f));
            vertices_equipo_front.Add(new helper.VectorThree(0.15f, -0.2f, 0.1f));
            vertices_equipo_front.Add(new helper.VectorThree(-0.15f, -0.2f, 0.1f));

            // BACK EQUIPO1
            List<helper.VectorThree> vertices_equipo_back = new List<helper.VectorThree>();
            vertices_equipo_back.Add(new helper.VectorThree(-0.15f, 0.1f, -0.1f));
            vertices_equipo_back.Add(new helper.VectorThree(0.15f, 0.1f, -0.1f));
            vertices_equipo_back.Add(new helper.VectorThree(0.15f, -0.2f, -0.1f));
            vertices_equipo_back.Add(new helper.VectorThree(-0.15f, -0.2f, -0.1f));

            // TOP EQUIPO1
            List<helper.VectorThree> vertices_equipo_top = new List<helper.VectorThree>();
            vertices_equipo_top.Add(new helper.VectorThree(-0.15f, 0.1f, 0.1f));
            vertices_equipo_top.Add(new helper.VectorThree(0.15f, 0.1f, 0.1f));
            vertices_equipo_top.Add(new helper.VectorThree(0.15f, 0.1f, -0.1f));
            vertices_equipo_top.Add(new helper.VectorThree(-0.15f, 0.1f, -0.1f));

            // BOTTOM EQUIPO1
            List<helper.VectorThree> vertices_equipo_bottom = new List<helper.VectorThree>();
            vertices_equipo_bottom.Add(new helper.VectorThree(0.15f, -0.2f, 0.1f));
            vertices_equipo_bottom.Add(new helper.VectorThree(-0.15f, -0.2f, 0.1f));
            vertices_equipo_bottom.Add(new helper.VectorThree(-0.15f, -0.2f, -0.1f));
            vertices_equipo_bottom.Add(new helper.VectorThree(0.15f, -0.2f, -0.1f));


            // LEFT EQUIPO1
            List<helper.VectorThree> vertices_equipo_left = new List<helper.VectorThree>();
            vertices_equipo_left.Add(new helper.VectorThree(-0.15f, 0.1f, 0.1f));
            vertices_equipo_left.Add(new helper.VectorThree(-0.15f, -0.2f, 0.1f));
            vertices_equipo_left.Add(new helper.VectorThree(-0.15f, -0.2f, -0.1f));
            vertices_equipo_left.Add(new helper.VectorThree(-0.15f, 0.1f, -0.1f));

            // RIGHT EQUIPO1
            List<helper.VectorThree> vertices_equipo_right = new List<helper.VectorThree>();
            vertices_equipo_right.Add(new helper.VectorThree(0.15f, 0.1f, 0.1f));
            vertices_equipo_right.Add(new helper.VectorThree(0.15f, -0.2f, 0.1f));
            vertices_equipo_right.Add(new helper.VectorThree(0.15f, -0.2f, -0.1f));
            vertices_equipo_right.Add(new helper.VectorThree(0.15f, 0.1f, -0.1f));

            // FRONT EQUIPO1
            List<helper.VectorThree> vertices_equipo_front_circle = new List<helper.VectorThree>();
            vertices_equipo_front_circle.Add(new helper.VectorThree(-0.1f, 0.05f, 0.1f));
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.1f, 0.05f, 0.1f));
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.1f, -0.15f, 0.1f));
            vertices_equipo_front_circle.Add(new helper.VectorThree(-0.1f, -0.15f, 0.1f));

            Cara CaraEquipoFront = new Cara(eq1.width, eq1.height, eq1.depth, vertices_equipo_front, negro);
            Cara CaraEquipoBack = new Cara(eq1.width, eq1.height, eq1.depth, vertices_equipo_back, negro);
            Cara CaraEquipoTop = new Cara(eq1.width, eq1.height, eq1.depth, vertices_equipo_top, negro);
            Cara CaraEquipoBottom = new Cara(eq1.width, eq1.height, eq1.depth, vertices_equipo_bottom, negro);
            Cara CaraEquipoLeft = new Cara(eq1.width, eq1.height, eq1.depth, vertices_equipo_left, negro);
            Cara CaraEquipoRight = new Cara(eq1.width, eq1.height, eq1.depth, vertices_equipo_right, negro);
            Cara CaraEquipoCircle = new Cara(eq1.width, eq1.height, eq1.depth, vertices_equipo_front_circle, color);



            /********************** PARTE FLORERO *****************/

            // OBJETO FLORERO

            // FLORERO

            // FRONT FLORERO
            vertices_equipo_front = new List<helper.VectorThree>();
            vertices_equipo_front.Add(new helper.VectorThree(-0.15f, 0.1f, 0.1f));
            vertices_equipo_front.Add(new helper.VectorThree(0.15f, 0.1f, 0.1f));
            vertices_equipo_front.Add(new helper.VectorThree(0.15f, -0.2f, 0.1f));
            vertices_equipo_front.Add(new helper.VectorThree(-0.15f, -0.2f, 0.1f));

            // BACK FLORERO
            vertices_equipo_back = new List<helper.VectorThree>();
            vertices_equipo_back.Add(new helper.VectorThree(-0.15f, 0.1f, -0.1f));
            vertices_equipo_back.Add(new helper.VectorThree(0.15f, 0.1f, -0.1f));
            vertices_equipo_back.Add(new helper.VectorThree(0.15f, -0.2f, -0.1f));
            vertices_equipo_back.Add(new helper.VectorThree(-0.15f, -0.2f, -0.1f));

            // TOP FLORERO
            vertices_equipo_top = new List<helper.VectorThree>();
            vertices_equipo_top.Add(new helper.VectorThree(-0.15f, 0.1f, 0.1f));
            vertices_equipo_top.Add(new helper.VectorThree(0.15f, 0.1f, 0.1f));
            vertices_equipo_top.Add(new helper.VectorThree(0.15f, 0.1f, -0.1f));
            vertices_equipo_top.Add(new helper.VectorThree(-0.15f, 0.1f, -0.1f));

            // BOTTOM FLORERO
            vertices_equipo_bottom = new List<helper.VectorThree>();
            vertices_equipo_bottom.Add(new helper.VectorThree(0.15f, -0.2f, 0.1f));
            vertices_equipo_bottom.Add(new helper.VectorThree(-0.15f, -0.2f, 0.1f));
            vertices_equipo_bottom.Add(new helper.VectorThree(-0.15f, -0.2f, -0.1f));
            vertices_equipo_bottom.Add(new helper.VectorThree(0.15f, -0.2f, -0.1f));


            // LEFT FLORERO
            vertices_equipo_left = new List<helper.VectorThree>();
            vertices_equipo_left.Add(new helper.VectorThree(-0.15f, 0.1f, 0.1f));
            vertices_equipo_left.Add(new helper.VectorThree(-0.15f, -0.2f, 0.1f));
            vertices_equipo_left.Add(new helper.VectorThree(-0.15f, -0.2f, -0.1f));
            vertices_equipo_left.Add(new helper.VectorThree(-0.15f, 0.1f, -0.1f));

            // RIGHT FLORERO
            vertices_equipo_right = new List<helper.VectorThree>();
            vertices_equipo_right.Add(new helper.VectorThree(0.15f, 0.1f, 0.1f));
            vertices_equipo_right.Add(new helper.VectorThree(0.15f, -0.2f, 0.1f));
            vertices_equipo_right.Add(new helper.VectorThree(0.15f, -0.2f, -0.1f));
            vertices_equipo_right.Add(new helper.VectorThree(0.15f, 0.1f, -0.1f));

            // FRONT FLORERO tallo
            List<helper.VectorThree> vertices_equipo_front_tallo = new List<helper.VectorThree>();
            vertices_equipo_front_tallo.Add(new helper.VectorThree(-0.02f, 0.3f, -0.05f));
            vertices_equipo_front_tallo.Add(new helper.VectorThree(0.02f, 0.3f, -0.05f));
            vertices_equipo_front_tallo.Add(new helper.VectorThree(0.02f, 0.1f, -0.05f));
            vertices_equipo_front_tallo.Add(new helper.VectorThree(-0.02f, 0.1f, -0.05f));

            // FRONT FLORERO rosa
            vertices_equipo_front_circle = new List<helper.VectorThree>();
            // Definimos los vértices de una estrella de cinco puntas
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.0f, 0.3f, -0.05f)); // Vértice superior
            vertices_equipo_front_circle.Add(new helper.VectorThree(-0.1f, 0.4f, -0.05f)); // Vértice superior izquierdo
            vertices_equipo_front_circle.Add(new helper.VectorThree(-0.3f, 0.3f, -0.05f)); // Vértice izquierdo
            vertices_equipo_front_circle.Add(new helper.VectorThree(-0.2f, 0.4f, -0.05f)); // Vértice inferior izquierdo
            vertices_equipo_front_circle.Add(new helper.VectorThree(-0.3f, 0.5f, -0.05f)); // Vértice inferior

            vertices_equipo_front_circle.Add(new helper.VectorThree(0.0f, 0.5f, -0.05f)); // Vértice inferior
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.3f, 0.5f, -0.05f)); // Vértice inferior derecho
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.2f, 0.5f, -0.05f)); // Vértice inferior derecho
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.2f, 0.4f, -0.05f)); // Vértice derecho
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.1f, 0.4f, -0.05f)); // Vértice superior derecho

            vertices_equipo_front_circle.Add(new helper.VectorThree(-0.1f, 0.5f, -0.05f)); // Vértice superior izquierdo interno
            vertices_equipo_front_circle.Add(new helper.VectorThree(-0.25f, 0.5f, -0.05f)); // Vértice inferior izquierdo interno
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.25f, 0.5f, -0.05f)); // Vértice inferior derecho interno
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.1f, 0.5f, -0.05f)); // V




            Cara CaraFloreroFront = new Cara(florero.width, florero.height, florero.depth, vertices_equipo_front, cafe);
            Cara CaraFloreroBack = new Cara(florero.width, florero.height, florero.depth, vertices_equipo_back, cafe);
            Cara CaraFloreroTop = new Cara(florero.width, florero.height, florero.depth, vertices_equipo_top, cafe);
            Cara CaraFloreroBottom = new Cara(florero.width, florero.height, florero.depth, vertices_equipo_bottom, cafe);
            Cara CaraFloreroLeft = new Cara(florero.width, florero.height, florero.depth, vertices_equipo_left, cafe);
            Cara CaraFloreroRight = new Cara(florero.width, florero.height, florero.depth, vertices_equipo_right, cafe);
            Cara CaraFloreroTallo = new Cara(florero.width, florero.height, florero.depth, vertices_equipo_front_tallo, verde);
            Cara CaraFloreroRosa = new Cara(florero.width, florero.height, florero.depth, vertices_equipo_front_circle, rojo);



            //PANTALLA
            Parte pantalla = new Parte(t2.center, t2.width, t2.height / 2, t2.depth, t2.size);
           // pantalla.Add(Front);
            pantalla.Add(BACK);
            pantalla.Add(TOP);
            pantalla.Add(BOTTOM);
            pantalla.Add(LEFT);
            pantalla.Add(RIGTH);
            pantalla.Add(cuadro);
            pantalla.Add(CaraPantalla);
            Parte pie = new Parte(t2.center, t2.width, t2.height / 4, t2.depth, t2.size);
            pie.Add(FRONTPIE);
            pie.Add(BACKPIE);
            pie.Add(LEFTPIE);
            pie.Add(RIGTHPIE);
            Parte piso = new Parte(t2.center, t2.width, t2.height / 4, t2.depth, t2.size);
            piso.Add(FRONTPIEPISO);
            piso.Add(BACKPIEPISO);
            piso.Add(LEFTPIEPISO);
            piso.Add(RIGTHPIEPISO);
            piso.Add(TOPPIEPISO);
            piso.Add(BOTTOMPIEPISO);
            //piso.Add(CaraPantalla);

            t2.Add("pantalla", pantalla);
            t2.Add("pie", pie);
            t2.Add("piso", piso);

            // EQUIPO
            Parte Equipo = new Parte(eq1.center, eq1.width, eq1.height / 2, eq1.depth, eq1.size);
            Equipo.Add(CaraEquipoFront);
            Equipo.Add(CaraEquipoBack);
            Equipo.Add(CaraEquipoTop);
            Equipo.Add(CaraEquipoBottom);
            Equipo.Add(CaraEquipoLeft);
            Equipo.Add(CaraEquipoRight);
            Equipo.Add(CaraEquipoCircle);

            eq1.Add("equipo", Equipo);

            // FLORERO
            Parte Florero = new Parte(florero.center, florero.width, florero.height / 2, florero.depth, florero.size);
            Florero.Add(CaraFloreroFront);
            Florero.Add(CaraFloreroBack);
            Florero.Add(CaraFloreroTop);
            Florero.Add(CaraFloreroBottom);
            Florero.Add(CaraFloreroLeft);
            Florero.Add(CaraFloreroRight);
            Florero.Add(CaraFloreroTallo);
            Florero.Add(CaraFloreroRosa);

            florero.Add("florero", Florero);

            escenario.Add("televisor", t2);
            escenario.Add("equipo", eq1);
            escenario.Add("florero", florero);
           
            base.OnLoad(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Frustum(-1.0, 1.0, -1.0, 1.0, 1.0, 500); // Configura la proyección perspectiva
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Translate(0.0f, 0.0f, -2.0f);
            GL.Rotate(40.0f + rotationAngle, 0.0f, 1.0f, 0.0f);



            string fileName = "escenario.json";
            Utils.Save<Escenario>(escenario, fileName);
            //escenario = Utils.Open<Escenario>(fileName);
            escenario.Draw();


            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }

        protected override void OnUnload(EventArgs e)
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            base.OnUnload(e);
        }

    }
}
    
