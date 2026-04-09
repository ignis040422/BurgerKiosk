using System;
using System.Windows.Forms;

namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Enter 키를 누르면 주문하기 버튼이 실행되도록 설정
            this.AcceptButton = btnOrder;

            // Esc 키를 누르면 초기화 버튼이 실행되도록 설정
            this.CancelButton = btnReset;

            // Tab 키 이동 순서를 설정
            SetTabOrder();
        }

        // 키보드 Tab 이동 순서를 설정하는 함수
        private void SetTabOrder()
        {
            int tabIndex = 0;

            // 메뉴 선택 영역
            rdoHamBurger.TabIndex = tabIndex++;
            rdoBulgogiBurger.TabIndex = tabIndex++;
            rdoChickenBurger.TabIndex = tabIndex++;

            // 추가 옵션 영역
            chkPotato.TabIndex = tabIndex++;
            chkCola.TabIndex = tabIndex++;
            chkCheese.TabIndex = tabIndex++;
            chkSauce.TabIndex = tabIndex++;

            // 버튼 영역
            btnOrder.TabIndex = tabIndex++;
            btnReset.TabIndex = tabIndex++;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 총 금액을 저장할 변수
            int totalCost = 0;

            // 주문 버튼을 다시 눌렀을 때 이전 주문 내역이 남지 않도록 초기화
            lstOrder.Items.Clear();

            // 이전 에러 메시지를 먼저 지움
            lblErrorMsg.Text = "";

            // 메뉴와 옵션이 아무것도 선택되지 않았는지 검사
            if (!rdoHamBurger.Checked &&
                !rdoBulgogiBurger.Checked &&
                !rdoChickenBurger.Checked &&
                !chkPotato.Checked &&
                !chkCola.Checked &&
                !chkCheese.Checked &&
                !chkSauce.Checked)
            {
                // MessageBox 대신 화면의 Label에 에러 메시지 출력
                lblErrorMsg.Text = "메뉴 또는 옵션을 하나 이상 선택하세요.";
                return;
            }

            // 메뉴 선택 처리
            if (rdoHamBurger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            // 추가 옵션 처리
            if (chkPotato.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }

            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }

            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 추가 1,500원");
            }

            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 추가 500원");
            }

            // 계산된 총 금액을 Label에 출력
            lblTotalCost.Text = "총 금액: " + totalCost + "원";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // 메뉴 선택 초기화
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            // 옵션 선택 초기화
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 주문 내역 초기화
            lstOrder.Items.Clear();

            // 총 금액 초기화
            lblTotalCost.Text = "총 금액: 0원";

            // 에러 메시지 초기화
            lblErrorMsg.Text = "";
        }
    }
}