using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures.Model;
using Tekla.Structures.Geometry3d;
using Point = Tekla.Structures.Geometry3d.Point;
using System.Collections;

namespace Chair
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double TopDia;
        double BottomDia;
        public void button1_Click(object sender, EventArgs e)
        {
           TopDia = double.Parse(TopDiaTextBox1.Text);
           BottomDia = double.Parse(BottomDiaTextBox2.Text);
            SetStackData();
            Stack();

            

        }

        public void SetStackData()
        {


            CreateChair();
        }

        private void CreateChair()
        {
            Tekla.Structures.Model.Model model = new Model();
            double TopRad = Convert.ToDouble(TopDiaTextBox1.Text) /2;
            double BotRad = Convert.ToDouble(BottomDiaTextBox2.Text)/ 2;
            int stiffenerCount = Convert.ToInt32(StiffCountTextBox1.Text);

            for (int i = 0; i < 4; i++)
            {
                ContourPoint origin = new ContourPoint(new Point(0,0,0), null);
                ContourPoint ePoint = new ContourPoint(ShiftHorizontallyRad(origin, 100, i + 1,0), null);

                CustomPart CPart = new CustomPart();
                CPart.Name = "Cha";
                CPart.Number = BaseComponent.CUSTOM_OBJECT_NUMBER;
                CPart.Position.Plane = Position.PlaneEnum.LEFT;
                CPart.Position.PlaneOffset = -10;
                CPart.Position.Depth = Position.DepthEnum.MIDDLE;
                CPart.Position.DepthOffset = 550;
                CPart.Position.RotationOffset = 0;
                CPart.Position.Rotation = Position.RotationEnum.TOP;
                CPart.SetInputPositions(origin, ePoint);


                CPart.SetAttribute("P1", TopRad);
                CPart.SetAttribute("P2", BotRad);
                CPart.SetAttribute("P3", 200);
                CPart.SetAttribute("Ring Width", 1000);
                CPart.SetAttribute("Stiffener Length", 1000);
                CPart.SetAttribute("Top Ring Thickness", 50);
                CPart.SetAttribute("Bottom Ring Thickness", 50);
                CPart.SetAttribute("Stiffener Plate Thickness", 20);
                CPart.SetAttribute("P9", stiffenerCount);
                CPart.SetAttribute("Plate Washer Thickness", 16);
                CPart.SetAttribute("Anchor Bolt Circle Distance", 2260);
                CPart.SetAttribute("Projection", 1410);
                CPart.SetAttribute("Embedment", 210);
                CPart.SetAttribute("Plate washer Length", 80);
                CPart.Insert();
                
                model.CommitChanges();


            }


        }
        public ContourPoint ShiftHorizontallyRad
           (ContourPoint point, double dist, int side, double angle = double.NaN)
        {
            ContourPoint shiftedPt;
            if (double.IsNaN(angle))
            {
              
            }

            switch (side)
            {
                case 1:
                    shiftedPt = new ContourPoint(new Point(
                    point.X + (dist * Math.Cos(angle)),
                    point.Y + (dist * Math.Sin(angle)),
                    point.Z), null);
                    break;
                case 2:
                    shiftedPt = new ContourPoint(new Point(
                    point.X - (dist * Math.Sin(angle)),
                    point.Y + (dist * Math.Cos(angle)),
                    point.Z), null);
                    break;
                case 3:
                    shiftedPt = new ContourPoint(new Point(
                    point.X - (dist * Math.Cos(angle)),
                    point.Y - (dist * Math.Sin(angle)),
                    point.Z), null);
                    break;
                case 4:
                    shiftedPt = new ContourPoint(new Point(
                    point.X + (dist * Math.Sin(angle)),
                    point.Y - (dist * Math.Cos(angle)),
                    point.Z), null);
                    break;
                default:
                    shiftedPt = point;
                    break;
            }


            return shiftedPt;
        }

        public void Stack()
        {
            string pro = "CHS" + BottomDia + "*" + TopDia + "*10";
            Tekla.Structures.Model.Model model = new Model();
            Point point = new Point(0, 0, 0);
            Point point2 = new Point(0, 0, 1000);
            Beam beam = new Beam();
            beam.StartPoint = point;
            beam.EndPoint = point2;
            beam.Profile.ProfileString = pro;
            beam.Finish = "PAINT";
            beam.Position.Plane = Position.PlaneEnum.MIDDLE;
            beam.Position.Rotation = Position.RotationEnum.TOP;
            beam.Position.Depth = Position.DepthEnum.MIDDLE;
            beam.StartPointOffset = new Offset();
            beam.EndPointOffset = new Offset();
            bool result = false;
            result = beam.Insert();
            model.CommitChanges();  
        }

        private void StiffCount_Click(object sender, EventArgs e)
        {

        }
    }
}
