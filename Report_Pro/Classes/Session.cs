using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Report_Pro.Classes.DataBaseWatcher;
using static Report_Pro.Classes.Master;

namespace Report_Pro.Classes
{
    public static class Session
    {

        //Test

        public static class Defualts
        {
            public static int Drawer { get => 1; }
            public static int Customer { get => 1; }
            public static int Vendor { get => 2; }
            public static int Store { get => 1003; }
            public static int RawStore { get => 1003; }
            public static int DiscountAllowedAccountID { get => 1010; }
            public static int DiscountReceivedAccountID { get => 1009; }
            public static int SalesTax { get => 1019; }
            public static int PurchaseTax { get => 1020; }
            public static int PurchaseExpences { get => 1021; }
        }

        private static DAL.Wh_Oiner_Comp companyInfo;
        public static DAL.Wh_Oiner_Comp CompanyInfo
        {
            get
            {
                if (companyInfo == null)
                {
                    using (var db = new DAL.dbDataContext())
                    {
                        companyInfo = db.Wh_Oiner_Comps.First();
                    }
                }
                return companyInfo;

            }
        }
        public static class CurrentSettings
        {
          //  public static PrintMode InvoicePrintMode { get => PrintMode.ShowPreview; }


        }
        public static UserSettingsTemplate _userSettings;
        public static UserSettingsTemplate UserSettings
        {
            get
            {

                if (_userSettings == null)
                    _userSettings = new UserSettingsTemplate(User.Perm_code.Value);
                return _userSettings;

            }
        }
        public static class GlobalSettings
        {
            public static Boolean ReadFormScaleBarcode { get => true; }

            public static string ScaleBarcodePrefix { get => "21"; }
            public static byte ProductCodeLength { get => 5; }
            public static byte BarcodeLength { get => 13; }
            public static byte ValueCodeLength { get => 5; }
            public static ReadValueMode ReadMode { get => ReadValueMode.Price; }
            public static Boolean IgnoreCheckDigit { get => true; }
            public static byte DivideValueBy { get => 2; }

            public enum ReadValueMode
            {
                Weight,
                Price,
            }
        }
        private static BindingList<DAL.Wh_Unit> unitNames;
        public static BindingList<DAL.Wh_Unit> UnitNames
        {
            get
            {

                if (unitNames == null)
                {
                    using (var db = new DAL.dbDataContext())
                    {
                        unitNames = new BindingList<DAL.Wh_Unit>(db.Wh_Units.ToList());
                    }
                }
                return unitNames;
            }

        }

        private static BindingList<DAL.wh_main_master> _products;
        public static BindingList<DAL.wh_main_master> Products
        {
            get
            {

                if (_products == null)
                {

                    using (var db = new DAL.dbDataContext())
                    {
                        _products = new BindingList<DAL.wh_main_master>(db.wh_main_masters.ToList());
                    }
                    DataBaseWatcher.Products = new TableDependency.SqlClient.SqlTableDependency<DAL.wh_main_master>("server=" + Properties.Settings.Default.Server + " ;database= " + Convert.ToString(Properties.Settings.Default.Database_1) + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + ";timeout=60");
                    DataBaseWatcher.Products.OnChanged += DataBaseWatcher.Products_Changed;
                    DataBaseWatcher.Products.Start();
                }
                return _products;
            }
        }


        private static BindingList<ProductViewClass> productViewClasses;
        public static BindingList<ProductViewClass> ProductsView
        {
            get
            {
                if (productViewClasses == null)
                {
                    using (var db = new DAL.dbDataContext())
                    {


                 


                        var data = from pr in Session.Products
                                   join cg in db.wh_Groups on pr.group_code equals cg.group_code
                                   select new ProductViewClass
                                   {
                                       ID = pr.group_code,
                                       Code = pr.item_no,
                                       Name = pr.descr,
                                       CategoryName = cg.Group_name,
                                       Descreption = pr.Descr_eng,
                                       IsActive = Convert.ToBoolean(pr.Open_Items),
                                       Type = pr.Category,
                                       FactoryNo =pr.factory_no == null ? "" : pr.factory_no,
                                       //Units = (from u in db.ProductUnits
                                       //         where u.ProductID == pr.ID
                                       //         join un in db.UnitNames on u.UnitID equals un.ID
                                       //         select new ProductViewClass.ProductUOMView
                                       //         {
                                       //             UnitID = u.UnitID,
                                       //             UnitName = un.Name,
                                       //             Factor = u.Factor,
                                       //             SellPrice = u.SellPrice,
                                       //             BuyPrice = u.BuyPrice,
                                       //             Barcode = u.Barcode,
                                       //         }).ToList()
                                   };
                        productViewClasses = new BindingList<ProductViewClass>(data.ToList());
                    }
                }
                return productViewClasses;
            }
        }



    

