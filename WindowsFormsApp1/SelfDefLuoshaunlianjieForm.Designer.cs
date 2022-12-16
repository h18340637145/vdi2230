namespace WindowsFormsApp1
{
    partial class SelfDefLuoshaunlianjieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton5 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar5 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton5, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings5 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera5 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 3.76000072009692D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton5 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton5 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton5 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton5 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton5 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton5 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton5 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar5 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton5)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton5)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton5)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton5)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton5)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton5)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton5))});
            devDept.Eyeshot.Grid grid5 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings5 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings5 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings5 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings5 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager5 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport5 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(425, 376), backgroundSettings5, camera5, new devDept.Eyeshot.ToolBar[] {
            toolBar5}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid5}, false, rotateSettings5, zoomSettings5, panSettings5, navigationSettings5, savedViewsManager5, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon5 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol5 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon5 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton6 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar6 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton6, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings6 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera6 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 3.7499988429163831D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton6 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton6 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton6 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton6 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton6 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton6 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton6 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar6 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton6)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton6)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton6)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton6)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton6)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton6)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton6))});
            devDept.Eyeshot.Grid grid6 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings6 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings6 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings6 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings6 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager6 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport6 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(420, 375), backgroundSettings6, camera6, new devDept.Eyeshot.ToolBar[] {
            toolBar6}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid6}, false, rotateSettings6, zoomSettings6, panSettings6, navigationSettings6, savedViewsManager6, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon6 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol6 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon6 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton7 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar7 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton7, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings7 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera7 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 3.7499988429163831D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton7 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton7 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton7 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton7 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton7 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton7 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton7 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar7 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton7)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton7)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton7)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton7)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton7)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton7)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton7))});
            devDept.Eyeshot.Grid grid7 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings7 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings7 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings7 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings7 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager7 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport7 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(426, 375), backgroundSettings7, camera7, new devDept.Eyeshot.ToolBar[] {
            toolBar7}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid7}, false, rotateSettings7, zoomSettings7, panSettings7, navigationSettings7, savedViewsManager7, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon7 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol7 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon7 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            devDept.Eyeshot.CancelToolBarButton cancelToolBarButton8 = new devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ProgressBar progressBar8 = new devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Black, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1D, true, cancelToolBarButton8, false, 0.1D, true);
            devDept.Graphics.BackgroundSettings backgroundSettings8 = new devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.LinearGradient, System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))), System.Drawing.Color.DodgerBlue, System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(163)))), ((int)(((byte)(210))))), 0.75D, null, devDept.Graphics.colorThemeType.Auto, 0.33D);
            devDept.Eyeshot.Camera camera8 = new devDept.Eyeshot.Camera(new devDept.Geometry.Point3D(0D, 0D, 45D), 380D, new devDept.Geometry.Quaternion(0.018434349666532526D, 0.039532590434972079D, 0.42221602280006187D, 0.90544518284475428D), devDept.Graphics.projectionType.Perspective, 40D, 5.3399989938439685D, false, 0.001D);
            devDept.Eyeshot.HomeToolBarButton homeToolBarButton8 = new devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.MagnifyingGlassToolBarButton magnifyingGlassToolBarButton8 = new devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomWindowToolBarButton zoomWindowToolBarButton8 = new devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomToolBarButton zoomToolBarButton8 = new devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.PanToolBarButton panToolBarButton8 = new devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.RotateToolBarButton rotateToolBarButton8 = new devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true);
            devDept.Eyeshot.ZoomFitToolBarButton zoomFitToolBarButton8 = new devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true);
            devDept.Eyeshot.ToolBar toolBar8 = new devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, new devDept.Eyeshot.ToolBarButton[] {
            ((devDept.Eyeshot.ToolBarButton)(homeToolBarButton8)),
            ((devDept.Eyeshot.ToolBarButton)(magnifyingGlassToolBarButton8)),
            ((devDept.Eyeshot.ToolBarButton)(zoomWindowToolBarButton8)),
            ((devDept.Eyeshot.ToolBarButton)(zoomToolBarButton8)),
            ((devDept.Eyeshot.ToolBarButton)(panToolBarButton8)),
            ((devDept.Eyeshot.ToolBarButton)(rotateToolBarButton8)),
            ((devDept.Eyeshot.ToolBarButton)(zoomFitToolBarButton8))});
            devDept.Eyeshot.Grid grid8 = new devDept.Eyeshot.Grid(new devDept.Geometry.Point3D(-100D, -100D, 0D), new devDept.Geometry.Point3D(100D, 100D, 0D), 10D, new devDept.Geometry.Plane(new devDept.Geometry.Point3D(0D, 0D, 0D), new devDept.Geometry.Vector3D(0D, 0D, 1D)), System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))), System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255))))));
            devDept.Eyeshot.RotateSettings rotateSettings8 = new devDept.Eyeshot.RotateSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10D, true, 1D, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, new devDept.Geometry.Point3D(0D, 0D, 0D), false);
            devDept.Eyeshot.ZoomSettings zoomSettings8 = new devDept.Eyeshot.ZoomSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1D, System.Drawing.Color.Empty, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true);
            devDept.Eyeshot.PanSettings panSettings8 = new devDept.Eyeshot.PanSettings(new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true);
            devDept.Eyeshot.NavigationSettings navigationSettings8 = new devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, new devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), new devDept.Geometry.Point3D(-1000D, -1000D, -1000D), new devDept.Geometry.Point3D(1000D, 1000D, 1000D), 8D, 50D, 50D);
            devDept.Eyeshot.Viewport.SavedViewsManager savedViewsManager8 = new devDept.Eyeshot.Viewport.SavedViewsManager(8);
            devDept.Eyeshot.Viewport viewport8 = new devDept.Eyeshot.Viewport(new System.Drawing.Point(0, 0), new System.Drawing.Size(1451, 534), backgroundSettings8, camera8, new devDept.Eyeshot.ToolBar[] {
            toolBar8}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, new devDept.Eyeshot.Grid[] {
            grid8}, false, rotateSettings8, zoomSettings8, panSettings8, navigationSettings8, savedViewsManager8, devDept.Eyeshot.viewType.Trimetric);
            devDept.Eyeshot.CoordinateSystemIcon coordinateSystemIcon8 = new devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false);
            devDept.Eyeshot.OriginSymbol originSymbol8 = new devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, null, false);
            devDept.Eyeshot.ViewCubeIcon viewCubeIcon8 = new devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(147))))), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))), 'S', 'N', 'W', 'E', true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, null, null, null, null, null, null, false);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PropeField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.BoltOk = new System.Windows.Forms.Button();
            this.BoltBtn = new System.Windows.Forms.Button();
            this.boltModel = new devDept.Eyeshot.Model();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.GasketProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GasketValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitContainer9 = new System.Windows.Forms.SplitContainer();
            this.GasketOk = new System.Windows.Forms.Button();
            this.GasketBtn = new System.Windows.Forms.Button();
            this.gasketModel = new devDept.Eyeshot.Model();
            this.splitContainer10 = new System.Windows.Forms.SplitContainer();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.NutProp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NutValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer11 = new System.Windows.Forms.SplitContainer();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.splitContainer12 = new System.Windows.Forms.SplitContainer();
            this.NutOk = new System.Windows.Forms.Button();
            this.NutBtn = new System.Windows.Forms.Button();
            this.nutModel = new devDept.Eyeshot.Model();
            this.splitContainer13 = new System.Windows.Forms.SplitContainer();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.model1 = new devDept.Eyeshot.Model();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.myDataSet = new WindowsFormsApp1.myDataSet();
            this.boltBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boltTableAdapter = new WindowsFormsApp1.myDataSetTableAdapters.boltTableAdapter();
            this.boltindexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normalDdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screwPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boltLenlsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boreDdhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boltHeadOutDdwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boltHeadInnerDdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screwMidDd2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screwMinDd3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polishRodLenl1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polishRodLenl2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boltNutSideWidsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boltNutScrewMinDD1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boltModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).BeginInit();
            this.splitContainer9.Panel1.SuspendLayout();
            this.splitContainer9.Panel2.SuspendLayout();
            this.splitContainer9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gasketModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).BeginInit();
            this.splitContainer10.Panel1.SuspendLayout();
            this.splitContainer10.Panel2.SuspendLayout();
            this.splitContainer10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).BeginInit();
            this.splitContainer11.Panel1.SuspendLayout();
            this.splitContainer11.Panel2.SuspendLayout();
            this.splitContainer11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).BeginInit();
            this.splitContainer12.Panel1.SuspendLayout();
            this.splitContainer12.Panel2.SuspendLayout();
            this.splitContainer12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nutModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer13)).BeginInit();
            this.splitContainer13.Panel1.SuspendLayout();
            this.splitContainer13.Panel2.SuspendLayout();
            this.splitContainer13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer13);
            this.splitContainer1.Size = new System.Drawing.Size(1927, 1159);
            this.splitContainer1.SplitterDistance = 621;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1927, 621);
            this.splitContainer2.SplitterDistance = 641;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(641, 621);
            this.splitContainer4.SplitterDistance = 193;
            this.splitContainer4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropeField,
            this.ValueField});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(641, 193);
            this.dataGridView1.TabIndex = 1;
            // 
            // PropeField
            // 
            this.PropeField.HeaderText = "尺寸";
            this.PropeField.Name = "PropeField";
            // 
            // ValueField
            // 
            this.ValueField.HeaderText = "值";
            this.ValueField.Name = "ValueField";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer5.Size = new System.Drawing.Size(641, 424);
            this.splitContainer5.SplitterDistance = 212;
            this.splitContainer5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 424);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.BoltOk);
            this.splitContainer6.Panel1.Controls.Add(this.BoltBtn);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.boltModel);
            this.splitContainer6.Size = new System.Drawing.Size(425, 424);
            this.splitContainer6.SplitterDistance = 44;
            this.splitContainer6.TabIndex = 0;
            // 
            // BoltOk
            // 
            this.BoltOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.BoltOk.Enabled = false;
            this.BoltOk.Location = new System.Drawing.Point(227, 0);
            this.BoltOk.Name = "BoltOk";
            this.BoltOk.Size = new System.Drawing.Size(198, 44);
            this.BoltOk.TabIndex = 0;
            this.BoltOk.Text = "完成";
            this.BoltOk.UseVisualStyleBackColor = true;
            this.BoltOk.Click += new System.EventHandler(this.BoltOk_Click);
            // 
            // BoltBtn
            // 
            this.BoltBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.BoltBtn.Location = new System.Drawing.Point(0, 0);
            this.BoltBtn.Name = "BoltBtn";
            this.BoltBtn.Size = new System.Drawing.Size(207, 44);
            this.BoltBtn.TabIndex = 0;
            this.BoltBtn.Text = "螺栓渲染";
            this.BoltBtn.UseVisualStyleBackColor = true;
            this.BoltBtn.Click += new System.EventHandler(this.BoltBtn_Click);
            // 
            // boltModel
            // 
            this.boltModel.Cursor = System.Windows.Forms.Cursors.Default;
            this.boltModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boltModel.Location = new System.Drawing.Point(0, 0);
            this.boltModel.Name = "boltModel";
            this.boltModel.ProgressBar = progressBar5;
            this.boltModel.Size = new System.Drawing.Size(425, 376);
            this.boltModel.TabIndex = 2;
            this.boltModel.Text = "model2";
            coordinateSystemIcon5.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport5.CoordinateSystemIcon = coordinateSystemIcon5;
            viewport5.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol5.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport5.OriginSymbol = originSymbol5;
            viewCubeIcon5.Font = null;
            viewCubeIcon5.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport5.ViewCubeIcon = viewCubeIcon5;
            this.boltModel.Viewports.Add(viewport5);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer7);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer10);
            this.splitContainer3.Size = new System.Drawing.Size(1282, 621);
            this.splitContainer3.SplitterDistance = 635;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.splitContainer8);
            this.splitContainer7.Size = new System.Drawing.Size(635, 621);
            this.splitContainer7.SplitterDistance = 194;
            this.splitContainer7.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GasketProp,
            this.GasketValue});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(635, 194);
            this.dataGridView2.TabIndex = 1;
            // 
            // GasketProp
            // 
            this.GasketProp.HeaderText = "属性";
            this.GasketProp.Name = "GasketProp";
            // 
            // GasketValue
            // 
            this.GasketValue.HeaderText = "值";
            this.GasketValue.Name = "GasketValue";
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.pictureBox2);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.splitContainer9);
            this.splitContainer8.Size = new System.Drawing.Size(635, 423);
            this.splitContainer8.SplitterDistance = 211;
            this.splitContainer8.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 423);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // splitContainer9
            // 
            this.splitContainer9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer9.Location = new System.Drawing.Point(0, 0);
            this.splitContainer9.Name = "splitContainer9";
            this.splitContainer9.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer9.Panel1
            // 
            this.splitContainer9.Panel1.Controls.Add(this.GasketOk);
            this.splitContainer9.Panel1.Controls.Add(this.GasketBtn);
            // 
            // splitContainer9.Panel2
            // 
            this.splitContainer9.Panel2.Controls.Add(this.gasketModel);
            this.splitContainer9.Size = new System.Drawing.Size(420, 423);
            this.splitContainer9.SplitterDistance = 44;
            this.splitContainer9.TabIndex = 0;
            // 
            // GasketOk
            // 
            this.GasketOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.GasketOk.Enabled = false;
            this.GasketOk.Location = new System.Drawing.Point(222, 0);
            this.GasketOk.Name = "GasketOk";
            this.GasketOk.Size = new System.Drawing.Size(198, 44);
            this.GasketOk.TabIndex = 0;
            this.GasketOk.Text = "完成";
            this.GasketOk.UseVisualStyleBackColor = true;
            this.GasketOk.Click += new System.EventHandler(this.GasketOk_Click);
            // 
            // GasketBtn
            // 
            this.GasketBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.GasketBtn.Location = new System.Drawing.Point(0, 0);
            this.GasketBtn.Name = "GasketBtn";
            this.GasketBtn.Size = new System.Drawing.Size(207, 44);
            this.GasketBtn.TabIndex = 0;
            this.GasketBtn.Text = "垫片渲染";
            this.GasketBtn.UseVisualStyleBackColor = true;
            this.GasketBtn.Click += new System.EventHandler(this.GasketBtn_Click);
            // 
            // gasketModel
            // 
            this.gasketModel.Cursor = System.Windows.Forms.Cursors.Default;
            this.gasketModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gasketModel.Location = new System.Drawing.Point(0, 0);
            this.gasketModel.Name = "gasketModel";
            this.gasketModel.ProgressBar = progressBar6;
            this.gasketModel.Size = new System.Drawing.Size(420, 375);
            this.gasketModel.TabIndex = 2;
            this.gasketModel.Text = "model3";
            coordinateSystemIcon6.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport6.CoordinateSystemIcon = coordinateSystemIcon6;
            viewport6.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol6.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport6.OriginSymbol = originSymbol6;
            viewCubeIcon6.Font = null;
            viewCubeIcon6.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport6.ViewCubeIcon = viewCubeIcon6;
            this.gasketModel.Viewports.Add(viewport6);
            // 
            // splitContainer10
            // 
            this.splitContainer10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer10.Location = new System.Drawing.Point(0, 0);
            this.splitContainer10.Name = "splitContainer10";
            this.splitContainer10.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer10.Panel1
            // 
            this.splitContainer10.Panel1.Controls.Add(this.dataGridView3);
            // 
            // splitContainer10.Panel2
            // 
            this.splitContainer10.Panel2.Controls.Add(this.splitContainer11);
            this.splitContainer10.Size = new System.Drawing.Size(643, 621);
            this.splitContainer10.SplitterDistance = 194;
            this.splitContainer10.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NutProp,
            this.NutValue});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(643, 194);
            this.dataGridView3.TabIndex = 1;
            // 
            // NutProp
            // 
            this.NutProp.HeaderText = "属性";
            this.NutProp.Name = "NutProp";
            // 
            // NutValue
            // 
            this.NutValue.HeaderText = "值";
            this.NutValue.Name = "NutValue";
            // 
            // splitContainer11
            // 
            this.splitContainer11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer11.Location = new System.Drawing.Point(0, 0);
            this.splitContainer11.Name = "splitContainer11";
            // 
            // splitContainer11.Panel1
            // 
            this.splitContainer11.Panel1.Controls.Add(this.pictureBox3);
            // 
            // splitContainer11.Panel2
            // 
            this.splitContainer11.Panel2.Controls.Add(this.splitContainer12);
            this.splitContainer11.Size = new System.Drawing.Size(643, 423);
            this.splitContainer11.SplitterDistance = 213;
            this.splitContainer11.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(213, 423);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // splitContainer12
            // 
            this.splitContainer12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer12.Location = new System.Drawing.Point(0, 0);
            this.splitContainer12.Name = "splitContainer12";
            this.splitContainer12.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer12.Panel1
            // 
            this.splitContainer12.Panel1.Controls.Add(this.NutOk);
            this.splitContainer12.Panel1.Controls.Add(this.NutBtn);
            // 
            // splitContainer12.Panel2
            // 
            this.splitContainer12.Panel2.Controls.Add(this.nutModel);
            this.splitContainer12.Size = new System.Drawing.Size(426, 423);
            this.splitContainer12.SplitterDistance = 44;
            this.splitContainer12.TabIndex = 0;
            // 
            // NutOk
            // 
            this.NutOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.NutOk.Enabled = false;
            this.NutOk.Location = new System.Drawing.Point(228, 0);
            this.NutOk.Name = "NutOk";
            this.NutOk.Size = new System.Drawing.Size(198, 44);
            this.NutOk.TabIndex = 0;
            this.NutOk.Text = "完成";
            this.NutOk.UseVisualStyleBackColor = true;
            this.NutOk.Click += new System.EventHandler(this.NutOk_Click);
            // 
            // NutBtn
            // 
            this.NutBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.NutBtn.Location = new System.Drawing.Point(0, 0);
            this.NutBtn.Name = "NutBtn";
            this.NutBtn.Size = new System.Drawing.Size(207, 44);
            this.NutBtn.TabIndex = 0;
            this.NutBtn.Text = "螺母渲染";
            this.NutBtn.UseVisualStyleBackColor = true;
            this.NutBtn.Click += new System.EventHandler(this.NutBtn_Click);
            // 
            // nutModel
            // 
            this.nutModel.Cursor = System.Windows.Forms.Cursors.Default;
            this.nutModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nutModel.Location = new System.Drawing.Point(0, 0);
            this.nutModel.Name = "nutModel";
            this.nutModel.ProgressBar = progressBar7;
            this.nutModel.Size = new System.Drawing.Size(426, 375);
            this.nutModel.TabIndex = 2;
            this.nutModel.Text = "model4";
            coordinateSystemIcon7.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport7.CoordinateSystemIcon = coordinateSystemIcon7;
            viewport7.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol7.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport7.OriginSymbol = originSymbol7;
            viewCubeIcon7.Font = null;
            viewCubeIcon7.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport7.ViewCubeIcon = viewCubeIcon7;
            this.nutModel.Viewports.Add(viewport7);
            // 
            // splitContainer13
            // 
            this.splitContainer13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer13.Location = new System.Drawing.Point(0, 0);
            this.splitContainer13.Name = "splitContainer13";
            // 
            // splitContainer13.Panel1
            // 
            this.splitContainer13.Panel1.Controls.Add(this.dataGridView4);
            this.splitContainer13.Panel1.Controls.Add(this.cancelBtn);
            this.splitContainer13.Panel1.Controls.Add(this.clearBtn);
            this.splitContainer13.Panel1.Controls.Add(this.addBtn);
            // 
            // splitContainer13.Panel2
            // 
            this.splitContainer13.Panel2.Controls.Add(this.model1);
            this.splitContainer13.Size = new System.Drawing.Size(1927, 534);
            this.splitContainer13.SplitterDistance = 472;
            this.splitContainer13.TabIndex = 0;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.cancelBtn.Location = new System.Drawing.Point(0, 84);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(472, 42);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "取消";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearBtn.Location = new System.Drawing.Point(0, 42);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(472, 42);
            this.clearBtn.TabIndex = 3;
            this.clearBtn.Text = "清除";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addBtn.Location = new System.Drawing.Point(0, 0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(472, 42);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "添加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // model1
            // 
            this.model1.Cursor = System.Windows.Forms.Cursors.Default;
            this.model1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.model1.Location = new System.Drawing.Point(0, 0);
            this.model1.Name = "model1";
            this.model1.ProgressBar = progressBar8;
            this.model1.Size = new System.Drawing.Size(1451, 534);
            this.model1.TabIndex = 2;
            this.model1.Text = "model1";
            coordinateSystemIcon8.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport8.CoordinateSystemIcon = coordinateSystemIcon8;
            viewport8.Legends = new devDept.Eyeshot.Legend[0];
            originSymbol8.LabelFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            viewport8.OriginSymbol = originSymbol8;
            viewCubeIcon8.Font = null;
            viewCubeIcon8.InitialRotation = new devDept.Geometry.Quaternion(0D, 0D, 0D, 1D);
            viewport8.ViewCubeIcon = viewCubeIcon8;
            this.model1.Viewports.Add(viewport8);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.boltindexDataGridViewTextBoxColumn,
            this.normalDdDataGridViewTextBoxColumn,
            this.screwPPDataGridViewTextBoxColumn,
            this.boltLenlsDataGridViewTextBoxColumn,
            this.boreDdhDataGridViewTextBoxColumn,
            this.dTDataGridViewTextBoxColumn,
            this.boltHeadOutDdwDataGridViewTextBoxColumn,
            this.boltHeadInnerDdaDataGridViewTextBoxColumn,
            this.screwMidDd2DataGridViewTextBoxColumn,
            this.screwMinDd3DataGridViewTextBoxColumn,
            this.polishRodLenl1DataGridViewTextBoxColumn,
            this.polishRodLenl2DataGridViewTextBoxColumn,
            this.boltNutSideWidsDataGridViewTextBoxColumn,
            this.boltNutScrewMinDD1DataGridViewTextBoxColumn});
            this.dataGridView4.DataSource = this.boltBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(173, 176);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(240, 150);
            this.dataGridView4.TabIndex = 4;
            // 
            // myDataSet
            // 
            this.myDataSet.DataSetName = "myDataSet";
            this.myDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boltBindingSource
            // 
            this.boltBindingSource.DataMember = "bolt";
            this.boltBindingSource.DataSource = this.myDataSet;
            // 
            // boltTableAdapter
            // 
            this.boltTableAdapter.ClearBeforeFill = true;
            // 
            // boltindexDataGridViewTextBoxColumn
            // 
            this.boltindexDataGridViewTextBoxColumn.DataPropertyName = "boltindex";
            this.boltindexDataGridViewTextBoxColumn.HeaderText = "boltindex";
            this.boltindexDataGridViewTextBoxColumn.Name = "boltindexDataGridViewTextBoxColumn";
            // 
            // normalDdDataGridViewTextBoxColumn
            // 
            this.normalDdDataGridViewTextBoxColumn.DataPropertyName = "normalD_d";
            this.normalDdDataGridViewTextBoxColumn.HeaderText = "normalD_d";
            this.normalDdDataGridViewTextBoxColumn.Name = "normalDdDataGridViewTextBoxColumn";
            // 
            // screwPPDataGridViewTextBoxColumn
            // 
            this.screwPPDataGridViewTextBoxColumn.DataPropertyName = "screwP_P";
            this.screwPPDataGridViewTextBoxColumn.HeaderText = "screwP_P";
            this.screwPPDataGridViewTextBoxColumn.Name = "screwPPDataGridViewTextBoxColumn";
            // 
            // boltLenlsDataGridViewTextBoxColumn
            // 
            this.boltLenlsDataGridViewTextBoxColumn.DataPropertyName = "boltLen_ls";
            this.boltLenlsDataGridViewTextBoxColumn.HeaderText = "boltLen_ls";
            this.boltLenlsDataGridViewTextBoxColumn.Name = "boltLenlsDataGridViewTextBoxColumn";
            // 
            // boreDdhDataGridViewTextBoxColumn
            // 
            this.boreDdhDataGridViewTextBoxColumn.DataPropertyName = "boreD_dh";
            this.boreDdhDataGridViewTextBoxColumn.HeaderText = "boreD_dh";
            this.boreDdhDataGridViewTextBoxColumn.Name = "boreDdhDataGridViewTextBoxColumn";
            // 
            // dTDataGridViewTextBoxColumn
            // 
            this.dTDataGridViewTextBoxColumn.DataPropertyName = "dT";
            this.dTDataGridViewTextBoxColumn.HeaderText = "dT";
            this.dTDataGridViewTextBoxColumn.Name = "dTDataGridViewTextBoxColumn";
            // 
            // boltHeadOutDdwDataGridViewTextBoxColumn
            // 
            this.boltHeadOutDdwDataGridViewTextBoxColumn.DataPropertyName = "boltHeadOutD_dw";
            this.boltHeadOutDdwDataGridViewTextBoxColumn.HeaderText = "boltHeadOutD_dw";
            this.boltHeadOutDdwDataGridViewTextBoxColumn.Name = "boltHeadOutDdwDataGridViewTextBoxColumn";
            // 
            // boltHeadInnerDdaDataGridViewTextBoxColumn
            // 
            this.boltHeadInnerDdaDataGridViewTextBoxColumn.DataPropertyName = "boltHeadInnerD_da";
            this.boltHeadInnerDdaDataGridViewTextBoxColumn.HeaderText = "boltHeadInnerD_da";
            this.boltHeadInnerDdaDataGridViewTextBoxColumn.Name = "boltHeadInnerDdaDataGridViewTextBoxColumn";
            // 
            // screwMidDd2DataGridViewTextBoxColumn
            // 
            this.screwMidDd2DataGridViewTextBoxColumn.DataPropertyName = "screwMidD_d2";
            this.screwMidDd2DataGridViewTextBoxColumn.HeaderText = "screwMidD_d2";
            this.screwMidDd2DataGridViewTextBoxColumn.Name = "screwMidDd2DataGridViewTextBoxColumn";
            // 
            // screwMinDd3DataGridViewTextBoxColumn
            // 
            this.screwMinDd3DataGridViewTextBoxColumn.DataPropertyName = "screwMinD_d3";
            this.screwMinDd3DataGridViewTextBoxColumn.HeaderText = "screwMinD_d3";
            this.screwMinDd3DataGridViewTextBoxColumn.Name = "screwMinDd3DataGridViewTextBoxColumn";
            // 
            // polishRodLenl1DataGridViewTextBoxColumn
            // 
            this.polishRodLenl1DataGridViewTextBoxColumn.DataPropertyName = "polishRodLen_l1";
            this.polishRodLenl1DataGridViewTextBoxColumn.HeaderText = "polishRodLen_l1";
            this.polishRodLenl1DataGridViewTextBoxColumn.Name = "polishRodLenl1DataGridViewTextBoxColumn";
            // 
            // polishRodLenl2DataGridViewTextBoxColumn
            // 
            this.polishRodLenl2DataGridViewTextBoxColumn.DataPropertyName = "polishRodLen_l2";
            this.polishRodLenl2DataGridViewTextBoxColumn.HeaderText = "polishRodLen_l2";
            this.polishRodLenl2DataGridViewTextBoxColumn.Name = "polishRodLenl2DataGridViewTextBoxColumn";
            // 
            // boltNutSideWidsDataGridViewTextBoxColumn
            // 
            this.boltNutSideWidsDataGridViewTextBoxColumn.DataPropertyName = "boltNutSideWid_s";
            this.boltNutSideWidsDataGridViewTextBoxColumn.HeaderText = "boltNutSideWid_s";
            this.boltNutSideWidsDataGridViewTextBoxColumn.Name = "boltNutSideWidsDataGridViewTextBoxColumn";
            // 
            // boltNutScrewMinDD1DataGridViewTextBoxColumn
            // 
            this.boltNutScrewMinDD1DataGridViewTextBoxColumn.DataPropertyName = "boltNutScrewMinD_D1";
            this.boltNutScrewMinDD1DataGridViewTextBoxColumn.HeaderText = "boltNutScrewMinD_D1";
            this.boltNutScrewMinDD1DataGridViewTextBoxColumn.Name = "boltNutScrewMinDD1DataGridViewTextBoxColumn";
            // 
            // SelfDefLuoshaunlianjieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1927, 1159);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SelfDefLuoshaunlianjieForm";
            this.Text = "SelfDefLuoshaunlianjieForm";
            this.Load += new System.EventHandler(this.SelfDefLuoshaunlianjieForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.boltModel)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer9.Panel1.ResumeLayout(false);
            this.splitContainer9.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer9)).EndInit();
            this.splitContainer9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gasketModel)).EndInit();
            this.splitContainer10.Panel1.ResumeLayout(false);
            this.splitContainer10.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer10)).EndInit();
            this.splitContainer10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.splitContainer11.Panel1.ResumeLayout(false);
            this.splitContainer11.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer11)).EndInit();
            this.splitContainer11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.splitContainer12.Panel1.ResumeLayout(false);
            this.splitContainer12.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer12)).EndInit();
            this.splitContainer12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nutModel)).EndInit();
            this.splitContainer13.Panel1.ResumeLayout(false);
            this.splitContainer13.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer13)).EndInit();
            this.splitContainer13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boltBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.Button BoltOk;
        private System.Windows.Forms.Button BoltBtn;
        private devDept.Eyeshot.Model boltModel;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.SplitContainer splitContainer9;
        private System.Windows.Forms.Button GasketOk;
        private System.Windows.Forms.Button GasketBtn;
        private devDept.Eyeshot.Model gasketModel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SplitContainer splitContainer10;
        private System.Windows.Forms.SplitContainer splitContainer11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.SplitContainer splitContainer12;
        private System.Windows.Forms.Button NutOk;
        private System.Windows.Forms.Button NutBtn;
        private devDept.Eyeshot.Model nutModel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropeField;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueField;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.SplitContainer splitContainer13;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button addBtn;
        private devDept.Eyeshot.Model model1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GasketProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn GasketValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn NutProp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NutValue;
        private System.Windows.Forms.DataGridView dataGridView4;
        private myDataSet myDataSet;
        private System.Windows.Forms.BindingSource boltBindingSource;
        private myDataSetTableAdapters.boltTableAdapter boltTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltindexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normalDdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screwPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltLenlsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boreDdhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltHeadOutDdwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltHeadInnerDdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screwMidDd2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screwMinDd3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polishRodLenl1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polishRodLenl2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltNutSideWidsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boltNutScrewMinDD1DataGridViewTextBoxColumn;
    }
}