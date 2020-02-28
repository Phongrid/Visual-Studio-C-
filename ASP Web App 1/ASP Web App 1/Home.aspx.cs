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
        protected void Button1_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - int.Parse(txtb_year.Text);
            // save cookie .this
            WriteCookie(age);
            if(ReadCookie() > 15)
            {
                Response.Write("<script>alert('Successfully!!!');</script>");
                Response.Redirect("Member.aspx");
                
            }
            else
            {
                Response.Write("<script>alert('อายุน้อยกว่า 15ปี ห้ามเข้า!!!');</script>");
            }

        }
        private void WriteCookie(int age)
        {   // Create obj Cookie  Create parameter Cookie = UserSetting
            HttpCookie userCookie = new HttpCookie("UserSetting");
            // เก็บ ปีเกิดของ User
            userCookie.Value = age.ToString();
            // กำหนดวันหมดอายุของ Cookie
            userCookie.Expires = DateTime.Now.AddDays(3d);
            Response.Cookies.Add(userCookie);
        }
        private int ReadCookie()
        {   // Create objec HTTP / parameter user old data = use old Data (Request.Cookies)
            HttpCookie userCookie = Request.Cookies["UserSetting"];
            return int.Parse(userCookie.Value);
        }

        // Cookie จำเมื่อ โหลดจาก การเข้าใช้งานคราวที่แล้ว
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ReadCookie() > 15)
            {
                Response.Write("<script>alert('Successfully!!!');</script>");
                Response.Redirect("Member.aspx");

            }
            else
            {
                Response.Write("<script>alert('อายุน้อยกว่า 15ปี ห้ามเข้า!!!');</script>");
            }
        }
    }
}