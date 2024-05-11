using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructura_Basica_Grafica.helper;
namespace Estructura_Basica_Grafica.presentacion
{
    public partial class Presentation: Form
    {
        public Escenario escenario;
        string nameSelectObject, nameSelectPart;
        sbyte refSelectObject, refSelectPart;
        VectorThree translate, scale;

        public Presentation()
        {
            InitializeComponent();
            loadEscenario();
            loadSelectObjects();
            translate = new VectorThree();
            scale = new VectorThree();
        }

        private void loadEscenario()
        {
            Objeto t2;
            Objeto eq1;
            Objeto florero;

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
            vertices_pie_front.Add(new helper.VectorThree(-0.05f, 0.05f, 0.05f));
            vertices_pie_front.Add(new helper.VectorThree(0.05f, 0.05f, 0.05f));
            vertices_pie_front.Add(new helper.VectorThree(0.05f, -0.05f, 0.05f));
            vertices_pie_front.Add(new helper.VectorThree(-0.05f, -0.05f, 0.05f));

            //BACK 
            List<helper.VectorThree> vertices_pie_back = new List<helper.VectorThree>();
            vertices_pie_back.Add(new helper.VectorThree(-0.05f, 0.05f, -0.05f));
            vertices_pie_back.Add(new helper.VectorThree(0.05f, 0.05f, -0.05f));
            vertices_pie_back.Add(new helper.VectorThree(0.05f, -0.05f, -0.05f));
            vertices_pie_back.Add(new helper.VectorThree(-0.05f, -0.05f, -0.05f));

            List<helper.VectorThree> vertices_pie_top = new List<helper.VectorThree>();
            //TOP 
            vertices_pie_top.Add(new helper.VectorThree(-0.05f, 0.05f, 0.05f));
            vertices_pie_top.Add(new helper.VectorThree(0.05f, 0.05f, 0.05f));
            vertices_pie_top.Add(new helper.VectorThree(0.05f, 0.05f, -0.05f));
            vertices_pie_top.Add(new helper.VectorThree(-0.05f, 0.05f, -0.05f));


            List<helper.VectorThree> vertices_pie_bottom = new List<helper.VectorThree>();
            //BOTTOM 
            vertices_pie_bottom.Add(new helper.VectorThree(0.05f, -0.05f, 0.05f));
            vertices_pie_bottom.Add(new helper.VectorThree(-0.05f, -0.05f, 0.05f));
            vertices_pie_bottom.Add(new helper.VectorThree(-0.05f, -0.05f, -0.05f));
            vertices_pie_bottom.Add(new helper.VectorThree(0.05f, -0.05f, -0.05f));

            //LEFT
            List<helper.VectorThree> vertices_pie_left = new List<helper.VectorThree>();
            vertices_pie_left.Add(new helper.VectorThree(-0.05f, 0.05f, 0.05f));
            vertices_pie_left.Add(new helper.VectorThree(-0.05f, 0.05f, -0.05f));
            vertices_pie_left.Add(new helper.VectorThree(-0.05f, -0.05f, -0.05f));
            vertices_pie_left.Add(new helper.VectorThree(-0.05f, -0.05f, 0.05f));

            //RIGTH
            List<helper.VectorThree> vertices_pie_right = new List<helper.VectorThree>();
            vertices_pie_right.Add(new helper.VectorThree(0.05f, 0.05f, 0.05f));
            vertices_pie_right.Add(new helper.VectorThree(0.05f, -0.05f, 0.05f));
            vertices_pie_right.Add(new helper.VectorThree(0.05f, -0.05f, -0.05f));
            vertices_pie_right.Add(new helper.VectorThree(0.05f, 0.05f, -0.05f));

            Cara FRONTPIE = new Cara(1, 1, 1, vertices_pie_front, color);
            Cara BACKPIE = new Cara(1, 1, 1, vertices_pie_back, color);
            Cara LEFTPIE = new Cara(1, 1, 1, vertices_pie_left, color);
            Cara RIGTHPIE = new Cara(1, 1, 1, vertices_pie_right, color);
            Cara TOPPIE = new Cara(1, 1, 1, vertices_pie_top, color);
            Cara BOTTOMPIE = new Cara(1, 1, 1, vertices_pie_bottom, color);
            // PIE PISO

            // FRONT
            List<helper.VectorThree> vertices_pie_piso_front = new List<helper.VectorThree>();
            vertices_pie_piso_front.Add(new helper.VectorThree(-0.15f, 0.03f, 0.1f));
            vertices_pie_piso_front.Add(new helper.VectorThree(0.15f, 0.03f, 0.1f));
            vertices_pie_piso_front.Add(new helper.VectorThree(0.15f, -0.03f, 0.1f));
            vertices_pie_piso_front.Add(new helper.VectorThree(-0.15f, -0.03f, 0.1f));

            // BACK
            List<helper.VectorThree> vertices_pie_piso_back = new List<helper.VectorThree>();
            vertices_pie_piso_back.Add(new helper.VectorThree(-0.15f, 0.03f, -0.1f));
            vertices_pie_piso_back.Add(new helper.VectorThree(0.15f, 0.03f, -0.1f));
            vertices_pie_piso_back.Add(new helper.VectorThree(0.15f, -0.03f, -0.1f));
            vertices_pie_piso_back.Add(new helper.VectorThree(-0.15f, -0.03f, -0.1f));

            //TOP 
            List<helper.VectorThree> vertices_pie_piso_top = new List<helper.VectorThree>();
            vertices_pie_piso_top.Add(new helper.VectorThree(-0.15f, 0.03f, 0.1f));
            vertices_pie_piso_top.Add(new helper.VectorThree(0.15f, 0.03f, 0.1f));
            vertices_pie_piso_top.Add(new helper.VectorThree(0.15f, 0.03f, -0.1f));
            vertices_pie_piso_top.Add(new helper.VectorThree(-0.15f, 0.03f, -0.1f));

            //BOTTOM
            List<helper.VectorThree> vertices_pie_piso_bottom = new List<helper.VectorThree>();
            vertices_pie_piso_bottom.Add(new helper.VectorThree(0.15f, -0.03f, 0.1f));
            vertices_pie_piso_bottom.Add(new helper.VectorThree(-0.15f, -0.03f, 0.1f));
            vertices_pie_piso_bottom.Add(new helper.VectorThree(-0.15f, -0.03f, -0.1f));
            vertices_pie_piso_bottom.Add(new helper.VectorThree(0.15f, -0.03f, -0.1f));


            //LEFT
            List<helper.VectorThree> vertices_pie_piso_left = new List<helper.VectorThree>();
            vertices_pie_piso_left.Add(new helper.VectorThree(-0.15f, 0.03f, 0.1f));
            vertices_pie_piso_left.Add(new helper.VectorThree(-0.15f, -0.03f, 0.1f));
            vertices_pie_piso_left.Add(new helper.VectorThree(0.15f, -0.03f, -0.1f));
            vertices_pie_piso_left.Add(new helper.VectorThree(-0.15f, 0.03f, -0.1f));


            //RIGTH
            List<helper.VectorThree> vertices_pie_piso_rigth = new List<helper.VectorThree>();
            vertices_pie_piso_front.Add(new helper.VectorThree(0.15f, 0.03f, 0.1f));
            vertices_pie_piso_front.Add(new helper.VectorThree(0.15f, -0.03f, 0.1f));
            vertices_pie_piso_back.Add(new helper.VectorThree(0.15f, -0.03f, -0.1f));
            vertices_pie_piso_back.Add(new helper.VectorThree(0.15f, 0.03f, -0.1f));

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
            vertices_equipo_front_circle.Add(new helper.VectorThree(-0.1f, 0.05f, 0.11f));
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.1f, 0.05f, 0.11f));
            vertices_equipo_front_circle.Add(new helper.VectorThree(0.1f, -0.15f, 0.11f));
            vertices_equipo_front_circle.Add(new helper.VectorThree(-0.1f, -0.15f, 0.11f));

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
            Parte pie = new Parte(new VectorThree(0, -0.20f, 0), 1, 1, 1, 1);
            pie.Add(FRONTPIE);
            pie.Add(BACKPIE);
            pie.Add(LEFTPIE);
            pie.Add(RIGTHPIE);
            pie.Add(TOPPIE);
            pie.Add(BOTTOMPIE);
            Parte piso = new Parte(new VectorThree(0, -0.25f, 0), t2.width, t2.height, t2.depth, t2.size);
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

