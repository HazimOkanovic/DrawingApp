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
            pic_color = new Button();
            panel4 = new Panel();
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
            panel3.Location = new Point(0, 397);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 53);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(pic_color);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 100);
            panel2.TabIndex = 0;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(166, 66);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(37, 34);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(btn_line);
            panel4.Controls.Add(btn_color);
            panel4.Controls.Add(btn_rect);
            panel4.Controls.Add(btn_fill);
            panel4.Controls.Add(btn_ellipse);
            panel4.Controls.Add(btn_pencil);
            panel4.Controls.Add(btn_eraser);
            panel4.Location = new Point(263, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(537, 78);
            panel4.TabIndex = 8;
            // 
            // btn_line
            // 
            btn_line.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_line.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.White;
            btn_line.Image = Properties.Resources.line;
            btn_line.ImageAlign = ContentAlignment.TopCenter;
            btn_line.Location = new Point(442, 9);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(69, 60);
            btn_line.TabIndex = 7;
            btn_line.Text = "Line";
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = true;
            // 
            // btn_color
            // 
            btn_color.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_color.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.Image = Properties.Resources.color;
            btn_color.ImageAlign = ContentAlignment.TopCenter;
            btn_color.Location = new Point(21, 10);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(61, 60);
            btn_color.TabIndex = 1;
            btn_color.Text = "Color";
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = true;
            // 
            // btn_rect
            // 
            btn_rect.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_rect.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.White;
            btn_rect.Image = Properties.Resources.rectangle;
            btn_rect.ImageAlign = ContentAlignment.TopCenter;
            btn_rect.Location = new Point(367, 9);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(69, 60);
            btn_rect.TabIndex = 6;
            btn_rect.Text = "Rectangle";
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = true;
            // 
            // btn_fill
            // 
            btn_fill.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_fill.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.White;
            btn_fill.Image = Properties.Resources.bucket;
            btn_fill.ImageAlign = ContentAlignment.TopCenter;
            btn_fill.Location = new Point(88, 9);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(63, 60);
            btn_fill.TabIndex = 2;
            btn_fill.Text = "Fill";
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = true;
            // 
            // btn_ellipse
            // 
            btn_ellipse.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_ellipse.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_ellipse.FlatStyle = FlatStyle.Flat;
            btn_ellipse.ForeColor = Color.White;
            btn_ellipse.Image = Properties.Resources.circle;
            btn_ellipse.ImageAlign = ContentAlignment.TopCenter;
            btn_ellipse.Location = new Point(297, 9);
            btn_ellipse.Name = "btn_ellipse";
            btn_ellipse.Size = new Size(64, 60);
            btn_ellipse.TabIndex = 5;
            btn_ellipse.Text = "Ellipse";
            btn_ellipse.TextAlign = ContentAlignment.BottomCenter;
            btn_ellipse.UseVisualStyleBackColor = true;
            // 
            // btn_pencil
            // 
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.White;
            btn_pencil.Image = Properties.Resources.pencil;
            btn_pencil.ImageAlign = ContentAlignment.TopCenter;
            btn_pencil.Location = new Point(157, 9);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(64, 60);
            btn_pencil.TabIndex = 3;
            btn_pencil.Text = "Pencil";
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = true;
            // 
            // btn_eraser
            // 
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 0, 0);
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.Chocolate;
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.White;
            btn_eraser.Image = Properties.Resources.eraser;
            btn_eraser.ImageAlign = ContentAlignment.TopCenter;
            btn_eraser.Location = new Point(227, 9);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(64, 60);
            btn_eraser.TabIndex = 4;
            btn_eraser.Text = "Eraser";
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = true;
            // 
            // pic
            // 
            pic.Dock = DockStyle.Fill;
            pic.Location = new Point(0, 0);
            pic.Name = "pic";
            pic.Size = new Size(800, 450);
            pic.TabIndex = 2;
            pic.TabStop = false;
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
    }
}