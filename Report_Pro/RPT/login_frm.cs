using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Data.SqlClient;
using System.Reflection;
using System.Resources;
using System.Data.OleDb;



namespace Report_Pro.RPT
{
 
    public partial class login_frm : Form 
    
    {


       DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        TreeNode _selectedNode = null;
        DataTable _acountsTb = null;



        public login_frm()
        {
          
            InitializeComponent();


            //if (Properties.Settings.Default.lungh == "0")
            //{
            //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            //}
            //else if (Properties.Settings.Default.lungh == "1")
            //{
            //    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            //}


            ////
            //this.Controls.Clear();


            //InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //DataTable dtv = dal.getDataTabl_1(@"SELECT Password FROM  tblPassword  where pass_id ='Virgon' and Password='2000'");
            //if (dtv.Rows.Count == 0)
            //{
            //    MessageBox.Show("this vergon not approved");
            //    return;
            //}

            DataTable dt = dal.getDataTabl_1(@"SELECT *  FROM wh_USERS  where USER_ID='"+textBox1.Text+"' and PASSWORD='"+ textBox2.Text + "'");
            //DataTable dt_C_ch = dal.getDataTabl_1(@"SELECT *  FROM "+Properties.Settings.Default.Database+ ".dbo.setting_bg_font  where ID='Chiled'");
            //DataTable dt_C_Ma = dal.getDataTabl_1(@"SELECT *  FROM " + Properties.Settings.Default.Database + ".dbo.setting_bg_font  where ID='Main'");
            if (dt.Rows.Count > 0)
            {
                using (var db = new DAL.dbDataContext())
                {
                    var userName = textBox1.Text;
                    var passWord = textBox2.Text;
                    var user = db.wh_USERs.SingleOrDefault(x => x.USER_ID== userName);

                    Classes.Session.SetUser(user);
                    //  PL.Frm_Main frm = new PL.Frm_Main();
                    // Forms.frm_Main frm = new Forms.frm_Main();
                   // frm.Show();
                    Forms.frm_Main.Instance.Show();
                   
                    this.Hide();

                    Program.salesman = dt.Rows[0]["USER_NAME"].ToString();
                    Program.userID = dt.Rows[0]["USER_ID"].ToString();
                    Program.userCostCode = dt.Rows[0][38].ToString();

                    Properties.Settings.Default.C_year = dal.GetCell_1(@"SELECT Cyear FROM Wh_Configration").ToString();

                    DataTable dt_currency = dal.getDataTabl_1(@"SELECT A_Main_currancy,E_Main_currancy,A_sub_currancy,e_sub_currancy FROM Configration_Acc");
                    if(dt_currency.Rows.Count > 0)
                    {
                        Properties.Settings.Default.A_Main_currancy = dt_currency.Rows[0]["A_Main_currancy"].ToString();
                        Properties.Settings.Default.E_Main_currancy = dt_currency.Rows[0]["E_Main_currancy"].ToString();
                        Properties.Settings.Default.A_sub_currancy = dt_currency.Rows[0]["A_sub_currancy"].ToString();
                        Properties.Settings.Default.e_sub_currancy = dt_currency.Rows[0]["e_sub_currancy"].ToString();
                    }
                    //try
                    //{



                        //DataTable tb1 = dal.getDataTabl_1("select * from setting_bg_font where id='Main'");
                        //if (tb1.Rows.Count < 1)
                        //{
                        //    dal.Execute_1("insert into setting_bg_font values(Main,255,255,255,8)");
                        //}
                        //Program.R = Convert.ToInt32(tb1.Rows[0][1]);
                        //Program.G = Convert.ToInt32(tb1.Rows[0][2]);
                        //Program.B = Convert.ToInt32(tb1.Rows[0][3]);
                        //Program.FS = Convert.ToInt32(tb1.Rows[0][4]);

                        //DataTable tb2 = dal.getDataTabl_1("select * from setting_bg_font where id='Chiled'");
                        //if (tb2.Rows.Count < 1)
                        //{
                        //    dal.Execute_1("insert into setting_bg_font values(Chiled,255,255,255,8)");
                        //}
                        //Program.R1 = Convert.ToInt32(tb2.Rows[0][1]);
                        //Program.G1 = Convert.ToInt32(tb2.Rows[0][2]);
                        //Program.B1 = Convert.ToInt32(tb2.Rows[0][3]);
                        //Program.FS1 = Convert.ToInt32(tb2.Rows[0][4]);

                    //}
                    //catch { }

                }
            }

            else
            {
                MessageBox.Show("Faild");
            }

            //DataTable dt_com = dal.getDataTabl_1("select * from Company_Tbl");
            //if (dt_com.Rows.Count > 0)
            //{
            //    Program.companyName_1 = dt_com.Rows[0][1].ToString();
            //    Program.companyName_E1 = dt_com.Rows[0][2].ToString();

            //}





            //PL.Frm_Main frm = new PL.Frm_Main();
            //frm.Show();
            //    this.Hide();           
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text != string.Empty)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)

