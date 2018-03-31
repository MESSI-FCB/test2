using Common.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\Users\\xq\\Desktop\\g-star\\1.xml";
            var proc = new XMLProcess(path);
            //var node= proc.Read("bookstore");

            //var node2 = proc.Read("book");

            //var node3 = proc.Read("/DOCUMENT/CUSTOMERS/CUSTOMER");
            //var node5 = proc.Read("DOCUMENT/CUSTOMERS/CUSTOMER");

            //var node4 = proc.Read("/DOCUMENT/CUSTOMERS");
            //var s1 = proc.ReadAllChildallValue("/DOCUMENT/CUSTOMERS");
            //var s2 = proc.ReadAllChildallValue("DOCUMENT/CUSTOMERS/CUSTOMER");
            var bookModeList = new List<BookModel>();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            //然后可以通过调用SelectSingleNode得到指定的结点,通过GetAttribute得到具体的属性值.参看下面的代码
            // 得到根节点bookstore
            XmlNode xn = doc.SelectSingleNode("bookstore");
            // 得到根节点的所有子节点
            XmlNodeList xnl = xn.ChildNodes;
            foreach (XmlNode xn1 in xnl)
            {
                BookModel bookModel = new BookModel();
                // 将节点转换为元素，便于得到节点的属性值
                XmlElement xe = (XmlElement)xn1;
                // 得到Type和ISBN两个属性的属性值
                bookModel.BookISBN = xe.GetAttribute("ISBN").ToString();
                bookModel.BookType = xe.GetAttribute("Type").ToString();
                var s1 = xe.GetAttribute("as").ToString();
                // 得到Book节点的所有子节点
                XmlNodeList xnl0 = xe.ChildNodes;
                bookModel.BookName = xnl0.Item(0).InnerText;
                bookModel.BookAuthor = xnl0.Item(1).InnerText;
                bookModel.BookPrice = Convert.ToDouble(xnl0.Item(2).InnerText);
                bookModeList.Add(bookModel);
            }
            var ss = 0;



            var starpath = "C:\\Users\\xq\\Desktop\\g-star\\2.xml";
            doc.Load(starpath);
            xn = doc.SelectSingleNode("DOCUMENT/CUSTOMERS");

            xnl = xn.ChildNodes;
            foreach(XmlNode xn1 in xnl)
            {
                BookModel bookModel = new BookModel();
                // 将节点转换为元素，便于得到节点的属性值
                XmlElement xe = (XmlElement)xn1;
                // 得到Type和ISBN两个属性的属性值
                bookModel.BookISBN = xe.GetAttribute("cust_sid").ToString();
                bookModel.BookType = xe.GetAttribute("sbs_no").ToString();
                var s1 = xe.GetAttribute("cust_id").ToString();
                var store_no = xe.GetAttribute("store_no").ToString();
                var station = xe.GetAttribute("station").ToString();
                var status = xe.GetAttribute("status").ToString();
                var first_name = xe.GetAttribute("first_name").ToString();
                var last_name = xe.GetAttribute("last_name").ToString();
                var info1 = xe.GetAttribute("info1").ToString();
                var info2 = xe.GetAttribute("info2").ToString();
                var price_lvl = xe.GetAttribute("price_lvl").ToString();
                var credit_limit = xe.GetAttribute("credit_limit").ToString();
                var credit_used = xe.GetAttribute("credit_used").ToString();
                var store_credit = xe.GetAttribute("store_credit").ToString();
                var accept_checks = xe.GetAttribute("accept_checks").ToString();
                var detax = xe.GetAttribute("detax").ToString();
                var max_disc_perc = xe.GetAttribute("max_disc_perc").ToString();
                var active = xe.GetAttribute("active").ToString();
                var mark1 = xe.GetAttribute("mark1").ToString();
                var mark2 = xe.GetAttribute("mark2").ToString();
                var udf1_date = xe.GetAttribute("udf1_date").ToString();
                var udf2_date = xe.GetAttribute("udf2_date").ToString();
                var created_date = xe.GetAttribute("created_date").ToString();
                var modified_date = xe.GetAttribute("modified_date").ToString();
                var ref_cust_sid = xe.GetAttribute("ref_cust_sid").ToString();
                var email_addr = xe.GetAttribute("email_addr").ToString();
                var qb_id = xe.GetAttribute("qb_id").ToString();
                var ar_flag = xe.GetAttribute("ar_flag").ToString();
                var share_with = xe.GetAttribute("share_with").ToString();
                var cust_type = xe.GetAttribute("cust_type").ToString();
                var notes = xe.GetAttribute("notes").ToString();
                var last_sale_date = xe.GetAttribute("last_sale_date").ToString();
                var lst_sale_date = xe.GetAttribute("lst_sale_date").ToString();
                var company_name = xe.GetAttribute("company_name").ToString();
                var title = xe.GetAttribute("title").ToString();
                var tax_area_name = xe.GetAttribute("tax_area_name").ToString();
                var tax_area2_name = xe.GetAttribute("tax_area2_name").ToString();
                // 得到Book节点的所有子节点
                XmlNodeList xno0 = xe.ChildNodes;
                foreach(XmlNode xn00 in xno0)
                {
                    XmlElement xe00 = xn00 as XmlElement;
                    if (xe00.Name.Equals("CUST_ADDRESSS"))
                    {
                        var address = xe00.ChildNodes;
                        if(address != null && address.Count > 0)
                        {
                            var xe000 = address[0] as XmlElement;
                            var addr_no = xe000.GetAttribute("addr_no");
                            var address1 = xe000.GetAttribute("address1");
                            var address2 = xe000.GetAttribute("address2");
                            var address3 = xe000.GetAttribute("address3");
                            var zip = xe000.GetAttribute("zip");
                            var phone1 = xe000.GetAttribute("phone1");
                            var phone2 = xe000.GetAttribute("phone2");
                            var active = xe000.GetAttribute("active");
                        }
                    }
                    else if(xe00.Name.Equals("CUST_SUPPLS"))
                    {
                        var suppl = xe00.ChildNodes;
                    }
                    else if(xe00.Name.Equals("CUST_CRDS"))
                    {
                        var crds = xe00.ChildNodes;
                        if (crds != null && crds.Count > 0)
                        {
                            var xe000 = crds[0] as XmlElement;
                            var crd_ord = xe000.GetAttribute("crd_ord");
                            var crd_no = xe000.GetAttribute("crd_no");
                            var crd_type = xe000.GetAttribute("crd_type");
                            var crd_exp_month = xe000.GetAttribute("crd_exp_month");
                            var crd_exp_year = xe000.GetAttribute("crd_exp_year");
                            var crd_name = xe000.GetAttribute("crd_name");

                        }
                    }

                }
                bookModeList.Add(bookModel);
            }

        }
    }
}
