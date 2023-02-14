using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace vsGUI
{
    class ChangeLanguage
    {
        public static string DefaultLanguage = "CN";

        //加载语言
        public static bool LoadLanguage(Form form, string language)
        {
            if (form == null || form.IsDisposed) { return false; }
            if (string.IsNullOrEmpty(language)) { return false; }

            Hashtable hashText = ReadXMLText(form.Name, language);
            Hashtable hashHeaderText = ReadXMLText(form.Name, language);

            if (hashText == null) { return false; }

            Control.ControlCollection childCollections = form.Controls;

            //遍历所有类型的控件
            foreach (Control c in childCollections)
            {
                if (c.GetType() == typeof(Label))
                {
                    GetSetSubControls(c.Controls, hashText, hashHeaderText);
                }



                if (hashText.Contains(c.Name))
                {
                    c.Text = (string)hashText[c.Name];
                }
            }

            //找到控件则重命名
            if (hashText.Contains(form.Name))
            {
                form.Text = (string)(hashText[form.Name]);
            }

            return true;
        }

        //获取并设置控件中的子控件
        private static void GetSetSubControls(Control.ControlCollection controls, Hashtable hashText, Hashtable hashHeaderText)
        {
            try
            {
                foreach (Control c in controls)
                {
                    if (c.GetType() == typeof(Label))
                    {
                        GetSetSubControls(c.Controls, hashText, hashHeaderText);
                    }


                    //找到控件则重命名
                    if (hashText.Contains(c.Name))
                    {
                        c.Text = (string)(hashText[c.Name]);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //从XML读取需要修改的语言内容
        private static Hashtable ReadXMLText(string formName, string xmlName)
        {
            try
            {
                Hashtable hashResult = new Hashtable();
                XmlReader reader = null;

                //判断是否存在该语言类型
                if (!(new System.IO.FileInfo("Language" + xmlName + ".xml").Exists))
                {
                    return null;
                }
                else
                {
                    reader = new XmlTextReader("Language" + xmlName + ".xml");
                }

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(reader);
                XmlNode root = xmlDoc.DocumentElement;
                XmlNodeList nodeList = root.SelectNodes(
                    "Form[Name='" + formName + "']/Controls/Control");

                foreach (XmlNode node in nodeList)
                {
                    try
                    {
                        XmlNode node1 = node.SelectSingleNode("@name");
                        XmlNode node2 = node.SelectSingleNode("@text");

                        if (node1 != null)
                        {
                            hashResult.Add(
                                node1.InnerText.ToLower(), node2.InnerText.ToLower());
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
                reader.Close();
                reader.Dispose();
                return hashResult;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //从XML读取需要修改的HeaderText的语言内容
        private static Hashtable ReadXMLHeaderText(string formName, string xmlName)
        {
            try
            {
                Hashtable hashResult = new Hashtable();
                XmlReader reader = null;

                //判断是否存在该语言类型
                if (!(new System.IO.FileInfo("Language" + xmlName + ".xml").Exists))
                {
                    return null;
                }
                else
                {
                    reader = new XmlTextReader("Language" + xmlName + ".xml");
                }

                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(reader);
                XmlNode root = xmlDoc.DocumentElement;
                XmlNodeList nodeList = root.SelectNodes(
                    "Form[Name='" + formName + "']/DataGridViewCells/DataGridViewCell");

                foreach (XmlNode node in nodeList)
                {
                    try
                    {
                        XmlNode node1 = node.SelectSingleNode("@name");
                        XmlNode node2 = node.SelectSingleNode("@HeaderText");

                        if (node1 != null)
                        {
                            hashResult.Add(
                                node1.InnerText.ToLower(), node2.InnerText.ToLower());
                        }
                    }
                    catch (Exception e)
                    {
                        throw new Exception(e.Message);
                    }
                }
                reader.Close();
                reader.Dispose();
                return hashResult;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        //获取并设置DataGridView的列头
        private static void GetSetHeaderCell(DataGridView dataGridView, Hashtable hashHeaderText)
        {
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (hashHeaderText.Contains(column.Name.ToLower()))
                {
                    column.HeaderText = (string)hashHeaderText[column.Name.ToLower()];
                }
            }
        }






    }
}
