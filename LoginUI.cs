using Lead.Tool.ProjectPath;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lead.Tool.Login
{
    public partial class LoginUI : Form
    {
        private static string filePathUser = "";
        private static string filePathOpe = "";
        private static string filePathAdmin = "";

        public bool IsLogined = false;
        private string _filePath = "";
        public Level _level = Level.NA;
         
        public LoginUI(string ConfigDic)
        {
            InitializeComponent();
            filePathUser = ConfigDic + "\\Config\\Pas\\1.obj";
            filePathOpe = ConfigDic + "\\Config\\Pas\\2.obj";
            filePathAdmin = ConfigDic + "\\Config\\Pas\\3.obj";
            comboBoxLevel.Items.Add(Level.普通用户.ToString());
            comboBoxLevel.Items.Add(Level.工艺员.ToString());
            comboBoxLevel.Items.Add(Level.管理员.ToString());
            comboBoxLevel.Text = Level.普通用户.ToString();
            if (IsLogined)
            {
                this.groupBox1.Hide();
                this.groupBox2.Hide();
            }
            else
            {
                this.groupBox2.Hide();
                this.groupBox3.Hide();
            }
        }
        private void pasFileCheck()
        {
            if (!File.Exists(_filePath))
            {
                FileStream fs1 = new FileStream(_filePath, FileMode.Create, FileAccess.Write);
                fs1.Close();
                setPassword("zzc");

            }
        }
        //获取密码
        private string getPassword()
        {
            pasFileCheck();

            //用于序列化和反序列化的对象
            BinaryFormatter serializer = new BinaryFormatter();
            //反序列化
            FileStream loadFile = new FileStream(_filePath, FileMode.Open, FileAccess.Read);
            List<password> pasResult = (List<password>)serializer.Deserialize(loadFile);
            loadFile.Close();
            return pasResult[0].passWord;
        }

        //保存密码
        private void setPassword(string passWord)
        {
            password pas = new password { passWord = passWord };

            List<password> pasList = new List<password>();
            pasList.Add(pas);
            //开始序列化
            FileStream loadFile = new FileStream(_filePath, FileMode.Create, FileAccess.Write);
            //用于序列化和反序列化的对象
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(loadFile, pasList);
            loadFile.Close();
        }
        private void button登录_Click(object sender, EventArgs e)
        {
            if (textBoxPassWord.Text.Trim() == getPassword())
            {
                IsLogined = true;
                comboBoxLevel.Enabled = false;
                labelWarnning.ForeColor =  Color.Green;
                labelWarnning.Text = "密码正确，登录成功！";
                _level = (comboBoxLevel.Text == Level.普通用户.ToString()) ? Level.普通用户 :
                    (comboBoxLevel.Text == Level.工艺员.ToString()) ? Level.工艺员 :
                    (comboBoxLevel.Text == Level.管理员.ToString()) ? Level.管理员 : Level.NA;
                this.Hide();
            }
            else
            {
                labelWarnning.ForeColor = Color.Red;
                labelWarnning.Text = "密码输入错误，请重试！";
            }
        }



        private void button取消_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {

            _filePath = (comboBoxLevel.Text == Level.普通用户.ToString()) ? filePathUser:
                (comboBoxLevel.Text == Level.工艺员.ToString()) ? filePathOpe :
                (comboBoxLevel.Text == Level.管理员.ToString()) ? filePathAdmin : null;
            textBoxPassWord.Focus();
        }

        private void labelResetPassword_Click(object sender, EventArgs e)
        {
            this.groupBox1.Hide();
            this.groupBox2.Show();
        }

        private void button修改密码_Click(object sender, EventArgs e)
        {
            if (textBoxOldPassword.Text.Trim() == getPassword())
            {
                if (textBoxNewPassword.Text.Trim() != "")
                {
                    setPassword(textBoxNewPassword.Text.Trim());
                    labelWarnning.ForeColor = Color.Green;
                    labelWarnning.Text = "密码修改成功！";
                    this.groupBox1.Show();
                    this.groupBox2.Hide();
                }
            }
            else
            {
                labelWarnning.ForeColor = Color.Red;
                labelWarnning.Text = "密码输入错误，请重试！";
            }
        }

        private void button取消修改_Click(object sender, EventArgs e)
        {
            this.groupBox1.Show();
            this.groupBox2.Hide();
        }

        private void LoginUI_Shown(object sender, EventArgs e)
        {
            labelWarnning.Text = "";
            textBoxPassWord.Text = "";
            if (IsLogined)
            {
                this.groupBox1.Hide();
                this.groupBox2.Hide();
                this.groupBox3.Show();
                this.Refresh();
            }
            else
            {
                this.groupBox2.Hide();
                this.groupBox3.Hide();
                this.groupBox1.Show();
            }
            this.Update();
        }

        private void button登出_Click(object sender, EventArgs e)
        {
            IsLogined = false;
            comboBoxLevel.Enabled = true;
            this.Hide();
        }

        private void button登出取消_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
