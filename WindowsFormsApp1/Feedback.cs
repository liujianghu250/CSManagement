using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class Feedback
    {
        public Feedback()
        {
            jhGoodsForms = new List<JhGoodsForm>();
            companyInfoForms = new List<CompanyInfoForm>();
            employeeInfoForms = new List<EmployeeInfoForm>();
        }

        //
        //装载全部进货窗口的列表
        private List<JhGoodsForm> jhGoodsForms;
        //将进货窗口装入
        public void CreateJhGoodsForm(JhGoodsForm jh)
        {
            jhGoodsForms.Add(jh);
        }
        //使全部进货窗口更新
        public void UpdateJhGoodsForm()
        {
            for (int i = 0; i < jhGoodsForms.Count; i++)
            {
                jhGoodsForms[i].FeedbackUseUpdate();
            }
        }
        //

        //
        //装载CompanyInfoForm的列表
        private List<CompanyInfoForm> companyInfoForms;
        //将公司信息窗口装入
        public void CreateCompanyInfoForm(CompanyInfoForm company)
        {
            companyInfoForms.Add(company);
        }
        //使全部公司信息窗口更新
        public void UpdateCompanyInfoForm()
        {
            for (int i = 0; i < jhGoodsForms.Count; i++)
            {
                //companyInfoForms[i].FeedbackUseUpdate();
            }
        }
        //

        //
        //装载EmployeeInfoForm的列表
        private List<EmployeeInfoForm> employeeInfoForms;
        //将员工信息窗口装入
        public void CreateEmployeeInfoForm(EmployeeInfoForm employee)
        {
            employeeInfoForms.Add(employee);
        }
        //使全部员工信息窗口更新
        public void UpdateEmployeeInfoForm()
        {
            for (int i = 0; i < jhGoodsForms.Count; i++)
            {
                //employeeInfoForms[i].FeedbackUseUpdate();
            }
        }
        //





    }
}
