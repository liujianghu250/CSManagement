using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ClassInfo
{
    public class tb_SellGoods
    {
        private string SellID;  //销售编号
        public string strSellID
        {
            get
            {
                return SellID;
            }
            set
            {
                SellID = value;
            }
        }
        //private string KcID; //库存编号
        /*public string strKcID
        {
            get
            {
                return KcID;
            }
            set
            {
                KcID = value;
            }
        }*/
        private string GoodsID; //商品编号
        public string strGoodsID
        {
            get
            {
                return GoodsID;
            }
            set
            {
                GoodsID = value;
            }
        }
        private string EmpId;   //员工编号
        public string strEmpId
        {
            get
            {
                return EmpId;
            }
            set
            {
                EmpId = value;
            }
        }
        private string GoodsName;   //商品名称
        public string strGoodsName
        {
            get
            {
                return GoodsName;
            }
            set
            {
                GoodsName = value;
            }
        }
        private int SellGoodsNum;   //销售数量
        public int strSellGoodsNum
        {
            get
            {
                return SellGoodsNum;
            }
            set
            {
                SellGoodsNum = value;
            }
        }
        private DateTime SellGoodsTime; //销售时间
        public DateTime daSellGoodsTime
        {
            get
            {
                return SellGoodsTime;
            }
            set
            {
                SellGoodsTime = value;
            }
        }
        private string GoodsJhPrice;
        public string deGoodsJhPrice
        {
            get
            {
                return GoodsJhPrice;
            }
            set
            {
                GoodsJhPrice = value;
            }
        }
        private string SellPrice;    //销售单价
        public string deSellPrice
        {
            get
            {
                return SellPrice;
            }
            set
            {
                SellPrice = value;
            }
        }
        private string SellNeedPay; //应付金额
        public string deSellNeedPay
        {
            get
            {
                return SellNeedPay;
            }
            set
            {
                SellNeedPay = value;
            }
        }
        private string SellHasPay;  //实付金额
        public string deSellHasPay
        {
            get
            {
                return SellHasPay;
            }
            set
            {
                SellHasPay = value;
            }
        }
        private string SellRemark;  //备注
        public string strSellRemark
        {
            get
            {
                return SellRemark;
            }
            set
            {
                SellRemark = value;
            }
        }
        private int SellFlag;   //删除标记
        public int intSellFlag
        {
            get
            {
                return SellFlag;
            }
            set
            {
                SellFlag = value;
            }
        }
    }
}
