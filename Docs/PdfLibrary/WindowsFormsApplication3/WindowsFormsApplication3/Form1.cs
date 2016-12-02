using Spire.Pdf;
using Spire.Pdf.General.Find;
using Spire.Pdf.Graphics;
using Spire.Pdf.Grid;
using System;
using System.Drawing;
using System.Threading;

using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string outputFile = "output.pdf";
            //新建一个PDF文档
            PdfDocument doc = new PdfDocument();
            //添加页面
            PdfPageBase page = doc.Pages.Add();
            //创建PDF网格
            PdfGrid grid = new PdfGrid();
            //设置单元格边框与填充内容的间距
            grid.Style.CellPadding = new PdfPaddings(1, 1, 1, 1);
            //添加行
            PdfGridRow row = grid.Rows.Add();
            //添加列
            grid.Columns.Add(2);
            float width = page.Canvas.ClientSize.Width - (grid.Columns.Count + 1);
            //设置列宽
            grid.Columns[0].Width = width * 0.1f;
            grid.Columns[1].Width = width * 0.1f;
            //加载图片
            PdfGridCellTextAndStyleList lst = new PdfGridCellTextAndStyleList();
            PdfGridCellTextAndStyle textAndStyle = new PdfGridCellTextAndStyle();
            textAndStyle.Image = PdfImage.FromFile(@"C:\Users\mingli\Desktop\untitled.png");
            //设置图片大小
            textAndStyle.ImageSize = new SizeF(50, 50);
            lst.List.Add(textAndStyle);
            //在第一个单元格添加图片
            row.Cells[0].Value = lst;
            //在页面特定位置绘制PDF网格
            PdfLayoutResult result = grid.Draw(page, new PointF(10, 30));
            //保存并运行PDF文件
            doc.SaveToFile(outputFile, FileFormat.PDF);
            System.Diagnostics.Process.Start(outputFile);
        }

        private void btnSaveToPdf_Click(object sender, EventArgs e)
        {

                //Create a pdf document.
                PdfDocument doc = new PdfDocument();
            String url = this.txbPdfUrl.Text;
            if (!string.IsNullOrEmpty(url))
            {
                Thread thread = new Thread(() =>
                { doc.LoadFromHTML(url, false, true, true); });
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                thread.Join();
                //Save pdf file.
                doc.SaveToFile("sample.pdf");
                doc.Close();
                //Launching the Pdf file.
                System.Diagnostics.Process.Start("sample.pdf");
            }else
            {
                MessageBox.Show("no url");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            PdfDocument doc = new PdfDocument();
            doc.LoadFromFile(@"C:\Users\mingli\Desktop\AAA.pdf");
            PdfTextFind[] results = null;
            foreach (PdfPageBase page in doc.Pages)
            {
                results = page.FindText("AAA").Finds;
                foreach (PdfTextFind text in results)
                {
                    PointF p = text.Position;
                    Image bm = Bitmap.FromFile(@"C:\Users\mingli\Desktop\untitled.png");
                    Bitmap bm2 = new Bitmap(bm, new Size(30,30));

                    PdfImage img = PdfImage.FromImage(bm2 as Image);   // PdfImage.FromFile(@"C:\Users\mingli\Desktop\untitled.png");
                    //img.Width = 30; 
                   // img.Height = 130;

                    page.Canvas.DrawImage(img, new PointF(p.X, p.Y + 30));

                    //Console.WriteLine(p);
                    this.txbPosition.AppendText(p.ToString() + "\r\n");
                }
            }

            doc.SaveToFile("AAACopy.pdf");
            System.Diagnostics.Process.Start("AAACopy.pdf");
        }
    }
}
