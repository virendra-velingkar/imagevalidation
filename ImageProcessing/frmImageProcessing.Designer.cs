namespace ImageProcessing
{
    partial class frmImageLoader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.grpBoxImagePreview = new System.Windows.Forms.GroupBox();
            this.imgSource = new System.Windows.Forms.PictureBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblProductStatus = new System.Windows.Forms.Label();
            this.lblProductStatusLabel = new System.Windows.Forms.Label();
            this.lblProductCoveragePercent = new System.Windows.Forms.Label();
            this.lblProductCoveragePercentLabel = new System.Windows.Forms.Label();
            this.lblImageNonWhitePix = new System.Windows.Forms.Label();
            this.lblNonWhitePixLabel = new System.Windows.Forms.Label();
            this.lblImageWhitePix = new System.Windows.Forms.Label();
            this.lblImageWhitePixLabel = new System.Windows.Forms.Label();
            this.lblImageSize = new System.Windows.Forms.Label();
            this.lblImageHeight = new System.Windows.Forms.Label();
            this.lblImageWidth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImageHeightLabel = new System.Windows.Forms.Label();
            this.lblImageWidthLabel = new System.Windows.Forms.Label();
            this.lblImageName = new System.Windows.Forms.Label();
            this.lblImageNameLabel = new System.Windows.Forms.Label();
            this.btnUploadFromCSV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grdVwImageSummary = new System.Windows.Forms.DataGridView();
            this.lblFileUploadStatus = new System.Windows.Forms.Label();
            this.grpBoxImagePreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSource)).BeginInit();
            this.grpSummary.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwImageSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(236, 331);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(111, 23);
            this.btnLoadImage.TabIndex = 0;
            this.btnLoadImage.Text = "Browse Single File";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // grpBoxImagePreview
            // 
            this.grpBoxImagePreview.Controls.Add(this.imgSource);
            this.grpBoxImagePreview.Location = new System.Drawing.Point(12, 12);
            this.grpBoxImagePreview.Name = "grpBoxImagePreview";
            this.grpBoxImagePreview.Size = new System.Drawing.Size(214, 217);
            this.grpBoxImagePreview.TabIndex = 2;
            this.grpBoxImagePreview.TabStop = false;
            this.grpBoxImagePreview.Text = "Image Preview";
            // 
            // imgSource
            // 
            this.imgSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgSource.Location = new System.Drawing.Point(8, 19);
            this.imgSource.Name = "imgSource";
            this.imgSource.Size = new System.Drawing.Size(196, 188);
            this.imgSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSource.TabIndex = 3;
            this.imgSource.TabStop = false;
            // 
            // grpSummary
            // 
            this.grpSummary.Controls.Add(this.lblProductStatus);
            this.grpSummary.Controls.Add(this.lblProductStatusLabel);
            this.grpSummary.Controls.Add(this.lblProductCoveragePercent);
            this.grpSummary.Controls.Add(this.lblProductCoveragePercentLabel);
            this.grpSummary.Controls.Add(this.lblImageNonWhitePix);
            this.grpSummary.Controls.Add(this.lblNonWhitePixLabel);
            this.grpSummary.Controls.Add(this.lblImageWhitePix);
            this.grpSummary.Controls.Add(this.lblImageWhitePixLabel);
            this.grpSummary.Controls.Add(this.lblImageSize);
            this.grpSummary.Controls.Add(this.lblImageHeight);
            this.grpSummary.Controls.Add(this.lblImageWidth);
            this.grpSummary.Controls.Add(this.label1);
            this.grpSummary.Controls.Add(this.lblImageHeightLabel);
            this.grpSummary.Controls.Add(this.lblImageWidthLabel);
            this.grpSummary.Controls.Add(this.lblImageName);
            this.grpSummary.Controls.Add(this.lblImageNameLabel);
            this.grpSummary.Location = new System.Drawing.Point(375, 391);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(552, 298);
            this.grpSummary.TabIndex = 3;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Image Summary";
            // 
            // lblProductStatus
            // 
            this.lblProductStatus.AutoSize = true;
            this.lblProductStatus.Location = new System.Drawing.Point(138, 196);
            this.lblProductStatus.Name = "lblProductStatus";
            this.lblProductStatus.Size = new System.Drawing.Size(41, 13);
            this.lblProductStatus.TabIndex = 14;
            this.lblProductStatus.Text = "Demo1";
            // 
            // lblProductStatusLabel
            // 
            this.lblProductStatusLabel.AutoSize = true;
            this.lblProductStatusLabel.Location = new System.Drawing.Point(19, 196);
            this.lblProductStatusLabel.Name = "lblProductStatusLabel";
            this.lblProductStatusLabel.Size = new System.Drawing.Size(43, 13);
            this.lblProductStatusLabel.TabIndex = 13;
            this.lblProductStatusLabel.Text = "Status :";
            // 
            // lblProductCoveragePercent
            // 
            this.lblProductCoveragePercent.AutoSize = true;
            this.lblProductCoveragePercent.Location = new System.Drawing.Point(135, 172);
            this.lblProductCoveragePercent.Name = "lblProductCoveragePercent";
            this.lblProductCoveragePercent.Size = new System.Drawing.Size(41, 13);
            this.lblProductCoveragePercent.TabIndex = 12;
            this.lblProductCoveragePercent.Text = "Demo1";
            // 
            // lblProductCoveragePercentLabel
            // 
            this.lblProductCoveragePercentLabel.AutoSize = true;
            this.lblProductCoveragePercentLabel.Location = new System.Drawing.Point(19, 172);
            this.lblProductCoveragePercentLabel.Name = "lblProductCoveragePercentLabel";
            this.lblProductCoveragePercentLabel.Size = new System.Drawing.Size(107, 13);
            this.lblProductCoveragePercentLabel.TabIndex = 11;
            this.lblProductCoveragePercentLabel.Text = "Product Coverage %:";
            // 
            // lblImageNonWhitePix
            // 
            this.lblImageNonWhitePix.AutoSize = true;
            this.lblImageNonWhitePix.Location = new System.Drawing.Point(135, 148);
            this.lblImageNonWhitePix.Name = "lblImageNonWhitePix";
            this.lblImageNonWhitePix.Size = new System.Drawing.Size(41, 13);
            this.lblImageNonWhitePix.TabIndex = 10;
            this.lblImageNonWhitePix.Text = "Demo1";
            // 
            // lblNonWhitePixLabel
            // 
            this.lblNonWhitePixLabel.AutoSize = true;
            this.lblNonWhitePixLabel.Location = new System.Drawing.Point(19, 148);
            this.lblNonWhitePixLabel.Name = "lblNonWhitePixLabel";
            this.lblNonWhitePixLabel.Size = new System.Drawing.Size(110, 13);
            this.lblNonWhitePixLabel.TabIndex = 9;
            this.lblNonWhitePixLabel.Text = "Image Non White Pix:";
            // 
            // lblImageWhitePix
            // 
            this.lblImageWhitePix.AutoSize = true;
            this.lblImageWhitePix.Location = new System.Drawing.Point(112, 124);
            this.lblImageWhitePix.Name = "lblImageWhitePix";
            this.lblImageWhitePix.Size = new System.Drawing.Size(41, 13);
            this.lblImageWhitePix.TabIndex = 8;
            this.lblImageWhitePix.Text = "Demo1";
            // 
            // lblImageWhitePixLabel
            // 
            this.lblImageWhitePixLabel.AutoSize = true;
            this.lblImageWhitePixLabel.Location = new System.Drawing.Point(19, 124);
            this.lblImageWhitePixLabel.Name = "lblImageWhitePixLabel";
            this.lblImageWhitePixLabel.Size = new System.Drawing.Size(87, 13);
            this.lblImageWhitePixLabel.TabIndex = 7;
            this.lblImageWhitePixLabel.Text = "Image White Pix:";
            // 
            // lblImageSize
            // 
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Location = new System.Drawing.Point(98, 101);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(41, 13);
            this.lblImageSize.TabIndex = 6;
            this.lblImageSize.Text = "Demo1";
            // 
            // lblImageHeight
            // 
            this.lblImageHeight.AutoSize = true;
            this.lblImageHeight.Location = new System.Drawing.Point(98, 78);
            this.lblImageHeight.Name = "lblImageHeight";
            this.lblImageHeight.Size = new System.Drawing.Size(41, 13);
            this.lblImageHeight.TabIndex = 5;
            this.lblImageHeight.Text = "Demo1";
            // 
            // lblImageWidth
            // 
            this.lblImageWidth.AutoSize = true;
            this.lblImageWidth.Location = new System.Drawing.Point(98, 52);
            this.lblImageWidth.Name = "lblImageWidth";
            this.lblImageWidth.Size = new System.Drawing.Size(35, 13);
            this.lblImageWidth.TabIndex = 4;
            this.lblImageWidth.Text = "Demo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Size:";
            // 
            // lblImageHeightLabel
            // 
            this.lblImageHeightLabel.AutoSize = true;
            this.lblImageHeightLabel.Location = new System.Drawing.Point(19, 78);
            this.lblImageHeightLabel.Name = "lblImageHeightLabel";
            this.lblImageHeightLabel.Size = new System.Drawing.Size(76, 13);
            this.lblImageHeightLabel.TabIndex = 3;
            this.lblImageHeightLabel.Text = "Image Height :";
            // 
            // lblImageWidthLabel
            // 
            this.lblImageWidthLabel.AutoSize = true;
            this.lblImageWidthLabel.Location = new System.Drawing.Point(19, 52);
            this.lblImageWidthLabel.Name = "lblImageWidthLabel";
            this.lblImageWidthLabel.Size = new System.Drawing.Size(73, 13);
            this.lblImageWidthLabel.TabIndex = 2;
            this.lblImageWidthLabel.Text = "Image Width :";
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(98, 28);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(35, 13);
            this.lblImageName.TabIndex = 1;
            this.lblImageName.Text = "Demo";
            // 
            // lblImageNameLabel
            // 
            this.lblImageNameLabel.AutoSize = true;
            this.lblImageNameLabel.Location = new System.Drawing.Point(19, 28);
            this.lblImageNameLabel.Name = "lblImageNameLabel";
            this.lblImageNameLabel.Size = new System.Drawing.Size(73, 13);
            this.lblImageNameLabel.TabIndex = 0;
            this.lblImageNameLabel.Text = "Image Name :";
            // 
            // btnUploadFromCSV
            // 
            this.btnUploadFromCSV.Location = new System.Drawing.Point(12, 331);
            this.btnUploadFromCSV.Name = "btnUploadFromCSV";
            this.btnUploadFromCSV.Size = new System.Drawing.Size(113, 23);
            this.btnUploadFromCSV.TabIndex = 5;
            this.btnUploadFromCSV.Text = "Upload from CSV";
            this.btnUploadFromCSV.UseVisualStyleBackColor = true;
            this.btnUploadFromCSV.Click += new System.EventHandler(this.btnUploadFromCSV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grdVwImageSummary);
            this.groupBox1.Location = new System.Drawing.Point(236, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 298);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Summary";
            // 
            // grdVwImageSummary
            // 
            this.grdVwImageSummary.AllowUserToAddRows = false;
            this.grdVwImageSummary.AllowUserToDeleteRows = false;
            this.grdVwImageSummary.AllowUserToResizeRows = false;
            this.grdVwImageSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdVwImageSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVwImageSummary.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.grdVwImageSummary.Location = new System.Drawing.Point(10, 19);
            this.grdVwImageSummary.Name = "grdVwImageSummary";
            this.grdVwImageSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdVwImageSummary.Size = new System.Drawing.Size(671, 269);
            this.grdVwImageSummary.TabIndex = 7;
            this.grdVwImageSummary.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grdVwImageSummary_RowPrePaint);
            // 
            // lblFileUploadStatus
            // 
            this.lblFileUploadStatus.Location = new System.Drawing.Point(233, 313);
            this.lblFileUploadStatus.Name = "lblFileUploadStatus";
            this.lblFileUploadStatus.Size = new System.Drawing.Size(547, 15);
            this.lblFileUploadStatus.TabIndex = 7;
            this.lblFileUploadStatus.Text = "Processing Files: Idle.";
            // 
            // frmImageLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 368);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.lblFileUploadStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUploadFromCSV);
            this.Controls.Add(this.grpBoxImagePreview);
            this.Controls.Add(this.btnLoadImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmImageLoader";
            this.Text = "Image Processing";
            this.grpBoxImagePreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSource)).EndInit();
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVwImageSummary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.GroupBox grpBoxImagePreview;
        private System.Windows.Forms.PictureBox imgSource;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblImageNameLabel;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Label lblImageHeightLabel;
        private System.Windows.Forms.Label lblImageWidthLabel;
        private System.Windows.Forms.Label lblImageWidth;
        private System.Windows.Forms.Label lblImageHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.Label lblImageWhitePix;
        private System.Windows.Forms.Label lblImageWhitePixLabel;
        private System.Windows.Forms.Label lblImageNonWhitePix;
        private System.Windows.Forms.Label lblNonWhitePixLabel;
        private System.Windows.Forms.Label lblProductCoveragePercent;
        private System.Windows.Forms.Label lblProductCoveragePercentLabel;
        private System.Windows.Forms.Label lblProductStatus;
        private System.Windows.Forms.Label lblProductStatusLabel;
        private System.Windows.Forms.Button btnUploadFromCSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdVwImageSummary;
        private System.Windows.Forms.Label lblFileUploadStatus;
    }
}

