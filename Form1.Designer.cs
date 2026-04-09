namespace BurgerKiosk
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            grpMenu = new GroupBox();
            picChickenBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picHamBurger = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoHamBurger = new RadioButton();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grpOrder = new GroupBox();
            lblErrorMsg = new Label();
            btnReset = new Button();
            btnOrder = new Button();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            grpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("맑은 고딕", 20F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTitle.ForeColor = Color.RoyalBlue;
            lblTitle.Location = new Point(29, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(251, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "버거 주문 키오스크";
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(picChickenBurger);
            grpMenu.Controls.Add(picBulgogiBurger);
            grpMenu.Controls.Add(picHamBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpMenu.ForeColor = Color.Firebrick;
            grpMenu.Location = new Point(33, 82);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(245, 260);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // picChickenBurger
            // 
            picChickenBurger.BackColor = Color.Beige;
            picChickenBurger.BorderStyle = BorderStyle.FixedSingle;
            picChickenBurger.Image = (Image)resources.GetObject("picChickenBurger.Image");
            picChickenBurger.Location = new Point(137, 180);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(80, 50);
            picChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picChickenBurger.TabIndex = 5;
            picChickenBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.BackColor = Color.Beige;
            picBulgogiBurger.BorderStyle = BorderStyle.FixedSingle;
            picBulgogiBurger.Image = (Image)resources.GetObject("picBulgogiBurger.Image");
            picBulgogiBurger.Location = new Point(137, 105);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(80, 50);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogiBurger.TabIndex = 4;
            picBulgogiBurger.TabStop = false;
            // 
            // picHamBurger
            // 
            picHamBurger.BackColor = Color.Beige;
            picHamBurger.BorderStyle = BorderStyle.FixedSingle;
            picHamBurger.Image = (Image)resources.GetObject("picHamBurger.Image");
            picHamBurger.Location = new Point(137, 30);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(80, 50);
            picHamBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picHamBurger.TabIndex = 3;
            picHamBurger.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 10F);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(19, 191);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(83, 23);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 10F);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(19, 116);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(97, 23);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 10F);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(19, 41);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(69, 23);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOption.ForeColor = Color.Firebrick;
            grpOption.Location = new Point(301, 82);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(165, 180);
            grpOption.TabIndex = 2;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 10F);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(19, 131);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(89, 23);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 10F);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(19, 101);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(89, 23);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 10F);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(19, 71);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(56, 23);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 10F);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(19, 41);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(84, 23);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblErrorMsg);
            grpOrder.Controls.Add(btnReset);
            grpOrder.Controls.Add(btnOrder);
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            grpOrder.ForeColor = Color.Firebrick;
            grpOrder.Location = new Point(495, 82);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(240, 290);
            grpOrder.TabIndex = 3;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(20, 201);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(0, 15);
            lblErrorMsg.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(132, 236);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(82, 35);
            btnReset.TabIndex = 4;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.LimeGreen;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(20, 236);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(82, 35);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblTotalCost.ForeColor = Color.RoyalBlue;
            lblTotalCost.Location = new Point(20, 176);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(99, 21);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액: 0원";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 11F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lstOrder.ForeColor = Color.RoyalBlue;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(20, 35);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(194, 124);
            lstOrder.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(760, 390);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(grpMenu);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Burger Kiosk v1.0";
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpMenu;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox picHamBurger;
        private PictureBox picBulgogiBurger;
        private PictureBox picChickenBurger;
        private GroupBox grpOption;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpOrder;
        private ListBox lstOrder;
        private Label lblTotalCost;
        private Button btnOrder;
        private Button btnReset;
        private Label lblErrorMsg;
    }
}