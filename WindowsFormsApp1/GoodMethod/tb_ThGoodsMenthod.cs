using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp1.ClassInfo;

namespace WindowsFormsApp1.GoodMethod
{
    class tb_ThGoodsMenthod
    {
        public string tb_ThGoodsID()    //用当前时间生成退货商品编号
        {
            int intYear = DateTime.Now.Day;
            int intMonth = DateTime.Now.Month;
            int intDate = DateTime.Now.Year;
            int intHour = DateTime.Now.Hour;
            int intMinute = DateTime.Now.Minute;
            int intSecond = DateTime.Now.Second;
            string strTime = null;
            strTime = intYear.ToString();
            if (intMonth < 10)
            {
                strTime += "0" + intMonth.ToString();
            }
            else
            {
                strTime += intMonth.ToString();
            }
            if (intDate < 10)
            {
                strTime += "0" + intDate.ToString();
            }
            else
            {
                strTime += intDate.ToString();
            }
            if (intHour < 10)
            {
                strTime += "0" + intHour.ToString();
            }
            else
            {
                strTime += intHour.ToString();
            }
            if (intMinute < 10)
            {
                strTime += "0" + intMinute.ToString();
            }
            else
            {
                strTime += intMinute.ToString();
            }
            if (intSecond < 10)
            {
                strTime += "0" + intSecond.ToString();
            }
            else
            {
                strTime += intSecond.ToString();
            }

            return ("TH-" + strTime);
        }
        //添加
        public bool Add(tb_ThGoodsInfo thGoods) 
        {
            string sqlAdd = "insert into tb_ThGoodsInfo values( ";
            sqlAdd += "'" + thGoods.strThGoodsID + "','" + thGoods.strGoodsID + "',";
            sqlAdd += "'" + thGoods.strSellID + "','" + thGoods.intEmpId + "','" + thGoods.strThGoodsName + "',";
            sqlAdd += "" + thGoods.intThGoodsNum + ",'" + thGoods.daThGoodsTime + "','" + thGoods.deThGoodsPrice + "',";
            sqlAdd += "'" + thGoods.deThHasPay + "','" + thGoods.deThNeedPay + "','" + thGoods.deThGoodsResult + "')";
            string sqlQuery = "select * from tb_KcGoods where GoodsID ='" + thGoods.strGoodsID + "'";
            int num;    //当前库存数量
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                //再增加库存数量
                SqlConnection conn1 = (new GetSqlConnection()).GetCon();
                SqlCommand cmd1 = new SqlCommand(sqlQuery, conn1);
                SqlDataReader dataReader = cmd1.ExecuteReader();
                dataReader.Read();
                num = Convert.ToInt32(dataReader[3]);   //获取当前的库存数量
                dataReader.Close();
                num += thGoods.intThGoodsNum;           //库存数量增加
                string sqlUpdate = "update tb_KcGoods set KcNum = " + num + " where GoodsID ='" + thGoods.strGoodsID + "'";
                SqlConnection conn2 = (new GetSqlConnection()).GetCon();
                SqlCommand cmd2 = new SqlCommand(sqlUpdate, conn2);
                cmd2.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        //删除
        public bool Delete(string thGoodsID)
        {
            string sqlDelete = "delete from tb_ThGoodsInfo where ThGoodsID='" + thGoodsID + "'";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        //修改
        public bool Update(tb_ThGoodsInfo thGoods,string pastNum)  
        {
            string sqlUpdate = "update tb_ThGoodsInfo set ";
            sqlUpdate += "GoodsID='" + thGoods.strGoodsID + "',";
            sqlUpdate += "SellID='" + thGoods.strSellID + "',EmpId='" + thGoods.intEmpId + "',ThGoodsName='" + thGoods.strThGoodsName + "',";
            sqlUpdate += "ThGoodsNum=" + thGoods.intThGoodsNum + ",ThGoodsTime='" + thGoods.daThGoodsTime + "',ThGoodsPrice='" + thGoods.deThGoodsPrice + "',";
            sqlUpdate += "ThHasPay='" + thGoods.deThHasPay + "',ThNeedPay='" + thGoods.deThNeedPay + "',ThGoodsResult='" + thGoods.deThGoodsResult + "'";
            sqlUpdate += " where  ThGoodsID= '" + thGoods.strThGoodsID + "'";
            string sqlQuery = "select * from tb_KcGoods where GoodsID='" + thGoods.strGoodsID + "'";
            int num;    //当前库存数量
            int n = Convert.ToInt32(pastNum);   //修改前销售记录中的销售数量
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                //修改库存数量
                SqlConnection conn1 = (new GetSqlConnection()).GetCon();
                SqlCommand cmd1 = new SqlCommand(sqlQuery, conn1);
                SqlDataReader dataReader = cmd1.ExecuteReader();
                dataReader.Read();
                num = Convert.ToInt32(dataReader[3]);   //获取当前的库存数量
                dataReader.Close();
                num -= n;                               //减去修改前的退货数量
                num += thGoods.intThGoodsNum;           //加上修改后的退货数量
                string sqlUpdate1 = "update tb_KcGoods set KcNum = " + num + " where GoodsID = '" + thGoods.strGoodsID + "'";
                SqlConnection conn2 = (new GetSqlConnection()).GetCon();
                SqlCommand cmd2 = new SqlCommand(sqlUpdate1, conn2);
                cmd2.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        //查询单项记录
        public bool Find(string thGoodsId)
        {
            string sqlSelect = "select * from tb_ThGoodInfo where ThGoodsID='" + thGoodsId + "'";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);
                int count = (int)cmd.ExecuteScalar();
                conn.Dispose();
                if (count == 1)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("退货商品编号错误");
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        //查询整个表
        public bool Find(DataGridView data)
        {
            string sqlSelect = "select * from tb_ThGoodsInfo ";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                int rowCount = 0;   //行数
                while (dataReader.Read())
                {
                    rowCount++;
                }
                dataReader.Close();

                if (rowCount != 0)
                {
                    int i = 0;
                    data.RowCount = rowCount;
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        data[0, i].Value = dataReader[0].ToString();    //退货编号
                        data[1, i].Value = dataReader[4].ToString();    //商品名称
                        data[2, i].Value = dataReader[7].ToString();    //退货单价
                        data[3, i].Value = dataReader[5].ToString();    //退货数量
                        data[4, i].Value = dataReader[6].ToString();    //退货日期
                        i++;
                    }
                    dataReader.Close();
                }
                else
                {
                    data.RowCount = 1;
                    for (int j = 0; j < 5; j++)
                    {
                        data[j, 0].Value = "";
                    }
                }
                conn.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public void filltProd(object objTreeView, object obimage)   //用销售表生成treeview
        {
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                string strCmd = "select * from tb_SellGoods where SellFlag=0";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlDataReader qlddr = cmd.ExecuteReader();

                if (objTreeView.GetType().ToString() == "System.Windows.Forms.TreeView")
                {
                    System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage;

                    System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;
                    TV.Nodes.Clear();

                    TV.ImageList = imlist;
                    System.Windows.Forms.TreeNode TN = TV.Nodes.Add("A", "商品销售信息", 0, 1);

                    while (qlddr.Read())
                    {
                        TreeNode newNode12 = new TreeNode(qlddr[0].ToString(), 0, 1);   //销售编号
                        newNode12.Nodes.Add("A", qlddr[3].ToString(), 0, 1);            //商品名称
                        TN.Nodes.Add(newNode12);
                    }
                    qlddr.Close();
                    TV.ExpandAll();
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