        {


            if (e.KeyCode == Keys.Enter && textBox2.Text != string.Empty)


            {

               
                DataTable dt = dal.getDataTabl_1(@"SELECT *  FROM wh_USERS  where USER_ID='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'");
                if (dt.Rows.Count > 0)
                {

                    if (dt.Rows[0]["LANG"].ToString() == "A")
                    {

                        chArabic.Checked = true;
                        Properties.Settings.Default.lungh = "0";
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
                       // lang("ar");
                    }
                    else
                    {
                        chEnglish.Checked = true;
                        Properties.Settings.Default.lungh = "1";
                        Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                        //lang("en");
                    }
                    Properties.Settings.Default.Save();

                    if (dt.Rows[0]["CAN_GIVE_PERM"].ToString() == "1")
                    {
                        _acountsTb = dal.getDataTabl_1("select * from  wh_BRANCHES ");
                    }
                    else
                    {
                        _acountsTb = dal.getDataTabl_1("select A.* from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code  where b.User_id = '" + textBox1.Text + "' ");
                    }
                    PopulateTreeView_1("0", null);

                    TV1.SelectedNode = GetNodeByName(TV1.Nodes, dt.Rows[0][8].ToString());



                    

                }
                BtnLogin.Enabled = true;
                BtnLogin.Focus();



                //if (e.KeyCode == Keys.Enter && textBox2.Text != string.Empty)
                //{



                //    BtnLogin.Enabled = true;
                //    BtnLogin.Focus();
                //}
            }

        }


        private void PopulateTreeView(string parentId, TreeNode parentNode)
        {
            TreeNode childNode;
            foreach (DataRow dr in _acountsTb.Select("[PREV_NO]= '" + parentId + "'"))
            {
                TreeNode t = new TreeNode();
                string branch_ = dr["Branch_code"].ToString();
                if (string.IsNullOrEmpty(dr["Branch_code"].ToString()))
                { branch_ = "0"; }
                else
                {
                    branch_ = dr["Branch_code"].ToString();
                }
                t.Text = branch_ + " - " + dr["branch_name"].ToString();
                t.Name = branch_;
                t.Tag = _acountsTb.Rows.IndexOf(dr);
                if (dr["t_final"].ToString() == "1")
                {
                    t.ImageIndex = 0;
                    t.SelectedImageIndex = 1;
                }
                else
                {
                    t.ImageIndex = 2;
                    t.SelectedImageIndex = 6;
                }
                if (parentNode == null)
                {

                    TV1.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }
               
                PopulateTreeView(branch_, childNode);
            }
        }


        private void PopulateTreeView_1(string parentId, TreeNode parentNode)
        {
            TV1.Nodes.Clear();
            TreeNode node1;
            TreeNode childNode;
            if (Properties.Settings.Default.lungh == "0")
            {
                node1 = new TreeNode("الفروع");
            }
            else
            {
                node1 = new TreeNode("Branches");
            }
            
            
            TV1.Nodes.Add(node1);
            foreach (DataRow dr in _acountsTb.Select())
             {
                TreeNode t = new TreeNode();
                string branch_ = dr["Branch_code"].ToString();
                if (Properties.Settings.Default.lungh == "0")
                {
                    t.Text = branch_ + " - " + dr["branch_name"].ToString();
                }
                else
                {
                    t.Text = branch_ + " - " + dr["WH_E_NAME"].ToString();
                }
                t.Name = branch_;
                t.Tag = _acountsTb.Rows.IndexOf(dr);
                if (dr["t_final"].ToString() == "1")
                {
                    t.ImageIndex = 0;
                    t.SelectedImageIndex = 1;
                }
                else
                {
                    t.ImageIndex = 2;
                    t.SelectedImageIndex = 6;
                }

                       
                if (parentNode == null)
                {

                    node1.Nodes.Add(t);
                    childNode = t;
                }
                else
                {

                    parentNode.Nodes.Add(t);

                    childNode = t;

                }

                PopulateTreeView(branch_, childNode);
            }
        }








