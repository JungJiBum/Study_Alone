using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public List<Customer> Customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text,
                DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;

            CusList.Rows.Add(cus.FirstName, cus.Age, CusIsQualified);

            Customers.Add(cus);
            
        }

        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();

        }

        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //firstName 은 리스트 내 저장된 Item
            string firstName = (string)CusList.Rows[e.RowIndex].Cells[0].Value;

            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CusListPanel.Dock = DockStyle.Fill;
            CusDetailPanel.Dock = DockStyle.Right;
            CusNewPanel.Dock = DockStyle.Right;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CusNewPanel.Show();
            CusDetailPanel.Hide();

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    ArrayList arrayList = new ArrayList();
        //    arrayList.Add(0);
        //    arrayList.Add("HI");
        //    arrayList.Add(new Customer("First","Last",new DateTime(2000,2,2)));

        //    arrayList.Insert(2, 2);

        //    arrayList.Remove(2);
        //    //Remove는 value를 없애고
        //    arrayList.RemoveAt(1);
        //    //RemoveAt는 인덱스 번호를 가지고 없앰

        //    int sum = 0;
        //    for (int index=0; index < arrayList.Count; index++)
        //    {
        //        int num = (int)arrayList[index];
        //        sum += num;
        //    }

        //    //배열은 인서트나 리무브 같은 기능밖에없음 값들이 유동적으로 앞뒤로 이동하는 개념이 없음
        //    //aaryList는 내부적으로 배열을 사용하고있지만 동작방식은 링크드리스트 자료구조에 가깝다
        //    //링크드 리스트는 값들이 다 연결되어 있는 형태이며, 하나의 요소가 그 다음 요소에 저장 공간 정보를 가지고있음
        //    //맨앞 요소인 헤드부터 테일까지연결되어있음 따라서 새로운 요소가 중간에 들어오면 중간을 이어주는역할을 함


        //}
    }
}
