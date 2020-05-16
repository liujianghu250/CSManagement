using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ClassInfo
{
    class tb_Employee
    {
        private string EmpID;
        public string intEmpID
        {
            get { return EmpID; }
            set { EmpID = value; }
        }
        private string EmpName;
        public string strEmpName
        {
            get { return EmpName; }
            set { EmpName = value; }
        }
        private string EmpLoginName;
        public string strEmpLoginName
        {
            get { return EmpLoginName; }
            set { EmpLoginName = value; }
        }
        private string EmpLoginPwd;
        public string strEmpLoginPwd
        {
            get { return EmpLoginPwd; }
            set { EmpLoginPwd = value; }
        }
        private string EmpSex;
        public string intEmpSex
        {
            get { return EmpSex; }
            set { EmpSex = value; }
        }
        private DateTime EmpBirthday;
        public DateTime daEmpBirthday
        {
            get { return EmpBirthday; }
            set { EmpBirthday = value; }
        }
        private string EmpDept;
        public string strEmpDept
        {
            get { return EmpDept; }
            set { EmpDept = value; }
        }
        private string EmpPost;
        public string strEmpPost
        {
            get { return EmpPost; }
            set { EmpPost = value; }
        }
        private string EmpPhone;
        public string strEmpPhone
        {
            get { return EmpPhone; }
            set { EmpPhone = value; }
        }
        private string EmpPhoneM;
        public string strEmpPhoneM
        {
            get { return EmpPhoneM; }
            set { EmpPhoneM = value; }
        }
        private string EmpAddress;
        public string strEmpAddress
        {
            get { return EmpAddress; }
            set { EmpAddress = value; }
        }
        private int EmpPopedomID;
        public int intEmpPopedomID
        {
            get { return EmpPopedomID; }
            set { EmpPopedomID = value; }
        }
        private int EmpFlag;
        public int intEmpFlag
        {
            get { return EmpFlag; }
            set { EmpFlag = value; }
        }
        private string EmpLoing;
        public string strEmpLoing
        {
            get { return EmpLoing; }
            set { EmpLoing = value; }
        }
        private string EmpPwd;
        public string strEmpPwd
        {
            get { return EmpPwd; }
            set { EmpPwd = value; }
        }
    }
}
