using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace StudentSupportApp
{
    public partial class NoteForm : Form
    {
        [DllImport("user32")]
        private static extern bool ReleaseCapture();

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wp, int lp);
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 161, 2, 0);
            }
        }

        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        string UserID;
        string oldName;
        public NoteForm()
        {
            InitializeComponent();
            this.UserID = "";
            this.oldName = "";
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }

        public NoteForm(string userID)
        {
            InitializeComponent();
            this.UserID = userID;
            this.oldName = "";
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.btnSaveNote.BackColor = this.btnExitNote.BackColor = Color.Transparent;
            SetColor(Properties.Settings.Default.Color);

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        public NoteForm(string userID, string name, string detail)
        {
            InitializeComponent();
            this.UserID = userID;
            this.oldName = "";
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.btnSaveNote.BackColor = this.btnExitNote.BackColor = Color.Transparent;
            tbxNoteName.Text = name;
            rtbDetail.Text = detail;
            SetColor(Properties.Settings.Default.Color);

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        #region EventHandler

        private void btnExitNote_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NoteForm_SizeChanged(object sender, EventArgs e)
        {
            rtbDetail.Width = this.Size.Width - GradientPanelNote.Size.Width;
            rtbDetail.Height = this.Size.Height - 85;
        }

        private void btnSaveNote_Click(object sender, EventArgs e)
        {
            Note note = new Note(UserID);
            note.Name = tbxNoteName.Text;
            note.Detail = rtbDetail.Text;
            note.Width = this.Size.Width;
            note.Height = this.Size.Height;
            if (this.oldName == "")
                note.AddNoteToDatabase();
            else note.UpdateNoteInfo(this.oldName);
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            this.oldName = tbxNoteName.Text;
            this.btnSaveNote.BackColor = this.btnExitNote.BackColor = Color.Transparent;
        }
        #endregion

        void SetColor(Color x)
        {
            this.GradientPanelNote.BackColor = this.GradientPanelNote.GradientBottomLeft =
            this.GradientPanelNote.GradientBottomRight = this.GradientPanelNote.GradientTopLeft =
            this.GradientPanelNote.GradientTopRight =
            this.tbxNoteName.LineFocusedColor = this.tbxNoteName.LineMouseHoverColor =
            this.btnSaveNote.ActiveForecolor = this.btnSaveNote.ActiveLineColor = this.btnSaveNote.IdleLineColor = this.btnSaveNote.ForeColor = this.btnSaveNote.IdleForecolor =
            this.btnExitNote.ActiveForecolor = this.btnExitNote.ActiveLineColor = this.btnExitNote.IdleLineColor = this.btnExitNote.ForeColor = this.btnExitNote.IdleForecolor = x;
        }
    }
}
