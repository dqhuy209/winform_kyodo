using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormNanoX_Kyodo;

namespace WinFormNanoX_Kyodo
{
    public partial class frmSingleLineDC : Form
    {
        #region MOVE FORM

        private bool dragging = false;

        private Point dragCursorPoint;

        private Point dragFormPoint;

        #endregion
        public frmSingleLineDC()
        {
            InitializeComponent();
            Init();
        }
        private Button activeButton;
        private frmAllInverter frmAllInverter;
        private frmInverter1 frmInverter1;
        private frmInverter2 frmInverter2;
        private frmInverter3 frmInverter3;
        private frmInverter4 frmInverter4;
        private frmInverter5 frmInverter5;
        private frmInverter6 frmInverter6;


        private void Init()
        {
            this.btnAllInverter.Click += BtnAllInverter_Click;
            this.btnInverter1.Click += BtnInverter1_Click;

            this.btnInverter2.Click += BtnInverter2_Click;
            this.btnInverter3.Click += BtnInverter3_Click;
            this.btnInverter4.Click += BtnInverter4_Click;
            this.btnInverter5.Click += BtnInverter5_Click;
            this.btnInverter6.Click += BtnInverter6_Click;

            this.Load += FrmSingleLineDC_Load;



            SetActionButton(this.btnAllInverterActive);
        }

        private void FrmSingleLineDC_Load(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke((Action)(() =>
                {
                    CreateChildForm();
                    return;
                }));

                return;
            }

            btnAllInverterActive.BringToFront();

            CreateChildForm();
            this.frmAllInverter?.Show();
            this.frmAllInverter?.BringToFront();
            this.frmInverter1?.Hide();
            this.frmInverter2?.Hide();
            this.frmInverter3?.Hide();
            this.frmInverter4?.Hide();
            this.frmInverter5?.Hide();
            this.frmInverter6?.Hide();
        }


        private void CreateChildForm()
        {
            int i = 0;
            if (this.frmAllInverter is null)
            {
                this.btnAllInverterActive.Enabled = true;
                this.frmAllInverter = new frmAllInverter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmAllInverter.Show();
                this.pnlInverter.Controls.Add(this.frmAllInverter);
                i++;
            }
            if (this.frmInverter1 is null && i == 1)
            {
                this.btnInverter1.Enabled = true;
                this.frmInverter1 = new frmInverter1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmInverter1.Show();
                this.pnlInverter.Controls.Add(this.frmInverter1);
                i++;
            }
        }
        private void SetActionButton(Button button)
        {
            if (button is null) return;
            button.FlatAppearance.MouseOverBackColor = button.BackColor;
            button.BackColorChanged += (s, e) =>
            {
                button.FlatAppearance.MouseOverBackColor = button.BackColor;
            };
        }
        
        private void BtnAllInverter_Click(object sender, EventArgs e)
        {



            //if (ClassStatic.NumberScreen == 210)
            //{
            btnAllInverterActive.BringToFront();
            btnAllInverterActive.Show();
            btnAllInverter.SendToBack();

            btnInverter1.BackColor = Color.Transparent;
            btnInverter2.BackColor = Color.Transparent;
            btnInverter3.BackColor = Color.Transparent;
            btnInverter4.BackColor = Color.Transparent;
            btnInverter5.BackColor = Color.Transparent;
            btnInverter6.BackColor = Color.Transparent;


            NavigateToAllInverter();
            // }
        }

