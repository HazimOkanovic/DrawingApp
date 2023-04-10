namespace DrawingApp
{
    partial class Paint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            color_picker = new PictureBox();
            pic_color = new Button();
            panel4 = new Panel();
            btn_save = new Button();
            btn_clear = new Button();
            btn_line = new Button();
            btn_color = new Button();
            btn_rect = new Button();
            btn_fill = new Button();
            btn_ellipse = new Button();
            btn_pencil = new Button();
            btn_eraser = new Button();
            pic = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pic);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DimGray;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 435);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 15);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(color_picker);
            panel2.Controls.Add(pic_color);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 0;
            // 
            // color_picker
            // 
            color_picker.Cursor = Cursors.Hand;
            color_picker.Image = Properties.Resources.color_palette;
            color_picker.Location = new Point(3, 0);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(291, 98);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 9;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(300, 36);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(24, 27);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(btn_save);
            panel4.Controls.Add(btn_clear);
            panel4.Controls.Add(btn_line);
            panel4.Controls.Add(btn_color);
            panel4.Controls.Add(btn_rect);
            panel4.Controls.Add(btn_fill);
            panel4.Controls.Add(btn_ellipse);
            panel4.Controls.Add(btn_pencil);
            panel4.Controls.Add(btn_eraser);
            panel4.Location = new Point(330, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(537, 69);
            panel4.TabIndex = 8;
            // 
            // btn_save
            // 
            btn_save.Cursor = Cursors.Hand;
            btn_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_save.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.ImageAlign = ContentAlignment.TopCenter;
            btn_save.Location = new Point(478, 4);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(56, 25);
            btn_save.TabIndex = 10;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.Cursor = Cursors.Hand;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_clear.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.ImageAlign = ContentAlignment.TopCenter;
            btn_clear.Location = new Point(478, 35);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(56, 27);
            btn_clear.TabIndex = 8;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_line
            // 
            btn_line.Cursor = Cursors.Hand;
            btn_line.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_line.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.White;
            btn_line.Image = Properties.Resources.line;
            btn_line.ImageAlign = ContentAlignment.TopCenter;
            btn_line.Location = new Point(408, 4);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(64, 59);
            btn_line.TabIndex = 7;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = true;
            btn_line.Click += btn_line_Click;
            // 
            // btn_color
            // 
            btn_color.Cursor = Cursors.Hand;
            btn_color.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_color.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.Image = Properties.Resources.color;
            btn_color.ImageAlign = ContentAlignment.TopCenter;
            btn_color.Location = new Point(7, 4);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(54, 60);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = true;
            btn_color.Click += btn_color_Click;
            // 
            // btn_rect
            // 
            btn_rect.Cursor = Cursors.Hand;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_rect.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.White;
            btn_rect.Image = Properties.Resources.rectangle;
            btn_rect.ImageAlign = ContentAlignment.TopCenter;
            btn_rect.Location = new Point(333, 3);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(69, 59);
            btn_rect.TabIndex = 6;
            btn_rect.Text = "Rectangle";
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = true;
            btn_rect.Click += btn_rect_Click;
            // 
            // btn_fill
            // 
            btn_fill.Cursor = Cursors.Hand;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_fill.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.White;
            btn_fill.Image = Properties.Resources.bucket;
            btn_fill.ImageAlign = ContentAlignment.TopCenter;
            btn_fill.Location = new Point(67, 4);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(58, 59);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = true;
            btn_fill.Click += btn_fill_Click;
            // 
            // btn_ellipse
            // 
            btn_ellipse.Cursor = Cursors.Hand;
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = Color.White;
            btn_ellipse.Image = Properties.Resources.circle;
            btn_ellipse.ImageAlign = ContentAlignment.TopCenter;
            btn_ellipse.Location = new Point(263, 4);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(64, 59);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.Text = "Ellipse";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = true;
            btn_ellipse.Click += btn_ellipse_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.Cursor = Cursors.Hand;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.White;
            btn_pencil.Image = Properties.Resources.pencil;
            btn_pencil.ImageAlign = ContentAlignment.TopCenter;
            btn_pencil.Location = new Point(131, 4);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(61, 59);
            btn_pencil.TabIndex = 3;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = true;
            btn_pencil.Click += btn_pencil_Click;
            // 
            // btn_eraser
            // 
            btn_eraser.Cursor = Cursors.Hand;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.White;
            btn_eraser.Image = Properties.Resources.eraser;
            btn_eraser.ImageAlign = ContentAlignment.TopCenter;
            btn_eraser.Location = new Point(198, 4);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(59, 59);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = true;
            btn_eraser.Click += btn_eraser_Click;
            // 
            // pic
            // 
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(800, 450);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // Paint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Paint";
            Text = "Paint";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Button btn_color;
        private Button pic_color;
        private PictureBox pic;
        private Button btn_line;
        private Button btn_rect;
        private Button btn_ellipse;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button btn_fill;
        private Panel panel4;
        private PictureBox color_picker;
        private Button btn_clear;
        private Button btn_save;
    }
}