        public class ProductViewClass
        {


           

            public static ProductViewClass GetProduct(string id)
            {
                ProductViewClass obj;
                using (var db = new DAL.dbDataContext())
                {

                    //var q =
                    //    from a in dc.GetTable<Order>()
                    //    where a.CustomerID.StartsWith("A")
                    //    select a;

                    var data = from pr in Session.Products
                               where pr.item_no == "2606004"
                               join cg in db.wh_Groups on pr.group_code equals cg.group_code
                               select new ProductViewClass
                               {
                                   ID = pr.group_code,
                                   Code = pr.item_no,
                                   Name = pr.descr,
                                   CategoryName = cg.Group_name,
                                   Descreption = pr.Descr_eng,
                                   IsActive = Convert.ToBoolean(pr.Open_Items),
                                   Type = pr.Category,
                                   FactoryNo = pr.factory_no == null ? "" : pr.factory_no,
                                   //Units = (from u in db.Wh_Units
                                   //         where u.Wh_Unit1 == pr.Unit
                                   //         join un in db.UnitNames on u.UnitID equals un.ID
                                   //         select new ProductViewClass.ProductUOMView
                                   //         {
                                   //             UnitID = u.UnitID,
                                   //             UnitName = un.Name,
                                   //             Factor = u.Factor,
                                   //             SellPrice = u.SellPrice,
                                   //             BuyPrice = u.BuyPrice,
                                   //             Barcode = u.Barcode,
                                   //         }).ToList()
                               };
                    obj = data.First();
                };
                return obj;
            }
            public string ID { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public string CategoryName { get; set; }
            public string Descreption { get; set; }
            public Boolean IsActive { get; set; }
            public string Type { get; set; }
            public string FactoryNo { get; set; }
            public List<ProductUOMView> Units { get; set; }
            public class ProductUOMView
            {
                public int UnitID { get; set; }
                public string UnitName { get; set; }
                public Double Factor { get; set; }
                public Double SellPrice { get; set; }
                public Double BuyPrice { get; set; }
                public string Barcode { get; set; }
            }
        }

        //private static BindingList<DAL.CustomersAndVendor> _vendors;
        //public static BindingList<DAL.CustomersAndVendor> Vendors
        //{
        //    get
        //    {
        //        if (_vendors == null)
        //        {
        //            using (var db = new DAL.dbDataContext())
        //            {
        //                _vendors = new BindingList<DAL.CustomersAndVendor>(db.CustomersAndVendors.Where(x => x.IsCustomer == false).ToList());
        //            }
        //            DataBaseWatcher.Vendors =
        //                new TableDependency.SqlClient.SqlTableDependency<CustomersAndVendors>(Properties.Settings.Default.SalesDBConnectionString,
        //                filter: new DataBaseWatcher.VendorsOnly());
        //            DataBaseWatcher.Vendors.OnChanged += DataBaseWatcher.VendorsChanged;
        //            DataBaseWatcher.Vendors.Start();
        //        }
        //        return _vendors;
        //    }
        //}