        private void BtnInverter1_Click(object sender, EventArgs e)
        {





            btnInverter1.BackColor = Color.Lime;
            btnInverter2.BackColor = Color.Transparent;
            btnInverter3.BackColor = Color.Transparent;
            btnInverter4.BackColor = Color.Transparent;
            btnInverter5.BackColor = Color.Transparent;
            btnInverter6.BackColor = Color.Transparent;

            btnAllInverterActive.SendToBack();
            btnAllInverter.Show();
            btnAllInverterActive.Hide();
            NavigateToInverter1();
            //}
        }
        private void BtnInverter2_Click(object sender, EventArgs e)
        {


            //if (ClassStatic.NumberScreen == 212)
            //{
            btnInverter2.BackColor = Color.Lime;
            btnInverter1.BackColor = Color.Transparent;
            btnInverter3.BackColor = Color.Transparent;
            btnInverter4.BackColor = Color.Transparent;
            btnInverter5.BackColor = Color.Transparent;
            btnInverter6.BackColor = Color.Transparent;

            btnAllInverterActive.SendToBack();
            btnAllInverter.Show();
            btnAllInverterActive.Hide();
            NavigateToInverter2();
            // }
        }
        private void BtnInverter3_Click(object sender, EventArgs e)
        {


            //if (ClassStatic.NumberScreen == 213)
            //{
            btnInverter3.BackColor = Color.Lime;
            btnInverter1.BackColor = Color.Transparent;
            btnInverter2.BackColor = Color.Transparent;
            btnInverter4.BackColor = Color.Transparent;
            btnInverter5.BackColor = Color.Transparent;
            btnInverter6.BackColor = Color.Transparent;

            btnAllInverterActive.SendToBack();
            btnAllInverter.Show();
            btnAllInverterActive.Hide();
            NavigateToInverter3();
            // }
        }
        private void BtnInverter4_Click(object sender, EventArgs e)
        {


            //if (ClassStatic.NumberScreen == 214)
            //{
            btnInverter4.BackColor = Color.Lime;
            btnInverter1.BackColor = Color.Transparent;
            btnInverter2.BackColor = Color.Transparent;
            btnInverter3.BackColor = Color.Transparent;
            btnInverter5.BackColor = Color.Transparent;
            btnInverter6.BackColor = Color.Transparent;

            btnAllInverterActive.SendToBack();
            btnAllInverter.Show();
            btnAllInverterActive.Hide();
            NavigateToInverter4();
            // }
        }

        private void BtnInverter5_Click(object sender, EventArgs e)
        {


            //if (ClassStatic.NumberScreen == 214)
            //{
            btnInverter5.BackColor = Color.Lime;
            btnInverter1.BackColor = Color.Transparent;
            btnInverter2.BackColor = Color.Transparent;
            btnInverter3.BackColor = Color.Transparent;
            btnInverter4.BackColor = Color.Transparent;
            btnInverter6.BackColor = Color.Transparent;

            btnAllInverterActive.SendToBack();
            btnAllInverter.Show();
            btnAllInverterActive.Hide();
            NavigateToInverter5();
            // }
        }
        private void BtnInverter6_Click(object sender, EventArgs e)
        {


            //if (ClassStatic.NumberScreen == 214)
            //{
            btnInverter6.BackColor = Color.Lime;
            btnInverter1.BackColor = Color.Transparent;
            btnInverter2.BackColor = Color.Transparent;
            btnInverter3.BackColor = Color.Transparent;
            btnInverter4.BackColor = Color.Transparent;
            btnInverter5.BackColor = Color.Transparent;

            btnAllInverterActive.SendToBack();
            btnAllInverter.Show();
            btnAllInverterActive.Hide();
            NavigateToInverter6();
            // }
        }


        private Form currentForm;

        private void NavigateToAllInverter()
        {
            this.pnlInverter.Controls.Clear();
            this.currentForm?.Close();

            this.currentForm = new frmAllInverter() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.currentForm.Show();
            this.pnlInverter.Controls.Add(this.currentForm);

        }
        private void NavigateToInverter1()
        {
            this.pnlInverter.Controls.Clear();
            this.currentForm?.Close();

            this.currentForm = new frmInverter1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.currentForm.Show();
            this.pnlInverter.Controls.Add(this.currentForm);

        }

        private void NavigateToInverter2()
        {
            this.pnlInverter.Controls.Clear();
            this.currentForm?.Close();

            this.currentForm = new frmInverter2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.currentForm.Show();
            this.pnlInverter.Controls.Add(this.currentForm);
        }
        private void NavigateToInverter3()
        {
            this.pnlInverter.Controls.Clear();
            this.currentForm?.Close();

            this.currentForm = new frmInverter3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.currentForm.Show();
            this.pnlInverter.Controls.Add(this.currentForm);
        }
        private void NavigateToInverter4()
        {
            this.pnlInverter.Controls.Clear();
            this.currentForm?.Close();

            this.currentForm = new frmInverter4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.currentForm.Show();
            this.pnlInverter.Controls.Add(this.currentForm);
        }
        private void NavigateToInverter5()
        {
            this.pnlInverter.Controls.Clear();
            this.currentForm?.Close();

            this.currentForm = new frmInverter5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.currentForm.Show();
            this.pnlInverter.Controls.Add(this.currentForm);
        }
        private void NavigateToInverter6()
        {
            this.pnlInverter.Controls.Clear();
            this.currentForm?.Close();

            this.currentForm = new frmInverter6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.currentForm.Show();
            this.pnlInverter.Controls.Add(this.currentForm);
        }



    }
}
