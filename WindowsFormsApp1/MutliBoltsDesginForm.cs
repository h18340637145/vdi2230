using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using devDept.Eyeshot;
using System.Windows.Forms;
using devDept.Geometry;
using devDept.Eyeshot.Entities;
using CreateBotSpring;
using devDept.Eyeshot.Translators;
using devDept.Eyeshot.Fem;
using WindowsApplication1;
using WindowsFormsApp1.VDISolution;
using WindowsFormsApp1.ClampedModel;

namespace WindowsFormsApp1
{
    public partial class MutliBoltsDesginForm : Form
    {
        public enum FemElementsType
        {
            None,
            Beam2D,
            Beam3D,
            Element2D,
            Element3D
        }
        public MutliBoltsDesginForm()
        {
            InitializeComponent();
            simulation1.Viewports[0].LabelSelectionChanged += viewportZero_LabelSelectionChanged;
            simulation1.SelectionChanged += simulation1_SelectionChanged;
            simulation1.WorkCompleted += simulation1_WorkCompleted;
            simulation1.WorkCancelled += simulation1_WorkCancelled;
            simulation1.WorkFailed += simulation1_WorkFailed;
            simulation1.OriginSymbol.Visible = false;
            simulation1.ToolBar.Visible = false;
            simulation1.Grid.AutoSize = true;
            simulation1.Grid.AutoStep = true;
            simulation1.Grid.FillColor = Color.FromArgb(150, 123, 123, 123);
            simulation1.ViewCubeIcon.Visible = false;
            simulation1.CoordinateSystemIcon.Visible = false;
            simulation1.Grid.Visible = false;
            simulation1.ShowLoad = true;
            simulation1.ShowRestraint = true;

        }

        #region Event handlers                

        private void simulation1_SelectionChanged(object sender, EventArgs e)
        {

            int count = 0;

            // counts selected entities
            foreach (Entity ent in simulation1.Entities)

                if (ent.Selected)

                    count++;

            object[] selected = new object[count];

            count = 0;

            // fills selected array
            foreach (Entity ent in simulation1.Entities)

                if (ent.Selected)

                    selected[count++] = ent;

            //// updates count on the status bar
            //selectedCountStatusLabel.Text = count.ToString();

            // updates the propertyGrid control
            propertyGrid1.SelectedObjects = selected;

        }

        private void viewportZero_LabelSelectionChanged(object sender, EventArgs e)
        {

            int count = 0;

            // counts selected entities
            foreach (devDept.Eyeshot.Labels.Label lbl in simulation1.Viewports[0].Labels)

                if (lbl.Selected)

                    count++;

            object[] selected = new object[count];

            count = 0;

            // fills selected array
            foreach (devDept.Eyeshot.Labels.Label lbl in simulation1.Viewports[0].Labels)

                if (lbl.Selected)

                    selected[count++] = lbl;

            // updates count on the status bar
            //selectedCountStatusLabel.Text = count.ToString();

            // updates the propertyGrid control
            propertyGrid1.SelectedObjects = selected;
        }

        private void simulation1_WorkCancelled(object sender, EventArgs e)
        {

            //numericResultsButton.Enabled = false;
            plotTypeComboBox.Enabled = false;
        }


        private void simulation1_WorkCompleted(object sender, devDept.Eyeshot.WorkCompletedEventArgs e)
        {
            if (e.WorkUnit is ReadFileAsync)
            {
                ReadFileAsync rfa = (ReadFileAsync)e.WorkUnit;

                rfa.AddToScene(simulation1);
                simulation1.ZoomFit();
            }
            else if (e.WorkUnit is SolverBase)
            {

                SolverBase solver = (SolverBase)e.WorkUnit;

                FemMesh fm = solver.Mesh;

                // computes the selected plot
                fm.PlotMode = FemMesh.plotType.Tresca;

                fm.NodalAverages = true;

                fm.ComputePlot(simulation1, simulation1.Legends[0]);

                simulation1.ZoomFit();

            }
            //numericResultsButton.Enabled = true;
            FillPlotTypeComboBox();
            UpdateDisplayModeButtons();
            plotTypeComboBox.Enabled = true;
        }

        private void FillPlotTypeComboBox()
        {
            plotTypeComboBox.Items.Clear();
            plotTypeComboBox.Items.Add("Mesh");


            var elementType = GetFemElementsType(Draw.fm);
            plotTypeComboBox.Items.Add("Ux");
            plotTypeComboBox.Items.Add("Uy");

            if (elementType == FemElementsType.Beam3D || elementType == FemElementsType.Element3D)
                plotTypeComboBox.Items.Add("Uz");

            plotTypeComboBox.Items.Add("U");

            if (elementType == FemElementsType.Beam3D)
            {
                plotTypeComboBox.Items.Add("Rx");
                plotTypeComboBox.Items.Add("Ry");
            }

            if (elementType == FemElementsType.Beam2D || elementType == FemElementsType.Beam3D)
            {
                plotTypeComboBox.Items.Add("Rz");
                plotTypeComboBox.Items.Add("Axial Force");
                plotTypeComboBox.Items.Add("Shear Force V");
            }

            if (elementType == FemElementsType.Beam3D)
            {
                plotTypeComboBox.Items.Add("Shear Force W");
                plotTypeComboBox.Items.Add("Torsion Moment");
                plotTypeComboBox.Items.Add("Bending Moment V");
            }

            if (elementType == FemElementsType.Beam2D || elementType == FemElementsType.Beam3D)
            {
                plotTypeComboBox.Items.Add("Bending Moment W");
            }

            if (elementType == FemElementsType.Beam3D)
            {
                plotTypeComboBox.Items.Add("Twist Angle");
            }

            if (elementType == FemElementsType.Element2D || elementType == FemElementsType.Element3D)
            {
                plotTypeComboBox.Items.Add("X stress");
                plotTypeComboBox.Items.Add("Y stress");
                if (elementType == FemElementsType.Element3D)
                    plotTypeComboBox.Items.Add("Z stress");
                plotTypeComboBox.Items.Add("XY shear");
                if (elementType == FemElementsType.Element3D)
                {
                    plotTypeComboBox.Items.Add("YZ shear");
                    plotTypeComboBox.Items.Add("XZ shear");
                }
                plotTypeComboBox.Items.Add("Maximum Principal");
                plotTypeComboBox.Items.Add("Intermediate Principal");
                if (elementType == FemElementsType.Element3D)
                    plotTypeComboBox.Items.Add("Minimum Principal");
                plotTypeComboBox.Items.Add("Von Mises");
                plotTypeComboBox.Items.Add("Tresca");
            }

            //plotTypeComboBox.SelectedIndex = plotTypeComboBox.Items.Count - 2;


            // here we set the PlotType to displacement magnitude, a quantity shared by all elements
            if (elementType == FemElementsType.Beam3D || elementType == FemElementsType.Element3D)
                plotTypeComboBox.SelectedIndex = 4;
            else
                plotTypeComboBox.SelectedIndex = 3;
        }

