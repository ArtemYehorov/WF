using System.Runtime.CompilerServices;

namespace WF
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// ���������� ������� ���� ������������ ��������� �����
            //X = Control.MousePosition.X;
            //Y = Control.MousePosition.Y;
            
            
            
            //// ����� ����
            //this.BackColor = Color.FromArgb(X % 256, Y % 256, 127);


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

//[10:40] ��������� ��������� ����������
//using System;
//using System.Drawing;
//using System.Windows.Forms;

//namespace KeyboardCaption
//{
//    public partial class Form1 : Form
//    {

//        int x = 0;

//        public Form1()
//        {
//            InitializeComponent();

//            // ������ �� �������� ������ࠠ����// ������ � �������� - ��� ��������, ������� ��������� ��������� ����������� ������� ������������ � ��������� ���������� ����������
//            ��var t = new Timer(); // ��� ������������ ��������򠠠��������
//            �t.Interval = 1; // �������� (��������) ����� ������� ���������� ������������ ������� ���� (� ������ ������ ����� ����� �����-�� ���� ����������� ��� � ������������ - 1000 ��� � �������)�����������
//            �t.Tick += Fun; // ��� (�������) - ��������� ����� ��������� ������� ���������, ������� Fun ����������� ��� ���������� ����� �����������������
//            ��t.Start(); // ����� (�����) - ��������������� ������ �������������� �����ࠠ����������
//            t.Stop();������
//            ��}

//            private void Fun(object sender, EventArgs e) { x += 5; button1.Location = new Point(x, 0); }
//        }
//    }

