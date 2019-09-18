using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SqlSugar;
using DbType = System.Data.DbType;

namespace TestClobOrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectStr =
                string.Format(
                    "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))(CONNECT_DATA=(SERVICE_NAME={2})));User Id={3};Password={4};",
                    "192.168.10.60", "1521", "his", "emr", "test");
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            { 
                ConnectionString = connectStr,
                DbType = SqlSugar.DbType.Oracle,        　//必填, 数据库类型
                IsAutoCloseConnection = true,       //默认false, 时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
                InitKeyType = InitKeyType.SystemTable    //默认SystemTable, 字段信息读取, 如：该属性是不是主键，是不是标识列等等信息
            });

          var res = db.Queryable<Dbtestclob>().ToList();
        }
    }
}
