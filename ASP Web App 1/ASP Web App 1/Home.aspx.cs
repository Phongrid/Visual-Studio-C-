using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Web_App_1
{
    public partial class Home : System.Web.UI.Page
    {
        // Cookie จำเมื่อ โหลดจาก การเข้าใช้งานคราวที่แล้ว
        protected void Page_Load(object sender, EventArgs e)
        {
            // CheckAge(int.Parse(Request.Cookies["UserSetting"].Value));
            // ReadSession();

        }
        private void CheckAge(int age)
        {
            if (age > 15)
            {
                Response.Write("<script>alert('Successfully!!!');</script>");
                Response.Redirect("Member.aspx");
            }
            else
            {
                Response.Write("<script>alert('อายุน้อยกว่า 15ปี ห้ามเข้า!!!');</script>");
            }
        }
        private void WriteSession(int age)
        {
            Session["userAge"] = age;
        }
        private int ReadSession()
        {   if(Session["userAge"] == null)
            {
                return 0;
            }
            return int.Parse(Session["userAge"].ToString());
        }
      
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtb_year.Text))
            {
                Response.Write("<script>alert('Empty!!!');</script>");
            }
            else
            {
                int age = DateTime.Now.Year - int.Parse(txtb_year.Text);
                // WriteCookie(age);// save cookie .this
                WriteSession(age);
                CheckAge(int.Parse(Request.Cookies["UserSetting"].Value));
            }
            
        }
        private void WriteCookie(int age)
        {   HttpCookie userCookie = new HttpCookie("UserSetting");// Create obj Cookie  Create parameter Cookie = UserSetting
            userCookie.Value = age.ToString();  // เก็บ ปีเกิดของ User
            userCookie.Expires = DateTime.Now.AddDays(3d);            // กำหนดวันหมดอายุของ Cookie = 3 วัน
            Response.Cookies.Add(userCookie);
        }
        private int ReadCookie()
        {  HttpCookie userCookie = Request.Cookies["UserSetting"]; // Create objec HTTP / parameter user old data = use old Data (Request.Cookies)
            return int.Parse(userCookie.Value);
        }

        
    }
}