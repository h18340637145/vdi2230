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

namespace WindowsFormsApp1
{
    public partial class MutliBoltsDesginForm : Form
    {
        public MutliBoltsDesginForm()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Selection
        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            // update the entities
            simulation1.Entities.Regen();

            // if mass properties were changed, updates the proterty grid values
            propertyGrid1.Refresh();

            // Redraw
            simulation1.Invalidate();
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
                simulation1.ActionMode = actionType.None;
            }
        }


        private void Selection()
        {
            switch (selectionComboBox.SelectedIndex)
            {
                case 0:
                    simulation1.ActionMode = actionType.SelectByPick;
                    break;

                case 1:
                    simulation1.ActionMode = actionType.SelectByBox;
                    break;

                case 2:
                    simulation1.ActionMode = actionType.SelectByPolygon;
                    break;

                case 3:
                    simulation1.ActionMode = actionType.SelectByBoxEnclosed;
                    break;

                case 4:
                    simulation1.ActionMode = actionType.SelectByPolygonEnclosed;
                    break;

                case 5:
                    simulation1.ActionMode = actionType.SelectByPick;
                    break;

                case 6:
                    simulation1.ActionMode = actionType.SelectVisibleByBox;
                    break;

                case 7:
                    simulation1.ActionMode = actionType.SelectVisibleByPolygon;
                    break;
                case 8:
                    simulation1.ActionMode = actionType.SelectVisibleByPickLabel;
                    groupButton.Enabled = false;
                    break;

                default:
                    simulation1.ActionMode = actionType.None;
                    break;
            }
        }


        private void clearSelectionButton_Click(object sender, EventArgs e)
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

        private void groupButton_Click(object sender, EventArgs e)
        {
            simulation1.GroupSelection();
        }

        private void invertSelectionButton_Click(object sender, EventArgs e)
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
        #endregion


        private void wireframeButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(simulation1, displayType.Wireframe);
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
            SetDisplayMode(simulation1, displayType.Shaded);
        }

        private void renderedButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(simulation1, displayType.Rendered);
        }

        private void hiddenLinesButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(simulation1, displayType.HiddenLines);
        }

        private void flatButton_CheckedChanged(object sender, EventArgs e)
        {
            SetDisplayMode(simulation1, displayType.Flat);
        }
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
            simulation1.OriginSymbol.Visible = showOriginButton.Checked;
            simulation1.Invalidate();
        }

        private void showExtentsButton_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.OriginSymbol.Visible = showExtentsButton.Checked;
            simulation1.Invalidate();
        }

        private void showVerticesButton_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.OriginSymbol.Visible = showVerticesButton.Enabled;
            simulation1.Invalidate();
        }

        private void showGridButton_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.OriginSymbol.Visible = showGridButton.Enabled;
            simulation1.Invalidate();
        }

        #endregion

        #region Projection_zhengjiao

        private void parallelButton_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.Camera.ProjectionMode = devDept.Graphics.projectionType.Orthographic;
            simulation1.AdjustNearAndFarPlanes();
            simulation1.Invalidate();
        }

        private void perspectiveButton_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.Camera.ProjectionMode = devDept.Graphics.projectionType.Perspective;
            simulation1.AdjustNearAndFarPlanes();
            simulation1.Invalidate();
        }


        #endregion


        #region view
        // 多视图
        private void frontViewButton_Click(object sender, EventArgs e)
        {
            simulation1.SetView(viewType.Front, true, simulation1.AnimateCamera);
            simulation1.Invalidate();
        }

        private void sideViewButton_Click(object sender, EventArgs e)
        {
            simulation1.SetView(viewType.Right, true, simulation1.AnimateCamera);
            simulation1.Invalidate();
        }

        private void topViewButton_Click(object sender, EventArgs e)
        {
            simulation1.SetView(viewType.Top, true, simulation1.AnimateCamera);
            simulation1.Invalidate();
        }

        private void isoViewButton_Click(object sender, EventArgs e)
        {
            simulation1.SetView(viewType.Isometric, true, simulation1.AnimateCamera);
            simulation1.Invalidate();
        }

        private void animateCameraCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            simulation1.AnimateCamera = animateCameraCheckBox.Checked;
        }

        #endregion


        #region clamped
        private CreateBoltForm _createBoltForm;
        private CreateClampedForm _createFlangeForm;
        private CreateNutForm _createNutForm;

        private void createBoltBtn_Click(object sender, EventArgs e)
        {
            if (_createBoltForm == null)
                _createBoltForm = new CreateBoltForm();

            _createBoltForm.StartPosition = FormStartPosition.CenterParent;
            _createBoltForm.ShowDialog();
            var bolt = _createBoltForm.GetModelEntity();
            if (bolt == null) return;

            createBoltBtn.Enabled = false;
        }

        private void createFlangeBtn_Click_1(object sender, EventArgs e)
        {
            if (_createFlangeForm == null)
            {
                _createFlangeForm = new CreateClampedForm();
            }
            _createFlangeForm.StartPosition = FormStartPosition.CenterParent;
            _createFlangeForm.ShowDialog();

            var flange = _createFlangeForm.GetModelEntity();
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
        private BoltsClampedForm boltsClampedForm;

        private void _assemblyBtn_Click(object sender, EventArgs e)
        {
            if (_createBoltForm == null)
            {
                MessageBox.Show("请先创建螺栓");
                return;
            }
            if (_createFlangeForm == null)
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
            boltsClampedForm.FlangeForm = _createFlangeForm;
            boltsClampedForm.NutForm = _createNutForm;

            var fmod = _createFlangeForm.GetModel() as HKFDJClamped;
            var bmod = _createBoltForm.GetModel() as Bolt;
            var nmod = _createNutForm.GetModel() as NutClass;
            if (fmod == null || bmod == null || nmod == null) return;
            var result = boltsClampedForm.ShowDialog();

            if (result == DialogResult.Yes)
            {
                _twoStepsOpParamDataGridView.Rows.Clear();
                _twoStepsOpParamDataGridView.Rows.Add("twisWay", 1, "拧紧方式，1顺序，2交叉");
                _twoStepsOpParamDataGridView.Rows.Add("n", fmod.n, "螺栓个数");
                _twoStepsOpParamDataGridView.Rows.Add("d", fmod.d, "螺栓公称直径");
                _twoStepsOpParamDataGridView.Rows.Add("dm", fmod.C, "法兰螺栓定位圆直径");
                _twoStepsOpParamDataGridView.Rows.Add("Eb", 2e5, "螺栓弹性模量(MPa)");
                _twoStepsOpParamDataGridView.Rows.Add("F0", 120000, "螺栓目标载荷");
                _twoStepsOpParamDataGridView.Rows.Add("batch", 2, "拧紧批次，1或2次");
                _twoStepsOpParamDataGridView.Rows.Add("odf", fmod.outer_A, "法兰外径");
                _twoStepsOpParamDataGridView.Rows.Add("idf", fmod.inner_B, "法兰内径");
                _twoStepsOpParamDataGridView.Rows.Add("dj", 31.75, "");
                _twoStepsOpParamDataGridView.Rows.Add("tff", fmod.tf, "法兰厚");
                _twoStepsOpParamDataGridView.Rows.Add("Ef", 2e5, "法兰弹性模量(MPa)");
                //_twoStepsOpParamDataGridView.Rows.Add("odj", fmod.Ag, "垫片外径");
                //_twoStepsOpParamDataGridView.Rows.Add("idj", fmod.Bg, "垫片内径");
                //_twoStepsOpParamDataGridView.Rows.Add("tg", fmod.ddz, "垫片厚");
                _twoStepsOpParamDataGridView.Rows.Add("Eg", 1915, "垫片弹性模量(MPa)");
                _twoStepsOpParamDataGridView.Rows.Add("C", "1.50916E-06,6.25961E-07,-1.76612E-07,-1.85035E-07,-5.67578E-08 ", "弹性顺度,逗号分隔");
                _modelingParamOkBtn.Enabled = true;
            }
        }
        #endregion

    }
}
