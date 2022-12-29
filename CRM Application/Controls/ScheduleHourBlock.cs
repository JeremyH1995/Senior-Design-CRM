using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CRM_Application {
    public partial class ScheduleHourBlock : UserControl {

        public int BlockHour { get; set; }
        public Color BlockColor { get; set; }
        public Label BlockText { get; set; }
        public List<PartialBlock> PartialBlocskForHour { get; }
        public int RoomNumber { get; set; }

        public ScheduleHourBlock() {
            BlockHour = 0;
            BlockColor = Color.White;
            PartialBlocskForHour = new List<PartialBlock>();
            Controls.Add(BlockText);
            PartialBlocskForHour.Add(InitializePartialBlock(BlockColor, 0, 100));
            AutoSize = false;
            InitializeComponent();
        }

        public ScheduleHourBlock(Color blockColor) {
            BlockColor = blockColor;
            BlockHour = 0;
            PartialBlocskForHour = new List<PartialBlock>();
            Width = 200;
            Height = 100;
            Padding = Padding.Empty;
            Dock = DockStyle.Fill;
            PartialBlocskForHour.Add(InitializePartialBlock(BlockColor, 0, 100));
            DoubleBuffered = true;
            InitializeComponent();
        }

        private PartialBlock InitializePartialBlock(Color color, int blockPosY, float percentage) {

            PartialBlock tempBlock = new PartialBlock(color, 0, blockPosY, Width, ((int)percentage / Height) * Height);
            tempBlock.Dock = DockStyle.Fill;
            Controls.Add(tempBlock);
            return tempBlock;
        }
    }

    public sealed class PartialBlock : UserControl {

        public Color BlockColor { get; set; }
        public int PositionX { get; private set; }
        public int PositionY { get; set; }
        public int SizeX { get; private set; }
        public int SizeY { get; set; }
        public Appointment AppointmentInBlock { get; set; }

        public PartialBlock(Color color, int positionX, int positionY, int sizeX, int sizeY) {
            PositionX = positionX;
            PositionY = positionY;
            SizeX = sizeX;
            SizeY = sizeY;
            BlockColor = color;
            AppointmentInBlock = null;
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs paintEvent) {

            if (AppointmentInBlock == null) return;

            Brush brush = new SolidBrush(BlockColor);
            string rectangleText = AppointmentInBlock.ClientName + "\n" + AppointmentInBlock.AppointmentStartTime.ToString("MM/dd/yyyy\nhh:mm tt") + 
                " - " + AppointmentInBlock.AppointmentEndTime.ToString("hh:mm tt");
            Font font = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            Rectangle rect = new Rectangle(PositionX, PositionY, SizeX, SizeY);
     
            paintEvent.Graphics.FillRectangle(brush, Rectangle.Round(rect));
            TextRenderer.DrawText(paintEvent.Graphics, rectangleText, font, rect, Color.Black, TextFormatFlags.WordBreak);
           
        }

        protected override void OnClick(EventArgs eventArgs) {
            base.OnClick(eventArgs);

            if (AppointmentInBlock != null) {
                AppointmentDataView dataView = new AppointmentDataView(this, AppointmentInBlock);
                dataView.ShowDialog();
            }
        }
    }
}
