using Collar_flange_configurator.Extensions;
using Multicad.DatabaseServices;
using Multicad.DatabaseServices.StandardObjects;
using Multicad.Geometry;
using Multicad.Mc3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.Model
{
    class CollarFlangeConfig3D: AbstractCollarFlangeModel
    {
        protected McDocument _activeSheet;
        protected Mc3dSolid _detail3D;


        protected PlanarSketch _sketch1;
        protected SketchProfile _sketchProfile1;

        protected RevolveFeature _revolve1;


        public CollarFlangeConfig3D(string Dm, string Dn, string d1, string b, string H, string H1, string D, string D1, string d, string n, string l1, string R1, string f, string D2)
        {
            this.Dm = Dm.ToDouble();
            this.Dn = Dn.ToDouble();
            this.d1 = d1.ToDouble();
            this.b = b.ToDouble();
            this.H = H.ToDouble();
            this.H1 = H1.ToDouble();
            this.D = D.ToDouble();
            this.D1 = D1.ToDouble();
            this.d = d.ToDouble();
            this.n = n.ToInt32();
            this.l1 = l1.ToDouble();
            this.R1 = R1.ToDouble();
            this.f = f.ToDouble();
            this.D2 = D2.ToDouble();

            _activeSheet = McDocumentsManager.GetActiveSheet();
            _detail3D = new Mc3dSolid();

            bool addSolidResult = McObjectManager.Add2Document(_detail3D.DbEntity,_activeSheet);

            _detail3D.DbEntity.AddToCurrentDocument();
        }

        protected void Revolve1()
        {
            _sketch1 = _detail3D.AddPlanarSketch();

            DbPolyline circuitPolyline = new DbPolyline()
            {
                Polyline = new Polyline3d
                (
                    new List<Point3d>
                    {
                        new Point3d(d1 / 2, 0, 0),
                        new Point3d(D2 / 2, 0, 0),
                        new Point3d(D2 / 2, l1, 0),
                        new Point3d(D / 2, l1, 0),
                        new Point3d(D / 2, b,0),
                        new Point3d(Dm / 2, b,0),
                        new Point3d(Dn / 2,H - H1,0),
                        new Point3d(Dn / 2, H,0),
                        new Point3d(d1 / 2,H,0),
                        new Point3d(-1 + d1 / 2,H,0),
                        new Point3d(-1 + d1 / 2,0,0),
                         new Point3d(d1 / 2, 0, 0)
                    }
                )
            };


            DbLine axis = new DbLine()
            {
                StartPoint = new Point3d(0, 0, 0), 
                EndPoint = new Point3d(0,10,0)
            };

            circuitPolyline.DbEntity.AddToCurrentDocument();
            
            axis.DbEntity.AddToCurrentDocument();

            _sketch1.AddObject(circuitPolyline.ID);

            _sketch1.DbEntity.Update();

            _sketchProfile1 = _sketch1.CreateProfile();

            _sketchProfile1.AutoProcessExternalContours();

            McGeomParam axi_y = new McGeomParam() { ID = axis.ID};

            _revolve1 = _detail3D.AddRevolveFeature(_sketchProfile1.ID,axi_y,2*Math.PI);

            McObjectManager.UpdateAll();
        }



        public void Build()
        {
        
            Revolve1();

            
        }
    }
}
