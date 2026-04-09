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

            // 폼이 처음 열릴 때 초기 상태 설정
            this.Load += Form1_Load;

            // 방향키로 항목 이동이 되도록 이벤트 연결
            SetKeyboardNavigation();

            // 과제 4: 선택 즉시 주문 내역과 총 금액이 갱신되도록 이벤트 연결
            SetLiveUpdateEvents();
        }

        // 폼이 시작될 때 아무것도 선택되지 않도록 설정
        private void Form1_Load(object sender, EventArgs e)
        {
            // 라디오버튼 자동 선택 방지를 위해 그룹 밖 컨트롤에 먼저 포커스
            this.ActiveControl = lblTitle;

            // 메뉴 선택 해제
            rdoHamBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;

            // 옵션 선택 해제
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;

            // 출력 초기화
            lstOrder.Items.Clear();
            lblTotalCost.Text = "총 금액: 0원";
            lblErrorMsg.Text = "";
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

        // 방향키 이동을 위한 이벤트 연결
        private void SetKeyboardNavigation()
        {
            rdoHamBurger.KeyDown += MoveFocusByArrowKey;
            rdoBulgogiBurger.KeyDown += MoveFocusByArrowKey;
            rdoChickenBurger.KeyDown += MoveFocusByArrowKey;

            chkPotato.KeyDown += MoveFocusByArrowKey;
            chkCola.KeyDown += MoveFocusByArrowKey;
            chkCheese.KeyDown += MoveFocusByArrowKey;
            chkSauce.KeyDown += MoveFocusByArrowKey;

            btnOrder.KeyDown += MoveFocusByArrowKey;
            btnReset.KeyDown += MoveFocusByArrowKey;
        }

        // 위/왼쪽 방향키는 이전 컨트롤, 아래/오른쪽 방향키는 다음 컨트롤로 이동
        private void MoveFocusByArrowKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
            {
                SelectNextControl((Control)sender, false, true, true, true);
                e.Handled = true;
            }
        }

        // 선택 즉시 업데이트 이벤트 연결
        private void SetLiveUpdateEvents()
        {
            rdoHamBurger.CheckedChanged += UpdateOrder;
            rdoBulgogiBurger.CheckedChanged += UpdateOrder;
            rdoChickenBurger.CheckedChanged += UpdateOrder;

            chkPotato.CheckedChanged += UpdateOrder;
            chkCola.CheckedChanged += UpdateOrder;
            chkCheese.CheckedChanged += UpdateOrder;
            chkSauce.CheckedChanged += UpdateOrder;
        }

        // 과제 4 핵심: 선택하는 즉시 주문 내역과 총 금액 갱신
        private void UpdateOrder(object sender, EventArgs e)
        {
            int totalCost = 0;

            // 이전 주문 내역 초기화
            lstOrder.Items.Clear();

            // 이전 에러 메시지 초기화
            lblErrorMsg.Text = "";

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

            // 아무것도 선택하지 않았을 때
            if (!rdoHamBurger.Checked &&
                !rdoBulgogiBurger.Checked &&
                !rdoChickenBurger.Checked &&
                !chkPotato.Checked &&
                !chkCola.Checked &&
                !chkCheese.Checked &&
                !chkSauce.Checked)
            {
                lblTotalCost.Text = "총 금액: 0원";
                return;
            }

            // 총 금액 출력
            lblTotalCost.Text = "총 금액: " + totalCost.ToString("N0") + "원";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // 아무것도 선택되지 않았을 때 에러 메시지 출력
            if (!rdoHamBurger.Checked &&
                !rdoBulgogiBurger.Checked &&
                !rdoChickenBurger.Checked &&
                !chkPotato.Checked &&
                !chkCola.Checked &&
                !chkCheese.Checked &&
                !chkSauce.Checked)
            {
                lblErrorMsg.Text = "메뉴 또는 옵션을 하나 이상 선택하세요.";
                return;
            }

            // 이미 실시간으로 표시되고 있으므로 에러 메시지만 제거
            lblErrorMsg.Text = "";
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

            // 초기화 후 라벨에 포커스
            this.ActiveControl = lblTitle;
        }
    }
}