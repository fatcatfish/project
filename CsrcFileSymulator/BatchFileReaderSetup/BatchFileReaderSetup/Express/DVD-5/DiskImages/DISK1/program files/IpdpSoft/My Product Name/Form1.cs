using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace CsrcFileSymulator
{
    public partial class IpdpBatchFileReader : Form
    {
        public IpdpBatchFileReader()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void 中银易商文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 选项ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem2.OwnerItem.Text+toolStripMenuItem2.Text+"文件";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 版权ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem3.OwnerItem.Text+toolStripMenuItem3.Text+"文件";
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem4.OwnerItem.Text + toolStripMenuItem4.Text + "文件";
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem6.OwnerItem.Text + toolStripMenuItem6.Text + "文件";
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem7.OwnerItem.Text + toolStripMenuItem7.Text + "文件";

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem3.OwnerItem.Text + toolStripMenuItem8.Text + "文件";
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem3.OwnerItem.Text + toolStripMenuItem9.Text + "文件";
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem3.OwnerItem.Text + toolStripMenuItem10.Text + "文件";
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem3.OwnerItem.Text + toolStripMenuItem11.Text + "文件";
        }

        private void c1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem3.OwnerItem.Text + c1ToolStripMenuItem.Text + "文件";
        }

        private void c2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem3.OwnerItem.Text + c2ToolStripMenuItem.Text + "文件";
        }

        private void c5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem3.OwnerItem.Text + c5ToolStripMenuItem.Text + "文件";
        }

        private void c6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem3.OwnerItem.Text + c6ToolStripMenuItem.Text + "文件";
        }

        private void fEDZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = fEDZToolStripMenuItem.OwnerItem.Text + fEDZToolStripMenuItem.Text + "文件";
        }

        private void sHQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = sHQRToolStripMenuItem.OwnerItem.Text + sHQRToolStripMenuItem.Text + "文件";
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem12.OwnerItem.Text + toolStripMenuItem12.Text + "文件";
        }

        private void f1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = f1ToolStripMenuItem.OwnerItem.Text + f1ToolStripMenuItem.Text + "文件";
        }

        private void f2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = f2ToolStripMenuItem.OwnerItem.Text + f2ToolStripMenuItem.Text + "文件";
        }

        private void f3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = f3ToolStripMenuItem.OwnerItem.Text + f3ToolStripMenuItem.Text + "文件";
        }

        private void f4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = f4ToolStripMenuItem.OwnerItem.Text + f4ToolStripMenuItem.Text + "文件";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aSSU文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tRP对账文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileContext.Text == "")
            {
                MessageBox.Show("请将报文体粘贴到上面文本框中!");
            }
            else if (textBox1.Text == "请首先选择解析文件类型")
            {
                MessageBox.Show("请首先选择文件类型！");
            }
            else {
                fileAnalysis(textBox1.Text,fileContext.Text);
            }
        }

        private void fileAnalysis(String selectMode,String inputStr)
        {
            //throw new NotImplementedException();
            String[] paramNameListCsrc01 = { "ADDRESS", "INSTREPRIDCODE", "INSTREPRIDTYPE", "INSTREPRNAME", "APPSHEETSERIALNO", "CERTIFICATETYPE", "CERTIFICATENO", "INVESTORNAME", "TRANSACTIONDATE", "TRANSACTIONTIME", "IDDOI", "POSTCODE", "TRANSACTORCERTNO", "TRANSACTORCERTTYPE", "TRANSACTORNAME", "TRANSACTIONACCOUNTID ", "DISTRIBUTORCODE", "BUSINESSCODE", "ANOFMICA", "ANOFFMICLA", "CLEARINGAGENCYCODE", "INVESTORSBIRTHDAY", "DEPOSITACCT", "REGIONCODE", "EDUCATIONLEVEL", "EMAILADDRESS", "FAXNO", "VOCATIONCODE", "HOMETELNO", "ANNUALINCOME", "MOBILETELNO", "BRANCHCODE", "OFFICETELNO", "ACCOUNTABBR", "CFDLDC", "SEX", "SHSECURITIESACCOUNTID", "SZSECURITIESACCOUNTID", "TAACCOUNTID", "TELNO", "TRADINGMETHOD", "MINORFLAG", "DELIVERTYPE", "TRANSACTORIDTYPE", "ACCOUNTCARDID", "MULTIACCTFLAG", "TTAID", "ANOFIINCA", "ANOOFIINCA", "CLEARINGAGENCY", "DELIVERWAY", "NATIONALITY", "NETNO", "BROKER", "CORPNAME", "CERTVALIDDATE", "INSTTRANCERTVALIDDATE", "INSTREPRCERTVALIDDATE", "CLIENTRISKRATE", "INSTREPRMANAGERANGE  ", "CONTROLHOLDER", "ACTUALCONTROLLER", "MARRIAGESTATUS", "FAMILYNUM", "PENATES", "MEDIAHOBBY", "INSTITUTIONTYPE", "ENGLISHFIRSTNAME", "ENGLISHFAMLIYNAME", "VOCATION", "CORPOPROPERTY", "STAFFNUM", "HOBBYTYPE", "PROVINCE", "CITY", "COUNTY", "COMMENDPERSON", "COMMENDPERSONTYPE", "ACCEPTMETHOD", "FROZENCAUSE", "FREEZINGDEADLINE", "ORIGINALSERIALNO", "ORIGINALAPPSHEETNO", "SPECIFICATION" };
            String[] paramCNameListCsrc01 = { "通讯地址", "法人代表身份证件代码", "法人代表证件类型", "法人代表姓名", "申请单编号", "个人证件类型及机构证件型", "投资人证件号码", "投资人户名", "交易发生日期", "交易发生时间", "个人/机构标志", "投资人邮政编码", "经办人证件号码", "经办人证件类型", "经办人姓名", "投资人基金交易帐号", "销售人代码", "业务代码", "基金管理人在资金清算机构的交收帐号", "基金管理人在资金清算机构的交收账户名", "基金资金清算机构代码", "投资人出生日期", "投资人在销售人处用于交易的资金帐号", "交易所在地区编号", "投资人学历", "投资人E-MAIL地址", "投资人传真号码", "投资人职业代码", "投资人住址电话", "投资人年收入", "投资人手机号码", "网点号码", "投资人单位电话号码", "投资人户名简称", "密函编号", "投资人性别", "上海证券帐号", "深圳证券帐号", "投资人基金帐号", "投资人电话号码", "使用的交易手段", "未成年人标志", "对帐单寄送选择", "经办人识别方式", "基金账户卡的凭证号", "多渠道开户标志", "对方销售人处投资人基", "金交易帐号", "投资人收款银行账户户名", "投资人收款银行账户账号", "投资人收款银行账户开户行", "对帐单寄送方式", "投资者国籍", "操作（清算）网点编号", "经纪人", "工作单位名称", "证件有效日期", "机构经办人身份证件有效日期", "机构法人身份证件有效日期", "客户风险等级", "机构法人经营范围", "控股股东", "实际控制人", "婚姻状况", "家庭人口数", "家庭资产", "媒体偏好", "机构类型", "投资人英文名", "投资人英文姓", "行业", "企业性质", "员工人数", "兴趣爱好类型", "省/直辖市", "市", "县/区", "推荐人", "推荐人类型", "受理方式", "冻结原因", "冻结截止日期", "TA的原确认流水号", "原申请单编号", "摘要/说明" };
            int[] paramStartPosCsrc01= { 1, 121, 151, 152, 172, 196, 197, 227, 347, 355, 361, 362, 368, 398, 399, 419, 436, 445, 448, 476, 536, 545, 553, 572, 576, 579, 619, 643, 646, 668, 676, 700, 709, 731, 743, 751, 752, 762, 772, 784, 806, 814, 815, 816, 817, 825, 826, 843, 903, 931, 940, 948, 951, 960, 972, 1012, 1020, 1028, 1036, 1037, 1039, 1119, 1199, 1200, 1202, 1218, 1219, 1220, 1240, 1260, 1264, 1266, 1282, 1284, 1290, 1296, 1302, 1342, 1343, 1344, 1345, 1353, 1373, 1397, 1457 };
            String[] paramTypeCsrc01= { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrc02 = { "APPSHEETSERIALNO","TRANSACTIONCFMDATE","RETURNCODE","TRANSACTIONACCOUNTID","DISTRIBUTORCODE","BUSINESSCODE","TAACCOUNTID","MULTIACCTFLAG","TASERIALNO","TRANSACTIONDATE","TRANSACTIONTIME","BRANCHCODE","FROMTAFLAG","CERTIFICATETYPE","CERTIFICATENO","INVESTORNAME","IDDOI","ACCOUNTABBR","ACCOUNTCARDID","REGIONCODE","TTAID","NETNO","SPECIFICATION","CUSTOMERNO","FROZENCAUSE","FREEZINGDEADLINE","ERRORDETAIL"};
            String[] paramCNameListCsrc02 = { "申请单编号", "交易确认日期", "交易处理返回代码", "投资人基金交易帐号", "销售人代码", "业务代码", "投资人基金帐号", "多渠道开户标志", "TA确认交易流水号", "交易发生日期", "交易发生时间", "网点号码", "是否注册登记人发起业务标志", "个人证件类型及机构证件型", "投资人证件号码", "投资人户名", "个人/机构标志", "投资人户名简称", "基金账户卡的凭证号", "交易所在地区编号", "对方销售人处投资人基金交易帐号", "操作（清算）点编号", "摘要/说明", "TA客户号", "冻结原因", "冻结截止日期", "出错详细信息" };
            int[] paramStartPosCsrc02 = { 1, 25, 33, 37, 54, 63, 66, 78, 79, 99, 107, 113, 122, 123, 124, 154, 274, 275, 287, 295, 299, 316, 325, 385, 397, 398, 406, 466 };
            String[] paramTypeCsrc02 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrc03 = { "APPSHEETSERIALNO", "FUNDCODE", "LARGEREDEMPTIONFLAG", "TRANSACTIONDATE", "TRANSACTIONTIME", "TRANSACTIONACCOUNTID", "DISTRIBUTORCODE", "APPLICATIONVOL", "APPLICATIONAMOUNT", "BUSINESSCODE", "TAACCOUNTID", "DISCOUNTRATEOFCOMMISSION", "DEPOSITACCT", "REGIONCODE", "CURRENCYTYPE", "BRANCHCODE", "ORIGINALAPPSHEETNO", "ORIGINALSUBSDATE", "INDIVIDUALORINSTITUTION", "VALIDPERIOD", "DAYSREDEMPTIONINADVANCE", "REDEMPTIONDATEINADVANCE", "ORIGINALSERIALNO", "DATEOFPERIODICSUBS", "TASERIALNO", "TERMOFPERIODICSUBS", "FUTUREBUYDATE", "TARGETDISTRIBUTORCODE", "CHARGE", "TARGETBRANCHCODE", "TARGETTRANSACTIONACCOUNTID", "TARGETREGIONCODE", "DIVIDENDRATIO", "SPECIFICATION", "CODEOFTARGETFUND", "TOTALBACKENDLOAD", "SHARECLASS", "ORIGINALCFMDATE", "DETAILFLAG", "ORIGINALAPPDATE", "DEFDIVIDENDMETHOD", "FROZENCAUSE", "FREEZINGDEADLINE", "VARIETYCODEOFPERIODICSUBS", "SERIALNOOFPERIODICSUBS", "RATIONTYPE", "TARGETTAACCOUNTID", "TARGETREGISTRARCODE", "NETNO", "CUSTOMERNO", "TARGETSHARETYPE", "RATIONPROTOCOLNO", "BEGINDATEOFPERIODICSUBS", "ENDDATEOFPERIODICSUBS", "SENDDAYOFPERIODICSUBS", "BROKER", "SALESPROMOTION", "ACCEPTMETHOD", "FORCEREDEMPTIONTYPE", "TAKEINCOMEFLAG", "PURPOSEOFPESUBS", "FREQUENCYOFPESUBS", "PERIODSUBTIMEUNIT", "BATCHNUMOFPESUBS", "CAPITALMODE", "DETAILCAPTICALMODE", "BACKENLOADDISCOUNT", "COMBINENUM", "FUTURESUBSCRIBEDATE", "TRADINGMETHOD", "LARGEBUYFLAG", "CHARGETYPE", "SPECIFYRATEFEE", "SPECIFYFEE" };
            String[] paramCNameListCsrc03 = { "申请单编号", "基金代码", "巨额赎回处理标志", "交易发生日期", "交易发生时间", "投资人基金交易帐号", "销售人代码", "申请基金份数", "申请金额", "业务代码", "投资人基金帐号", "销售佣金折扣率", "投资人在销售人处用于交易的资金帐号", "交易所在地区编号", "结算币种", "网点号码", "原申请单编号", "原申购日期", "个人/机构标志", "交易申请有效天数", "预约赎回工作日天数", "预约赎回日期", "TA的原确认流水号", "定期定额申购日期", "TA确认交易流水号", "定期定额申购期限", "指定申购日期", "对方销售人代码", "手续费", "对方网点号", "对方销售人处投资人基金交易帐号", "对方所在地区编号", "红利比例", "摘要/说明", "转换时的目标基金代码", "交易后端收费总额", "收费类别", "TA的原确认日期", "数据明细标志", "原申请日期", "默认分红方式", "冻结原因", "冻结截止日期", "定时定额品种代码", "定时定额申购序号", "定期定额种类", "对方基金账号", "对方TA代码", "操作（清算）网点编号", "TA客户编号", "对方基金份额类别", "定期定额协议号", "定时定额申购起始日期", "定时定额申购终止日期", "定时定额申购每月发送日", "经纪人", "促销活动代码", "受理方式", "强制赎回类型", "带走收益标志", "定投目的", "定投频率", "定投周期单位", "定投期数", "资金方式", "明细资金方式", "补差费折扣率", "组合编号", "指定认购日期", "使用的交易手段", "巨额购买处理标志", "收费类型", "指定费率", "指定费用" };
            int[] paramStartPosCsrc03 = { 1, 25, 31, 32, 40, 46, 63, 72, 88, 104, 107, 119, 124, 143, 147, 150, 159, 183, 191, 192, 194, 199, 207, 227, 235, 255, 260, 268, 277, 287, 296, 313, 317, 333, 393, 399, 415, 416, 424, 425, 433, 434, 435, 443, 448, 453, 454, 466, 468, 477, 489, 490, 510, 518, 526, 528, 540, 543, 544, 545, 546, 586, 591, 592, 608, 610, 612, 617, 623, 631, 639, 640, 641, 650, 666 };
            String[] paramTypeCsrc03 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER" };

            String[] paramNameListCsrc04 = { "APPSHEETSERIALNO", "TRANSACTIONCFMDATE", "CURRENCYTYPE", "CONFIRMEDVOL", "CONFIRMEDAMOUNT", "FUNDCODE", "LARGEREDEMPTIONFLAG", "TRANSACTIONDATE", "TRANSACTIONTIME", "RETURNCODE", "TRANSACTIONACCOUNTID", "DISTRIBUTORCODE", "APPLICATIONVOL", "APPLICATIONAMOUNT", "BUSINESSCODE", "TAACCOUNTID", "TASERIALNO", "BUSINESSFINISHFLAG", "DISCOUNTRATEOFCOMMISSION", "DEPOSITACCT", "REGIONCODE", "DOWNLOADDATE", "CHARGE", "AGENCYFEE", "NAV", "BRANCHCODE", "ORIGINALAPPSHEETNO", "ORIGINALSUBSDATE", "OTHERFEE1", "INDIVIDUALORINSTITUTION", "REDEMPTIONDATEINADVANCE", "STAMPDUTY", "VALIDPERIOD", "RATEFEE", "TOTALBACKENDLOAD", "ORIGINALSERIALNO", "SPECIFICATION", "DATEOFPERIODICSUBS", "TARGETDISTRIBUTORCODE", "TARGETBRANCHCODE", "TARGETTRANSACTIONACCOUNTID", "TARGETREGIONCODE", "TRANSFERDIRECTION", "DEFDIVIDENDMETHOD", "DIVIDENDRATIO", "INTEREST", "VOLUMEBYINTEREST", "INTERESTTAX", "TRADINGPRICE", "FREEZINGDEADLINE", "FROZENCAUSE", "TAX", "TARGETNAV", "TARGETFUNDPRICE", "CFMVOLOFTARGETFUND", "MINFEE", "OTHERFEE2", "ORIGINALAPPDATE", "TRANSFERFEE", "FROMTAFLAG", "SHARECLASS", "DETAILFLAG", "REDEMPTIONINADVANCEFLAG", "FROZENMETHOD", "ORIGINALCFMDATE", "REDEMPTIONREASON", "CODEOFTARGETFUND", "TOTALTRANSFEE", "VARIETYCODEOFPERIODICSUBS", "SERIALNOOFPERIODICSUBS", "RATIONTYPE", "TARGETTAACCOUNTID", "TARGETREGISTRARCODE", "NETNO", "CUSTOMERNO", "TARGETSHARETYPE", "RATIONPROTOCOLNO", "BEGINDATEOFPERIODICSUBS", "ENDDATEOFPERIODICSUBS", "SENDDAYOFPERIODICSUBS", "BROKER", "SALESPROMOTION", "ACCEPTMETHOD", "FORCEREDEMPTIONTYPE", "ALTERNATIONDATE", "TAKEINCOMEFLAG", "PURPOSEOFPESUBS", "FREQUENCYOFPESUBS", "PERIODSUBTIMEUNIT", "BATCHNUMOFPESUBS", "CAPITALMODE", "DETAILCAPTICALMODE", "BACKENLOADDISCOUNT", "COMBINENUM", "REFUNDAMOUNT", "SALEPERCENT", "MANAGERREALRATIO", "CHANGEFEE", "RECUPERATEFEE", "ACHIEVEMENTPAY", "ACHIEVEMENTCOMPEN", "SHARESADJUSTMENTFLAG", "GENERALTASERIALNO", "UNDISTRIBUTEMONETARYINCOME", "UNDISTRIBUTEMONETARYINCOMEFLAG", "BREACHFEE", "BREACHFEEBACKTOFUND", "PUNISHFEE", "TRADINGMETHOD", "CHANGEAGENCYFEE", "RECUPERATEAGENCYFEE", "ERRORDETAIL", "LARGEBUYFLAG", "RAISEINTEREST", "FEECALCULATOR", "SHAREREGISTERDATE" };
            String[] paramCNameListCsrc04 = { "申请单编号", "交易确认日期", "结算币种", "基金账户交易确认份数", "每笔交易确认金额", "基金代码", "巨额赎回处理标志", "交易发生日期", "交易发生时间", "交易处理返回代码", "投资人基金交易帐号", "销售人代码", "申请基金份数", "申请金额", "业务代码", "投资人基金帐号", "TA确认交易流水号", "业务过程完全结束标识", "销售佣金折扣率", "投资人在销售人处用于交易的资金帐号", "交易所在地区编号", "交易数据下传日期", "手续费", "代理费", "基金单位净值", "网点号码", "原申请单编号", "原申购日期", "其他费用1", "个人/机构标志", "预约赎回日期", "印花税", "交易申请有效天数", "费率", "交易后端收费总额", "TA的原确认流水号", "摘要/说明", "定期定额申购日期", "对方销售人代码", "对方网点号", "对方销售人处投资人基金交易帐号", "对方所在地区编号", "转入/转出标识", "默认分红方式", "红利比例", "基金账户利息金额", "利息产生的基金份数", "利息税", "交易价格", "冻结截止日期", "冻结原因", "税金", "目标基金的单位净值", "目标基金的价格", "目标基金的确认份数", "最少收费", "其他费用2", "原申请日期", "过户费", "是否注册登记人发起业务标志", "收费类别", "数据明细标志", "预约赎回标志", "冻结方式", "TA的原确认日期", "强行赎回原因", "转换时的目标基金代码", "交易确认费用合计", "定时定额品种代码", "定时定额申购序号", "定期定额种类", "对方基金账号", "对方TA代码", "操作（清算）网点编号", "TA客户编号", "对方基金份额类别", "定期定额协议号", "定时定额申购起始日期", "定时定额申购终止日期", "定时定额申购每月发送日", "经纪人", "促销活动代码", "受理方式", "强制赎回类型", "最后更新日", "带走收益标志", "定投目的", "定投频率", "定投周期单位", "定投期数", "资金方式", "明细资金方式", "补差费折扣率", "组合编号", "退款金额", "配售比例", "实际计算折扣", "转换费", "补差费", "业绩报酬", "业绩补偿", "份额强制调整标志", "总TA确认流水号", "货币基金未付收益金额", "货币基金未付收益金额正负", "违约金", "违约金归基金资产金额", "惩罚性费用", "使用的交易手段", "转换代理费", "补差代理费", "出错详细信息", "巨额购买处理标志", "认购期间利息", "计费人", "份额注册日期" }; int[] paramStartPosCsrc04 = { 1, 25, 33, 36, 52, 68, 74, 75, 83, 89, 93, 110, 119, 135, 151, 154, 166, 186, 187, 192, 211, 215, 223, 233, 243, 250, 259, 283, 291, 301, 302, 310, 326, 328, 337, 353, 373, 433, 441, 450, 459, 476, 480, 481, 482, 498, 508, 524, 540, 547, 555, 556, 572, 579, 586, 602, 612, 628, 636, 646, 647, 648, 649, 650, 651, 659, 660, 666, 676, 681, 686, 687, 699, 701, 710, 722, 723, 743, 751, 759, 761, 773, 776, 777, 778, 786, 787, 827, 832, 833, 849, 851, 853, 858, 864, 880, 888, 895, 911, 927, 943, 959, 960, 980, 996, 997, 1013, 1029, 1045, 1053, 1069, 1085, 1145, 1146, 1162, 1163, 1171 };
            String[] paramTypeCsrc04 = {"CHAR","CHAR","CHAR","NUMBER","NUMBER","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","NUMBER","NUMBER","CHAR","CHAR","CHAR","CHAR","NUMBER","CHAR","CHAR","CHAR","NUMBER","NUMBER","NUMBER","CHAR","CHAR","CHAR","NUMBER","CHAR","CHAR","NUMBER","NUMBER","NUMBER","NUMBER","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","NUMBER","NUMBER","NUMBER","NUMBER","NUMBER","CHAR","CHAR","NUMBER","NUMBER","NUMBER","NUMBER","NUMBER","NUMBER","CHAR","NUMBER","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","NUMBER","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","NUMBER","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","CHAR","NUMBER","CHAR","NUMBER","CHAR","CHAR","NUMBER","CHAR","NUMBER","NUMBER","NUMBER","NUMBER","NUMBER","NUMBER","NUMBER","CHAR","CHAR","NUMBER","CHAR","NUMBER","NUMBER","NUMBER","CHAR","NUMBER","NUMBER","CHAR","CHAR","NUMBER","CHAR","CHAR"};

            String[] paramNameListCsrc05 = { "AvailableVol", "TotalVolOfDistributorInTA", "TransactionCfmDate", "FundCode", "TransactionAccountID", "DistributorCode", "TAAccountID", "TotalFrozenVol", "BranchCode", "TASerialNO", "TotalBackendLoad", "ShareClass", "DetailFlag", "AccountStatus", "ShareRegisterDate", "UndistributeMonetaryIncome", "UndistributeMonetaryIncomeFlag", "GuaranteedAmount", "SourceType", "DefDividendMethod" };
            String[] paramCNameListCsrc05 = { "持有人可用基金份数", "基金总份数（含冻结）", "交易确认日期", "基金代码", "投资人基金交易账号", "销售人代码", "投资人基金账号", "基金冻结总份数", "网点号码", "TA确认交易流水号", "交易后端收费总额", "收费方式", "明细标志", "账户状态", "份额注册日期", "货币基金未付收益金额", "货币基金未付收益金额正负", "剩余保本金额", "份额原始来源", "默认分红方式" };
            int[] paramStartPosCsrc05 = { 1, 17, 33, 41, 47, 64, 73, 85, 101, 110, 130, 146, 147, 148, 149, 157, 173, 174, 190, 191, 192 };
            String[] paramTypeCsrc05 = { "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "NUMBER", "CHAR", "CHAR" };

            String[] paramNameListCsrc06 = { "BasisforCalculatingDividend", "TransactionCfmDate", "CurrencyType", "VolOfDividendforReinvestment", "DividentDate", "DividendAmount", "XRDate", "ConfirmedAmount", "FundCode", "RegistrationDate", "ReturnCode", "TransactionAccountID", "DistributorCode", "BusinessCode", "TAAccountID", "DividendPerUnit", "DefDividendMethod", "DepositAcct", "RegionCode", "DownLoaddate", "Charge", "AgencyFee", "TotalFrozenVol", "NAV", "BranchCode", "OtherFee1", "OtherFee2", "IndividualOrInstitution", "DividendRatio", "TASerialNO", "StampDuty", "FrozenBalance", "TransferFee", "ShareClass", "FeeCalculator", "DrawBonusUnit", "FrozenSharesforReinvest", "DividendType", "OriginalAppSheetNo", "AchievementPay", "AchievementCompen" };
            String[] paramCNameListCsrc06 = { "红利/红利再投资基数", "交易确认日期", "结算币种", "基金账户红利再投资基金份数", "分红日/发放日", "基金账户红利资金", "除权日", "每笔交易确认金额", "基金代码", "权益登记日期", "交易处理返回代码", "投资人基金交易账号", "销售人代码", "业务代码", "投资人基金账号", "单位基金分红金额（含税）", "默认分红方式", "投资人在销售人处用于交易的资金账号", "交易所在地区编号", "交易数据下传日期", "手续费", "代理费", "基金冻结总份数", "基金单位净值", "网点号码", "其他费用1", "其他费用2", "个人/机构标志", "红利比例", "TA确认交易流水号", "印花税", "冻结金额", "过户费", "收费方式", "计费人", "分红单位", "冻结再投资份额", "分红类型", "原申请单编号", "业绩报酬", "业绩补偿" };
            int[] paramStartPosCsrc06 = { 1, 17, 25, 28, 44, 52, 68, 76, 92, 98, 106, 110, 127, 136, 139, 151, 167, 168, 187, 191, 199, 209, 219, 235, 242, 251, 261, 277, 278, 294, 314, 330, 346, 356, 357, 358, 368, 384, 385, 409, 425, 441 };
            String[] paramTypeCsrc06 = { "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "NUMBER", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "NUMBER", "NUMBER", "CHAR", "NUMBER", "CHAR", "NUMBER", "NUMBER", "NUMBER", "CHAR", "CHAR", "NUMBER", "NUMBER", "CHAR", "CHAR", "NUMBER", "NUMBER" };

            String[] paramNameListCsrc07 = { "FundName", "TotalFundVol", "FundCode", "FundStatus", "NAV", "UpdateDate", "NetValueType", "AccumulativeNAV", "ConvertStatus", "PeriodicStatus", "TransferAgencyStatus", "FundSize", "CurrencyType", "AnnouncFlag", "DefDividendMethod", "InstAppSubsAmnt", "InstAppSubsVol", "MinAmountByInst", "MinVolByInst", "CustodianCode", "AmountOfPeriodicSubs", "DateOfPeriodicSubs", "MaxRedemptionVol", "MinAccountBalance", "IPOStartDate", "IPOEndDate", "FundManagerCode", "IndiAppSubsVol", "IndiAppSubsAmount", "MinSubsVolByIndi", "MinSubsAmountByIndi", "RegistrarCode", "FundSponsor", "TradingPrice", "FaceValue", "DividentDate", "RegistrationDate", "XRDate", "MaxSubsVolByIndi", "MaxSubsAmountByIndi", "MaxSubsVolByInst", "MaxSubsAmountByInst", "UnitSubsVolByIndi", "UnitSubsAmountByIndi", "UnitSubsVolByInst", "UnitSubsAmountByInst", "MinBidsAmountByIndi", "MinBidsAmountByInst", "MinAppBidsAmountByIndi", "MinAppBidsAmountByInst", "MinRedemptionVol", "MinInterconvertVol", "IssueTypeByIndi", "IssueTypeByInst", "SubsType", "CollectFeeType", "NextTradeDate", "ValueLine", "TotalDivident", "FundIncome", "FundIncomeFlag", "Yield", "YieldFlag", "GuaranteedNAV", "FundYearIncomeRate", "FundYearIncomeRateFlag", "IndiMaxPurchase", "InstMaxPurchase", "IndiDayMaxSumBuy", "InstDayMaxSumBuy", "IndiDayMaxSumRedeem", "InstDayMaxSumRedeem", "IndiMaxRedeem", "InstMaxRedeem", "FundDayIncomeFlag", "FundDayIncome", "AllowBreachRedempt", "FundType", "FundTypeName", "RegistrarName", "FundManagerName", "FundServerTel", "FundInternetAddress" };
            String[] paramCNameListCsrc07 = { "基金名称", "基金总份数", "基金代码", "基金状态", "基金单位净值", "基金净值日期", "净值类型", "累计基金单位净值", "基金转换状态", "定期定额状态", "转托管状态", "基金规模", "结算币种", "公告标志", "默认分红方式", "法人追加认购金额", "法人追加认购份数", "法人首次认购最低金额", "法人首次认购最低份数", "托管人代码", "定时定额申购的金额", "定时定额申购日期", "基金最高赎回份数", "基金最低持有份数", "基金募集开始日期", "基金募集结束日期", "基金管理人", "个人追加认购份数", "个人追加认购金额", "个人首次认购最低份数", "个人首次认购最低金额", "注册登记人代码", "基金发起人", "交易价格", "基金面值", "分红日/发放日", "权益登记日期", "除权日", "个人最高认购份数", "个人最高认购金额", "法人最高认购份数", "法人最高认购金额", "个人认购份数单位", "个人认购金额单位", "法人认购份数单位", "法人认购金额单位", "个人首次申购最低金额", "法人首次申购最低金额", "个人追加申购最低金额", "法人追加申购最低金额", "基金最少赎回份数", "最低基金转换份数", "个人发行方式", "机构发行方式", "认购方式", "交易费收取方式", "下一开放日", "产品价值线数值", "累计单位分红", "货币基金万份收益", "货币基金万份收益正负", "货币基金七日年化收益率", "货币基金七日年化收益率正负", "保本净值", "货币基金年收益率", "货币基金年收益率正负", "个人最大申购金额", "法人最大申购金额", "个人当日累计购买最大金额", "法人当日累计购买最大金额", "个人当日累计赎回最大份额", "法人当日累计赎回最大份额", "个人最大赎回份额", "法人最大赎回份额", "基金当日总收益正负", "基金当日总收益", "允许违约赎回标志", "基金类型", "基金类型名称", "注册登记人名称", "基金管理人名称", "基金公司客服电话", "基金公司网站网址" };
            int[] paramStartPosCsrc07 = { 1, 41, 57, 63, 64, 71, 79, 80, 87, 88, 89, 90, 106, 109, 110, 111, 127, 143, 159, 175, 178, 194, 202, 218, 234, 242, 250, 253, 269, 285, 301, 317, 319, 322, 329, 336, 344, 352, 360, 376, 392, 408, 424, 440, 456, 472, 488, 504, 520, 536, 552, 568, 584, 585, 586, 587, 588, 596, 603, 611, 619, 620, 628, 629, 636, 644, 645, 661, 677, 693, 709, 725, 741, 757, 773, 774, 790, 791, 793, 823, 863, 903, 933, 973 };
            String[] paramTypeCsrc07 = { "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "NUMBER", "CHAR", "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "CHAR", "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "CHAR", "NUMBER", "CHAR", "NUMBER", "NUMBER", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrc26 = { "AvailableVol", "TotalVolOfDistributorInTA", "TransactionCfmDate", "FundCode", "TransactionAccountID", "DistributorCode", "TAAccountID", "TotalFrozenVol", "BranchCode", "TASerialNO", "TotalBackendLoad", "ShareClass", "DetailFlag", "AccountStatus", "ShareRegisterDate", "UndistributeMonetaryIncome", "UndistributeMonetaryIncomeFlag", "GuaranteedAmount", "SourceType", "DefDividendMethod", "AllowRedemptDate" };
            String[] paramCNameListCsrc26 = { "持有人可用基金份数", "基金总份数（含冻结）", "交易确认日期", "基金代码", "投资人基金交易账号", "销售人代码", "投资人基金账号", "基金冻结总份数", "网点号码", "TA确认交易流水号", "交易后端收费总额", "收费方式", "明细标志", "账户状态", "份额注册日期", "货币基金未付收益金额", "货币基金未付收益金额正负", "剩余保本金额", "份额原始来源", "默认分红方式", "可赎回日期" };
            int[] paramStartPosCsrc26 = { 1, 17, 33, 41, 47, 64, 73, 85, 101, 110, 130, 146, 147, 148, 149, 157, 173, 174, 190, 191, 192, 200 };
            String[] paramTypeCsrc26 = { "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrc43 = { "FundCode", "TAAccountID", "TransactionAccountID", "BusinessCode", "ContractType", "SerialNo", "Version", "SignType", "DistributorCode", "InvestorName", "IndividualOrInstitution", "CertificateType", "CertificateNo", "TransactionDate", "TransactionTime", "AcceptMethod", "AcceptPlace", "NetNo", "Notes", "SignRiskNotice", "RiskMatching", "ClientRiskRate", "AlternationDate", "CardNo", "TelNo", "MobileTelNo", "EmailAddress", "PostCode", "Address", "ReservedField1", "ReservedField2", "ReservedField3", "ReservedField4", "ReservedField5" };
            String[] paramCNameListCsrc43 = { "基金代码", "投资人基金账号", "投资人基金交易账号", "业务代码", "合同类型", "流水号", "版本号", "签署类型", "销售人代码", "投资人户名", "个人/机构标志", "个人证件类型及机构证件类型", "投资人证件号码", "交易发生日期", "交易发生时间", "受理方式", "受理地点", "操作（清算）网点编号", "附加信息", "已签署风险揭示书", "风险承受能力匹配情况", "客户风险等级", "最后更新日", "卡号", "投资人电话号码", "投资人手机号码", "投资人E-MAIL地址", "投资人邮政编码", "通讯地址", "预留字段1", "预留字段2", "预留字段3", "预留字段4", "预留字段5" };
            int[] paramStartPosCsrc43 = { 1, 7, 19, 36, 39, 40, 66, 69, 70, 79, 199, 200, 201, 231, 239, 245, 246, 286, 295, 359, 360, 361, 362, 370, 402, 424, 448, 488, 494, 614, 634, 654, 684, 700, 716 };
            String[] paramTypeCsrc43 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER" };

            String[] paramNameListCsrc44 = { "FundCode", "TAAccountID", "TransactionAccountID", "BusinessCode", "ContractType", "SerialNo", "Version", "SignType", "SecondStatus", "ThirdStatus", "DistributorCode", "FundManagerCode", "CustodianCode", "InvestorName", "IndividualOrInstitution", "CertificateType", "CertificateNo", "TransactionDate", "TransactionTime", "AcceptMethod", "AcceptPlace", "NetNo", "Notes", "SecondNotes", "ThirdNotes", "AlternationDate", "SecondDate", "ThirdDate", "SignRiskNotice", "RiskMatching", "ClientRiskRate", "CardNo", "TelNo", "MobileTelNo ", "EmailAddress", "PostCode", "Address", "ReservedField1", "ReservedField2", "ReservedField3", "ReservedField4", "ReservedField5" };
            String[] paramCNameListCsrc44 = { "基金代码", "投资人基金账号", "投资人基金交易账号", "业务代码", "合同类型", "流水号", "版本号", "签署类型", "第二用途状态", "第三用途状态", "销售人代码", "基金管理人", "托管人代码", "投资人户名", "个人/机构标志", "个人证件类型及机构证件类型", "投资人证件号码", "交易发生日期", "交易发生时间", "受理方式", "受理地点", "操作（清算）网点编号", "附加信息", "第二用途信息", "第三用途信息", "最后更新日", "第二用途日期", "第三用途日期", "已签署风险揭示书", "风险承受能力匹配情况", "客户风险等级", "卡号", "投资人电话号码", "投资人手机号码", "投资人E-MAIL地址", "投资人邮政编码", "通讯地址", "预留字段1", "预留字段2", "预留字段3", "预留字段4", "预留字段5" };
            int[] paramStartPosCsrc44 = { 1, 7, 19, 36, 39, 40, 66, 69, 70, 71, 72, 81, 84, 87, 207, 208, 209, 239, 247, 253, 254, 294, 303, 367, 431, 495, 503, 511, 519, 520, 521, 522, 554, 576, 600, 640, 646, 766, 786, 806, 836, 852, 868 };
            String[] paramTypeCsrc44 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER" };

            String[] paramNameListCsrcC1 = { "SequenceNO", "FundCode", "ShareClass", "FundName", "FundNameAbbr", "TotalFundVol", "FundType", "FundTypeName", "IsGuaranteedFund", "IsLOFFund", "IsQDIIFund", "IsETFFund", "RedeemFeeBackRatio", "DefDividendMethod", "RedemptionSequence", "BuyUpperAmount", "CovertInUpperAmount", "PeriodSubUpperAmount", "InstAppSubsAmnt", "InstAppSubsVol", "MinAmountByInst", "MinVolByInst", "CurrencyType", "CustodianCode", "AmountOfPeriodicSubs", "DateOfPeriodicSubs", "MaxRedemptionVol", "MinAccountBalance", "IPOStartDate", "IPOEndDate", "FundEstablishDate", "FundManagerCode", "IndiAppSubsVol", "IndiAppSubsAmount", "MinSubsVolByIndi", "MinSubsAmountByIndi", "RegistrarCode", "FundSize", "ExchangeFlag", "FundSponsor", "FaceValue", "MaxSubsVolByIndi", "MaxSubsAmountByIndi", "MaxSubsVolByInst", "MaxSubsAmountByInst", "UnitSubsVolByIndi", "UnitSubsAmountByIndi", "UnitSubsVolByInst", "UnitSubsAmountByInst", "MinBidsAmountByIndi", "MinBidsAmountByInst", "MinAppBidsAmountByIndi", "MinAppBidsAmountByInst", "MinRedemptionVol", "MinInterconvertVol", "IssueTypeByIndi", "IssueTypeByInst", "SubsType", "CollectFeeType", "IndiMaxPurchase", "InstMaxPurchase", "IndiDayMaxSumBuy", "InstDayMaxSumBuy", "IndiDayMaxSumRedeem", "InstDayMaxSumRedeem", "IndiMaxRedeem", "InstMaxRedeem", "RegistrarName", "FundManagerName", "FundServerTel", "FundInternetAddress", "Specification", "WholeFlag", "ModifyWay", "OperateDate", "DownLoaddate" };
            String[] paramCNameListCsrcC1 = { "序号", "基金代码", "收费方式", "基金名称", "基金简称", "基金总份数", "基金类型", "基金类型名称", "是否保本基金", "是否LOF基金", "是否QDII基金", "是否ETF基金", "赎回费归基金资产比例", "默认分红方式", "指定赎回方式", "申购金额上限", "基金转换转入金额上限", "定时定额申购金额上限", "法人追加认购金额", "法人追加认购份数", "法人首次认购最低金额", "法人首次认购最低份数", "结算币种", "托管人代码", "定时定额申购的金额", "定时定额申购日期", "基金最高赎回份数", "基金最低持有份数", "基金募集开始日期", "基金募集结束日期", "基金成立日期", "基金管理人", "个人追加认购份数", "个人追加认购金额", "个人首次认购最低份数", "个人首次认购最低金额", "注册登记人代码", "基金规模", "交易所标志", "基金发起人", "基金面值", "个人最高认购份数", "个人最高认购金额", "法人最高认购份数", "法人最高认购金额", "个人认购份数单位", "个人认购金额单位", "法人认购份数单位", "法人认购金额单位", "个人首次申购最低金额", "法人首次申购最低金额", "个人追加申购最低金额", "法人追加申购最低金额", "基金最少赎回份数", "最低基金转换份数", "个人发行方式", "机构发行方式", "认购方式", "交易费收取方式", "个人最大申购金额", "法人最大申购金额", "个人当日累计购买最大金额", "法人当日累计购买最大金额", "个人当日累计赎回最大份额", "法人当日累计赎回最大份额", "个人最大赎回份额", "法人最大赎回份额", "注册登记人名称", "基金管理人名称", "基金公司客服电话", "基金公司网站网址", "摘要/说明", "全量标志", "修改方式", "生效日期", "交易数据下传日期" };
            int[] paramStartPosCsrcC1 = { 1, 21, 27, 28, 68, 88, 104, 106, 136, 137, 138, 139, 140, 156, 157, 158, 174, 190, 206, 222, 238, 254, 270, 273, 276, 292, 300, 316, 332, 340, 348, 356, 359, 375, 391, 407, 423, 425, 441, 442, 445, 452, 468, 484, 500, 516, 532, 548, 564, 580, 596, 612, 628, 644, 660, 676, 677, 678, 679, 680, 696, 712, 728, 744, 760, 776, 792, 808, 848, 888, 918, 958, 1018, 1019, 1020, 1028, 1036 };
            String[] paramTypeCsrcC1 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrcC3 = { "SequenceNO","FundCode", "ShareClass","VolLowerLimit", "VolUpperLimit","DaysLowerLimit", "CodeOfTargetFund","TargetShareType", "IndividualOrInstitution","RegistrarCode", "TargetRegistrarCode","WholeFlag", "ModifyWay","OperateDate", "DownLoaddate" };
            String[] paramCNameListCsrcC3 = { "序号","基金代码", "收费方式","份额下限", "份额上限","天数下限", "转换时的目标基金代码","对方基金份额类别", "个人/机构标志","注册登记人代码", "对方TA代码","全量标志", "修改方式","生效日期", "交易数据下传日期" };
            int[] paramStartPosCsrcC3 = { 1, 21, 27, 28, 44, 60, 65, 71, 72, 73, 75, 77, 78, 79, 87, 95 };
            String[] paramTypeCsrcC3 = { "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrcC5 = { "SequenceNO", "FundCode", "ShareClass", "CodeOfTargetFund", "TargetShareType", "DistributorCode", "BranchCode", "BusinessCode", "CapitalType", "IndividualOrInstitution", "GetFeeRateMethod", "ConstantFee", "VolLowerLimit", "VolUpperLimit", "AmountLowerLimit", "AmountUpperLimit", "DaysLowerLimit", "DaysUpperLimit", "MaxFee", "MinFee", "RateFee", "FeeRateFlag ", "CompareProportion", "CompareCapitalType", "WholeFlag", "ModifyWay", "OperateDate", "DownLoaddate" };
            String[] paramCNameListCsrcC5 = { "序号", "基金代码", "收费方式", "转换时的目标基金代码", "对方基金份额类别", "销售人代码", "网点号码", "业务代码", "资金类型", "个人/机构标志", "取费率方式", "固定费用", "份额下限", "份额上限", "金额下限", "金额上限", "天数下限", "天数上限", "最高费用", "最少收费", "费率", "费率标志", "相对比例", "相对资金类型", "全量标志", "修改方式", "生效日期", "交易数据下传日期" };
            int[] paramStartPosCsrcC5 = { 1, 21, 27, 28, 34, 35, 44, 53, 56, 59, 60, 61, 77, 93, 109, 125, 141, 146, 151, 167, 177, 186, 187, 203, 206, 207, 208, 216, 224 };
            String[] paramTypeCsrcC5 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrcC6 = { "FundCode", "ShareClass", "ShareRegisterDate", "AllowRedemptDate", "AddFlag" };
            String[] paramCNameListCsrcC6 = { "基金代码", "收费方式", "份额注册日期", "可赎回日期", "增删标志" };
            int[] paramStartPosCsrcC6 = { 1, 7, 8, 16, 24, 25 };
            String[] paramTypeCsrcC6 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrcR1 = { "AppSheetSerialNo", "TransactionDate", "TransactionTime", "DistributorCode", "BranchCode", "TAAccountID", "IndividualOrInstitution", "OriginalAppDate", "OriginalAppSheetNo", "SurveyMethod", "GetInvestCerFlag", "NonResiFlag", "ChineseName", "EnglishFamliyName2", "EnglishFirstName2", "EnglishName", "Sex", "AddressType", "LivingCountry", "LivingAddress", "LivingAddress2", "LivingAddress3", "LivingAddress4", "BirthDate", "BirthCountry", "BirthCountryEngName", "BirthCity", "RegRegionCode", "TaxCountry", "TaxID", "Specification", "PassiveNonFinFlag", "HaveNonResConFlag", "ChineseName2", "EnglishFamliyName3", "EnglishFirstName3", "ControllerType", "ConNonResiFlag", "ConShareRatio", "LivingCountry2", "LivingAddress5", "LivingAddress6", "LivingAddress7", "LivingAddress8", "RegRegionCode2", "BirthDate2", "BirthCountry2", "BirthCouEngName2", "BirthCity2", "TaxCountry2", "TaxID2", "Specification2", "AddFlag", "ReservedField1", "ReservedField2", "ReservedField3", "ReservedField4", "ReservedField5", "ReservedField6" };
            String[] paramCNameListCsrcR1 = { "申请单编号", "交易发生日期", "交易发生时间", "销售人代码", "网点号码", "投资人基金帐号", "个人/机构标志", "原申请日期", "原申请单编号", "调查规则", "取得投资人声明标识", "非居民标识", "中文姓名", "英文姓2", "英文名2", "英文全称", "投资人性别", "地址类型", "现居国家", "现居地址", "现居地址2", "现居地址3", "现居地址4", "出生日期", "出生国家", "出生国英文名称", "出生城市", "注册地国家代码", "税收居民国", "纳税人识别号", "摘要/说明", "消极非金融机构标识", "存在非居民控制人标识", "中文姓名2", "英文姓3", "英文名3", "控制人类型", "控制人非居民标识", "控制人持股比例", "现居国家2", "现居地址5", "现居地址6", "现居地址7", "现居地址8", "国籍2", "出生日期2", "出生国家2", "出生国英文名称2", "出生城市2", "税收居民国2", "纳税人识别号2", "摘要/说明2", "增删标志", "预留字段1", "预留字段2", "预留字段3", "预留字段4", "预留字段5", "预留字段6" };
            int[] paramStartPosCsrcR1 = { 1, 25, 33, 39, 48, 57, 69, 70, 78, 102, 103, 104, 105, 205, 305, 405, 605, 606, 609, 612, 912, 1212, 1512, 1812, 1820, 1823, 2023, 2223, 2225, 2228, 2428, 2488, 2489, 2490, 2590, 2690, 2790, 2796, 2797, 2804, 2807, 3107, 3407, 3707, 4007, 4009, 4017, 4020, 4220, 4340, 4343, 4543, 4603, 4604, 4624, 4644, 4674, 4690, 4706, 5006 };
            String[] paramTypeCsrcR1 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "CHAR" };

            String[] paramNameListCsrcR2 = { "AppSheetSerialNo", "TransactionDate", "TransactionCfmDate", "TASerialNO", "ReturnCode", "ErrorDetail", "ReservedField1", "ReservedField2", "ReservedField3" };
            String[] paramCNameListCsrcR2 = { "申请单编号", "交易发生日期", "交易确认日期", "TA确认交易流水号", "交易处理返回代码", "出错详细信息", "预留字段1", "预留字段2", "预留字段3" };
            int[] paramStartPosCsrcR2 = { 1, 25, 33, 41, 61, 65, 125, 145, 165, 195 };
            String[] paramTypeCsrcR2 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrcA2 = { "BUSINESSCODE", "DISTRIBUTORCODE", "TRANSACTIONCFMDATE", "REGIONCODE", "TASERIALNO", "BRANCHCODE", "TAACCOUNTID", "TRANSACTIONDATE", "TRANSACTIONACCOUNTID", "TRANSACTIONTIME", "ORIGINALAPPSHEETNO", "APPSHEETSERIALNO", "FROZENCAUSE", "FREEZINGDEADLINE", "RETURNCODE", "UNFROZENBALANCE", "BUSINESSORGANIGER", "NETNO", "CUSTOMERNO", "ERRORDETAIL", "FROMTAFLAG" };
            String[] paramCNameListCsrcA2 = { "业务代码", "销售商代码", "交易确认日期", "交易所在地区编号", "确认交易流水号", "托管网点编号", "投资人基金帐号", "交易发生日期", "投资人基金交易帐号", "交易发生时间", "原申请单编号", "申请单编号", "冻结原因", "冻结截止日期", "交易处理返回代码", "解冻金额", "业务发起人代码", "操作网点编号", "TCHAR客户编号", "出错详细信息", "是否注册登记人发起业务标志" };
            int[] paramStartPosCsrcA2 = { 1, 4, 7, 15, 19, 39, 48, 60, 68, 85, 91, 115, 139, 140, 148, 152, 168, 171, 180, 192, 228, 229 };
            String[] paramTypeCsrcA2 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR" };

            String[] paramNameListCsrcA4 = { "BUSINESSCODE", "TRANSACTIONCFMDATE", "TASERIALNO", "TRANSACTIONDATE", "TRANSACTIONTIME", "APPSHEETSERIALNO", "DISTRIBUTORCODE", "REGIONCODE", "BRANCHCODE", "TAACCOUNTID", "TRANSACTIONACCOUNTID", "FUNDCODE", "APPLICATIONVOL", "APPLICATIONAMOUNT", "CURRENCYTYPE", "CONFIRMEDVOL", "CONFIRMEDAMOUNT", "COMMISSION", "AGENCYFEE", "STAMPDUTY", "RETURNCODE", "ORIGINALSERIALNO", "TARGETTAACCOUNTID", "TARGETDISTRIBUTORCODE", "TARGETREGIONCODE", "TARGETBRANCHCODE", "CODEOFTARGETFUND", "DEFDIVIDENDMETHOD", "FROZENCAUSE", "INTEREST", "INTERESTTAX", "FROZENBALANCE", "ORIGINALAPPSHEETNO", "UNFROZENBALANCE", "DISCOUNTRATEOFCOMMISSION", "SHARETYPE", "BUSINESSORGANIGER", "NAV", "INDIVIDUALORINSTITUTION", "NETNO", "TARGETSHARETYPE", "REDEMPTIONSTATUS", "DATADETAILFLAG", "REGISTERDATE", "ERRORDETAIL", "TASERIALNOTOTAL", "PROTOCOLNO", "PROMISEFAILFLAG", "GAINBALANCE", "TAFLAG", "LARGEREDEMPTIONFLAG", "BUSINESSFINISHFLAG" };
            String[] paramCNameListCsrcA4 = { "业务代码", "交易确认日期", "确认交易流水号", "交易发生日期", "交易发生时间", "申请单编号", "销售商代码", "交易所在地区编号", "托管网点编号", "投资人基金帐号", "投资人基金交易帐号", "基金代码", "申请基金份数", "申请金额", "结算币种", "交易确认份数", "交易确认金额", "手续费", "代理费", "印花税", "交易处理返回代码", "TCHAR的原确认流水号", "对方TCHAR基金帐号", "对方销售商代码", "对方网点号地区编号", "对方托管网点号", "对方基金代码", "分红方式", "冻结原因", "基金帐户利息金额", "利息税", "冻结金额", "原申请单编号", "解冻金额", "销售佣金折扣率", "份额类别", "业务发起人代码", "交易确认的单位净值", "个人/机构标志", "操作网点编号", "目标基金类别", "赎回状态", "数据明细标志", "份额注册日期", "出错详细信息", "总确认数据的TCHAR确认号", "承诺优惠协议号", "承诺优惠失效标志", "投资收益", "TCHAR发起业务标志", "巨额赎回处理标志", "业务过程完全结束标识" };
            int[] paramStartPosCsrcA4 = { 1, 4, 12, 32, 40, 46, 70, 73, 77, 86, 98, 115, 121, 137, 153, 156, 172, 188, 198, 208, 224, 228, 248, 260, 263, 267, 276, 282, 283, 284, 294, 310, 326, 350, 366, 371, 372, 375, 382, 383, 392, 393, 394, 395, 403, 439, 459, 471, 472, 488, 489, 490, 491 };
            String[] paramTypeCsrcA4 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "CHAR", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "CHAR", "NUMBER", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrcX26 = { "AvailableVol", "TotalVolOfDistributorInTA", "TransactionCfmDate", "FundCode", "TransactionAccountID", "DistributorCode", "TAAccountID", "TotalFrozenVol", "BranchCode", "TASerialNO", "TotalBackendLoad", "ShareClass", "DetailFlag", "AccountStatus", "ShareRegisterDate", "UndistributeMonetaryIncome", "UndistributeMonetaryIncomeFlag", "GuaranteedAmount", "SourceType", "DefDividendMethod", "AllowRedemptDate", "CycleRange" };
            String[] paramCNameListCsrcX26 = { "持有人可用基金份数", "基金总份数（含冻结）", "交易确认日期", "基金代码", "投资人基金交易账号", "销售人代码", "投资人基金账号", "基金冻结总份数", "网点号码", "TA确认交易流水号", "交易后端收费总额", "收费方式", "明细标志", "账户状态", "份额注册日期", "货币基金未付收益金额", "货币基金未付收益金额正负", "剩余保本金额", "份额原始来源", "默认分红方式", "可赎回日期", "对应可赎回日所在周期" };
            int[] paramStartPosCsrcX26 = { 1, 17, 33, 41, 47, 64, 73, 85, 101, 110, 130, 146, 147, 148, 149, 157, 173, 174, 190, 191, 192, 200, 204 };
            String[] paramTypeCsrcX26 = { "NUMBER", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrcF1 = { "DistributorCode", "FundCode", "DownLoaddate", "PrdRiskRate", "DebtFundType", "AllowClientGroup", "FinancialRegistrationCode", "SaleObject", "IsCycleFund", "CycleDays", "CycleNums", "DefCycleNums", "BreachOfContractFee", "FundType", "IPOType", "InvestmentTargets", "ClearDays", "RedeemAmtDays", "DivAmtDays", "FundEndDays", "FundIssuanceFailDays", "FundTrustee", "CashFlag", "IncomeEndDate", "IncomeCurrType", "CostCurrType", "ChoiceBonusType", "CancelOrderType", "BuyUpperLimitday", "IsPartRedeem", "LargeRedeemRatio", "RedeemAmtReturn", "FundMinBala", "FundMaXBala", "Subscribemode", "Purchasemode", "RealRedeemRatio", "RealRedeemUpperLimitOfDay", "RealRedeemUpperLimitOfSolo", "ShareDoMethod", "OrgRedeemBase", "PerRedeemBase", "ComparisonRatio", "FundIssuer", "ManagementBasic", "ExcessiveRtio", "SubBasic", "SubDelayedDays", "FundCollectAccount", "ExcessiveSubRtio", "InterestRate" };
            String[] paramCNameListCsrcF1 = { "销售人代码", "产品代码", "交易数据下传日期", "产品风险等级", "中债产品划分", "允许销售的中债客户组别", "理财登记编码", "销售对象（发售对象）", "是否周期产品", "周期天数", "最长周期数", "默认期数", "违约赎回费率", "产品类型", "产品募集方式", "投资标的(投资性质)", "结算天数", "赎回资金到账天数（结算天数）", "分红资金到账天数（结算天数）", "产品到期资金到账天数（结算天数", "发行失败/比例退款天数", "产品托管人", "钞汇标志", "产品收益到期日", "产品收益币种", "本金返还币种", "可选分红方式", "购买（认购）撤单", "单日申购上限", "允许部分赎回", "巨额赎回比例", "赎回本金返还方式", "产品最低募集额", "产品最高募集额", "认购帐务模式", "申购帐务模式", "实时赎回资金比例", "当日实时赎回份额上限", "单人单日快速赎回上限", "份额计算方式", "对公赎回基数", "对私赎回基数", "业绩基准", "产品发行人", "浮动管理费年化基数", "超额分层比例", "认购利息年化基础", "认购计息天数", "产品募集账户或清算户", "超额认购比例确认", "认购利息利率" };
            int[] paramStartPosCsrcF1 = { 1, 10, 16, 24, 25, 26, 46, 66, 68, 69, 73, 77, 81, 90, 91, 92, 93, 97, 102, 107, 112, 117, 120, 121, 129, 132, 135, 137, 138, 154, 155, 164, 165, 181, 197, 198, 199, 204, 220, 236, 237, 253, 269, 278, 281, 282, 291, 292, 297, 329, 330, 339 };
            String[] paramTypeCsrcF1 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER", "CHAR", "NUMBER", "CHAR", "NUMBER", "NUMBER", "CHAR", "CHAR", "NUMBER", "NUMBER", "NUMBER", "CHAR", "NUMBER", "NUMBER", "NUMBER", "CHAR", "CHAR", "NUMBER", "CHAR", "CHAR", "CHAR", "CHAR", "NUMBER" };

            String[] paramNameListCsrcF2 = { "DistributorCode", "FundCode", "TransDateType", "TransactionCfmDate" };
            String[] paramCNameListCsrcF2 = { "销售人代码", "产品代码", "产品类型", "交易日期(下一个)" };
            int[] paramStartPosCsrcF2 = { 1, 10, 16, 17, 25 };
            String[] paramTypeCsrcF2 = { "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrcF3 = {"DistributorCode","BusinessCode","AppSheetSerialNo","CertificateType","CertificateNo","TAAccountID","ClientClass","OtherCode"};
            String[] paramCNameListCsrcF3 = {"销售人代码","业务代码","申请单编号","个人证件类型及机构证件型","投资人证件号码","投资人理财帐号","投资者类别","其他证件名称"};
            int[] paramStartPosCsrcF3 = {  1, 10, 13, 37, 38, 68, 80, 82, 142 };
            String[] paramTypeCsrcF3 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR" };

            String[] paramNameListCsrcF4 = { "DistributorCode", "FundCode", "CycleDays", "CycleNums", "CycleSpace", "CycleStartDate", "AllowRedemptDate" };
            String[] paramCNameListCsrcF4 = { "销售人代码", "产品代码", "产品周期天数", "产品最长周期数", "持有周期数", "交易日期", "可赎回日期" };
            int[] paramStartPosCsrcF4 = { 1, 10, 16, 20, 24, 28, 36, 44 };
            String[] paramTypeCsrcF4 = { "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR", "CHAR" };



            ShowForm showForm = new ShowForm();
            showForm.Text = selectMode;
            FlowLayoutPanel flowLayout = new FlowLayoutPanel();
            flowLayout.Name = "fileBodyPan";
            flowLayout.Height=600;
            flowLayout.Width = 600;
            flowLayout.WrapContents = false;
            flowLayout.FlowDirection =FlowDirection.TopDown;
            flowLayout.AutoScroll = true;
            flowLayout.SetAutoScrollMargin(20, 600);
            flowLayout.BorderStyle = BorderStyle.Fixed3D;
            //flowLayout.AutoSize = true;
            FlowLayoutPanel flowLayout1 = new FlowLayoutPanel();
            flowLayout1.Location = new Point(600,0);
            flowLayout1.Height = 600;
            flowLayout1.Width = 600;
            flowLayout1.WrapContents = false;
            flowLayout1.FlowDirection = FlowDirection.TopDown;
            flowLayout1.AutoScroll = false;
            flowLayout1.BorderStyle = BorderStyle.Fixed3D;
            flowLayout1.Anchor = AnchorStyles.Top;
            
            TextBox newText = new TextBox();
            newText.Size = new Size(400,400);
            newText.Multiline = true;
            newText.Height = 400;
            newText.Name = "newText";
            //newText.Text = showForm.getText();
            flowLayout1.Controls.Add(newText);
        
            showForm.Name = "analyForm";
            showForm.Controls.Add(flowLayout);
            showForm.Controls.Add(flowLayout1);
            showForm.Show();

            Button button = new Button();
            button.Anchor = AnchorStyles.Top;
            button.Text = "复制新报文";
            button.Click += new EventHandler(btCopyClick);
            flowLayout1.Controls.Add(button);

            switch (selectMode) {
                case "CSRC标准01文件":                   
                    paramGenerator(flowLayout, inputStr, paramNameListCsrc01, paramCNameListCsrc01, paramTypeCsrc01, paramStartPosCsrc01);
                    break;
                case "CSRC标准02文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrc02, paramCNameListCsrc02, paramTypeCsrc02, paramStartPosCsrc02);
                    break;
                case "CSRC标准03文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrc03, paramCNameListCsrc03, paramTypeCsrc03, paramStartPosCsrc03);
                    break;
                case "CSRC标准04文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrc04, paramCNameListCsrc04, paramTypeCsrc04, paramStartPosCsrc04);
                    break;
                case "CSRC标准05文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrc05, paramCNameListCsrc05, paramTypeCsrc05, paramStartPosCsrc05);
                    break;
                case "CSRC标准06文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrc06, paramCNameListCsrc06, paramTypeCsrc06, paramStartPosCsrc06);
                    break;
                case "CSRC标准07文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrc07, paramCNameListCsrc07, paramTypeCsrc07, paramStartPosCsrc07);
                    break;
                case "CSRC标准26文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrc26, paramCNameListCsrc26, paramTypeCsrc26, paramStartPosCsrc26);
                    break;
                case "CSRC标准43文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrc43, paramCNameListCsrc43, paramTypeCsrc43, paramStartPosCsrc43);
                    break;
                case "CSRC标准44文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrc44, paramCNameListCsrc44, paramTypeCsrc44, paramStartPosCsrc44);
                    break;
                case "CSRC标准C1文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcC1, paramCNameListCsrcC1, paramTypeCsrcC1, paramStartPosCsrcC1);
                    break;
                case "CSRC标准C3文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcC3, paramCNameListCsrcC3, paramTypeCsrcC3, paramStartPosCsrcC3);
                    break;
                case "CSRC标准C5文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcC5, paramCNameListCsrcC5, paramTypeCsrcC5, paramStartPosCsrcC5);
                    break;
                case "CSRC标准C6文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcC6, paramCNameListCsrcC6, paramTypeCsrcC6, paramStartPosCsrcC6);
                    break;
                case "CSRC标准R1文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcR1, paramCNameListCsrcR1, paramTypeCsrcR1, paramStartPosCsrcR1);
                    break;
                case "CSRC标准R2文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcR2, paramCNameListCsrcR2, paramTypeCsrcR2, paramStartPosCsrcR2);
                    break;
                case "ASSU保险非标02文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcA2, paramCNameListCsrcA2, paramTypeCsrcA2, paramStartPosCsrcA2);
                    break;
                case "ASSU保险非标04文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcA4, paramCNameListCsrcA4, paramTypeCsrcA4, paramStartPosCsrcA4);
                    break;
                case "BTA非标26文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcX26, paramCNameListCsrcX26, paramTypeCsrcX26, paramStartPosCsrcX26);
                    break;
                case "BTA非标F1文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcF1, paramCNameListCsrcF1, paramTypeCsrcF1, paramStartPosCsrcF1);
                    break;
                case "BTA非标F2文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcF2, paramCNameListCsrcF2, paramTypeCsrcF2, paramStartPosCsrcF2);
                    break;
                case "BTA非标F3文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcF3, paramCNameListCsrcF3, paramTypeCsrcF3, paramStartPosCsrcF3);
                    break;
                case "BTA非标F4文件":
                    paramGenerator(flowLayout, inputStr, paramNameListCsrcF4, paramCNameListCsrcF4, paramTypeCsrcF4, paramStartPosCsrcF4);
                    break;

            }







        }

        private void btCopyClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            FlowLayoutPanel pan = (FlowLayoutPanel)GetControl(btn.FindForm(), "fileBodyPan");
            TextBox newText = (TextBox)GetControl(btn.FindForm(),"newText");
           
            String nstr="";
            foreach (Control cur in pan.Controls)
            {
                if (cur.Name.StartsWith("fileText"))
                {
                    nstr += cur.Text;
                }
            }
            newText.Text = nstr;
            Clipboard.SetDataObject(nstr);
            createFile(nstr);
            MessageBox.Show("当前记录已复制到剪贴板及"+@"D:\testCsrcFile.txt中");
        }

        private void createFile(string nstr)
        {
            // 创建文件
            FileStream fs = new FileStream(@"D:\testCsrcFile.txt", FileMode.Append, FileAccess.Write); //可以指定盘符，也可以指定任意文件名，还可以为word等文件
            StreamWriter sw = new StreamWriter(fs,Encoding.GetEncoding("GBK")); // 创建写入流
            sw.WriteLine(nstr); // 写入Hello World
            sw.Close(); //关闭文件
        }

        /// <summary>
        /// 通过控件名获取控件
        /// </summary>
        /// <param name="ct">控件所在的容器或者窗体</param>
        /// <param name="name">需要查找的控件名</param>
        /// <returns></returns>
        public static Control GetControl(Control p_Control, string p_ControlName)
        {
            if (p_Control.Name == p_ControlName) return p_Control;
            for (int i = 0; i != p_Control.Controls.Count; i++)
            {
                Control _SubControl = GetControl(p_Control.Controls[i], p_ControlName);
                if (_SubControl != null) return _SubControl;
            }
            return null;
        }


        public void paramGenerator(FlowLayoutPanel flowLayout,String inputStr,String[] paramNameList,String[] paramCNameList,String[] paramType,int[] paramStartPos) {
            for (int i = 0; i < paramNameList.Length; i++)
            {
                Label paramLabel = new Label();
                paramLabel.Text = paramNameList[i] + paramCNameList[i] + "{TYPE:" + paramType[i] + "  LENGTH:" + (paramStartPos[i + 1] - paramStartPos[i]) + "}";
                paramLabel.Width = 800;
                paramLabel.ForeColor = Color.Black;
                paramLabel.Font = new Font("宋体", 10f, FontStyle.Regular);
                flowLayout.Controls.Add(paramLabel);
                TextBox textBox = new TextBox();
                textBox.Width = 500;
                textBox.Name = "fileText" +i;
                String str = CutByteString(inputStr, paramStartPos[i] - 1, paramStartPos[i + 1] - paramStartPos[i]);
                if (paramCNameList[i].EndsWith("金额") || paramCNameList[i].EndsWith("份额") || paramCNameList[i].EndsWith("份数"))
                {
                    textBox.Text = str;
                    textBox.Font = new Font("宋体", 10.5f, FontStyle.Bold);
                }
                else
                {
                    textBox.Text = str;
                    textBox.Font = new Font("宋体", 10.5f, FontStyle.Regular);
                }
                
                flowLayout.Controls.Add(textBox);
            }
        }

        public static string CutByteString(string str, int len)
        {
            string result = string.Empty;// 最终返回的结果
            if (string.IsNullOrEmpty(str)) { return result; }
            int byteLen = System.Text.Encoding.Default.GetByteCount(str);// 单字节字符长度
            int charLen = str.Length;// 把字符平等对待时的字符串长度
            int byteCount = 0;// 记录读取进度
            int pos = 0;// 记录截取位置
            if (byteLen > len)
            {
                for (int i = 0; i < charLen; i++)
                {
                    if (Convert.ToInt32(str.ToCharArray()[i]) > 255)// 按中文字符计算加2
                    { byteCount += 2; }
                    else// 按英文字符计算加1
                    { byteCount += 1; }
                    if (byteCount > len)// 超出时只记下上一个有效位置
                    {
                        pos = i;
                        break;
                    }
                    else if (byteCount == len)// 记下当前位置
                    {
                        pos = i + 1;
                        break;
                    }
                }
                if (pos >= 0)
                { result = str.Substring(0, pos); }
            }
            else
            { result = str; }
            return result;
        }

        public static string CutByteString(string str, int startIndex, int len)

        {
            string result = string.Empty;// 最终返回的结果
            if (string.IsNullOrEmpty(str)) { return result; }
            int byteLen = System.Text.Encoding.Default.GetByteCount(str);// 单字节字符长度
            int charLen = str.Length;// 把字符平等对待时的字符串长度
            if (startIndex == 0)
            { return CutByteString(str, len); }
            else if (startIndex >= byteLen)
            { return result; }
            else //startIndex < byteLen
            {
                int AllLen = startIndex + len;
                int byteCountStart = 0;// 记录读取进度
                int byteCountEnd = 0;// 记录读取进度
                int startpos = 0;// 记录截取位置                
                int endpos = 0;// 记录截取位置
                for (int i = 0; i < charLen; i++)
                {
                    if (Convert.ToInt32(str.ToCharArray()[i]) > 255)// 按中文字符计算加2
                    { byteCountStart += 2; }
                    else// 按英文字符计算加1
                    { byteCountStart += 1; }
                    if (byteCountStart > startIndex)// 超出时只记下上一个有效位置
                    {
                        startpos = i;
                        AllLen = startIndex + len - 1;
                        break;
                    }
                    else if (byteCountStart == startIndex)// 记下当前位置
                    {
                        startpos = i + 1;
                        break;
                    }
                }
                if (startIndex + len <= byteLen)//截取字符在总长以内
                {
                    for (int i = 0; i < charLen; i++)
                    {
                        if (Convert.ToInt32(str.ToCharArray()[i]) > 255)// 按中文字符计算加2
                        { byteCountEnd += 2; }
                        else// 按英文字符计算加1
                        { byteCountEnd += 1; }
                        if (byteCountEnd > AllLen)// 超出时只记下上一个有效位置
                        {
                            endpos = i;
                            break;
                        }
                        else if (byteCountEnd == AllLen)// 记下当前位置
                        {
                            endpos = i + 1;
                            break;
                        }
                    }
                    endpos = endpos - startpos;
                }
                else if (startIndex + len > byteLen)//截取字符超出总长
                {
                    endpos = charLen - startpos;
                }
                if (endpos >= 0)
                { result = str.Substring(startpos, endpos); }
            }
            return result;
        }

        private void 升级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyRight copyRight = new CopyRight();
            copyRight.Show();
        }

        private void fileContext_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem5.OwnerItem.Text + toolStripMenuItem5.Text + "文件";
        }

        private void r1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = r1ToolStripMenuItem.OwnerItem.Text + r1ToolStripMenuItem.Text + "文件";
        }

        private void r2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = r2ToolStripMenuItem.OwnerItem.Text + r2ToolStripMenuItem.Text + "文件";
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem15.OwnerItem.Text + toolStripMenuItem15.Text + "文件";
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem16.OwnerItem.Text + toolStripMenuItem16.Text + "文件";
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem14.OwnerItem.Text + toolStripMenuItem14.Text + "文件";
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            textBox1.Text = toolStripMenuItem13.OwnerItem.Text + toolStripMenuItem13.Text + "文件";
        }

        private void 语言ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 文件路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileContext.Text = "";
        }
    }
}