        internal static FemElementsType GetFemElementsType(FemMesh femMesh)
        {
            if (femMesh == null)
                return FemElementsType.None;

            if (femMesh.Elements[0] is Beam2D)
                return FemElementsType.Beam2D;

            if (femMesh.Elements[0] is Beam)
                return FemElementsType.Beam3D;

            if (femMesh.Elements[0] is Element2D)
                return FemElementsType.Element2D;

            if (femMesh.Elements[0] is Element3D)
                return FemElementsType.Element3D;

            return FemElementsType.None;
        }

        private void simulation1_WorkFailed(object sender, WorkFailedEventArgs e)
        {
            //numericResultsButton.Enabled = false;
            plotTypeComboBox.Enabled = false;
        }

        #endregion
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // every time the selected tab changes ...
            simulation1.ActionMode = actionType.None; // reset all actions
            simulation1.Focus();

            perspectiveButton.Checked = true;                   // set default projection to perspective
            selectionComboBox.SelectedIndex = 5;                // set default selection to VisibleByPick            

            simulation1.ShowVertices = false;

            simulation1.StopAnimation();              // stop any animation

            simulation1.Clear();                      // clear model (entities, blocks, layers, materials, etc.)

            propertyGrid1.SelectedObjects = null;               // clear propertyGrid contents

            simulation1.Legends[0].Visible = false;
            simulation1.Grid.Visible = true;
            simulation1.Grid.Step = 10;


            simulation1.HiddenLines.Lighting = false;
            simulation1.HiddenLines.ColorMethod = hiddenLinesColorMethodType.SingleColor;
            simulation1.HiddenLines.DashedHiddenLines = false;

            simulation1.AutoHideLabels = true;
            simulation1.DisplayMode = displayType.Rendered;
            if (simulation1.IsBusy)
            {
                plotTypeComboBox.Enabled = false;
                //numericResultsButton.Enabled = false;
            }
            else
            {
                plotTypeComboBox.Enabled = true;
                //numericResultsButton.Enabled = true;
            }
            // Sets trimetric view and fits the model in the main viewport
            simulation1.SetView(viewType.Trimetric, true, simulation1.AnimateCamera);

            // Refresh the model
            simulation1.Invalidate();

            UpdateDisplayModeButtons();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Selection
        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            // update the entities
            simulation1.Entities.Regen();

            // Redraw
            simulation1.Invalidate();

            // update the entities

            // if mass properties were changed, updates the proterty grid values
            propertyGrid1.Refresh();

            // Redraw
        }

