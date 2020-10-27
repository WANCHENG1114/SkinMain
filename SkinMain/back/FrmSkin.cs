using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkinMain
{
    public partial class FrmSkin : Form
    {
        public FrmSkin()
        {
            InitializeComponent();//窗体构造函数

            #region MyRegion

            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lab_biaoti = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbox_guanbi = new System.Windows.Forms.PictureBox();
            this.pbox_zuixiaohua = new System.Windows.Forms.PictureBox();
            this.pbos_zuidahua = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_guanbi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zuixiaohua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbos_zuidahua)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 423);
            this.panel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lab_biaoti);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 25);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lab_biaoti
            // 
            this.lab_biaoti.AutoSize = true;
            this.lab_biaoti.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_biaoti.Location = new System.Drawing.Point(3, 4);
            this.lab_biaoti.Name = "lab_biaoti";
            this.lab_biaoti.Size = new System.Drawing.Size(54, 17);
            this.lab_biaoti.TabIndex = 0;
            this.lab_biaoti.Text = "FrmSkin";
            this.lab_biaoti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pbox_guanbi);
            this.panel5.Controls.Add(this.pbox_zuixiaohua);
            this.panel5.Controls.Add(this.pbos_zuidahua);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(692, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(106, 25);
            this.panel5.TabIndex = 1;
            // 
            // pbox_guanbi
            // 
            this.pbox_guanbi.BackColor = System.Drawing.SystemColors.Control;
            this.pbox_guanbi.BackgroundImage = global::SkinMain.Properties.Resources.关闭;
            this.pbox_guanbi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbox_guanbi.Location = new System.Drawing.Point(70, 0);
            this.pbox_guanbi.Name = "pbox_guanbi";
            this.pbox_guanbi.Size = new System.Drawing.Size(35, 25);
            this.pbox_guanbi.TabIndex = 0;
            this.pbox_guanbi.TabStop = false;
            this.pbox_guanbi.Click += new System.EventHandler(this.pbox_guanbi_Click);
            this.pbox_guanbi.MouseEnter += new System.EventHandler(this.pbox_XXX_MouseEnter);
            this.pbox_guanbi.MouseLeave += new System.EventHandler(this.pbox_XXX_MouseLeave);
            // 
            // pbox_zuixiaohua
            // 
            this.pbox_zuixiaohua.BackColor = System.Drawing.SystemColors.Control;
            this.pbox_zuixiaohua.BackgroundImage = global::SkinMain.Properties.Resources.最小化;
            this.pbox_zuixiaohua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbox_zuixiaohua.Location = new System.Drawing.Point(0, 0);
            this.pbox_zuixiaohua.Name = "pbox_zuixiaohua";
            this.pbox_zuixiaohua.Size = new System.Drawing.Size(35, 25);
            this.pbox_zuixiaohua.TabIndex = 0;
            this.pbox_zuixiaohua.TabStop = false;
            this.pbox_zuixiaohua.Click += new System.EventHandler(this.pbox_zuixiaohua_Click);
            this.pbox_zuixiaohua.MouseEnter += new System.EventHandler(this.pbox_XXX_MouseEnter);
            this.pbox_zuixiaohua.MouseLeave += new System.EventHandler(this.pbox_XXX_MouseLeave);
            // 
            // pbos_zuidahua
            // 
            this.pbos_zuidahua.BackColor = System.Drawing.SystemColors.Control;
            this.pbos_zuidahua.BackgroundImage = global::SkinMain.Properties.Resources.最大化;
            this.pbos_zuidahua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbos_zuidahua.Location = new System.Drawing.Point(35, 0);
            this.pbos_zuidahua.Name = "pbos_zuidahua";
            this.pbos_zuidahua.Size = new System.Drawing.Size(35, 25);
            this.pbos_zuidahua.TabIndex = 0;
            this.pbos_zuidahua.TabStop = false;
            this.pbos_zuidahua.Click += new System.EventHandler(this.pbos_zuidahua_Click);
            this.pbos_zuidahua.MouseEnter += new System.EventHandler(this.pbox_XXX_MouseEnter);
            this.pbos_zuidahua.MouseLeave += new System.EventHandler(this.pbox_XXX_MouseLeave);
            // 
            // FrmSkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSkin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_guanbi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_zuixiaohua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbos_zuidahua)).EndInit();
            this.ResumeLayout(false);
            
            #endregion


        }

        #region 窗体样式属性

        #region 标题栏拖拽移动
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                //这里一定要判断鼠标左键按下状态，否则会出现一个很奇葩的BUG，不信邪可以试一下~~
                ReleaseCapture();
                SendMessage(Handle, 0x00A1, 2, 0);
            }
        }
        //窗体移动API
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            OnMouseMove(e);
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    this.WindowState = FormWindowState.Maximized;
                }
            }
        }

        #endregion

        #region 小大关
        private void pbox_XXX_MouseEnter(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = Color.White;
        }
        private void pbox_XXX_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            pictureBox.BackColor = SystemColors.Control;
        }
        private void pbos_zuidahua_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pbox_zuixiaohua_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pbox_guanbi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 窗体阴影

        private const int CS_DropSHADOW = 0x20000;
        private const int GCL_STYLE = (-26);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SetClassLong(IntPtr hwnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetClassLong(IntPtr hwnd, int nIndex);


        #endregion

        #endregion
    }
    
    public class _ClassInfo
    {
        /// <summary>
        /// 窗体背景颜色
        /// </summary>
        public Color? _color { get; set; }
        /// <summary>
        /// 窗体标题
        /// </summary>
        public string _labStr { get; set; } 
        /// <summary>
        /// 是否显示窗体状态栏
        /// </summary>
        public bool _staBool { get; set; } 
        /// <summary>
        /// 窗体状态栏文本类容
        /// </summary>
        public string _staStr { get; set; } 
    }
}
