using System;

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WHu_Asn2
{
    class Asn2Form : Form
    {
        static int squareWidth = 10;
        static int channelWidth = 15;
        static int borderWidth = 2 * squareWidth + channelWidth;
        static Boolean wat = false;

        public Asn2Form()
        {
            Text = "C4560: Assignment 2, Exercise 1 (Wilson Hu 4-O / 2018)";
            BackColor = Color.Black;
            ResizeRedraw = true;

            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

        }

        protected override void OnPaint(PaintEventArgs pea)
        {
            Graphics grfx = pea.Graphics;
            SolidBrush brush = new SolidBrush(Color.Green);
            SolidBrush backgroundBrush = new SolidBrush(Color.White);
            grfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            grfx.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            if (wat)
            {
                grfx.FillRectangle(backgroundBrush, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
            }
            else
            {
                grfx.FillRectangle(backgroundBrush, 0, 0, ClientSize.Width / 2, ClientSize.Height);
            }
            
            int midX = ClientSize.Width / 2;
            int cx = midX;
            int cy = borderWidth;


            while (cy < (ClientSize.Height - borderWidth))
            {
                while (cx < (ClientSize.Width - borderWidth))
                {
                    grfx.FillRectangle(brush, cx, cy, squareWidth, squareWidth);
                    grfx.FillRectangle(brush, midX - squareWidth - (cx - midX), cy, squareWidth, squareWidth);
                    cx += channelWidth;
                }
                cy += channelWidth;
                cx = midX;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            wat = !wat;
            this.Invalidate();
        }


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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
        }

        #endregion
    }
}

