using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 汽车衡智能称重系统_by_C_shape
{
    public partial class 汽车衡智能称重系统 : Form
    {
        public 汽车衡智能称重系统()
        {
            InitializeComponent();
        }

        //-------------------------------------------

        //窗口界面
        private void 汽车衡智能称重系统_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 1000;

           

            USERTextBox.Text = "";
            PasswordTextBox.Text = "";

            //二级菜单
            messPanel.Visible = false;
            addPanel.Visible = false;
            userPanel.Visible = false;
            includingPanel.Visible = false;

            //一级菜单
            admin0.Visible = false;
            admin1.Visible = true;
            mess0.Visible = true;
            mess1.Visible = false;
            add0.Visible = true;
            add1.Visible = false;
            user0.Visible = true;
            user1.Visible = false;
            including0.Visible = true;
            including1.Visible = false;

            //panel容器
            loginPanel.Visible =true;
            newuserPanel.Visible = false;
            adminPanel.Visible = false;
            wPanel.Visible = false;
            cmPanel.Visible = false;
            dmPanel.Visible = false;
            caddPanel.Visible = false;
            daddPanel.Visible = false;
            usermessPanel.Visible = false;
            pwdPanel.Visible = false;
            helpPanel.Visible = false;
            suggestPanel.Visible = false;
            aboutPanel.Visible = false;

            downPanel.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.Second.ToString();
            logintime.Text = DateTime.Now.Second.ToString();
            logtime.Text = DateTime.Now.Second.ToString();
        }

        //'-------------------------------------------

        //登录界面
        //确定按钮
        private void entryButton_Click(object sender, EventArgs e)
        {

        }

        //取消按钮
        private void offButton_Click(object sender, EventArgs e)
        {

        }

        //忘记密码
        private void 忘记密码LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        //注册
        private void 账号注册LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //进入注册界面
            newuserPanel.Visible = true;
            loginPanel.Visible = false;

            //清除注册界面数据
            newuserTextBox.Text = "";
            newpasswTextBox.Text = "";
            newapasswTextBox.Text = "";
            newnameTextBox.Text = "";
        }
       
        //-------------------------------------------

        //账号注册界面
        private void newokButton_Click(object sender, EventArgs e)
        {

        }

        //返回登陆界面
        private void newcancelButton_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = true;
            newuserPanel.Visible = false;
        }

        //-------------------------------------------

        //管理界面
        //点击“管理界面”（未选中）
        private void admin0_Click(object sender, EventArgs e)
        {
            //二级菜单
            messPanel.Visible = false;
            addPanel.Visible = false;
            userPanel.Visible = false;
            includingPanel.Visible = false;

            //一级菜单
            admin0.Visible = false;
            admin1.Visible = true;
            mess0.Visible = true;
            mess1.Visible = false;
            add0.Visible = true;
            add1.Visible = false;
            user0.Visible = true;
            user1.Visible = false;
            including0.Visible = true;
            including1.Visible = false;

            //panel容器
            adminPanel.Visible = true;
            wPanel.Visible = false;
            cmPanel.Visible = false;
            dmPanel.Visible = false;
            caddPanel.Visible = false;
            daddPanel.Visible = false;
            usermessPanel.Visible = false;
            pwdPanel.Visible = false;
            helpPanel.Visible = false;
            suggestPanel.Visible = false;
            aboutPanel.Visible = false;
        }

        //启动按钮
        private void openButton_Click(object sender, EventArgs e)
        {
            //二级菜单
            messPanel.Visible = false;
            addPanel.Visible = false;
            userPanel.Visible = false;
            includingPanel.Visible = false;

            updateButton.Enabled = true;

            //清空数据
        if (TextBox1.Text != "" && TextBox2.Text != "" && TextBox3.Text !="" && TextBox4.Text !="" && TextBox5.Text !="" && TextBox6.Text != "" && TextBox8.Text != "" && TextBox10.Text != "" && TextBox12.Text != ""  )
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = "";
                TextBox10.Text = "";
                TextBox11.Text = "";
                TextBox12.Text = "";
                kindTextBox.Text = "";
                adminremarkTextBox.Text = "";
            }
        }
    }
}
