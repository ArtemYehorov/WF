namespace WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.button1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            if (MousePosition.X >= button1.Location.X && MousePosition.Y >= button1.Location.Y || MousePosition.X <= button1.Location.X && MousePosition.Y <= button1.Location.Y)
            {
                button1.Location = new Point(r.Next(0, 720), r.Next(0, 350));
                this.button1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            }
        }
    }
}