        public static void lang(string lge)
        {
            System.Globalization.CultureInfo TypeOfLanguage = new System.Globalization.CultureInfo(lge);
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(TypeOfLanguage);
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupPanel3.Visible = true;
                     
        }

       

     
        private void button4_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.lungh = "1";
            foreach (Form frm in this.MdiChildren)
            {

                frm.Dispose();
            }
            if (Properties.Settings.Default.lungh == "1")
            {
                Properties.Settings.Default.lungh = "0";
                Properties.Settings.Default.Save();
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
                this.Controls.Clear();
                InitializeComponent();
                lang("ar");
                button4.Text = "English";
            }
            else if (Properties.Settings.Default.lungh == "0")
            {
                Properties.Settings.Default.lungh = "1";
                Properties.Settings.Default.Save();
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                this.Controls.Clear();
                InitializeComponent();
                lang("en");
                button4.Text = "عربي";
            }
          
              
           
            textBox1.Focus();
         
            
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {

                frm.Dispose();
            }

            Properties.Settings.Default.lungh = "1";
            Properties.Settings.Default.Save();
          

            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
            this.Controls.Clear();


            InitializeComponent();
            lang("en");
            textBox1.Focus();

          


        }

        


    

     

     


        private TreeNode GetNodeByName(TreeNodeCollection nodes, string searchtext)
        {
            TreeNode n_found_node = null;
            bool b_node_found = false;

            foreach (TreeNode node in nodes)
            {

                if (node.Name == searchtext)
                {
                    b_node_found = true;
                    n_found_node = node;

                    return n_found_node;
                }

                if (!b_node_found)
                {
                    n_found_node = GetNodeByName(node.Nodes, searchtext);

                    if (n_found_node != null)
                    {
                        return n_found_node;
                    }
                }
            }
            return null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "administrator";
            //textBox2.Text = "P!!@@ssw0rd";
        }

        private void login_frm_Load(object sender, EventArgs e)
        {
            txtserver.Text = Properties.Settings.Default.Server;
            txtDatabase.Text =Properties.Settings.Default.Database;
            txtDataBase_1.Text= Properties.Settings.Default.Database_1 ;

            //Properties.Settings.Default.Mode = RbSql.Checked == true ? "sql" : "windows";
            txtUserName.Text=Properties.Settings.Default.Id;
            txtpasseord.Text=Properties.Settings.Default.Password;

            textBox1.Text = Environment.UserName;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                DataTable dt = dal.getDataTabl_1(@"SELECT *  FROM wh_USERS  where USER_ID='" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    TV1.SelectedNode = GetNodeByName(TV1.Nodes, dt.Rows[0][8].ToString());
                }


            }
        }

        private void TV1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedNode = TV1.SelectedNode;
            GetData(_selectedNode);
        }

        private void GetData(TreeNode nod)
        {
            DataRow r = _acountsTb.Rows[int.Parse(nod.Tag.ToString())];
            Properties.Settings.Default.BranchId = r[0].ToString();
            lblBranchCode.Text= r[0].ToString();
            if(Properties.Settings.Default.lungh == "0")
            {
                lblBranchName.Text = r[1].ToString();
            }
            else
            {
                lblBranchName.Text = r[2].ToString();
            }
            
            Properties.Settings.Default.BranchAccID = r[5].ToString();
            Properties.Settings.Default.TRANS_TO_ACC = r[13].ToString();
          
            Properties.Settings.Default.Save();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Server = txtserver.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.Database_1 = txtDataBase_1.Text;
            Properties.Settings.Default.Mode = RbSql.Checked == true ? "sql" : "windows";
            Properties.Settings.Default.Id = txtUserName.Text;
            Properties.Settings.Default.Password = txtpasseord.Text;
           
            Properties.Settings.Default.Save();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
            if (textBox3.Text == "1975")
            {
                textBox2.Text= dal.getDataTabl_1(@"SELECT PASSWORD  FROM wh_USERS  where USER_ID='" + textBox1.Text + "'").Rows[0][0].ToString();
            }
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            DataTable dt_tb = new DataTable();
            dt_tb = dal.getDataTabl_1(@"SELECT TABLE_CATALOG,TABLE_SCHEMA,TABLE_NAME,TABLE_TYPE from INFORMATION_SCHEMA.TABLES ");
            //dt_ = dal.getdatatabl_1(@"select menu_code,menu_name,menu_e_name,form_name,isnull(software_code,0),securty_code,securty_code2,securty_mode,main_no,isnull(prev_no,0),isnull(t_final,0),isnull(t_level,0),isnull(image_large_icon,0),isnull(image_small_icon,0),notes,user_id,g_date,isnull(administrator_level,0),screen_name from " + properties.settings.default.database + ".dbo.sysmenu ");

            OleDbConnection conn = new OleDbConnection();
            string cnString_tb = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + System.IO.Directory.GetCurrentDirectory() + "\\adj.mdb";
            conn = new OleDbConnection(cnString_tb);

            OleDbCommand cmd_tb = new OleDbCommand("delete from DataTables", conn);
            conn.Open();
            cmd_tb.ExecuteNonQuery();
            conn.Close();

            conn.Open();


            foreach (DataRow DR in dt_tb.Rows)
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO DataTables (TABLE_CATALOG,TABLE_SCHEMA,TABLE_NAME,TABLE_TYPE) VALUES('" + DR[0] + "','" + DR[1] + "','" + DR[2] + "','" + DR[3] + "')", conn);
                command.ExecuteNonQuery();
            }

            conn.Close();



            DataTable dt_ = new DataTable();
            dt_ = dal.getDataTabl_1(@"select  A.TABLE_CATALOG,A.TABLE_NAME,COLUMN_NAME,DATA_TYPE,isnull(CHARACTER_MAXIMUM_LENGTH,0) as CHARACTER_MAXIMUM_LENGTH,IS_NULLABLE from INFORMATION_SCHEMA.COLUMNS As A
            inner join INFORMATION_SCHEMA.TABLES As B on A.TABLE_NAME = B.TABLE_NAME where B.TABLE_TYPE ='Base table'");
            //dt_ = dal.getdatatabl_1(@"select menu_code,menu_name,menu_e_name,form_name,isnull(software_code,0),securty_code,securty_code2,securty_mode,main_no,isnull(prev_no,0),isnull(t_final,0),isnull(t_level,0),isnull(image_large_icon,0),isnull(image_small_icon,0),notes,user_id,g_date,isnull(administrator_level,0),screen_name from " + properties.settings.default.database + ".dbo.sysmenu ");

            //OleDbConnection conn = new OleDbConnection();
            string cnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + System.IO.Directory.GetCurrentDirectory() + "\\adj.mdb";
            conn = new OleDbConnection(cnString);

            OleDbCommand cmd = new OleDbCommand("delete from tatable", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();


            foreach (DataRow DR in dt_.Rows)
            {
                OleDbCommand command = new OleDbCommand("INSERT INTO tatable (database_name,table_name,field_name,field_type,field_size,AllowNull) VALUES('" + DR[0] + "','" + DR[1] + "','" + DR[2] + "','" + DR[3] + "'," + DR[4] + "," + DR[5] + ")", conn);
                command.ExecuteNonQuery();
            }

            conn.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            string cnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + System.IO.Directory.GetCurrentDirectory() + "\\adj.mdb";
            conn = new OleDbConnection(cnString);
            conn.Open();

            //OleDbCommand cmd_tb = new OleDbCommand("SELECT TABLE_CATALOG,TABLE_SCHEMA,TABLE_NAME,TABLE_TYPE from DataTables where TABLE_TYPE= 'base table' ", conn);
            //OleDbDataAdapter da_tb = new OleDbDataAdapter(cmd_tb);
            //DataTable dt_tb = new DataTable();
            //da_tb.Fill(dt_tb);
            //foreach (DataRow DR_tb in dt_tb.Rows)
            //{
            //    DataTable dt_check = dal.getDataTabl_1(@"SELECT TABLE_CATALOG,TABLE_SCHEMA,TABLE_NAME,TABLE_TYPE from INFORMATION_SCHEMA.TABLES where TABLE_NAME ='"+ DR_tb[2]+"' ");
            //    foreach (DataRow DR_ch in dt_check.Rows)
            //    {
                    OleDbCommand cmd = new OleDbCommand("Select database_name,table_name,field_name,field_type,field_size,AllowNull from tatable ", conn);
                    OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    conn.Close();

                    foreach (DataRow DR in dt1.Rows)
                    {
                        string f_siez = null;
                        if (DR[4].ToString() == "0" || DR[4].ToString().ParseInt(0) > 8000)
                        {
                            f_siez = null;
                        }
                        else if (DR[4].ToString() == "-1")
                        {
                            f_siez = "(max)";
                        }
                        else
                        {
                            f_siez = "(" + DR[4].ToString() + ")";
                        }

                        string f_Null = null;
                        if (DR[5].ToString() == "False")
                        {
                            f_Null = "not null";
                        }
                        else
                        {
                            f_Null = "null";

                        }


                        dal.Execute_1(@"iF NOT EXISTS " +
                        "(SELECT  TABLE_CATALOG, TABLE_NAME, COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS WHERE  TABLE_NAME = '" + DR[1] + "' and  COLUMN_NAME = '" + DR[2] +
                        "') BEGIN ALTER TABLE " + DR[1].ToString() + "  ADD   " + DR[2].ToString() + " " + DR[3].ToString() + " " + f_siez + " " + f_Null + " end");
                    
            }
            MessageBox.Show("data was adjusted");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            DataTable dt_tb = new DataTable();
            dt_tb = dal.getDataTabl_1(@"SELECT TABLE_CATALOG,TABLE_SCHEMA,TABLE_NAME,TABLE_TYPE from INFORMATION_SCHEMA.TABLES ");
            //dt_ = dal.getdatatabl_1(@"select menu_code,menu_name,menu_e_name,form_name,isnull(software_code,0),securty_code,securty_code2,securty_mode,main_no,isnull(prev_no,0),isnull(t_final,0),isnull(t_level,0),isnull(image_large_icon,0),isnull(image_small_icon,0),notes,user_id,g_date,isnull(administrator_level,0),screen_name from " + properties.settings.default.database + ".dbo.sysmenu ");

            OleDbConnection conn = new OleDbConnection();
            string cnString_tb = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + System.IO.Directory.GetCurrentDirectory() + "\\adj.mdb";
            conn = new OleDbConnection(cnString_tb);

            OleDbCommand cmd_tb = new OleDbCommand("delete from DataTables", conn);
            conn.Open();
            cmd_tb.ExecuteNonQuery();
            conn.Close();

            conn.Open();

            if (dt_tb.Rows.Count > 0)
            {
                foreach (DataRow DR in dt_tb.Rows)
                {
                    OleDbCommand command = new OleDbCommand("INSERT INTO DataTables (TABLE_CATALOG,TABLE_SCHEMA,TABLE_NAME,TABLE_TYPE) VALUES('" + DR[0] + "','" + DR[1] + "','" + DR[2] + "','" + DR[3] + "')", conn);
                    command.ExecuteNonQuery();
                }

                conn.Close();
            }

            try
            {
                string cnString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + System.IO.Directory.GetCurrentDirectory() + "\\adj.mdb";
                conn = new OleDbConnection(cnString);
                conn.Open();

                OleDbCommand cmd = new OleDbCommand(@"SELECT DISTINCT First(t1.database_name) AS database_name, First(t1.table_name) AS table_name, First(t1.field_name) AS field_name, First(t1.field_type) AS field_type, First(t1.field_size) AS field_size, First(t1.AllowNull) AS AllowNull
            FROM tatable AS t1
            WHERE ((Exists(SELECT 1 FROM DataTables as t2 WHERE t2.TABLE_NAME = t1.table_name)) = False)", conn);
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                if (dt1.Rows.Count > 0)
                {
                    foreach (DataRow DR in dt1.Rows)
                    {
                        string f_siez = null;
                        if (DR[4].ToString() == "0" || DR[4].ToString().ParseInt(0) > 8000)
                        {
                            f_siez = null;
                        }
                        else if (DR[4].ToString() == "-1")
                        {
                            f_siez = "(max)";
                        }
                        else
                        {
                            f_siez = "(" + DR[4].ToString() + ")";
                        }

                        string f_Null = null;
                        if (DR[5].ToString() == "False")
                        {
                            f_Null = "not null";
                        }
                        else
                        {
                            f_Null = "not null";

                        }


                        dal.Execute_1(@" create TABLE " + DR[1].ToString() + " ( " + DR[2].ToString() + " " + DR[3].ToString() + " " + f_siez + " " + f_Null + ")");



                    }
                    MessageBox.Show("data was adjusted");
                }
            }
            catch
            {

            }

        }

        private void chArabic_CheckedChanged(object sender, EventArgs e)
        {

         
                if(chArabic.Checked == true) { 
                Properties.Settings.Default.lungh = "0";
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            }
            else
            {
                
                Properties.Settings.Default.lungh = "1";
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                //lang("en");
            }
            Properties.Settings.Default.Save();


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            
        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
            if (toggleSwitch1.IsOn)
            {
                textBox2.PasswordChar = default(char);
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void chEnglish_CheckedChanged(object sender, EventArgs e)
        {

            if (chArabic.Checked == true)
            {
                Properties.Settings.Default.lungh = "0";
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
            }
            else
            {

                Properties.Settings.Default.lungh = "1";
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                //lang("en");
            }
            Properties.Settings.Default.Save();

        }
    }
}
