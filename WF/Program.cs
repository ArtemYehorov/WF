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
            //// координаты курсора мыши относительно рабочаего стола
            //X = Control.MousePosition.X;
            //Y = Control.MousePosition.Y;
            
            
            
            //// любой цвет
            //this.BackColor = Color.FromArgb(X % 256, Y % 256, 127);


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

//[10:40] Загоруйко Александр Дмитриевич
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

//            // пример на создание таймера      // таймер в винформс - это механизм, который позволяет запускать определённую функцию периодически с некоторым интервалом           
//              var t = new Timer(); // это невизуальный компонент           
//             t.Interval = 1; // интервал (свойство) задат частоту повторения определённого участка кода (в данном случае нужно чтобы какие-то вещи происходили раз в миллисекунду - 1000 раз в секунду)           
//             t.Tick += Fun; // тик (событие) - наступает после истечения времени интервала, функция Fun срабатывает как обработчик этого события          
//              t.Start(); // старт (метод) - непосредственно запуск дополнительнго потока            
//            t.Stop();      
//              }

//            private void Fun(object sender, EventArgs e) { x += 5; button1.Location = new Point(x, 0); }
//        }
//    }

