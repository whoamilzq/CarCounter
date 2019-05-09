using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;
using KV_125K;

namespace CarCounter
{
    public partial class FormMain : Form
    {
        Reader reader = new Reader();
        public FormMain()
        {
            InitializeComponent();
            Form.CheckForIllegalCrossThreadCalls = false;
        }

        // 加载主界面时执行
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        // 主界面加载完成时自动执行一次，
        private void FormMain_Shown(object sender, EventArgs e)
        {
            //// 获取串口号
            foreach (string s in SerialPort.GetPortNames())
            {
                cmbSerial.Items.Add(s);
            }
            cmbSerial.SelectedIndex = 0;
            openSerial();
        }

        // 退出
        private void msQuit_Click(object sender, EventArgs e)
        {
            if (reader.serialport.IsOpen)
            {
                closeSerial();
            }
            Application.Exit();
        }

        private void msOpenSerial_Click(object sender, EventArgs e) => openSerial();
        private void msCloseSerial_Click(object sender, EventArgs e) => closeSerial();

        // 打开串口
        private void openSerial()
        {
            if (reader.OpenPort(cmbSerial.Text, 9600) == "")
            {
                MessageBox.Show("串口打开成功！");
                reader.eventHex += Reader_eventHex;
                reader.eventWG += Reader_eventWG;
                btnSerialOpen.Enabled = false;
                msOpenSerial.Enabled = false;
                tsslabSerial2.Text =reader.serialport.PortName.ToString();
            }
            else
            {
                MessageBox.Show("串口打开失败！");
            }
        }
        // 关闭串口
        private void closeSerial()
        {
            reader.ClosePort();
            // MessageBox.Show("串口关闭成功！");
            btnSerialOpen.Enabled = true;
            msOpenSerial.Enabled = true;
            tsslabSerial2.Text = "未打开";
        }

        // 打开串口按钮点击事件
        private void btnSerialOpen_Click(object sender, EventArgs e) => openSerial();

        // 关闭串口按钮点击事件
        private void btnSerialClose_Click(object sender, EventArgs e) => closeSerial();

        // 获取韦根
        private void Reader_eventWG(string data) { }

        // 获取卡号
        private void Reader_eventHex(string data)
        {
            int selectedId = tvOperate.SelectedNode.Index;
            switch (selectedId)
            {
                case 0:
                    poCardNo.Text = data;
                    break;
                case 2:
                    pmcmbCardNo.Text = data;
                    break;
                default:
                    poCardNo.Text = null;
                    pmcmbCardNo.Text = null;
                    break;
            }
         }

        // TreeView选择结点事件
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            // MessageBox.Show("选择了TreeView -->" +treeView1.SelectedNode.Index);
            int selectedId = tvOperate.SelectedNode.Index;
            switch (selectedId)
            {
                case 0:
                    panelNewCard.BringToFront();
                    panelNewCard.Visible = true;
                    gpEdit.Text = tvOperate.Nodes[0].Text;
                    // gpEdit.Text = "发卡管理";
                    break;
                case 1:
                    panelLost.BringToFront();
                    panelLost.Visible = true;
                    gpEdit.Text = tvOperate.Nodes[1].Text;
                    // gpEdit.Text = "挂失";
                    break;
                case 2:
                    panelMonitor.BringToFront();
                    panelMonitor.Visible = true;
                    gpEdit.Text = tvOperate.Nodes[2].Text;
                    //gpEdit.Text = "监控统计";
                    break;
                case 3:
                    panelSearch.BringToFront();
                    panelSearch.Visible = true;
                    gpEdit.Text = tvOperate.Nodes[3].Text;
                    // gpEdit.Text = "信息统计";
                    break;
                default:
                    break;
            }
        }

        // 菜单关于本系统点击事件
        private void msAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }
    }
}
