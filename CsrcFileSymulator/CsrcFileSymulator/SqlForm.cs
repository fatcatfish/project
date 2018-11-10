using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsrcFileSymulator
{
    public partial class SqlForm : Form
    {
        public SqlForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = @"sf=select t.* from xx t 
s = select
scf = select count(*) from xx
tr= truncate table xx
df = delete from xx
up= update xx set
wh = where
int= insert into
sfpro = select t.* from product_base_info t
sfconf =select t.* from confirmation_txrecord t
sfcif =select t.* from customer_cif_info t
sford =select t.* from order_financial t
sfreg =select t.* from registrar_base_info t
sfregs =select t.* from registrar_file_send t
sfregr =select t.* from registrar_file_receive t where t.file_date = to_char(sysdate, 'yyyymmdd') and t.file_id  in ('02','04','06') 
sfregi = select t.* from registrar_interface_info t
sfpos =select t.* from position_balance t
sfposi =select t.* from position_incremental t
sftrp =select t.* from TRANSACTION_TRP_RECONCILIATION t
sfdual =select SYSDATE from DUAL;
sfta = select t.* from customer_taaccount_info t
sforda =select t.* from order_account t
sfctis =select t.* from Transaction_Ctis_Account t
sfcap =select t.* from liquidation_capital t
sftax =select t.* from customer_txaccount_info t";
            Clipboard.SetDataObject(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = @"select t.* from registrar_file_send t where t.file_date = to_char(sysdate,'yyyymmdd') ; ";
            Clipboard.SetDataObject(textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = @"---查询主服务表及其时间表达式 
select a.cron_expression,a.quartz_flag, t.command_table_name, t.* from PERMANENT_MAIN_SERVICE t, permanent_quartz_job a where t.quartz_id = a.quartz_id; ";
            Clipboard.SetDataObject(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = @"----批量轮询指令 
---ACK 
select p.rowid, p.* 
  from PERMANENT_COMMAND_RECEIVE p 
 where p.command_id = 'ACK0001'; 
---HQ 
select p.rowid, p.* 
  from PERMANENT_COMMAND_DAYBATCH p 
 where p.command_id = 'HQ0001'; 
---REQ 
select p.rowid, p.* 
  from PERMANENT_COMMAND_SEND p 
 where p.command_id = 'REQ0001'; 
---下划款 
select p.rowid, p.* 
  from PERMANENT_COMMAND_RECEIVE p 
 where p.command_id = 'XHK0001'; 
---监控短信 
select p.rowid, p.* 
  from PERMANENT_COMMAND_DAYBATCH p 
 where p.command_id = 'DX0001'; 
---ACLOG未明调整及挂账 
select p.rowid, p.* 
  from PERMANENT_COMMAND_DAYBATCH p 
 where p.command_id = 'ACLOG0001'; 
---ACLOG直销交易状态查询 
select p.rowid, p.* 
  from PERMANENT_COMMAND_DAYBATCH p 
 where p.command_id in ('ACLOG0003', 'ACLOG0004'); ";
            Clipboard.SetDataObject(textBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = @"select t.* from registrar_file_receive t where t.file_date = to_char(sysdate,'yyyymmdd') and t.file_usage='ACK' ; ";
            Clipboard.SetDataObject(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = @"select t.* from registrar_file_receive t where t.file_date = to_char(sysdate,'yyyymmdd') and t.file_usage='HQ' ; ";
            Clipboard.SetDataObject(textBox1.Text);
        }
    }
}
