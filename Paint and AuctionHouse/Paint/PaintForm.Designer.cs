namespace Paint
{
    partial class PaintForm
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
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.panelTools = new System.Windows.Forms.Panel();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnStraightLine = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.panelColors = new System.Windows.Forms.Panel();
            this.lightPurpleColor = new System.Windows.Forms.PictureBox();
            this.lightBlueColor = new System.Windows.Forms.PictureBox();
            this.lightTeelColor = new System.Windows.Forms.PictureBox();
            this.lightGreenColor = new System.Windows.Forms.PictureBox();
            this.lightYellowColor = new System.Windows.Forms.PictureBox();
            this.lightOrangeColor = new System.Windows.Forms.PictureBox();
            this.pinkColor = new System.Windows.Forms.PictureBox();
            this.brownColor = new System.Windows.Forms.PictureBox();
            this.lightGreyColor = new System.Windows.Forms.PictureBox();
            this.blackColor = new System.Windows.Forms.PictureBox();
            this.purpleColor = new System.Windows.Forms.PictureBox();
            this.blueColor = new System.Windows.Forms.PictureBox();
            this.teelColor = new System.Windows.Forms.PictureBox();
            this.greenColor = new System.Windows.Forms.PictureBox();
            this.yellowColor = new System.Windows.Forms.PictureBox();
            this.orangeColor = new System.Windows.Forms.PictureBox();
            this.RedColor = new System.Windows.Forms.PictureBox();
            this.darkRedColor = new System.Windows.Forms.PictureBox();
            this.darkGreyColor = new System.Windows.Forms.PictureBox();
            this.whiteColor = new System.Windows.Forms.PictureBox();
            this.panelSelectedColor = new System.Windows.Forms.Panel();
            this.selectedColor = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnInsert = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTools.SuspendLayout();
            this.panelColors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lightPurpleColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBlueColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightTeelColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightGreenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightYellowColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOrangeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightGreyColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teelColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkRedColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkGreyColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteColor)).BeginInit();
            this.panelSelectedColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCanvas
            // 
            this.panelCanvas.AutoScroll = true;
            this.panelCanvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCanvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCanvas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelCanvas.Location = new System.Drawing.Point(76, 98);
            this.panelCanvas.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.panelCanvas.MinimumSize = new System.Drawing.Size(350, 200);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Padding = new System.Windows.Forms.Padding(1);
            this.panelCanvas.Size = new System.Drawing.Size(561, 361);
            this.panelCanvas.TabIndex = 0;
            this.panelCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCanvas_Paint);
            this.panelCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelCanvas_MouseDown);
            this.panelCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelCanvas_MouseMove);
            this.panelCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelCanvas_MouseUp);
            // 
            // panelTools
            // 
            this.panelTools.Controls.Add(this.btnMinus);
            this.panelTools.Controls.Add(this.btnPlus);
            this.panelTools.Controls.Add(this.btnCircle);
            this.panelTools.Controls.Add(this.btnRectangle);
            this.panelTools.Controls.Add(this.btnStraightLine);
            this.panelTools.Controls.Add(this.btnEraser);
            this.panelTools.Controls.Add(this.btnPencil);
            this.panelTools.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelTools.Location = new System.Drawing.Point(12, 98);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(54, 201);
            this.panelTools.TabIndex = 1;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(3, 165);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(24, 24);
            this.btnMinus.TabIndex = 6;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(27, 165);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(24, 24);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircle.Location = new System.Drawing.Point(0, 120);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(54, 24);
            this.btnCircle.TabIndex = 4;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRectangle.Location = new System.Drawing.Point(0, 90);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(54, 24);
            this.btnRectangle.TabIndex = 3;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            // 
            // btnStraightLine
            // 
            this.btnStraightLine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnStraightLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStraightLine.Location = new System.Drawing.Point(0, 60);
            this.btnStraightLine.Name = "btnStraightLine";
            this.btnStraightLine.Size = new System.Drawing.Size(54, 24);
            this.btnStraightLine.TabIndex = 2;
            this.btnStraightLine.Text = "Line";
            this.btnStraightLine.UseVisualStyleBackColor = true;
            this.btnStraightLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Location = new System.Drawing.Point(0, 30);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(54, 24);
            this.btnEraser.TabIndex = 1;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Location = new System.Drawing.Point(0, 0);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(54, 24);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttons_Click);
            // 
            // panelColors
            // 
            this.panelColors.BackColor = System.Drawing.SystemColors.Control;
            this.panelColors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColors.Controls.Add(this.lightPurpleColor);
            this.panelColors.Controls.Add(this.lightBlueColor);
            this.panelColors.Controls.Add(this.lightTeelColor);
            this.panelColors.Controls.Add(this.lightGreenColor);
            this.panelColors.Controls.Add(this.lightYellowColor);
            this.panelColors.Controls.Add(this.lightOrangeColor);
            this.panelColors.Controls.Add(this.pinkColor);
            this.panelColors.Controls.Add(this.brownColor);
            this.panelColors.Controls.Add(this.lightGreyColor);
            this.panelColors.Controls.Add(this.blackColor);
            this.panelColors.Controls.Add(this.purpleColor);
            this.panelColors.Controls.Add(this.blueColor);
            this.panelColors.Controls.Add(this.teelColor);
            this.panelColors.Controls.Add(this.greenColor);
            this.panelColors.Controls.Add(this.yellowColor);
            this.panelColors.Controls.Add(this.orangeColor);
            this.panelColors.Controls.Add(this.RedColor);
            this.panelColors.Controls.Add(this.darkRedColor);
            this.panelColors.Controls.Add(this.darkGreyColor);
            this.panelColors.Controls.Add(this.whiteColor);
            this.panelColors.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelColors.Location = new System.Drawing.Point(76, 33);
            this.panelColors.Name = "panelColors";
            this.panelColors.Size = new System.Drawing.Size(261, 54);
            this.panelColors.TabIndex = 2;
            // 
            // lightPurpleColor
            // 
            this.lightPurpleColor.BackColor = System.Drawing.Color.Thistle;
            this.lightPurpleColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lightPurpleColor.Location = new System.Drawing.Point(237, 29);
            this.lightPurpleColor.Name = "lightPurpleColor";
            this.lightPurpleColor.Size = new System.Drawing.Size(20, 20);
            this.lightPurpleColor.TabIndex = 19;
            this.lightPurpleColor.TabStop = false;
            this.lightPurpleColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // lightBlueColor
            // 
            this.lightBlueColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lightBlueColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lightBlueColor.Location = new System.Drawing.Point(211, 29);
            this.lightBlueColor.Name = "lightBlueColor";
            this.lightBlueColor.Size = new System.Drawing.Size(20, 20);
            this.lightBlueColor.TabIndex = 18;
            this.lightBlueColor.TabStop = false;
            this.lightBlueColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // lightTeelColor
            // 
            this.lightTeelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lightTeelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lightTeelColor.Location = new System.Drawing.Point(185, 29);
            this.lightTeelColor.Name = "lightTeelColor";
            this.lightTeelColor.Size = new System.Drawing.Size(20, 20);
            this.lightTeelColor.TabIndex = 17;
            this.lightTeelColor.TabStop = false;
            this.lightTeelColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // lightGreenColor
            // 
            this.lightGreenColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lightGreenColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lightGreenColor.Location = new System.Drawing.Point(159, 29);
            this.lightGreenColor.Name = "lightGreenColor";
            this.lightGreenColor.Size = new System.Drawing.Size(20, 20);
            this.lightGreenColor.TabIndex = 16;
            this.lightGreenColor.TabStop = false;
            this.lightGreenColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // lightYellowColor
            // 
            this.lightYellowColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lightYellowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lightYellowColor.Location = new System.Drawing.Point(133, 29);
            this.lightYellowColor.Name = "lightYellowColor";
            this.lightYellowColor.Size = new System.Drawing.Size(20, 20);
            this.lightYellowColor.TabIndex = 15;
            this.lightYellowColor.TabStop = false;
            this.lightYellowColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // lightOrangeColor
            // 
            this.lightOrangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lightOrangeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lightOrangeColor.Location = new System.Drawing.Point(107, 29);
            this.lightOrangeColor.Name = "lightOrangeColor";
            this.lightOrangeColor.Size = new System.Drawing.Size(20, 20);
            this.lightOrangeColor.TabIndex = 14;
            this.lightOrangeColor.TabStop = false;
            this.lightOrangeColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // pinkColor
            // 
            this.pinkColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pinkColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pinkColor.Location = new System.Drawing.Point(81, 29);
            this.pinkColor.Name = "pinkColor";
            this.pinkColor.Size = new System.Drawing.Size(20, 20);
            this.pinkColor.TabIndex = 13;
            this.pinkColor.TabStop = false;
            this.pinkColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // brownColor
            // 
            this.brownColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.brownColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.brownColor.Location = new System.Drawing.Point(55, 29);
            this.brownColor.Name = "brownColor";
            this.brownColor.Size = new System.Drawing.Size(20, 20);
            this.brownColor.TabIndex = 12;
            this.brownColor.TabStop = false;
            this.brownColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // lightGreyColor
            // 
            this.lightGreyColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lightGreyColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lightGreyColor.Location = new System.Drawing.Point(29, 29);
            this.lightGreyColor.Name = "lightGreyColor";
            this.lightGreyColor.Size = new System.Drawing.Size(20, 20);
            this.lightGreyColor.TabIndex = 11;
            this.lightGreyColor.TabStop = false;
            this.lightGreyColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // blackColor
            // 
            this.blackColor.BackColor = System.Drawing.Color.Black;
            this.blackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blackColor.Location = new System.Drawing.Point(3, 3);
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(20, 20);
            this.blackColor.TabIndex = 10;
            this.blackColor.TabStop = false;
            this.blackColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // purpleColor
            // 
            this.purpleColor.BackColor = System.Drawing.Color.Purple;
            this.purpleColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purpleColor.Location = new System.Drawing.Point(237, 3);
            this.purpleColor.Name = "purpleColor";
            this.purpleColor.Size = new System.Drawing.Size(20, 20);
            this.purpleColor.TabIndex = 9;
            this.purpleColor.TabStop = false;
            this.purpleColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // blueColor
            // 
            this.blueColor.BackColor = System.Drawing.Color.Navy;
            this.blueColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blueColor.Location = new System.Drawing.Point(211, 3);
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(20, 20);
            this.blueColor.TabIndex = 8;
            this.blueColor.TabStop = false;
            this.blueColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // teelColor
            // 
            this.teelColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.teelColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.teelColor.Location = new System.Drawing.Point(185, 3);
            this.teelColor.Name = "teelColor";
            this.teelColor.Size = new System.Drawing.Size(20, 20);
            this.teelColor.TabIndex = 7;
            this.teelColor.TabStop = false;
            this.teelColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // greenColor
            // 
            this.greenColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.greenColor.Location = new System.Drawing.Point(159, 3);
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(20, 20);
            this.greenColor.TabIndex = 6;
            this.greenColor.TabStop = false;
            this.greenColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // yellowColor
            // 
            this.yellowColor.BackColor = System.Drawing.Color.Yellow;
            this.yellowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.yellowColor.Location = new System.Drawing.Point(133, 3);
            this.yellowColor.Name = "yellowColor";
            this.yellowColor.Size = new System.Drawing.Size(20, 20);
            this.yellowColor.TabIndex = 5;
            this.yellowColor.TabStop = false;
            this.yellowColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // orangeColor
            // 
            this.orangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orangeColor.Location = new System.Drawing.Point(107, 3);
            this.orangeColor.Name = "orangeColor";
            this.orangeColor.Size = new System.Drawing.Size(20, 20);
            this.orangeColor.TabIndex = 4;
            this.orangeColor.TabStop = false;
            this.orangeColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // RedColor
            // 
            this.RedColor.BackColor = System.Drawing.Color.Red;
            this.RedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RedColor.Location = new System.Drawing.Point(81, 3);
            this.RedColor.Name = "RedColor";
            this.RedColor.Size = new System.Drawing.Size(20, 20);
            this.RedColor.TabIndex = 3;
            this.RedColor.TabStop = false;
            this.RedColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // darkRedColor
            // 
            this.darkRedColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.darkRedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.darkRedColor.Location = new System.Drawing.Point(55, 3);
            this.darkRedColor.Name = "darkRedColor";
            this.darkRedColor.Size = new System.Drawing.Size(20, 20);
            this.darkRedColor.TabIndex = 2;
            this.darkRedColor.TabStop = false;
            this.darkRedColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // darkGreyColor
            // 
            this.darkGreyColor.BackColor = System.Drawing.Color.Gray;
            this.darkGreyColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.darkGreyColor.Location = new System.Drawing.Point(29, 3);
            this.darkGreyColor.Name = "darkGreyColor";
            this.darkGreyColor.Size = new System.Drawing.Size(20, 20);
            this.darkGreyColor.TabIndex = 1;
            this.darkGreyColor.TabStop = false;
            this.darkGreyColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // whiteColor
            // 
            this.whiteColor.BackColor = System.Drawing.Color.White;
            this.whiteColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.whiteColor.Location = new System.Drawing.Point(3, 29);
            this.whiteColor.Name = "whiteColor";
            this.whiteColor.Size = new System.Drawing.Size(20, 20);
            this.whiteColor.TabIndex = 0;
            this.whiteColor.TabStop = false;
            this.whiteColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelColors_MouseClick);
            // 
            // panelSelectedColor
            // 
            this.panelSelectedColor.Controls.Add(this.selectedColor);
            this.panelSelectedColor.Location = new System.Drawing.Point(12, 33);
            this.panelSelectedColor.Name = "panelSelectedColor";
            this.panelSelectedColor.Size = new System.Drawing.Size(54, 54);
            this.panelSelectedColor.TabIndex = 3;
            // 
            // selectedColor
            // 
            this.selectedColor.BackColor = System.Drawing.Color.Black;
            this.selectedColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.selectedColor.Location = new System.Drawing.Point(10, 10);
            this.selectedColor.Name = "selectedColor";
            this.selectedColor.Size = new System.Drawing.Size(35, 35);
            this.selectedColor.TabIndex = 0;
            this.selectedColor.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnFile,
            this.mnEdit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(656, 28);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // mnFile
            // 
            this.mnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnNew,
            this.mnSave,
            this.toolStripMenuItem1,
            this.mnQuit});
            this.mnFile.Name = "mnFile";
            this.mnFile.Size = new System.Drawing.Size(46, 24);
            this.mnFile.Text = "&File";
            // 
            // mnNew
            // 
            this.mnNew.Name = "mnNew";
            this.mnNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnNew.Size = new System.Drawing.Size(175, 26);
            this.mnNew.Text = "&New";
            this.mnNew.Click += new System.EventHandler(this.MnNew_Click);
            // 
            // mnSave
            // 
            this.mnSave.Name = "mnSave";
            this.mnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnSave.Size = new System.Drawing.Size(175, 26);
            this.mnSave.Text = "&Save";
            this.mnSave.Click += new System.EventHandler(this.MnSave_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(172, 6);
            // 
            // mnQuit
            // 
            this.mnQuit.Name = "mnQuit";
            this.mnQuit.Size = new System.Drawing.Size(175, 26);
            this.mnQuit.Text = "&Quit";
            this.mnQuit.Click += new System.EventHandler(this.MnQuit_Click);
            // 
            // mnEdit
            // 
            this.mnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnUndo,
            this.mnInsert});
            this.mnEdit.Name = "mnEdit";
            this.mnEdit.Size = new System.Drawing.Size(49, 24);
            this.mnEdit.Text = "&Edit";
            // 
            // mnUndo
            // 
            this.mnUndo.Name = "mnUndo";
            this.mnUndo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnUndo.Size = new System.Drawing.Size(179, 26);
            this.mnUndo.Text = "&Undo";
            this.mnUndo.Click += new System.EventHandler(this.MnUndo_Click);
            // 
            // mnInsert
            // 
            this.mnInsert.Name = "mnInsert";
            this.mnInsert.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnInsert.Size = new System.Drawing.Size(179, 26);
            this.mnInsert.Text = "&Insert ";
            this.mnInsert.Click += new System.EventHandler(this.MnInsert_Click);
            // 
            // PaintForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(656, 474);
            this.Controls.Add(this.panelSelectedColor);
            this.Controls.Add(this.panelColors);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "PaintForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTools.ResumeLayout(false);
            this.panelColors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lightPurpleColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightBlueColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightTeelColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightGreenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightYellowColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightOrangeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brownColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightGreyColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blackColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purpleColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teelColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkRedColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.darkGreyColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whiteColor)).EndInit();
            this.panelSelectedColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectedColor)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Panel panelColors;
        private System.Windows.Forms.PictureBox lightPurpleColor;
        private System.Windows.Forms.PictureBox lightBlueColor;
        private System.Windows.Forms.PictureBox lightTeelColor;
        private System.Windows.Forms.PictureBox lightGreenColor;
        private System.Windows.Forms.PictureBox lightYellowColor;
        private System.Windows.Forms.PictureBox lightOrangeColor;
        private System.Windows.Forms.PictureBox pinkColor;
        private System.Windows.Forms.PictureBox brownColor;
        private System.Windows.Forms.PictureBox lightGreyColor;
        private System.Windows.Forms.PictureBox blackColor;
        private System.Windows.Forms.PictureBox purpleColor;
        private System.Windows.Forms.PictureBox blueColor;
        private System.Windows.Forms.PictureBox teelColor;
        private System.Windows.Forms.PictureBox greenColor;
        private System.Windows.Forms.PictureBox yellowColor;
        private System.Windows.Forms.PictureBox orangeColor;
        private System.Windows.Forms.PictureBox RedColor;
        private System.Windows.Forms.PictureBox darkRedColor;
        private System.Windows.Forms.PictureBox darkGreyColor;
        private System.Windows.Forms.PictureBox whiteColor;
        private System.Windows.Forms.Panel panelSelectedColor;
        private System.Windows.Forms.PictureBox selectedColor;
        private System.Windows.Forms.Button btnStraightLine;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnFile;
        private System.Windows.Forms.ToolStripMenuItem mnNew;
        private System.Windows.Forms.ToolStripMenuItem mnSave;
        private System.Windows.Forms.ToolStripMenuItem mnEdit;
        private System.Windows.Forms.ToolStripMenuItem mnUndo;
        private System.Windows.Forms.ToolStripMenuItem mnInsert;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnQuit;
    }
}

