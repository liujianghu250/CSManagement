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
    class tb_SellGoodsMenthod
    {
        public string tb_SellID()   //用当前时间生成SellID
        {
            int intYear = DateTime.Now.Day;
            int intMonth = DateTime.Now.Month;
            int intDate = DateTime.Now.Year;
            int intHour = DateTime.Now.Hour;
            int intMinute = DateTime.Now.Minute;
            int intSecond = DateTime.Now.Second;
            string strTime = null;
            strTime = intYear.ToString();
            if(intMonth < 10)
            {
                strTime += "0" + intMonth.ToString();
            }
            else
            {
                strTime += intMonth.ToString();
            }
            if(intDate < 10)
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

            return ("XS-" + strTime);
        }
        //添加
        public bool Add(tb_SellGoods sellGoods) 
        {
            //先向销售表中添加记录
            string sqlAdd = "insert into tb_SellGoods values( ";
            sqlAdd += "'" + sellGoods.strSellID + "','" + sellGoods.strGoodsID + "',";
            sqlAdd += "'" + sellGoods.strEmpId + "','" + sellGoods.strGoodsName + "'," + sellGoods.strSellGoodsNum + ",";
            sqlAdd += "'" + sellGoods.daSellGoodsTime + "','" + sellGoods.deSellPrice + "',";
            sqlAdd += "'" + sellGoods.deSellNeedPay + "','" + sellGoods.deSellHasPay + "','" + sellGoods.strSellRemark + "'," + sellGoods.intSellFlag + ")";
            string sqlQuery = "select * from tb_KcGoods where GoodsID ='" + sellGoods.strGoodsID + "'";
            int num;    //当前库存数量
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlAdd, conn);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                //再减少库存数量
                SqlConnection conn1 = (new GetSqlConnection()).GetCon();
                SqlCommand cmd1 = new SqlCommand(sqlQuery, conn1);
                SqlDataReader dataReader = cmd1.ExecuteReader();
                dataReader.Read();
                num = Convert.ToInt32(dataReader[3]);   //获取当前的库存数量
                dataReader.Close();
                if(num == 0)    //当前库存为0，不能添加
                {
                    return false;
                }
                num -= sellGoods.strSellGoodsNum;       //库存数量减少
                string sqlUpdate = "update tb_KcGoods set KcNum = " + num + " where GoodsID ='" + sellGoods.strGoodsID + "'";
                SqlConnection conn2 = (new GetSqlConnection()).GetCon();
                SqlCommand cmd2 = new SqlCommand(sqlUpdate, conn2);
                cmd2.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            
        }
        //删除
        public bool Delete(tb_SellGoods sellGoods)
        {
            string sqlDelete = "update tb_SellGoods set ";
            sqlDelete += "SellFlag=" + sellGoods.intSellFlag + "";  //修改flag，置删除标记
            sqlDelete += " where SellID = '" + sellGoods.strSellID + "'";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                cmd.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        //修改
        public bool Update(tb_SellGoods sellGoods, string pastNum)  
        {
            string sqlUpdate = "update tb_SellGoods set ";
            sqlUpdate += "GoodsID='" + sellGoods.strGoodsID + "',";
            sqlUpdate += "EmpId='" + sellGoods.strEmpId + "',GoodsName='" + sellGoods.strGoodsName + "',SellGoodsNum=" + sellGoods.strSellGoodsNum + ",";
            sqlUpdate += "SellGoodsTime='" + sellGoods.daSellGoodsTime + "',SellPrice='" + sellGoods.deSellPrice + "',";
            sqlUpdate += "SellNeedPay='" + sellGoods.deSellNeedPay + "',SellHasPay='" + sellGoods.deSellHasPay + "',SellRemark='" + sellGoods.strSellRemark + "',SellFlag=" + sellGoods.intSellFlag + "";
            sqlUpdate += " where  SellID= '" + sellGoods.strSellID + "'";
            string sqlQuery = "select * from tb_KcGoods where GoodsID='" + sellGoods.strGoodsID + "'";
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
                num += n;   //加上修改前的销售数量
                num -= sellGoods.strSellGoodsNum;       //减去修改后的销售数量
                string sqlUpdate1 = "update tb_KcGoods set KcNum = " + num + " where GoodsID = '" + sellGoods.strGoodsID + "'";
                SqlConnection conn2 = (new GetSqlConnection()).GetCon();
                SqlCommand cmd2 = new SqlCommand(sqlUpdate1, conn2);
                cmd2.ExecuteNonQuery();
                conn.Dispose();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        //查询单个记录
        public bool Find(string sellId)
        {
            string sqlSelect = "select * from tb_SellGoods where SellID='" + sellId + "'";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);
                int count = (int)cmd.ExecuteScalar();
                conn.Dispose();
                if(count == 1)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("销售编号错误");
                    return false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        //查询整个表
        public bool Find(DataGridView data)
        {
            string sqlSelect = "select * from tb_SellGoods where SellFlag=0";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlSelect, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();

                int rowCount = 0;   //行数
                while(dataReader.Read())
                {
                    rowCount++;
                }
                dataReader.Close();

                if(rowCount != 0)
                {
                    int i = 0;
                    data.RowCount = rowCount;
                    dataReader = cmd.ExecuteReader();
                    while(dataReader.Read())
                    {
                        data[0, i].Value = dataReader[0].ToString();    //销售编号
                        data[1, i].Value = dataReader[3].ToString();    //商品名称
                        data[2, i].Value = dataReader[6].ToString();    //销售单价
                        data[3, i].Value = dataReader[4].ToString();    //销售数量
                        data[4, i].Value = dataReader[2].ToString();    //销售员工
                        data[5, i].Value = dataReader[5].ToString();    //销售日期
                        i++;
                    }
                    dataReader.Close();
                }
                else
                {
                    data.RowCount = 1;
                    for(int j = 0; j < 6; j++)
                    {
                        data[j, 0].Value = "";
                    }
                }
                conn.Dispose();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }
        public void filltProd(object objTreeView, object obimage)   //用进货表生成treeview
        {
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                string strCmd = "select * from tb_JhGoodsInfo where Flag=0";
                SqlCommand cmd = new SqlCommand(strCmd, conn);
                SqlDataReader qlddr = cmd.ExecuteReader();

                if (objTreeView.GetType().ToString() == "System.Windows.Forms.TreeView")
                {
                    System.Windows.Forms.ImageList imlist = (System.Windows.Forms.ImageList)obimage;

                    System.Windows.Forms.TreeView TV = (System.Windows.Forms.TreeView)objTreeView;
                    TV.Nodes.Clear();

                    TV.ImageList = imlist;
                    System.Windows.Forms.TreeNode TN = TV.Nodes.Add("A", "商品名称", 0, 1);

                    while (qlddr.Read())
                    {
                        TreeNode newNode12 = new TreeNode(qlddr[0].ToString(), 0, 1);
                        newNode12.Nodes.Add("A", qlddr[4].ToString(), 0, 1);    //商品名称
                        //newNode12.Nodes.Add("B", qlddr[5].ToString(), 0, 1);    //库存数量(暂时从进货表里取)
                        //newNode12.Nodes.Add("B", qlddr[8].ToString(), 0, 1);    //销售价格
                        TN.Nodes.Add(newNode12);
                    }
                    qlddr.Close();
                    TV.ExpandAll();
                }
            }//
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        /*public string fillfrmKcGoods(string id) //用商品编号在库存表中查询对应的库存编号
        {
            string sid = "";
            string sqlConn = "select KcID from tb_KcGoods where GoodsID='" + id + "'";
            try
            {
                SqlConnection conn = (new GetSqlConnection()).GetCon();
                SqlCommand cmd = new SqlCommand(sqlConn, conn);
                SqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                if(dataReader.HasRows)
                {
                    sid = dataReader[0].ToString();
                }
                dataReader.Close();
                return sid;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return sid;     //返回空
            }
        }*/
    }
}
