using QLSV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public static class Utility
    {
        static internal TaiKhoan taiKhoan;
        static public string ImagePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Images\";
        static public bool IsOpeningForm(string formName)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == formName)
                {
                    f.Activate(); 
                    return true;
                }
            }
            return false;
        }
    }
}
