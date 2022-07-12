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
        public Customer[] CustomerArray = new Customer[10];
        public int CustomerArrayIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void CreateCustomer_Click(object sender, EventArgs e)
        {

            CustomerArray[CustomerArrayIndex] = new Customer(CusNewFirstName.Text, CusNewLastName.Text,
                                                DateTime.Parse(CusNewBirthday.Text));
            CustomerArray[CustomerArrayIndex].Address = CusNewAddress.Text;
            CustomerArray[CustomerArrayIndex].Description = CusNewDescription.Text;

            CustomerList.Items.Add(CustomerArray[CustomerArrayIndex].FirstName);


            CustomerArrayIndex++;
        }

        public void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();

        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            //firstName 은 리스트 내 저장된 Item
            string firstName = CustomerList.SelectedItem.ToString();

            //인덱스가 CustomerArrayIndex 보다 작을때까지 반복
            for (int index = 0; index < CustomerArrayIndex; index++)
            {
                if(CustomerArray[index].FirstName == firstName)
                {
                    ShowDetails(CustomerArray[index]);
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(0);
            arrayList.Add(1);
            arrayList.Add(3);

            arrayList.Insert(2, 2);

            arrayList.Remove(2);
            //Remove는 value를 없애고
            arrayList.RemoveAt(1);
            //RemoveAt는 인덱스 번호를 가지고 없앰

            int sum = 0;
            for (int index=0; index < arrayList.Count; index++)
            {
                int num = (int)arrayList[index];
                sum += num;
            }

            //배열은 인서트나 리무브 같은 기능밖에없음 값들이 유동적으로 앞뒤로 이동하는 개념이 없음
            //aaryList는 내부적으로 배열을 사용하고있지만 동작방식은 링크드리스트 자료구조에 가깝다
            //링크드 리스트는 값들이 다 연결되어 있는 형태이며, 하나의 요소가 그 다음 요소에 저장 공간 정보를 가지고있음
            //맨앞 요소인 헤드부터 테일까지연결되어있음 따라서 새로운 요소가 중간에 들어오면 중간을 이어주는역할을 함


        }
    }
}
