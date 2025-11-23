using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNanoX_Kyodo
{
    public partial class frmSingleLine : Form
    {
        #region MOVE FORM

        private bool dragging = false;

        private Point dragCursorPoint;

        private Point dragFormPoint;

        #endregion
        public frmSingleLine()
        {
            InitializeComponent();
            Init();
            this.Load += frmSingleLine_Load;
        }
        private Button activeButton;
        private frmSingleLineAC frmSingleLineAC;
        private frmSingleLineDC frmSingleLineDC;


        private void Init()
        {
            this.btnSingleLineDC.Click += BtnSingleLineDC_Click;
            this.btnSingleLineAC.Click += BtnSingleLineAC_Click;

            
            SetActionButton(this.btnSingleLineDC);
            SetActionButton(this.btnSingleLineAC);
        }
        //private void InitMoveForm(Control control)
        //{
        //    control.MouseDown += (sender, e) =>
        //    {
        //        dragging = true;
        //        dragCursorPoint = Cursor.Position;
        //        dragFormPoint = this.Location;
        //    };

        //    control.MouseMove += (sender, e) =>
        //    {
        //        if (dragging)
        //        {
        //            Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
        //            this.Location = Point.Add(dragFormPoint, new Size(dif));
        //        }
        //    };

        //    control.MouseUp += (sender, e) => dragging = false;
        //}


        //private void IDriver1_ConstructionCompleted()
        //{
        //    if (this.InvokeRequired)
        //    {
        //        this.Invoke((Action)(() =>
        //        {
        //            CreateChildForm();
        //            return;
        //        }));

        //        return;
        //    }

        //    CreateChildForm();

        //}
        private void CreateChildForm()
        {

            if (this.frmSingleLineAC is null)
            {
                this.btnSingleLineDC.Enabled = true;
                this.frmSingleLineAC = new frmSingleLineAC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmSingleLineAC.Show();
                this.pnlProject.Controls.Add(this.frmSingleLineAC);
            }

            if (this.frmSingleLineDC is null)
            {
                this.btnSingleLineAC.Enabled = true;
                this.frmSingleLineDC = new frmSingleLineDC() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                this.frmSingleLineDC.Hide();
                this.pnlProject.Controls.Add(this.frmSingleLineDC);
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

        private void BtnSingleLineAC_Click(object sender, EventArgs e)
        {
            // ClassStatic.NumberScreen = 21;
            if (this.activeButton == this.btnSingleLineDC) return;
            this.activeButton = btnSingleLineDC;
            NavigateToSingleLineAC();

            //if (ClassStatic.NumberScreen == 21)
            //{
            btnSingleLineACActive.BringToFront();
            btnSingleLineDCActive.SendToBack();
            //}
            //if (ClassStatic.NumberScreen == 22)
            //{
            //    btnSingleLineDCActive.BringToFront();
            //    btnSingleLineACActive.SendToBack();
            //}
        }
        private void BtnSingleLineDC_Click(object sender, EventArgs e)
        {
            // ClassStatic.NumberScreen = 22;
            if (this.activeButton == this.btnSingleLineAC) return;
            this.activeButton = btnSingleLineAC;
            NavigateToSingleLineDC();

            //if (ClassStatic.NumberScreen == 21)
            //{
            //    btnSingleLineACActive.BringToFront();
            //    btnSingleLineDCActive.SendToBack();
            //}
            //if (ClassStatic.NumberScreen == 22)
            //{
            btnSingleLineDCActive.BringToFront();
            btnSingleLineACActive.SendToBack();
            // }
        }
        private void NavigateToSingleLineAC()
        {
            if (this.frmSingleLineAC is null) return;
            this.frmSingleLineAC?.Show();
            this.frmSingleLineAC?.BringToFront();
            this.frmSingleLineDC?.Hide();
        }
        private void NavigateToSingleLineDC()
        {
            if (this.frmSingleLineDC is null) return;
            this.frmSingleLineDC?.Show();
            this.frmSingleLineDC?.BringToFront();
            this.frmSingleLineAC?.Hide();
        }

        private void frmSingleLine_Load(object sender, EventArgs e)
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
            CreateChildForm();

            this.activeButton = btnSingleLineDC;
            if (this.frmSingleLineAC is null) return;
            this.frmSingleLineAC?.Show();
            this.frmSingleLineAC?.BringToFront();
            

            this.frmSingleLineDC?.Hide();

            NavigateToSingleLineAC();

            
            btnSingleLineACActive.BringToFront();
            btnSingleLineDCActive.SendToBack();
            
        }
    }
}
