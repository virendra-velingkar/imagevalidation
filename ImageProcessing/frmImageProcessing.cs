using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace ImageProcessing
{
    public partial class frmImageLoader : Form
    {
        private string _imagePath;
        private string _imageName;
        private int _imageWidth;
        private int _imageHeight;
        private string _imageSize;
        private int _WhitePix;
        private int _NonWhitePix;

        public frmImageLoader()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            btnLoadImage.Enabled = false;
            
            OpenFileDialog dlg = new OpenFileDialog();
            _WhitePix = 0;
            _NonWhitePix = 0;

            dlg.Title = "Open Image";
            dlg.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|"
       + "All Graphics Types|*.jpg;*.jpeg;*.png;";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _imagePath = dlg.FileName;
                imgSource.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();

            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Image_Source");
            dt.Rows.Add(new object []{_imagePath});
            GenerateSummary(dt, false);
            btnLoadImage.Enabled = true;
        }

        private void GenerateSummary(DataTable csvData, bool LoadFromURL)
        {
            int[] lst = { 250, 251, 252,253, 255, 254 };
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Image Name");
            dt.Columns.Add("Image Width");
            dt.Columns.Add("Image Height");
            dt.Columns.Add("Image Size");
            dt.Columns.Add("Image White Pix");
            dt.Columns.Add("Image NonWhite Pix");
            dt.Columns.Add("Product Coverage %");
            dt.Columns.Add("Status");

            for (int iCounter = 0; iCounter < csvData.Rows.Count; iCounter++)
            {
                _WhitePix = 0;
                _NonWhitePix = 0;
                string remoteFileName = csvData.Rows[iCounter][0].ToString();
                string[] parts = remoteFileName.Split('/');
                string localFileName = parts.Length > 0 ? parts[parts.Length - 1] : remoteFileName;
                lblFileUploadStatus.Text = "Processing File: " + (LoadFromURL ? localFileName : _imageName) + "(Started)";

                PictureBox pictureBox = new PictureBox();
                pictureBox.Load(LoadFromURL ? remoteFileName : _imagePath);

                WebClient webClient = new WebClient();
                string localImagePath = LoadFromURL ? Environment.CurrentDirectory + @"\" + localFileName : _imagePath;
                if (LoadFromURL)
                {
                    webClient.DownloadFile(remoteFileName, localFileName);
                }

                Bitmap img = new Bitmap(localFileName);
                Refresh();
                FileInfo file = new System.IO.FileInfo(localImagePath);

                for (int j = 0; j < img.Width; j++)
                {
                    for (int i = 0; i < img.Height; i++)
                    {
                        //if ((255 == img.GetPixel(j, i).R) && (255 == img.GetPixel(j, i).G) && (255 == img.GetPixel(j, i).B))
                        if ((lst.Contains(img.GetPixel(j, i).R)) && (lst.Contains(img.GetPixel(j, i).G)) && (lst.Contains(img.GetPixel(j, i).B)))
                        {
                            _WhitePix++;
                        }
                        else
                        {
                            _NonWhitePix++;
                        }
                    }
                    lblFileUploadStatus.Refresh();
                    lblFileUploadStatus.Text = "Processing File: " + (iCounter + 1) + @"/" + csvData.Rows.Count + " " + localFileName
                        + " " + Math.Round(((j) / (double)(img.Width) * 100), 2) + "%";
                }

                lblFileUploadStatus.Text = "Processing File: " + localFileName + "(Done)";
                _imageName = localFileName;
                _imageHeight = img.Height;
                _imageWidth = img.Width;
                _imageSize = Math.Round(file.Length / 1024.0 / 1024.0, 2) + "MB";
                img.Dispose();

                decimal productCoveragePercent = (Math.Round((decimal)_NonWhitePix / (_WhitePix + _NonWhitePix) * 100, 2));

                object[] o = { localFileName, _imageWidth, _imageHeight, _imageSize, _WhitePix, _NonWhitePix, productCoveragePercent + "%", Convert.ToInt32(productCoveragePercent) > 60 ? "Success" : "Failed" };
                dt.Rows.Add(o);
                Update_GridView(dt);
                if(LoadFromURL)
                File.Delete(file.FullName);
            }
        }

        private void btnUploadFromCSV_Click(object sender, EventArgs e)
        {
            imgSource.Image = null;
            btnUploadFromCSV.Enabled = false;
            DataTable csvData = GetDataTabletFromCsvFile("image_urls.csv");
            
            GenerateSummary(csvData,true);

            lblFileUploadStatus.Refresh();
            lblFileUploadStatus.Text = "Processing Files: Complete. ";
            btnUploadFromCSV.Enabled = true;
        }

        private void Update_GridView(DataTable dt)
        {
            grdVwImageSummary.DataSource = dt;
            grdVwImageSummary.Refresh();
        }


        private static DataTable GetDataTabletFromCsvFile(string path)
        {
            DataTable csvData = new DataTable();

            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(path))
                {
                    csvReader.SetDelimiters(new[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();

                    foreach (string column in colFields)
                    {
                        DataColumn serialno = new DataColumn(column);
                        serialno.AllowDBNull = true;
                        csvData.Columns.Add(serialno);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        DataRow dr = csvData.NewRow();
                        //Making empty value as empty
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == null)
                                fieldData[i] = string.Empty;

                            dr[i] = fieldData[i];
                        }
                        csvData.Rows.Add(dr);
                    }

                }
            }
            catch (Exception ex)
            {
            }
            return csvData;
        }

        private void grdVwImageSummary_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (grdVwImageSummary.Rows[e.RowIndex].Cells[7].Value.ToString() == "Failed") 
            {
                grdVwImageSummary.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
