using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ClassInfo
{
    public class tb_ThGoodsInfo
    {
        private string ThGoodsID;   //退货商品编号
        public string strThGoodsID
        {
            get
            {
                return ThGoodsID;
            }
            set
            {
                ThGoodsID = value;
            }
        }
        //private string KcID;    //库存编号
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
        private string EmpId;   //员工名称
        public string intEmpId
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
        private string ThGoodsName; //商品名称
        public string strThGoodsName
        {
            get
            {
                return ThGoodsName;
            }
            set
            {
                ThGoodsName = value;
            }
        }
        private int ThGoodsNum; //退货数量
        public int intThGoodsNum
        {
            get
            {
                return ThGoodsNum;
            }
            set
            {
                ThGoodsNum = value;
            }
        }
        private DateTime ThGoodsTime;   //退货时间
        public DateTime daThGoodsTime
        {
            get
            {
                return ThGoodsTime;
            }
            set
            {
                ThGoodsTime = value;
            }
        }
        private string ThGoodsPrice;    //退货单价
        public string deThGoodsPrice
        {
            get
            {
                return ThGoodsPrice;
            }
            set
            {
                ThGoodsPrice = value;
            }
        }
        private string ThNeedPay;   //应付金额
        public string deThNeedPay
        {
            get
            {
                return ThNeedPay;
            }
            set
            {
                ThNeedPay = value;
            }
        }
        private string ThHasPay;    //已退款金额
        public string deThHasPay
        {
            get
            {
                return ThHasPay;
            }
            set
            {
                ThHasPay = value;
            }
        }
        private string ThGoodsResult;   //退货原因
        public string deThGoodsResult
        {
            get
            {
                return ThGoodsResult;
            }
            set
            {
                ThGoodsResult = value;
            }
        }
    }
}
