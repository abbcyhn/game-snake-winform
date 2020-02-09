using System.Windows.Forms;

namespace SnakeGame
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            lblAbout.Text = "İlan Oyunundakı məqsəd ən yüksək xalı\n"+
                            "toplamaqdır. Ən yüksək xalı toplamaq\n"+
                            "üçün isə qırmızı rəngli yemləri yeməlisi -\n"+
                            "niz. Unutmayın ki, yemləri yedikcə ilan\n"+
                            "böyüyür, nəticədə ilan divara dəyə bilər\n"+
                            "və ya səhvən özünü yeyə bilər. Bununla\n"+
                            "da siz oyunu uduza bilərsiniz.";
        }
    }
}