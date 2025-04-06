using Collar_flange_configurator.Extensions;
using Multicad;
using Multicad.DatabaseServices;
using Multicad.DatabaseServices.StandardObjects;
using Multicad.Geometry;
using Multicad.Mc3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Teigha.DatabaseServices;

namespace Collar_flange_configurator.Model
{
    class CollarFlangeConfig3D: AbstractCollarFlangeModel
    {
        protected McDocument _activeSheet;
        protected Mc3dSolid _solid;


        protected PlanarSketch _sketch1 ,_sketch2;
        protected SketchProfile _sketchProfile1, _sketchProfile2;

        protected RevolveFeature _revolve1;

        protected ExtrudeFeature _extrude1;

        protected McGeomParam axi_y;

        protected CircularPatternFeature _circularArray;

        protected ChamferFeature _chamfer1;

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
            _solid = new Mc3dSolid();
        }






        protected void Revolve1()
        {
            _revolve1 = new RevolveFeature();

            _solid = _revolve1.Cast<Mc3dSolid>();
            if (McObjectManager.Add2Document(_solid.DbEntity, _activeSheet))
            {
                _solid.DbEntity.AddToCurrentDocument();

                _sketch1 = _solid.AddPlanarSketch();

                Plane3d xoy = new Plane3d(Plane3d.XYPlane);

                //Polyline3d baseCircuit = new Teigha.DatabaseServices.Polyline3d();                

                Polyline3d baseCircuit = new Polyline3d
                (
                    new List<Point3d>
                    {
                         new Point3d(d1 / 2, 0, 0),//0
                         new Point3d(D2 / 2, 0, 0),//1
                         new Point3d(D2 / 2, l1, 0),//2   
                         new Point3d(D / 2, l1, 0),//3   
                         new Point3d(D / 2, b,0),//4
                         new Point3d(Dm / 2, b,0),//5   
                         new Point3d(Dn / 2,H - H1,0),//6    
                         new Point3d(Dn / 2, H,0),//7    
                         new Point3d(d1 / 2,H,0),//8    
                         new Point3d(-1 + d1 / 2,H,0),//9    
                         new Point3d(-1 + d1 / 2,0,0),//10    
                         new Point3d(d1 / 2, 0, 0)//11       
                    }
                );

                double l = 0.5 * (Dn - d1);

                baseCircuit.MakeChamferAtVertex(7,l,30);

                DbPolyline dbBaseCircuit = new DbPolyline()
                {
                    Polyline = baseCircuit
                };

                dbBaseCircuit.DbEntity.AddToCurrentDocument();
                _sketch1.AddObject(dbBaseCircuit.ID);





                DbLine axis = new DbLine()
                {
                    StartPoint = new Point3d(0, 0, 0),
                    EndPoint = new Point3d(0, 10, 0)
                };
                axis.DbEntity.AddToCurrentDocument();


                axi_y = new McGeomParam() { ID = axis.ID };
                _sketch1.AddObject(axi_y.ID);


                _sketch1.SetPlane(Plane3d.XYPlane);
                _sketch1.DbEntity.Visibility = 0;


                _sketchProfile1 = _sketch1.CreateProfile();
                _sketchProfile1.DbEntity.Visibility = 0;
                _sketchProfile1.AutoProcessExternalContours();
                _revolve1.ProfileID = _sketchProfile1.ID;
                _revolve1.Axis = axi_y;
                _revolve1.Angle = 360;
                McObjectManager.UpdateAll();

                _sketch1.DbEntity.AddToCurrentDocument();


                

                //McObjectId id = _solid.GetPartContents(true)[3];


                //_solid.AddChamferFeature(new List<McObjectId> { id },ChamferType.DistanceAndAngle,ChamferSetbackType.Flat,1,1, 0.785398);
                //_chamfer1 = new ChamferFeature()
                //{
                //    Angle = f,
                //    Distance = l1,
                //    ChamferType = ChamferType.DistanceAndAngle,
                    
                //};
            }
        }








        protected void Extrude1()
        {
            _extrude1 = new ExtrudeFeature();
            
            _sketch2 = _solid.AddPlanarSketch();

            Plane3d xoz = new Plane3d(Plane3d.ZXPlane);


            DbCircle dbCircle = new DbCircle()
            {
                    Radius = d / 2,
                    Center = new Point3d(D1 / 2, l1,0)
            };

     
            dbCircle.DbEntity.AddToCurrentDocument();

            _sketch2.AddObject(dbCircle.ID);
            _sketch2.SetPlane(xoz);

            dbCircle.DbEntity.AddToCurrentDocument();

            _sketch2.DbEntity.Visibility = 0;

            _sketchProfile2 = _sketch2.CreateProfile();
            _sketchProfile2.DbEntity.Visibility = 0;
            _sketchProfile2.AutoProcessExternalContours();

            _extrude1 = _solid.AddExtrudeFeature(_sketchProfile2.ID, b, 0, FeatureExtentDirection.Positive);
            _extrude1.PartOperation = PartFeatureOperation.Cut;

            _circularArray = _solid.AddCircularPatternFeature(new McObjectId[] { _extrude1.ID }, axi_y, n, 360 * Math.PI / 180 / n);//360 * Math.PI / 180 / n_hole
            _circularArray.DbEntity.AddToCurrentDocument();

            McObjectManager.UpdateAll();
        }








        public void Build()
        {
            Revolve1();


            Extrude1();
        }
    }
}
