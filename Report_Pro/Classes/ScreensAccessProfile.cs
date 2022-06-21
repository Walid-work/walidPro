using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Report_Pro.Classes
{
    public class ScreensAccessProfile
    {
        string _languh = Properties.Settings.Default.lungh;

        //========strin screans Caption=====================================

        public static string mainSettings_Caption;
        public static string Transportation_Caption;
        public static string Inventory_Caption;
        public static string Sales_Caption;
        public static string Purchase_Caption;
        public static string Accounting_Caption;
        public static string LetterOfCredit_Caption;
        public static string Production_Caption;
        public static string LoansMenu_Caption;
        public static string FixedAssets_Caption;
        public static string CashTransaction_Caption;
        public static string GroupReports_Caption;
        public static string Permissions_Caption;




        public static string SalesInvoce_Caption;
        public static string SalesQutation_Caption;
        public static string SalesDelevary_Caption;
        public static string ItemQuery_Caption;
        public static string SalesReports_Caption;
        public static string SalesVatReports_Caption;

        
        public static string PurchaseInvoce_Caption;
        public static string PurchaseQutation_Caption;
        public static string PurchasePO_Caption;
        public static string PurchaseReports_Caption;
        public static string PurchaseVatReports_Caption;
        public static string LastPurchase_Caption;
        public static string RequstPurchaseQutation_Caption;
        public static string ComparePurchaseQuotation_Caption;
        public static string PurchaseOrdersReport_Caption;

        public static string ClosePurchToLc_Caption;

        //===================Purchase=====================================
        public static int MaxID = 1;
        public ScreensAccessProfile (string name,ScreensAccessProfile  parent=null)
        {
            ScreenName = name;
            ScreenID = MaxID++;
            if (parent != null)
            {
                ParentScreenID = parent.ScreenID;
            }
            else
            {
                ParentScreenID = 0;
            }
            Actions = new List<Master.Actions>() {

                Master.Actions.Add,
                Master.Actions.Edit,
                Master.Actions.Delete,
                Master.Actions.Print,
                Master.Actions.Show,
                Master.Actions.Open,
            };

             
         
            if (_languh == "0")
            {

                mainSettings_Caption ="البيانات الرئيسية";
                Transportation_Caption ="النقليات";
                Inventory_Caption ="المخزون";
                Accounting_Caption="الحسابات";
                LetterOfCredit_Caption="الاعتمادات المستندية";
                Production_Caption="الانتاج";
                LoansMenu_Caption="القروض";
                FixedAssets_Caption="الاصول الثابتة";
                CashTransaction_Caption="حركة الصندوق";
                GroupReports_Caption="التقارير المجمعة";
                Permissions_Caption="الصلاحيات";





                //==== قائمة المبيعات عربي ========
                Sales_Caption = "المبيعات";
                SalesInvoce_Caption = "فاتورة مبيعات";
                SalesQutation_Caption = "عرض سعر";
                SalesDelevary_Caption = "اشعار شحن";
                ItemQuery_Caption = "استعلام صنف";
                SalesReports_Caption = "تقارير المبيعات";
                SalesVatReports_Caption = "تقارير ضريبة المبيعات";
               
                //==== قائمة المشتريات عربي ========
                Purchase_Caption = "المشتريات";
                PurchaseInvoce_Caption = "فاتورة مشتريات";
                PurchaseQutation_Caption = "عرض سعر مشتريات";
                PurchasePO_Caption = "طلب شراء";
                PurchaseReports_Caption = "تقارير المشتريات";
                PurchaseVatReports_Caption = "تقارير ضريبة المشتريات";
                LastPurchase_Caption = "سعر اخر مشتريات";
                RequstPurchaseQutation_Caption = "طلب عرض سعر مشتريات";
                ComparePurchaseQuotation_Caption = "مقارنة عروض اسعار المشتريات";
                PurchaseOrdersReport_Caption = "تقرير طلبات الشراء";

                //==== قائمة الاعتمادات عربي ========
                ClosePurchToLc_Caption = "تحويل الاستلامات من حساب المورد للاعتماد";

            }
            else
            {


                mainSettings_Caption = "Main Data";
                Transportation_Caption = "Transportation";
                Inventory_Caption = "Inventory";
                Accounting_Caption = "Accounting";
                LetterOfCredit_Caption = "Letter Of Credit";
                Production_Caption = "Production";
                LoansMenu_Caption = "Loans";
                FixedAssets_Caption = "Fixed Assets";
                CashTransaction_Caption = "Cash Transaction";
                GroupReports_Caption = "Group Reports";
                Permissions_Caption = "Permissions";

                //==== قائمة المبيعات انجليزي   ========
                Sales_Caption = "Sales";
                SalesInvoce_Caption = "Sales Invice";
                SalesQutation_Caption = "Sales Qutation";
                SalesDelevary_Caption = "Delevary Note";
                ItemQuery_Caption = "Item Query";
                SalesReports_Caption = "Sales Reports";
                SalesVatReports_Caption = "Sales VAT Reports";
               
                //==== قائمة المشتريات انجليزي ========
                Purchase_Caption = "Purchase";
                PurchaseInvoce_Caption = "Purchase Invice";
                PurchaseQutation_Caption = "Purchases Qutation";
                PurchasePO_Caption = "Purchases Order";
                PurchaseReports_Caption = "Purchases Reports";
                PurchaseVatReports_Caption = "Purchases VAT Reports";
                LastPurchase_Caption = "Last Purchase Price";
                RequstPurchaseQutation_Caption = "Requst Purchase Qutation";
                ComparePurchaseQuotation_Caption = "Compare Purchase Quotation";
                PurchaseOrdersReport_Caption = "Purchase Orders Report";

                //==== قائمة الاعتمادات انجليزي ========
                ClosePurchToLc_Caption = "Close Purchase To Lc";
            }

        }

        


        public int ScreenID { get; set; }
        public int ParentScreenID { get; set; }
        public string ScreenName { get; set; }
        public string ScreenCaption { get; set; }
        public string ScreenCaption_E { get; set; }
        public bool CanShow { get; set; }
        public bool CanOpen { get; set; }
        public bool CanAdd { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDelete { get; set; }
        public bool CanPrint { get; set; }

        public List<Master.Actions> Actions { get; set; }
    
    }




    public static class Screens
    {




        public static ScreensAccessProfile mainSettings = new ScreensAccessProfile("elm_MainSetting")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "البيانات الرئيسية",ScreenCaption_E= "Main Data"

        };

        public static ScreensAccessProfile Transportation = new ScreensAccessProfile("elm_Transportation")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "النقليات",  ScreenCaption_E = "Transportation"
        };

        public static ScreensAccessProfile Sales = new ScreensAccessProfile("elm_Sales")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "المبيعات",ScreenCaption_E ="Sales"
        };

        public static ScreensAccessProfile Purchases = new ScreensAccessProfile("elm_Purchases")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "المشتريات",ScreenCaption_E ="Purchases"
        };


        public static ScreensAccessProfile Inventory = new ScreensAccessProfile("elm_Inventory")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "المخزون",ScreenCaption_E = "Inventory"
        };


        public static ScreensAccessProfile Accounting = new ScreensAccessProfile("elm_Accounting")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "الحسابات",ScreenCaption_E ="Accounting"
        };

        public static ScreensAccessProfile LetterOfCredit = new ScreensAccessProfile("elm_LetterOfCredit")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "الاعتمادات المستندية",ScreenCaption_E = "Letter Of Credit"
        };


        public static ScreensAccessProfile Production = new ScreensAccessProfile("elm_Production")

        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "الانتاج",ScreenCaption_E = "Production"
        };

        public static ScreensAccessProfile LoansMenu = new ScreensAccessProfile("elm_LoansMenu")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "القروض",ScreenCaption_E ="Loans"
        };

        public static ScreensAccessProfile FixedAssets = new ScreensAccessProfile("elm_FixedAssets")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "الاصول الثابتة" , ScreenCaption_E ="Fixed Assets"
        };

        public static ScreensAccessProfile CashTransaction = new ScreensAccessProfile("elm_CashTransaction")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "حركة الصندوق",ScreenCaption_E= "Cash Transaction"
        };

        public static ScreensAccessProfile GroupReports = new ScreensAccessProfile("elm_GroupReports")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption = "التقارير المجمعة",ScreenCaption_E = "Group Reports"
        };
        

        public static ScreensAccessProfile Permissions = new ScreensAccessProfile("elm_Permissions")
        {
            Actions = new List<Master.Actions>() { Master.Actions.Show, Master.Actions.Edit, Master.Actions.Open },
            ScreenCaption ="الصلاحيات", ScreenCaption_E = "Permissions"
        };

        public static ScreensAccessProfile frmCompanyData = new ScreensAccessProfile(nameof(Forms.frm_CompanyData), mainSettings)
        { 
            ScreenCaption = "بيانات الشركة" ,  ScreenCaption_E = "Company Data" };

        public static ScreensAccessProfile frmConfigration = new ScreensAccessProfile(nameof(PL.Frm_Config), mainSettings)
        { ScreenCaption = "اعدادات البرنامج", ScreenCaption_E = "Program Configration" };

        public static ScreensAccessProfile frmBanks = new ScreensAccessProfile(nameof(PL.Frm_Banks), mainSettings)
        { ScreenCaption = "البنوك", ScreenCaption_E = "Banks" };

        public static ScreensAccessProfile frmUsersList = new ScreensAccessProfile(nameof(Forms.frm_UserList), mainSettings)
        { ScreenCaption = "قائمة المستخدمين", ScreenCaption_E = "User List" };

        public static ScreensAccessProfile frmUsersMangment = new ScreensAccessProfile(nameof(Forms.frm_Users), mainSettings)
        { ScreenCaption = "ادارة المستخدمين", ScreenCaption_E = "User Mangment"};

        public static ScreensAccessProfile frmStores = new ScreensAccessProfile(nameof(PL.frmStores), mainSettings)
        { ScreenCaption = "المخازن", ScreenCaption_E = "Stores"};

        public static ScreensAccessProfile frmRate = new ScreensAccessProfile(nameof(PL.frmRate), mainSettings)
        { ScreenCaption = "معدل صرف العملات", ScreenCaption_E = "Currency Rate"};

        public static ScreensAccessProfile SalesQutation = new ScreensAccessProfile(nameof(PL.frmQuotation), Sales)
        { ScreenCaption = "عرض سعر مبيعات", ScreenCaption_E ="Sales Qutation" };

        public static ScreensAccessProfile SalesInvoice = new ScreensAccessProfile(nameof(PL.frm_Sales_Invoice), Sales)
        { ScreenCaption = "فاتورة مبيعات", ScreenCaption_E = "Sales Invoce" };
   

        public static ScreensAccessProfile SalesDelevary = new ScreensAccessProfile(nameof(PL.frmDelivryNote), Sales)
        { ScreenCaption = "اشعار شحن", ScreenCaption_E = "Delevary Note" };

        public static ScreensAccessProfile ItemQuery = new ScreensAccessProfile(nameof(PL.frm_check_item_Price), Sales)
        { ScreenCaption ="استعلام صنف", ScreenCaption_E = "Item Query" };

        public static ScreensAccessProfile SalesReports = new ScreensAccessProfile(nameof(RPT.frm_rpt_Sales_by_Br), Sales)
        { ScreenCaption = "تقارير المبيعات", ScreenCaption_E = "Sales Reports" };

        public static ScreensAccessProfile SalesVATReports = new ScreensAccessProfile(nameof(RPT.frm_Export_sales), Sales)
        { ScreenCaption = "تقارير مبيعات الضريبة", ScreenCaption_E = "Sales VatReports" };

        public static ScreensAccessProfile PurchaseReports = new ScreensAccessProfile(nameof(RPT.frm_rpt_Purchases), Purchases)
        { ScreenCaption ="تقارير المشتريات", ScreenCaption_E = "Purchase Reports"};

        public static ScreensAccessProfile VatPurchaseReports = new ScreensAccessProfile(nameof(RPT.frmPurchase_rpt), Purchases)
        { ScreenCaption ="تقرير مشتريات الضريبة", ScreenCaption_E = "Purchase Vat Reports"};

        public static ScreensAccessProfile LastPurchasPrice = new ScreensAccessProfile(nameof(RPT.Purchase_reports), Purchases)
        { ScreenCaption = "تقرير اخر مشتريات" ,  ScreenCaption_E = "Last Purchase" };

        public static ScreensAccessProfile PurchaseRequstQutation = new ScreensAccessProfile(nameof(PL.frm_R_Qutaion), Purchases)
        { ScreenCaption = "طلب تسعيرة مشتريات" , ScreenCaption_E = "Requst Purchase Qutation"};

        public static ScreensAccessProfile PurchaseQutation = new ScreensAccessProfile(nameof(PL.frm_Purch_Qutation), Purchases)
        { ScreenCaption = "تسعيرة مشتريات" , ScreenCaption_E = "Purchase Qutation" };

        public static ScreensAccessProfile PurchaseQutationCompare = new ScreensAccessProfile(nameof(RPT.frm_Compare_PQ), Purchases)
        { ScreenCaption = "مقارنة عروض اسعار" , ScreenCaption_E = "Compare Purchase Quotation" };

        public static ScreensAccessProfile PurchaseOrder = new ScreensAccessProfile(nameof(PL.frm_PurchaseOrder), Purchases)
        { ScreenCaption = "طلب شراء" , ScreenCaption_E = "Purchase PO" };

        public static ScreensAccessProfile ReportsPO = new ScreensAccessProfile(nameof(RPT.frm_rpt_Po), Purchases)
        { ScreenCaption = "تقرير طلبات الشراء" , ScreenCaption_E = "Purchase Orders Report" };

        public static ScreensAccessProfile Contract = new ScreensAccessProfile(nameof(PL.frm_Contract), LetterOfCredit)
        { ScreenCaption = "عقود المشتريات",ScreenCaption_E ="Purchase Contract" };

        public static ScreensAccessProfile PrformaInvoiceReport = new ScreensAccessProfile(nameof(RPT.frm_rpt_preform), LetterOfCredit)
        { ScreenCaption = "تقرير الفاتورة المبدئية",ScreenCaption_E = "Preforma Report" };

        public static ScreensAccessProfile ClosePurchToLc = new ScreensAccessProfile(nameof(Forms.frm_close_purch_to_lc), LetterOfCredit)
        { ScreenCaption = "اقفال المشتريات بالاعتماد", ScreenCaption_E="Close Purch To Lc" };

        public static ScreensAccessProfile Loan = new ScreensAccessProfile(nameof(Loans.frm_Loan), LoansMenu)
        { ScreenCaption = "قرض جديد" ,ScreenCaption_E = "New Loan"};

        public static ScreensAccessProfile LoanPayment = new ScreensAccessProfile(nameof(Loans.frm_LoanPayment), LoansMenu)
        { ScreenCaption = "سداد قرض" ,ScreenCaption_E = "Loan Payment"};

        public static ScreensAccessProfile LoansReports = new ScreensAccessProfile(nameof(Loans.frm_LoansReports), LoansMenu)
        { ScreenCaption = "تقارير القرض" ,ScreenCaption_E = "Loans Reports"};

        public static ScreensAccessProfile LoansInterest = new ScreensAccessProfile(nameof(Loans.frm_Loans_Interest), LoansMenu)
        { ScreenCaption = "تقارير فائدة القروض" ,ScreenCaption_E = "Loans Intrest Reports"};

        
        public static ScreensAccessProfile AccessProfile = new ScreensAccessProfile(nameof(Forms.frm_AccessProfile), Permissions)
        { ScreenCaption = "نماذج الصلاحيات" ,ScreenCaption_E = "Permission Forms" };

        public static ScreensAccessProfile AccessProfileList = new ScreensAccessProfile(nameof(Forms.frm_AccessProfileList), Permissions)
        { ScreenCaption = "عرض نماذج الصلاحيات",ScreenCaption_E = "Show Permission forms" };


        public static ScreensAccessProfile MatrialsRequest = new ScreensAccessProfile(nameof(PL.frm_R_Matrails), Inventory)
        { ScreenCaption = "طلب مواد" ,ScreenCaption_E = "Material Request" };

        public static ScreensAccessProfile InventoryBranches = new ScreensAccessProfile(nameof(RPT.frm_rpt_InventoryBranches), Inventory)
        { ScreenCaption = " تقرير مخزون مجموعة بالفروع" ,ScreenCaption_E = "Group Inventory By Branches" };

        public static ScreensAccessProfile PrintInvoices = new ScreensAccessProfile(nameof(RPT.frm_Print_invoice), Accounting)
        { ScreenCaption = "طباعة الفواتير",ScreenCaption_E ="Print Invoices" };

        public static ScreensAccessProfile Cash_Receipt = new ScreensAccessProfile(nameof(CTR.frm_Cash_Receipt), CashTransaction)
        { ScreenCaption ="سند قبض" , ScreenCaption_E = "Cash Receipt" };

        public static ScreensAccessProfile CloseCustomerPayment = new ScreensAccessProfile(nameof(CTR.frm_CloseCustomerPayment), CashTransaction)
        { ScreenCaption = "تعريف سداد فواتير عميل" ,ScreenCaption_E = "Definition of paying customer invoices" };

        public static ScreensAccessProfile InventoryReport = new ScreensAccessProfile(nameof(RPT.frm_Inventory_Report), Inventory)
        { ScreenCaption = " تقرير المخزون" , ScreenCaption_E ="Inventory Reports"};

        public static ScreensAccessProfile InventoryReportNew = new ScreensAccessProfile(nameof(RPT.frm_rpt_inventory), Inventory)
        { ScreenCaption = " تقارير المخزون المعدلة" ,ScreenCaption_E = "Adjusted inventory reports" };


        public static ScreensAccessProfile ReportsProductin = new ScreensAccessProfile(nameof(RPT.frm_rpt_Productin), Production)
        { ScreenCaption = "تقارير الانتاج " ,ScreenCaption_E = "Production Reports"};

        public static ScreensAccessProfile ElementsGroup = new ScreensAccessProfile(nameof(PL.frm_BS_elements_Group), GroupReports)
        { ScreenCaption = "قيد اعادة تصنيف"};

        public static ScreensAccessProfile TbGroup = new ScreensAccessProfile(nameof(Group.frm_BS_TB_Group), GroupReports)
        { ScreenCaption = "ميزان المراجعة المجمع" };


        public static ScreensAccessProfile AccountStatment = new ScreensAccessProfile(nameof(RPT.frm_statment_Rpt), Accounting)
        { ScreenCaption = "كشف حساب" };

        public static ScreensAccessProfile TB = new ScreensAccessProfile(nameof(RPT.frm_TB), Accounting)
        { ScreenCaption = "ميزان المراجعة" }; 

        public static ScreensAccessProfile AgingReport = new ScreensAccessProfile(nameof(RPT.frmAgeReport), Accounting)
        { ScreenCaption = "اعمار الديون" };

        public static ScreensAccessProfile CostTB = new ScreensAccessProfile(nameof(RPT.frm_CostCenter_TB), Accounting)
        { ScreenCaption = "ميزان مراكز التكلفة" };

        public static ScreensAccessProfile AccountConfirmation = new ScreensAccessProfile(nameof(RPT.frm_Confirmation), Accounting)
        { ScreenCaption = "مصادقة حساب" };

        public static ScreensAccessProfile FeesReport = new ScreensAccessProfile(nameof(RPT.frm_rep_Fees), Accounting)
        { ScreenCaption = "تقرير المصاريف" };

        public static ScreensAccessProfile FeesReportTotal= new ScreensAccessProfile(nameof(RPT.frm_rep_Fees_Consolidated), Accounting)
        { ScreenCaption = "تقرير المصاريف المجمع" };

        public static ScreensAccessProfile SalaryRepot = new ScreensAccessProfile(nameof(RPT.frm_rpt_salary), Accounting)
        { ScreenCaption = "تقرير الرواتب" };

        public static ScreensAccessProfile AccountsCompare = new ScreensAccessProfile(nameof(RPT.frm_Compare_TB), Accounting)
        { ScreenCaption = "مقارنة الحسابات" };

        public static ScreensAccessProfile SalesReportsGroup = new ScreensAccessProfile(nameof(Group.frm_rpt_Sales_Group), GroupReports)
        { ScreenCaption = "تقارير المبيعات" };

        public static ScreensAccessProfile InventoryReportsGroup = new ScreensAccessProfile(nameof(Group.frm_Inventory_Report_Group), GroupReports)
        { ScreenCaption = "تقارير المخزون",ScreenCaption_E = "Inventory Reports" };


        public static ScreensAccessProfile ChequeBanks = new ScreensAccessProfile(nameof(CTR.frm_ChequeBanks), CashTransaction)
        { ScreenCaption = "بنوك الشيكات", ScreenCaption_E = "cheques Banks" };

        public static ScreensAccessProfile ChoseStore = new ScreensAccessProfile(nameof(PL.frm_ChoseStore), mainSettings)
        { ScreenCaption = "اختيار المستودع", ScreenCaption_E = "Chose Store" };



        public static List<ScreensAccessProfile> GetScreens
        {
            get
            {
                Type t = typeof(Screens);
                FieldInfo[] fields = t.GetFields(BindingFlags.Public | BindingFlags.Static);
                var list = new List<ScreensAccessProfile>();
                foreach (var item in fields)
                {
                    var obj = item.GetValue(null);
                    if (obj != null && obj.GetType() == typeof(ScreensAccessProfile))
                    {
                        list.Add((ScreensAccessProfile)obj);

                    }
                    
                }
                return list; 
            }
        }
    }

}