        private void selectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupButton.Enabled = true;
            if (selectButton.Checked)
            {
                Selection();
            }
        }

        private void selectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            groupButton.Enabled = true;
            if (selectButton.Checked == true)
            {
                Selection();
            }
            else
            {
                //if (simulation1 == null && simulation2 == null)
                //{
                //    return;
                //}
                if (simulation1 != null)
                {
                    simulation1.ActionMode = actionType.None;
                }
                //if (simulation2 != null)
                //{
                //    simulation2.ActionMode = actionType.None;
                //}
            }
        }

        private void Selection()
        {
            switch (selectionComboBox.SelectedIndex)
            {
                case 0:
                    //if (simulation1 == null && simulation2 == null)
                    //    return;
                    if(simulation1 != null)
                        simulation1.ActionMode = actionType.SelectByPick;
                    //if (simulation2 != null)
                    //    simulation2.ActionMode = actionType.SelectByPick;
                    break;

                case 1:
                    //if (simulation1 == null && simulation2 == null)
                    //    return;
                    if (simulation1 != null)
                        simulation1.ActionMode = actionType.SelectByBox;
                    //else
                    //    simulation2.ActionMode = actionType.SelectByBox;
                    break;

                case 2:
                    //if (simulation1 == null && simulation2 == null)
                    //    return;
                    if (simulation1 != null)
                        simulation1.ActionMode = actionType.SelectByPolygon;
                    //simulation2.ActionMode = actionType.SelectByPolygon;
                    break;

                case 3:
                    //if (simulation1 == null && simulation2 == null)
                    //    return;
                    if (simulation1 != null)
                        simulation1.ActionMode = actionType.SelectByBoxEnclosed;
                    //else
                    //    simulation2.ActionMode = actionType.SelectByBoxEnclosed;
                    break;

                case 4:
                    //if (simulation1 == null && simulation2 == null)
                    //    return;
                    if (simulation1 != null)
                        simulation1.ActionMode = actionType.SelectByPolygonEnclosed;
                    //else
                    //    simulation2.ActionMode = actionType.SelectByPolygonEnclosed;
                    break;

                case 5:
                    //if (simulation1 == null && simulation2 == null)
                    //    return;
                    if (simulation1 != null)
                        simulation1.ActionMode = actionType.SelectByPick;
                    //else
                    //    simulation2.ActionMode = actionType.SelectByPick;
                    break;

                case 6:
                    //if (simulation1 == null && simulation2 == null)
                    //    return;
                    if (simulation1 != null)
                        simulation1.ActionMode = actionType.SelectVisibleByBox;
                    //else
                    //    simulation2.ActionMode = actionType.SelectVisibleByBox;
                    break;

                case 7:
                    //if (simulation1 == null && simulation2 == null)
                    //    return;
                    if (simulation1 != null)
                        simulation1.ActionMode = actionType.SelectVisibleByPolygon;
                    //else
                    //    simulation2.ActionMode = actionType.SelectVisibleByPolygon;
                    break;
                case 8:
                    //if (simulation1 == null && simulation2 == null)
                    //    return;
                    if (simulation1 != null)
                        simulation1.ActionMode = actionType.SelectVisibleByPickLabel;
                    //else
                    //    simulation2.ActionMode = actionType.SelectVisibleByPickLabel;
                    groupButton.Enabled = false;
                    break;

                default:
                    //if (simulation1 == null && simulation2 == null)
                    //    return;
                    if (simulation1 != null)
                        simulation1.ActionMode = actionType.None;
                    //else
                    //    simulation2.ActionMode = actionType.None;
                    break;
            }
        }

        private void clearSelectionButton_Click(object sender, EventArgs e)
        {
            //if (simulation1 == null && simulation2 == null)
            //    return;
            if (simulation1 != null)
            {
                if (simulation1.ActionMode == actionType.SelectVisibleByPickLabel)
                {
                    simulation1.Viewports[0].Labels.ClearSelection();
                }
                else
                {
                    simulation1.Entities.ClearSelection();
                }
                simulation1.Invalidate(); // redraw
            }


            //if (simulation2 != null)
            //{
            //    if (simulation2.ActionMode == actionType.SelectVisibleByPickLabel)
            //    {
            //        simulation2.Viewports[0].Labels.ClearSelection();
            //    }
            //    else
            //    {
            //        simulation2.Entities.ClearSelection();
            //    }
            //    simulation2.Invalidate(); // redraw
            //}
        }

        private void groupButton_Click(object sender, EventArgs e)
        {
            //if (simulation1 == null && simulation2 == null)
            //    return;
            if (simulation1 != null)
                simulation1.GroupSelection();
            //if (simulation2 != null)
            //   simulation2.GroupSelection();
        }

        private void invertSelectionButton_Click(object sender, EventArgs e)
        {
            //if (simulation1 == null && simulation2 == null)
            //    return;
            if (simulation1 != null)
            {
                if (simulation1.ActionMode == actionType.SelectVisibleByPickLabel)
                {
                    simulation1.Viewports[0].Labels.InvertSelection();
                }
                else
                {
                    simulation1.Entities.InvertSelection();
                }
                simulation1.Invalidate();
            }

            //if (simulation2 != null)
            //{
            //    if (simulation2.ActionMode == actionType.SelectVisibleByPickLabel)
            //    {
            //        simulation2.Viewports[0].Labels.InvertSelection();
            //    }
            //    else
            //    {
            //        simulation2.Entities.InvertSelection();
            //    }
            //    simulation2.Invalidate();
            //}
        }
        #endregion

        #region DisplayMode
        private void UpdateDisplayModeButtons()
        {
            if (simulation1 == null )
            {
                return;
            }
            if (simulation1 != null)
            {
                // syncs the shading buttons with the current display mode.
                switch (simulation1.DisplayMode)
                {
                    case displayType.Wireframe:
                        wireframeButton.Checked = true;
                        break;
                    case displayType.Shaded:
                        shadedButton.Checked = true;
                        break;
                    case displayType.Rendered:
                        renderedButton.Checked = true;
                        break;
                    case displayType.Flat:
                        flatButton.Checked = true;
                        break;
                    case displayType.HiddenLines:
                        hiddenLinesButton.Checked = true;
                        break;
                }
            }
        }

        private void wireframeButton_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                SetDisplayMode(simulation1, displayType.Wireframe);
            }
        }

        private static void SetDisplayMode(Simulation simulation, displayType displayType)
        {
            simulation.DisplayMode = displayType;
            SetBackgroundStyleAndColor(simulation);
            simulation.Invalidate();
        }

        private static void SetBackgroundStyleAndColor(Simulation simulation)
        {
            simulation.CoordinateSystemIcon.Lighting = false;
            simulation.ViewCubeIcon.Lighting = false;

            switch (simulation.DisplayMode)
            {
                case displayType.HiddenLines:
                    simulation.Background.TopColor = Color.FromArgb(0xD2, 0xD0, 0xB9);
                    simulation.CoordinateSystemIcon.Lighting = true;
                    simulation.ViewCubeIcon.Lighting = false;
                    break;
                default:
                    simulation.Background.TopColor = Color.Snow;
                    break;
            }
        }

        private void shadedButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (simulation1 != null)
                SetDisplayMode(simulation1, displayType.Shaded);
        }

        private void renderedButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (simulation1 != null)
                SetDisplayMode(simulation1, displayType.Rendered);
        }

        private void hiddenLinesButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (simulation1 != null)
                SetDisplayMode(simulation1, displayType.HiddenLines);
            
        }

        private void flatButton_CheckedChanged(object sender, EventArgs e)
        {
           
            if (simulation1 != null)
                SetDisplayMode(simulation1, displayType.Flat);
            
        }
        #endregion
       
        #region Inspection
        // 几何属性
        bool inspectVertex = false;
        bool inspectMesh = false;

        private void pickVertexButton_Click(object sender, EventArgs e)
        {
            simulation1.ActionMode = actionType.None;

            inspectMesh = false;
            inspectVertex = false;

            if (pickVertexButton.Checked)
            {
                inspectVertex = true;
            }
            else
            {
            }
            pickVertexButton.Checked = false;

        }

        private void pickFaceButton_Click(object sender, EventArgs e)
        {
            simulation1.ActionMode = actionType.None;

            inspectVertex = false; // 点拾取
            inspectMesh = false; // 面拾取

            if (pickVertexButton.Checked == true)
            {
                inspectMesh = true;
            }
            pickVertexButton.Checked = false;


        }

        private void areaButton_Click(object sender, EventArgs e)
        {
            // area proterites
            AreaProperties ap = new AreaProperties();

            int count = 0;

            for (int i = 0; i < simulation1.Entities.Count; i++)
            {
                Entity ent = simulation1.Entities[i];
                if (ent.Selected == true)
                {
                    if (ent is IFace)
                    {
                        IFace itfFace = (IFace)ent;

                        Mesh[] meshes  = itfFace.GetPolygonMeshes();
                        foreach (Mesh mesh in meshes)
                        {
                            ap.Add(mesh.Vertices, mesh.Triangles);
                        }
                        count++;
                    }
                    else
                    {
                        ICurve itfCurve = (ICurve)ent;
                        if (itfCurve.IsClosed)
                        {
                            ap.Add(ent.Vertices);
                        }
                        count++;
                    }
                }
            }
            StringBuilder text = new StringBuilder();
            text.AppendLine(count + " entity(ies) selected");
            text.AppendLine("---------------------");

            if (ap.Centroid != null)
            {
                double x, y, z;
                double xx, yy, zz, xy, zx, yz;

                MomentOfInertia world, centroid;

                ap.GetResults(ap.Area, ap.Centroid, out x, out y, out z, out xx, out yy, out zz, out xy, out zx, out yz, out world, out centroid);

                text.AppendLine("Cumulative area: " + ap.Area + " square " + simulation1.Units.ToString().ToLower());
                text.AppendLine("Cumulative centroid: " + ap.Centroid);
                text.AppendLine("Cumulative area moments:");
                text.AppendLine(" First moments");
                text.AppendLine("  x: " + x.ToString("g6"));
                text.AppendLine("  y: " + y.ToString("g6"));
                text.AppendLine("  z: " + z.ToString("g6"));
                text.AppendLine(" Second moments");
                text.AppendLine("  xx: " + xx.ToString("g6"));
                text.AppendLine("  yy: " + yy.ToString("g6"));
                text.AppendLine("  zz: " + zz.ToString("g6"));
                text.AppendLine(" Product moments");
                text.AppendLine("  xy: " + xx.ToString("g6"));
                text.AppendLine("  yz: " + yy.ToString("g6"));
                text.AppendLine("  zx: " + zz.ToString("g6"));
                text.AppendLine(" Area Moments of Inertia about World Coordinate Axes");
                text.AppendLine("  Ix: " + world.Ix.ToString("g6"));
                text.AppendLine("  Iy: " + world.Iy.ToString("g6"));
                text.AppendLine("  Iz: " + world.Iz.ToString("g6"));
                text.AppendLine(" Area Radii of Gyration about World Coordinate Axes");
                text.AppendLine("  Rx: " + world.Rx.ToString("g6"));
                text.AppendLine("  Ry: " + world.Ry.ToString("g6"));
                text.AppendLine("  Rz: " + world.Rz.ToString("g6"));
                text.AppendLine(" Area Moments of Inertia about Centroid Coordinate Axes:");
                text.AppendLine("  Ix: " + centroid.Ix.ToString("g6"));
                text.AppendLine("  Iy: " + centroid.Iy.ToString("g6"));
                text.AppendLine("  Iz: " + centroid.Iz.ToString("g6"));
                text.AppendLine(" Area Radii of Gyration about Centroid Coordinate Axes");
                text.AppendLine("  Rx: " + centroid.Rx.ToString("g6"));
                text.AppendLine("  Ry: " + centroid.Ry.ToString("g6"));
                text.AppendLine("  Rz: " + centroid.Rz.ToString("g6"));
            }

            DetailsForm rf = new DetailsForm();
            rf.Text = "Area Properties";

            rf.contentTextBox.Text = text.ToString();

            rf.Show();
        }

        private void volumeButton_Click(object sender, EventArgs e)
        {
            VolumeProperties vp = new VolumeProperties();

            int count = 0;
            for (int i = 0; i < simulation1.Entities.Count; i++)
            {
                Entity ent = simulation1.Entities[i];

                if (ent.Selected == true)
                {
                    if (ent is IFace)
                    {
                        IFace itfFace = (IFace)ent;
                        Mesh[] meshes = itfFace.GetPolygonMeshes();

                        foreach (var mesh in meshes)
                        {
                            vp.Add(mesh.Vertices, mesh.Triangles);
                        }
                        count++;
                    }
                }
            }
        }

        private void dumpButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < simulation1.Entities.Count; i++)
            {
                if (simulation1.Entities[i].Selected == true)
                {
                    string details = "entities id = " + System.Environment.NewLine + "-------------------" + System.Environment.NewLine + simulation1.Entities[i].Dump();
                    DetailsForm df = new DetailsForm();
                    df.Text = "Dump";
                    df.contentTextBox.Text = details;
                    df.Show();
                    break;
                }
            }
        }

        private void showCurveDirectionButton_CheckedChanged(object sender, EventArgs e)
        { 
            simulation1.ShowCurveDirection = showCurveDirectionButton.Checked;
            simulation1.Invalidate();
        }

        private void cullingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cullingButton.Checked == true)
            {
                simulation1.Backface.ColorMethod = devDept.Graphics.backfaceColorMethodType.Cull;
            }
            else
            {
                simulation1.Backface.ColorMethod = devDept.Graphics.backfaceColorMethodType.EntityColor;
            }
            simulation1.Invalidate();

        }

        #endregion

        #region Hide/Show

        private void showOriginButton_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                simulation1.OriginSymbol.Visible = showOriginButton.Checked;
                simulation1.Invalidate();
            }

        }

        private void showExtentsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                simulation1.OriginSymbol.Visible = showExtentsButton.Checked;
                simulation1.Invalidate();
            }

        }

        private void showVerticesButton_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1 != null )
            {
                simulation1.OriginSymbol.Visible = showVerticesButton.Enabled;
                simulation1.Invalidate();
            }

        }

        private void showGridButton_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1!= null)
            {
                simulation1.OriginSymbol.Visible = showGridButton.Enabled;
                simulation1.Invalidate();
            }
        }

        #endregion

        #region Projection_zhengjiao

        private void parallelButton_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1!= null)
            {
                simulation1.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
                simulation1.AdjustNearAndFarPlanes();
                simulation1.Invalidate();
            }
        }

        private void perspectiveButton_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {

                simulation1.Camera.ProjectionMode = devDept.Graphics.projectionType.Perspective;
                simulation1.AdjustNearAndFarPlanes();
                simulation1.Invalidate();
            }
        }

        #endregion

        #region view
        // 多视图
        private void frontViewButton_Click(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                simulation1.SetView(viewType.Front, true, simulation1.AnimateCamera);
                simulation1.Invalidate();
            }
        }

        private void sideViewButton_Click(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                simulation1.SetView(viewType.Right, true, simulation1.AnimateCamera);
                simulation1.Invalidate();
            }
        }

        private void topViewButton_Click(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                simulation1.SetView(viewType.Top, true, simulation1.AnimateCamera);
                simulation1.Invalidate();
            }

        }

        private void isoViewButton_Click(object sender, EventArgs e)
        {
            
            if (simulation1!= null)
            {

                simulation1.SetView(viewType.Isometric, true, simulation1.AnimateCamera);
                simulation1.Invalidate();
            }

        }


        private void animateCameraCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                simulation1.AnimateCamera = animateCameraCheckBox.Checked;
            }
           
        }

        #endregion

        #region createModel
        #region clamped
        private CreateBoltForm _createBoltForm;
        private CreateClampedForm _createClamedForm;
        private CreateNutForm _createNutForm;
        private BoltsClampedForm boltsClampedForm;

        private void createBoltBtn_Click(object sender, EventArgs e)
        {
            if (_createBoltForm == null)
                _createBoltForm = new CreateBoltForm();

            _createBoltForm.StartPosition = FormStartPosition.CenterParent;
            _createBoltForm.ShowDialog();
            var bolt = _createBoltForm.GetModelEntity();
            var boltData = _createBoltForm.getBoltData();
            this.boltData = boltData;
            //if (bolt == null || boltData == null) return;

            createBoltBtn.Enabled = false;
        }

        private void createFlangeBtn_Click_1(object sender, EventArgs e)
        {
            if (_createClamedForm == null)
            {
                _createClamedForm = new CreateClampedForm();
            }
            _createClamedForm.StartPosition = FormStartPosition.CenterParent;
            _createClamedForm.ShowDialog();

            var flange = _createClamedForm.GetModelEntity();
            if (flange == null)
            {
                return ;
            }

            createFlangeBtn.Enabled = false;
        }

        private void createNutBtn_Click(object sender, EventArgs e)
        {
            if (_createNutForm == null)
                _createNutForm = new CreateNutForm();

            _createNutForm.StartPosition = FormStartPosition.CenterParent;
            _createNutForm.ShowDialog();
            var nut = _createNutForm.GetModelEntity();
            if (nut == null) return;

            createNutBtn.Enabled = false;
        }

        #endregion

        #region flange
        public BoltClass boltData { get; private set; }
        public ComputeResult rs { get; private set; }
        public Solution solution { get; private set; }

        private void _assemblyBtn_Click(object sender, EventArgs e)
        {
            if (_createBoltForm == null)
            {
                MessageBox.Show("请先创建螺栓");
                return;
            }
            if (_createClamedForm == null)
            {
                MessageBox.Show("请先创建连接件");
                return;
            }
            if (_createNutForm == null)
            {
                MessageBox.Show("请先创建螺母");
                return;
            }

            if (boltsClampedForm == null)
                boltsClampedForm = new BoltsClampedForm();

            boltsClampedForm.BoltForm = _createBoltForm;
            boltsClampedForm.ClampedForm = _createClamedForm;
            boltsClampedForm.NutForm = _createNutForm;
            boltsClampedForm.boltData = boltData;

            object fmod;
            if (_createClamedForm.std_selfDef == "std")
            {
                fmod = _createClamedForm.GetModel() as HKFDJClamped;
            }
            else
            {
                fmod = _createClamedForm.GetModel() as SelfAssClamped;
            }

            var bmod = _createBoltForm.GetModel() as BoltClass;
            var nmod = _createNutForm.GetModel() as NutClass;
            if (fmod == null || bmod == null || nmod == null) return;
            var result = boltsClampedForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                if (rs == null)
                {
                    rs = new ComputeResult();
                }
                if (solution == null)
                {
                    solution = new Solution();
                }
                rs = boltsClampedForm.rs;
                solution = boltsClampedForm.solution;
                _twoStepsOpParamDataGridView.Rows.Clear();
                //_twoStepsOpParamDataGridView.Rows.Add("twisWay", 1, "拧紧方式，1顺序，2交叉");
                //_twoStepsOpParamDataGridView.Rows.Add("n", fmod.n, "螺栓个数");
                //_twoStepsOpParamDataGridView.Rows.Add("d", fmod.d, "螺栓公称直径");
                //_twoStepsOpParamDataGridView.Rows.Add("dm", fmod.C, "法兰螺栓定位圆直径");
                //_twoStepsOpParamDataGridView.Rows.Add("Eb", 2e5, "螺栓弹性模量(MPa)");
                //_twoStepsOpParamDataGridView.Rows.Add("F0", 120000, "螺栓目标载荷");
                //_twoStepsOpParamDataGridView.Rows.Add("batch", 2, "拧紧批次，1或2次");
                //_twoStepsOpParamDataGridView.Rows.Add("odf", fmod.outer_A, "法兰外径");
                //_twoStepsOpParamDataGridView.Rows.Add("idf", fmod.inner_B, "法兰内径");
                //_twoStepsOpParamDataGridView.Rows.Add("dj", 31.75, "");
                //_twoStepsOpParamDataGridView.Rows.Add("tff", fmod.tf, "法兰厚");
                //_twoStepsOpParamDataGridView.Rows.Add("Ef", 2e5, "法兰弹性模量(MPa)");
                //_twoStepsOpParamDataGridView.Rows.Add("odj", fmod.Ag, "垫片外径");
                //_twoStepsOpParamDataGridView.Rows.Add("idj", fmod.Bg, "垫片内径");
                //_twoStepsOpParamDataGridView.Rows.Add("tg", fmod.ddz, "垫片厚");
                _twoStepsOpParamDataGridView.Rows.Add("Eg", 1915, "垫片弹性模量(MPa)");
                _twoStepsOpParamDataGridView.Rows.Add("C", "1.50916E-06,6.25961E-07,-1.76612E-07,-1.85035E-07,-5.67578E-08 ", "弹性顺度,逗号分隔");
                _modelingParamOkBtn.Enabled = true;
            }
        }
        
        private void _resetBtn_Click(object sender, EventArgs e)
        {
            boltsClampedForm = new BoltsClampedForm();
            boltsClampedForm.ResetModel();
            createBoltBtn.Enabled = true;
            createFlangeBtn.Enabled = true;
            createNutBtn.Enabled = true;
            _modelingParamOkBtn.Enabled = false;
        }

        #endregion

        #endregion


        private void _moddelingParamResetBtn_Click(object sender, EventArgs e)
        {
            simulation1.Entities.Clear();

            var fmod = _createClamedForm.GetModel() as HKFDJClamped;
            var bmod = _createBoltForm.GetModel() as BoltClass;
            var nmod = _createNutForm.GetModel() as NutClass;
            if (fmod == null || nmod == null || bmod == null) return;
            if (rs == null) return;
            double[,] opResults = new double[2, (int)fmod.n];
            for (int i = 0; i < (int)fmod.n; i++)
            {
                opResults[0, i] = rs.Fmmax;
            }

            SetDisplayMode(simulation1, displayType.Shaded);
            simulation1.Legends[0].ColorTable = Legend.RedToBlue9;
            simulation1.Legends[0].IsSlave = true;
            simulation1.Legends[0].ItemSize = new Size(10, 24);
            simulation1.Legends[0].Visible = true;
            simulation1.Legends[0].Title = "FEM";

            Draw.Clamped = fmod;
            Draw.bolt = bmod;
            Draw.nut = nmod;
            Draw.InitConnFem(simulation1);
            _drawFlangeFemFrameParam = new MulForcesStepsDrawParam()
            {
                Forces = opResults,
                IsOverlay = false
            };
            _drawFlangeFemFrameParam.Batch = 0;
            Draw.DrawConnFemFrame(simulation1, _drawFlangeFemFrameParam);
        }
        private void _modelingParamOkBtn_Click(object sender, EventArgs e)
        {
            //boltnet(simulation1);
            simulation1.Entities.Clear();
            HKFDJClamped fmod;
            if (_createClamedForm.GetModel() is HKFDJClamped)
            {
                var temp = _createClamedForm.GetModel() as HKFDJClamped;
                if (temp == null) return;
                fmod = temp;
            }
            else
            {
                SelfAssClamped temp = (SelfAssClamped)_createClamedForm.GetModel();
                if (temp == null) return;
                fmod = new HKFDJClamped(temp);
            }
            
            if (rs == null) return;
            double[,] opResults = new double[2, (int)fmod.n];
            for (int i = 0; i < (int)fmod.n; i++)
            {
                opResults[0, i] = rs.Fmmax;
            }
            
            SetDisplayMode(simulation1, displayType.Shaded);
            simulation1.Legends[0].ColorTable = Legend.RedToBlue9;
            simulation1.Legends[0].IsSlave = true;
            simulation1.Legends[0].ItemSize = new Size(10, 24);
            simulation1.Legends[0].Visible = true;
            simulation1.Legends[0].Title = "FEM";

            Draw.Clamped = fmod; 
            Draw.InitFlangeFem(simulation1);
            _drawFlangeFemFrameParam = new MulForcesStepsDrawParam()
            {
                Forces = opResults,
                IsOverlay = false
            };

            tabControl2.SelectedIndex = 2;
            _firstBatchRenderBtn.Enabled = true;
        }

        private void boltnet(Simulation simulation1)
        {
            simulation1.Entities.Clear();

            var bmod = _createBoltForm.GetModel() as BoltClass;
            var nmod = _createNutForm.GetModel() as NutClass;
            if ( bmod == null || nmod == null) return;
            double opResults = rs.Fmmax;

            SetDisplayMode(simulation1, displayType.Shaded);
            simulation1.Legends[0].ColorTable = Legend.RedToBlue9;
            simulation1.Legends[0].IsSlave = true;
            simulation1.Legends[0].ItemSize = new Size(10, 24);
            simulation1.Legends[0].Visible = true;
            simulation1.Legends[0].Title = "FEM";

            Draw.bolt = bmod;
            Draw.InitBoltFem(simulation1);
            boltDram = new BoltDram()
            {
                Forces = opResults
            };
        }

        private MulForcesStepsDrawParam _drawFlangeFemFrameParam;
        private BoltDram boltDram;
        private void _firstBatchRenderBtn_Click(object sender, EventArgs e)
        {
            _drawFlangeFemFrameParam.Batch = 0;
            Draw.DrawFlangeFemFrame(simulation1, _drawFlangeFemFrameParam);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Draw.DrawBoltFemFrame(simulation1, boltDram);
            
        }
        private void plotTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Draw.fm == null)
                return;
            else if (Draw.fm != null && Draw.boltfm == null)
            {
                plotfm();
            }
            else if(Draw.fm == null && Draw.boltfm != null)
            {
                plotBoltfm();
            }
            else
            {
                Draw.fm = null;
                Draw.boltfm = null;
                return;
            }
        }

        private void plotBoltfm()
        {
            simulation1.Legends[0].Visible = true;
            Draw.boltfm.ContourPlot = true;
            simulation1.Legends[0].ColorTable = Legend.RedToBlue17;

            switch (plotTypeComboBox.Text)
            {

                case "Mesh":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Mesh;
                    simulation1.Legends[0].Visible = false;

                    break;

                case "Ux":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Ux;
                    Draw.boltfm.ContourPlot = false;

                    break;

                case "Uy":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Uy;
                    Draw.boltfm.ContourPlot = false;

                    break;

                case "Uz":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Uz;
                    Draw.boltfm.ContourPlot = false;

                    break;

                case "U":

                    Draw.boltfm.PlotMode = FemMesh.plotType.U;
                    Draw.boltfm.ContourPlot = false;

                    break;

                case "Rx":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Rx;

                    break;

                case "Ry":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Ry;

                    break;

                case "Rz":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Rz;

                    break;

                case "Axial Force":

                    Draw.boltfm.PlotMode = FemMesh.plotType.AxialForce;

                    break;

                case "Shear Force V":

                    Draw.boltfm.PlotMode = FemMesh.plotType.ShearForceV;

                    break;

                case "Shear Force W":

                    Draw.boltfm.PlotMode = FemMesh.plotType.ShearForceW;

                    break;

                case "Torsion Moment":

                    Draw.boltfm.PlotMode = FemMesh.plotType.TorsionMoment;

                    break;

                case "Bending Moment V":

                    Draw.boltfm.PlotMode = FemMesh.plotType.BeamBendingMomentV;

                    break;

                case "Bending Moment W":

                    Draw.boltfm.PlotMode = FemMesh.plotType.BeamBendingMomentW;

                    break;

                case "Twist Angle":

                    Draw.boltfm.PlotMode = FemMesh.plotType.TwistAngle;

                    break;

                case "X stress":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Sx;

                    break;

                case "Y stress":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Sy;

                    break;

                case "Z stress":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Sz;

                    break;

                case "XY shear":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Txy;

                    break;

                case "YZ shear":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Tyz;

                    break;

                case "XZ shear":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Txz;

                    break;

                case "Maximum Principal":

                    Draw.boltfm.PlotMode = FemMesh.plotType.P1;

                    break;

                case "Intermediate Principal":

                    Draw.boltfm.PlotMode = FemMesh.plotType.P2;

                    break;

                case "Minimum Principal":

                    Draw.boltfm.PlotMode = FemMesh.plotType.P3;

                    break;

                case "Von Mises":


                    Draw.boltfm.PlotMode = FemMesh.plotType.VonMises;

                    break;

                case "Tresca":

                    Draw.boltfm.PlotMode = FemMesh.plotType.Tresca;

                    break;
            }

            // re-computes the plot and redraw
            if (Draw.boltfm != null)
            {
                Draw.boltfm.ComputePlot(simulation1, simulation1.Legends[0]);
                simulation1.Entities.UpdateBoundingBox();
            }
            simulation1.Invalidate();

            contourPlotCheckBox.Checked = Draw.boltfm.ContourPlot;
            nodalAveragesCheckBox.Checked = Draw.boltfm.NodalAverages;
        }

        private void plotfm()
        {
            simulation1.Legends[0].Visible = true;
            Draw.fm.ContourPlot = true;
            simulation1.Legends[0].ColorTable = Legend.RedToBlue17;

            switch (plotTypeComboBox.Text)
            {

                case "Mesh":

                    Draw.fm.PlotMode = FemMesh.plotType.Mesh;
                    simulation1.Legends[0].Visible = false;

                    break;

                case "Ux":

                    Draw.fm.PlotMode = FemMesh.plotType.Ux;
                    Draw.fm.ContourPlot = false;

                    break;

                case "Uy":

                    Draw.fm.PlotMode = FemMesh.plotType.Uy;
                    Draw.fm.ContourPlot = false;

                    break;

                case "Uz":

                    Draw.fm.PlotMode = FemMesh.plotType.Uz;
                    Draw.fm.ContourPlot = false;

                    break;

                case "U":

                    Draw.fm.PlotMode = FemMesh.plotType.U;
                    Draw.fm.ContourPlot = false;

                    break;

                case "Rx":

                    Draw.fm.PlotMode = FemMesh.plotType.Rx;

                    break;

                case "Ry":

                    Draw.fm.PlotMode = FemMesh.plotType.Ry;

                    break;

                case "Rz":

                    Draw.fm.PlotMode = FemMesh.plotType.Rz;

                    break;

                case "Axial Force":

                    Draw.fm.PlotMode = FemMesh.plotType.AxialForce;

                    break;

                case "Shear Force V":

                    Draw.fm.PlotMode = FemMesh.plotType.ShearForceV;

                    break;

                case "Shear Force W":

                    Draw.fm.PlotMode = FemMesh.plotType.ShearForceW;

                    break;

                case "Torsion Moment":

                    Draw.fm.PlotMode = FemMesh.plotType.TorsionMoment;

                    break;

                case "Bending Moment V":

                    Draw.fm.PlotMode = FemMesh.plotType.BeamBendingMomentV;

                    break;

                case "Bending Moment W":

                    Draw.fm.PlotMode = FemMesh.plotType.BeamBendingMomentW;

                    break;

                case "Twist Angle":

                    Draw.fm.PlotMode = FemMesh.plotType.TwistAngle;

                    break;

                case "X stress":

                    Draw.fm.PlotMode = FemMesh.plotType.Sx;

                    break;

                case "Y stress":

                    Draw.fm.PlotMode = FemMesh.plotType.Sy;

                    break;

                case "Z stress":

                    Draw.fm.PlotMode = FemMesh.plotType.Sz;

                    break;

                case "XY shear":

                    Draw.fm.PlotMode = FemMesh.plotType.Txy;

                    break;

                case "YZ shear":

                    Draw.fm.PlotMode = FemMesh.plotType.Tyz;

                    break;

                case "XZ shear":

                    Draw.fm.PlotMode = FemMesh.plotType.Txz;

                    break;

                case "Maximum Principal":

                    Draw.fm.PlotMode = FemMesh.plotType.P1;

                    break;

                case "Intermediate Principal":

                    Draw.fm.PlotMode = FemMesh.plotType.P2;

                    break;

                case "Minimum Principal":

                    Draw.fm.PlotMode = FemMesh.plotType.P3;

                    break;

                case "Von Mises":


                    Draw.fm.PlotMode = FemMesh.plotType.VonMises;

                    break;

                case "Tresca":

                    Draw.fm.PlotMode = FemMesh.plotType.Tresca;

                    break;
            }

            // re-computes the plot and redraw
            if (Draw.fm != null)
            {
                Draw.fm.ComputePlot(simulation1, simulation1.Legends[0]);
                simulation1.Entities.UpdateBoundingBox();
            }
            simulation1.Invalidate();

            contourPlotCheckBox.Checked = Draw.fm.ContourPlot;
            nodalAveragesCheckBox.Checked = Draw.fm.NodalAverages;
        }

        //private void plotTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (Draw.fm == null)
        //        return;

        //    simulation1.Legends[0].Visible = true;
        //    Draw.fm.ContourPlot = true;
        //    simulation1.Legends[0].ColorTable = Legend.RedToBlue17;

        //    switch (plotTypeComboBox.Text)
        //    {

        //        case "Mesh":

        //            Draw.fm.PlotMode = FemMesh.plotType.Mesh;
        //            simulation1.Legends[0].Visible = false;

        //            break;

        //        case "Ux":

        //            Draw.fm.PlotMode = FemMesh.plotType.Ux;
        //            Draw.fm.ContourPlot = false;

        //            break;

        //        case "Uy":

        //            Draw.fm.PlotMode = FemMesh.plotType.Uy;
        //            Draw.fm.ContourPlot = false;

        //            break;

        //        case "Uz":

        //            Draw.fm.PlotMode = FemMesh.plotType.Uz;
        //            Draw.fm.ContourPlot = false;

        //            break;

        //        case "U":

        //            Draw.fm.PlotMode = FemMesh.plotType.U;
        //            Draw.fm.ContourPlot = false;

        //            break;

        //        case "Rx":

        //            Draw.fm.PlotMode = FemMesh.plotType.Rx;

        //            break;

        //        case "Ry":

        //            Draw.fm.PlotMode = FemMesh.plotType.Ry;

        //            break;

        //        case "Rz":

        //            Draw.fm.PlotMode = FemMesh.plotType.Rz;

        //            break;

        //        case "Axial Force":

        //            Draw.fm.PlotMode = FemMesh.plotType.AxialForce;

        //            break;

        //        case "Shear Force V":

        //            Draw.fm.PlotMode = FemMesh.plotType.ShearForceV;

        //            break;

        //        case "Shear Force W":

        //            Draw.fm.PlotMode = FemMesh.plotType.ShearForceW;

        //            break;

        //        case "Torsion Moment":

        //            Draw.fm.PlotMode = FemMesh.plotType.TorsionMoment;

        //            break;

        //        case "Bending Moment V":

        //            Draw.fm.PlotMode = FemMesh.plotType.BeamBendingMomentV;

        //            break;

        //        case "Bending Moment W":

        //            Draw.fm.PlotMode = FemMesh.plotType.BeamBendingMomentW;

        //            break;

        //        case "Twist Angle":

        //            Draw.fm.PlotMode = FemMesh.plotType.TwistAngle;

        //            break;

        //        case "X stress":

        //            Draw.fm.PlotMode = FemMesh.plotType.Sx;

        //            break;

        //        case "Y stress":

        //            Draw.fm.PlotMode = FemMesh.plotType.Sy;

        //            break;

        //        case "Z stress":

        //            Draw.fm.PlotMode = FemMesh.plotType.Sz;

        //            break;

        //        case "XY shear":

        //            Draw.fm.PlotMode = FemMesh.plotType.Txy;

        //            break;

        //        case "YZ shear":

        //            Draw.fm.PlotMode = FemMesh.plotType.Tyz;

        //            break;

        //        case "XZ shear":

        //            Draw.fm.PlotMode = FemMesh.plotType.Txz;

        //            break;

        //        case "Maximum Principal":

        //            Draw.fm.PlotMode = FemMesh.plotType.P1;

        //            break;

        //        case "Intermediate Principal":

        //            Draw.fm.PlotMode = FemMesh.plotType.P2;

        //            break;

        //        case "Minimum Principal":

        //            Draw.fm.PlotMode = FemMesh.plotType.P3;

        //            break;

        //        case "Von Mises":


        //            Draw.fm.PlotMode = FemMesh.plotType.VonMises;

        //            break;

        //        case "Tresca":

        //            Draw.fm.PlotMode = FemMesh.plotType.Tresca;

        //            break;
        //    }

        //    // re-computes the plot and redraw
        //    if (Draw.fm != null)
        //    {
        //        Draw.fm.ComputePlot(simulation1, simulation1.Legends[0]);
        //        simulation1.Entities.UpdateBoundingBox();
        //    }
        //    simulation1.Invalidate();

        //    contourPlotCheckBox.Checked = Draw.fm.ContourPlot;
        //    nodalAveragesCheckBox.Checked = Draw.fm.NodalAverages;
        //}

        void showRestraintsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                simulation1.ShowRestraint = showRestraintsCheckBox.Checked;
                simulation1.Invalidate();
            }
        }
        private void showJointCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                simulation1.ShowJoint = showJointCheckBox.Checked;
                simulation1.Invalidate();
            }
        }

        private void showLoadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                simulation1.ShowLoad = showLoadCheckBox.Checked;
                simulation1.Invalidate();
            }
        }

        private void showVertexIndicesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (simulation1 != null)
            {
                simulation1.ShowVertexIndices = showVertexIndicesCheckBox.Checked;
                simulation1.Invalidate();
            }
        }

        private void contourPlotCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // re-computes the plot and redraw
            if (Draw.fm != null)
            {
                Draw.fm.ContourPlot = contourPlotCheckBox.Checked;
                Draw.fm.ComputePlot(simulation1, simulation1.Legends[0]);
                simulation1.Invalidate();
            }
        }

        private void nodalAveragesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // re-computes the plot and redraw
            if (Draw.fm != null)
            {
                Draw.fm.NodalAverages = nodalAveragesCheckBox.Checked;
                Draw.fm.ComputePlot(simulation1, simulation1.Legends[0]);
                simulation1.Invalidate();
            }
        }

       
    }
}