            Parte FloreroTallo = new Parte(florero.center, florero.width, florero.height / 2, florero.depth, florero.size);
            FloreroTallo.Add(CaraFloreroTallo);
            Parte FloreroFlor = new Parte(florero.center, florero.width, florero.height / 2, florero.depth, florero.size);
            FloreroFlor.Add(CaraFloreroRosa);

            florero.Add("florero", Florero);
            florero.Add("tallo", FloreroTallo);
            florero.Add("flor", FloreroFlor);

            escenario.Add("televisor", t2);
            escenario.Add("equipo", eq1);
            escenario.Add("florero", florero);

        }

        private void loadSelectObjects()
        {
            comboBox1.Items.Add("Escenario");
            foreach (var name in escenario.objects.Keys)
            {
                comboBox1.Items.Add(name);
            }
        }
        private void loadSelectParts()
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "Seleccionar Partes";
            refSelectPart = -1;
            if(refSelectObject > 0)
            {
                Objeto obj = escenario.Get(nameSelectObject);
                foreach (var name in obj.parts.Keys)
                {
                    comboBox2.Items.Add(name);
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refSelectObject = (sbyte)comboBox1.SelectedIndex;
            nameSelectObject = comboBox1.Items[refSelectObject].ToString();
            this.loadSelectParts();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.refSelectPart = (sbyte)comboBox2.SelectedIndex;
            this.nameSelectPart = this.comboBox2.Items[refSelectPart].ToString();
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBarRotationX_Scroll_Scroll(object sender, EventArgs e)
        {
            realizarRotacionX();
        }

        private void trackBarRotationY_Scroll_Scroll(object sender, EventArgs e)
        {
            realizarRotacionY();
        }

        private void trackBarRotationZ_Scroll_Scroll(object sender, EventArgs e)
        {
            realizarRotacionZ();
        }

        private void trackBarScalationX_Scroll_Scroll(object sender, EventArgs e)
        {
            realizarScalacionX();
        }

        private void trackBarScalationY_Scroll_Scroll(object sender, EventArgs e)
        {
            //realizarScalacionX();
        }

        private void trackBarScalationZ_Scroll_Scroll(object sender, EventArgs e)
        {
            //realizarScalacionX();
        }

        private void trackBarTraslationX_Scroll_Scroll(object sender, EventArgs e)
        {
            realizarTraslacionX();
        }

        private void trackBarTraslationY_Scroll_Scroll(object sender, EventArgs e)
        {
            realizarTraslacionY();
        }

        private void trackBarTraslationZ_Scroll_Scroll(object sender, EventArgs e)
        {
            realizarTraslacionZ();
        }

        ////
        ///
        private void realizarTraslacionX()
        {
            float x = trackBarTraslationX_Scroll.Value;
            float eje = (this.translate.X < x) ? 0.20f : -0.20f;
            this.translate.X = x;
            
            if (this.refSelectObject == 0) //escenario
            {
                escenario.Translate(eje, 0, 0);
            }
            else if (this.refSelectPart == -1) //seleccion Objeto
            {
                escenario.Get(this.nameSelectObject).Translate(eje, 0, 0);
            }
            else //seleccionando Caras
            {
                escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).Translate(eje, 0, 0);
            }
        }

        private void realizarTraslacionY()
        {
            float x = trackBarTraslationY_Scroll.Value;
            float eje = (this.translate.Y < x) ? 0.20f : -0.20f;
            this.translate.Y = x;

            if (this.refSelectObject == 0) //escenario
            {
                escenario.Translate(0, eje, 0);
            }
            else if (this.refSelectPart == -1) //seleccion Objeto
            {
                escenario.Get(this.nameSelectObject).Translate(0, eje, 0);
            }
            else //seleccionando Caras
            {
                escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).Translate(0, eje, 0);
            }
        }

        private void realizarTraslacionZ()
        {
            float x = trackBarTraslationZ_Scroll.Value;
            float eje = (this.translate.Z < x) ? 0.20f : -0.20f;
            this.translate.Z = x;

            if (this.refSelectObject == 0) //escenario
            {
                escenario.Translate(0, 0, eje);
            }
            else if (this.refSelectPart == -1) //seleccion Objeto
            {
                escenario.Get(this.nameSelectObject).Translate(0, 0, eje);
            }
            else //seleccionando Caras
            {
                escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).Translate(0, 0, eje);
            }
        }

        private void realizarScalacionX()
        {
            float x = trackBarScalationX_Scroll.Value;
            float size = (this.scale.X < x) ? 0.9f : 1.1f;
            //size = (x == 0) ? 1 : size;
            this.scale.X = x;

            if (this.refSelectObject == 0) //escenario
            {
                escenario.Scale(size);
            }
            else if (this.refSelectPart == -1) //seleccion Objeto
            {
                escenario.Get(this.nameSelectObject).Scale(size, escenario.Get(this.nameSelectObject).center);
            }
            else //seleccionando Caras
            {
                escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).Scale(size, escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).center);
            }
        }

        private void realizarRotacionX()
        {
            float angle = 3.0f;

            if (this.refSelectObject == 0) //escenario
            {
                escenario.Rotate(angle, 1, 0, 0);
            }
            else if (this.refSelectPart == -1) //seleccion Objeto
            {
                escenario.Get(this.nameSelectObject).Rotate(angle, 1, 0, 0, escenario.Get(this.nameSelectObject).center);
            }
            else //seleccionando Caras
            {
                escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).Rotate(angle, 1, 0, 0, escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).center);
            }
        }

        private void realizarRotacionY()
        {
            float angle = 3.0f;

            if (this.refSelectObject == 0) //escenario
            {
                escenario.Rotate(angle, 0, 1, 0);
            }
            else if (this.refSelectPart == -1) //seleccion Objeto
            {
                escenario.Get(this.nameSelectObject).Rotate(angle, 0, 1, 0, escenario.Get(this.nameSelectObject).center);
            }
            else //seleccionando Caras
            {
                escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).Rotate(angle, 0, 1, 0, escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).center);
            }
        }

        private void realizarRotacionZ()
        {
            float angle = 3.0f;

            if (this.refSelectObject == 0) //escenario
            {
                escenario.Rotate(angle, 0, 0, 1);
            }
            else if (this.refSelectPart == -1) //seleccion Objeto
            {
                escenario.Get(this.nameSelectObject).Rotate(angle, 0, 0, 1, escenario.Get(this.nameSelectObject).center);
            }
            else //seleccionando Caras
            {
                escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).Rotate(angle, 0, 0, 1, escenario.Get(this.nameSelectObject).Get(this.nameSelectPart).center);
            }
        }


    }
}
