using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListControlWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> dsDuLieu = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnThem_Clck(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTri.Text);
            dsDuLieu.Add(x);
            HienthiDanhSach();
            txtGiaTri.Text = "";
        }

        //Ham hien thi danh sach
        private void HienthiDanhSach()
        {
            lstDuLieu.Items.Clear();
            foreach (int item in dsDuLieu)
            {
                lstDuLieu.Items.Add(item);
            }
        }

        private void BtnChen_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTriChen.Text);
            int vt = int.Parse(txtViTriChen.Text);
            dsDuLieu.Insert(vt, x);
            HienthiDanhSach();
            txtGiaTri.Text = "";
            txtViTriChen.Text = "";
        }

        private void BtnSapXepTang_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            HienthiDanhSach();
        }

        private void BtnSapXepGiam_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            dsDuLieu.Reverse();
            HienthiDanhSach();
        }

        private void BtnXoa1PhanTu_Click(object sender, RoutedEventArgs e)
        {
            if(lstDuLieu.SelectedIndex==-1)
            {
             MessageBox.Show("Vui lòng chọn phần tử để xóa.","Thong bao loi"
                 ,MessageBoxButton.OK);
                return;
            }
            //Xoa phan tu tai vi tri da chon
            dsDuLieu.RemoveAt(lstDuLieu.SelectedIndex);
            HienthiDanhSach();
        }
        private void BtnXoaTatCa_Click(object sender, RoutedEventArgs e)
        {
            dsDuLieu.Clear();
            HienthiDanhSach();
        }

        private void btnXoaNhieuPhanTu_Click(object sender, RoutedEventArgs e)
        {
            if(lstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phần tử để xóa.", "Thong bao loi"
                 , MessageBoxButton.OK);
                return;
            }
            //vong lap lay cac phan tu da chon
            while (lstDuLieu.SelectedItems.Count > 0)
            {
                //lay phan tu dau tien da chon
                int data = (int)lstDuLieu.SelectedItems[0];
                //xoa phan tu tai vi tri da chon
                dsDuLieu.RemoveAt(data);
                //xoa du lieu tren giao dien
                lstDuLieu.Items.RemoveAt(0);
            }
        }
    }
}