        private static BindingList<DAL.SHEEK_BANKS_TYPE> _cheuqeBanks;
        public static BindingList<DAL.SHEEK_BANKS_TYPE> CheuqeBanks
        {
            get
            {
                if (_cheuqeBanks == null)
                {
                    using (var db = new DAL.dbDataContext())
                    {
                        _cheuqeBanks = new BindingList<DAL.SHEEK_BANKS_TYPE>(db.SHEEK_BANKS_TYPEs.ToList());
                    }
                    DataBaseWatcher.ChequeBanks = new TableDependency.SqlClient.SqlTableDependency<SHEEK_BANKS_TYPE>("server = " + Properties.Settings.Default.Server + " ; database = " + Convert.ToString(Properties.Settings.Default.Database_1) + "; integrated security = false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + "; timeout = 60");
                    DataBaseWatcher.ChequeBanks.OnChanged += DataBaseWatcher.ChequeBanksChanged;
                    DataBaseWatcher.ChequeBanks.Start();
                }
                return _cheuqeBanks;
            }
        }



        //private static BindingList<DAL.Drawer> _drawer;
        //public static BindingList<DAL.Drawer> Drawer
        //{
        //    get
        //    {
        //        if (_drawer == null)
        //        {
        //            using (var db = new DAL.dbDataContext())
        //            {
        //                _drawer = new BindingList<DAL.Drawer>(db.Drawers.ToList());
        //            }
        //        }
        //        return _drawer;
        //    }
        //}

        private static BindingList<DAL.wh_BRANCH> _store;
        public static BindingList<DAL.wh_BRANCH> Store
        {
            get
            {
                if (_store == null)
                {
                    using (var db = new DAL.dbDataContext())
                    {
                        _store = new BindingList<DAL.wh_BRANCH>(db.wh_BRANCHes.ToList());
                    }
                }
                return _store;
            }
        }

        //private static BindingList<DAL.UserSettingsProfileProperty > _profileProperties;
        //public static BindingList<DAL.UserSettingsProfileProperty> ProfileProperties
        //{
        //    get
        //    {
        //    
        //        if (_profileProperties == null)
        //        {
        //            using (var db = new DAL.dbDataContext())
        //            {
        //                _profileProperties = new BindingList<DAL.UserSettingsProfileProperty>(db.UserSettingsProfileProperties .ToList());
        //            }
        //        }
        //        return _profileProperties;
        //    }
        //}
        private static DAL.wh_USER _user;
        public static DAL.wh_USER User { get => _user; }

        public static void SetUser(DAL.wh_USER user)
        {
            _user = user;
            using (DAL.dbDataContext db = new DAL.dbDataContext())
            {
                _screensAccesses = (from s in Classes.Screens.GetScreens
                                    from d in db.UserAccessProfileDetails
                                    .Where(x => x.ProfileID == user.Perm_code && x.ScreeanID == s.ScreenID).DefaultIfEmpty()
                                    select new Classes.ScreensAccessProfile(s.ScreenName)
                                    {
                                        CanAdd = (d == null) ? false : d.CanAdd,
                                        CanDelete = (d == null) ? false : d.CanDelete,
                                        CanEdit = (d == null) ? false : d.CanEdit,
                                        CanOpen = (d == null) ? false : d.CanOpen,
                                        CanPrint = (d == null) ? false : d.CanPrint,
                                        CanShow = (d == null) ? false : d.CanShow,
                                        Actions = s.Actions,
                                        ScreenName = s.ScreenName,
                                        ScreenCaption = s.ScreenCaption ,
                                        ScreenCaption_E = s.ScreenCaption_E,

                                      //  ScreenCaption = Properties.Settings.Default.lungh =="0" ?  s.ScreenCaption :  s.ScreenCaption_E ,
                                        ScreenID = s.ScreenID,
                                        ParentScreenID = s.ParentScreenID,
                                    }).ToList();
            }
        }
        //private static BindingList<DAL.CustomersAndVendor> _customer;
        //public static BindingList<DAL.CustomersAndVendor> Customers
        //{
        //    get
        //    {
        //        if (_customer == null)
        //        {
        //            using (var db = new DAL.dbDataContext())
        //            {
        //                _customer = new BindingList<DAL.CustomersAndVendor>(db.CustomersAndVendors.Where(x => x.IsCustomer == true).ToList());
        //            }

        //            DataBaseWatcher.Customers =
        //                new TableDependency.SqlClient.SqlTableDependency<CustomersAndVendors>(Properties.Settings.Default.SalesDBConnectionString,
        //                filter: new DataBaseWatcher.CustomersOnly());
        //            DataBaseWatcher.Customers.OnChanged += DataBaseWatcher.CustomerChanged;
        //            DataBaseWatcher.Customers.Start();
        //        }
        //        return _customer;
        //    }
        //}

        private static List<ScreensAccessProfile> _screensAccesses;
        public static List<ScreensAccessProfile> ScreensAccesses
        {

            get {

                if (User.CAN_GIVE_PERM == (byte)Master.UserType.Admin)
                  return Screens.GetScreens;
                else
                    return _screensAccesses;
            }  


        }

        public static string itemSearch_1;
        public static string itemSearch1 {
            get { return itemSearch_1; }
            set {itemSearch_1 = value; } }

        public static string itemSearch_2;
        public static string itemSearch2
        {
            get { return itemSearch_2; }
            set { itemSearch_2 = value; }
        }
        public static string itemSearch_3;
        public static string itemSearch3
        {
            get { return itemSearch_3; }
            set { itemSearch_3 = value; }
        }
        public static string itemSearch_4;
        public static string itemSearch4
        {
            get { return itemSearch_4; }
            set { itemSearch_4 = value; }
        }
        public static string itemSearch_5;
        public static string itemSearch5
        {
            get { return itemSearch_5; }
            set { itemSearch_5 = value; }
        }
    }
}
