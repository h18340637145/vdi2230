using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.IO;
using devDept.Eyeshot;
using WindowsFormsApp1;

namespace WindowsFormsApp1.report
{
    public class ReportOperation
    {
        public static HashSet<string> dynamicAnalysisProcess = new HashSet<string>();
        public static Dictionary<string, List<string>> reportTableList = new Dictionary<string, List<string>>();

        private static void addHtmlCatalog(string catalogName, ref int index, ref List<string> templateContent)
        {
            if (dynamicAnalysisProcess.Contains(catalogName))
            {
                index++;
                string templateData = @"<ul><li><a href='#" + index + "' class='Link'>" + catalogName + "</a></ul>";
                templateContent.Add(templateData + "\r\n");
            }
        }

        public static void generateReport(string savePath, ValidateDesignForm fMain)
        {
            ComputeResult rs = fMain.rs;

            //ViewportLayout vp = fMain.vp2d;

            string picPath = Application.StartupPath + @"\report\pictures\";
            StreamReader reader = new StreamReader(Application.StartupPath + @"\report\baseTemplate\base.html", Encoding.UTF8);
            string templateData = "";
            List<string> templateContent = new List<string>();
            while ((templateData = reader.ReadLine()) != null)
                templateContent.Add(templateData + "\r\n");

            templateContent.Add("<body>" + "\r\n");
            templateContent.Add("<div class='divMain'>" + "\r\n");
            templateContent.Add("<h1><a name='0'>VDI2230螺栓连接结构计算报告</a></h1>" + "\r\n");
            templateContent.Add("<table class='Details' Width='400' align='center' border='1' cellpadding='0' cellspacing='0'>" + "\r\n");
            templateContent.Add("<tbody>" + "\r\n");
            templateContent.Add("<tr><th width='200' class='ItemName'>保存时间</th><td>" + DateTime.Now.ToString() + "</td></tr>" + "\r\n");
            templateContent.Add("</tbody>" + "\r\n");
            templateContent.Add("</table>" + "\r\n");

            #region 目录
            templateContent.Add("<h2>目录</h2>" + "\r\n");
            templateContent.Add("</div>" + "\r\n");
            templateContent.Add("<div id='TableOfContents'>" + "\r\n");
            templateContent.Add("<ul><li><a href='#1' class='Link'>螺栓模型</a></ul>" + "\r\n");

            int index = 1;
            addHtmlCatalog("拧紧系数", ref index, ref templateContent);
            addHtmlCatalog("最小夹紧力", ref index, ref templateContent);
            addHtmlCatalog("回弹量", ref index, ref templateContent);
            addHtmlCatalog("嵌入损失载荷", ref index, ref templateContent);
            addHtmlCatalog("最小预紧力", ref index, ref templateContent);
            addHtmlCatalog("最大预紧力", ref index, ref templateContent);
            addHtmlCatalog("许用预紧力", ref index, ref templateContent);
            addHtmlCatalog("屈服安全", ref index, ref templateContent);
            addHtmlCatalog("疲劳安全", ref index, ref templateContent);
            addHtmlCatalog("表面压力安全", ref index, ref templateContent);
            addHtmlCatalog("啮合长度", ref index, ref templateContent);
            addHtmlCatalog("滑动安全", ref index, ref templateContent);
            addHtmlCatalog("拧紧力矩", ref index, ref templateContent);

            templateContent.Add("</div>" + "\r\n");
            templateContent.Add("<div id='Body'>" + "\r\n");
            #endregion

            #region 螺栓
            templateContent.Add("<h3><a name='1'>螺栓模型</a></h3>" + "\r\n");
            templateContent.Add("<p class='Caption'>螺栓参数</a></p>" + "\r\n");
            templateContent.Add("<table align='center' class='Details' border='1' cellpadding='0' cellspacing='0'>" + "\r\n");
            templateContent.Add("<tbody>\n");
            templateContent.Add("<tr><th width='150'>公称直径</th><th width='150'>螺距(mm)</th><th width='150'>ls()</th><th width='150'>dh(mm)</th><th width='150'>dt()</th>" +
                "<th width='150'>dw</th><th width='150'>da(mm)</th><th width='150'>d2()</th>" +
                "<th width='150'>d3</th><th width='150'>l1(mm)</th><th width='150'>l2()</th>" +
                "<th width='150'>s</th><th width='150'>D1(mm)</th>" +
                "</tr>\n");

            BoltClass bolt = fMain.bolt;
            {
                string res = "<tr>";
                foreach (var f in bolt.GetType().GetProperties())
                {
                    var propName = f.Name;
                    if (propName == "boltMaterial")
                    {
                        continue;
                    }
                    res += "<td>" + f.GetValue(bolt).ToString() + "</td>";
                }
                templateContent.Add(res += "</tr>");
            }
            templateContent.Add("</tbody>" + "\r\n");
            templateContent.Add("</table>" + "\r\n");

            StringBuilder builder = new StringBuilder();

            #endregion
            
            #region 材料
            templateContent.Add("<p class='Caption'>材料参数</a></p>" + "\r\n");
            templateContent.Add("<table align='center' class='Details' border='1' cellpadding='0' cellspacing='0'>" + "\r\n");
            templateContent.Add("<tbody>\n");
            templateContent.Add("<tr><th width='150'>强度等级</th><th width='150'>泊松比</th><th width='150'>弹性模量</th>" +
                "<th width='150'>屈服强度</th><th width='150'>抗拉强度</th><th width='150'>热膨胀系数</th>" +
                "<th width='150'>温度</th></tr>\n");
            BoltMaterialClass boltMaterial = fMain.bolt.boltMaterial;
            {
                string res = "<tr>";
                foreach (var f in boltMaterial.GetType().GetProperties())
                {
                    var propName = f.Name;
                    //if (propName == "boltMaterial")
                    //{
                    //    continue;
                    //}
                    res += "<td>" + f.GetValue(boltMaterial).ToString() + "</td>";
                }
                templateContent.Add(res += "</tr>");
            }
            templateContent.Add("</tbody>" + "\r\n");
            templateContent.Add("</table>" + "\r\n");
            #endregion

            templateContent.Add("<h4> R1拧紧系数计算 </h4> \r\n");
            templateContent.Add("\\(" +
                "\\alpha_A = "+
                "\\)" + rs.alphaA + "\r\n");

            templateContent.Add("<h4 R2 最小夹紧力计算 </h4>" + "\r\n");
            templateContent.Add("\\(" +
                "F_{Kerf} \\geq max(F_{KQ},F_{KP}+F_{FA}=)" +
                "\\)" + fMain.solution.r2.f_kerf + "\r\n");
            templateContent.Add("<h4 R3回弹量及载荷系数计算 /> " + "\r\n");
            
            templateContent.Add("\\(" +
                "\\sigma_{p} =" +
                "\\)" + fMain.solution.r3.deltaP + "\r\n");
            templateContent.Add("\\(" +
                "\\sigma_{s} =  \\sigma_{sk} + \\sigma_{1} + \\sigma_{2} + \\sigma_{Gew} + \\sigma_{GM}=" +
                "\\)" + fMain.solution.r3.deltaS + "</br>");

            string fileName = savePath.Split('\\').Last();
            string directoryPath = savePath.Replace(".html", "");
            if (Directory.Exists(directoryPath))
                Directory.Delete(directoryPath, true);

            Directory.CreateDirectory(directoryPath);
            Directory.CreateDirectory(directoryPath + "\\pictures");

            StreamWriter writer = new StreamWriter(directoryPath + "\\" + fileName, false, Encoding.UTF8);
            foreach (string i in templateContent)
                writer.WriteLine(i);
            writer.Close();

            MessageBox.Show("保存成功");
        }

        private static void addTable(List<string> contentList, string key)
        {
            if (reportTableList.ContainsKey(key))
                contentList.AddRange(reportTableList[key]);
        }

        private static void addPicture(List<string> contentList, string keyword, string[] files)
        {
            foreach (var file in files)
            {
                if (file.Contains(keyword))
                {
                    contentList.Add("<center>\n");
                    string src = "pictures\\" + file.Split('\\').Last();
                    contentList.Add("<img src='" + src + "' width='930' height='340' />\n");
                    contentList.Add("</p>\n");
                }
            }

        }

        private string ToBase64(Image image, ImageFormat format)
        {
            using (var ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void convertHtmlToMht(string htmlPath, string mhtPath)
        {
        }

        public static void ClearReportPics()
        {
            try
            {
                string path = Application.StartupPath + @"\report\pictures";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                string[] picFiles = Directory.GetFiles(path);
                foreach (var picName in picFiles)
                    File.Delete(picName);

            }
            catch (Exception)
            {
            }
        }
    }
}
