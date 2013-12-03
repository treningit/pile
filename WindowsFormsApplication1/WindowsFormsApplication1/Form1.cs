using System;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using ZedGraph;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }


        private void button1_Click(object sender, EventArgs e)
        {
               DrawGraph();
        }

        private void DrawGraph()
        {
            var logic = new Logic(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text),
                                  Convert.ToInt32(textBox3.Text));
        
            // Получим панель для рисования
            var pane = zedGraphControl1.GraphPane;

            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            var list = new PointPairList();
            var listT = new PointPairList();

            double xmin = -5;
            double xmax = 5;

            // Заполняем список точек
            for (var i = 0; i <= Convert.ToInt32(textBox3.Text); i ++)
            {
                // добавим в список точку
                list.Add(logic.Xiyi[0, i], logic.Xiyi[1, i]);
                listT.Add(logic.Xkyk[0, i], logic.Xkyk[1, i]);
            }

            // Создадим кривую с названием "Sinc", 
            // которая будет рисоваться голубым цветом (Color.Blue),
            // Опорные точки выделяться не будут (SymbolType.None)
            pane.AddCurve("Sinc", list, Color.Blue, SymbolType.Diamond);
            pane.AddCurve("SincT", listT, Color.Red, SymbolType.Plus);
            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGraphControl1.AxisChange();

            // Обновляем график
            zedGraphControl1.Invalidate();
        }

    }
}
