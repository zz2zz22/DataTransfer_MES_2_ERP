﻿
namespace MESdbToERPdb
{
    partial class mes2ERPMainWin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mes2ERPMainWin));
            this.panel_Controller = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb_fMailPass = new System.Windows.Forms.TextBox();
            this.btn_FixMail = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lb_logText = new System.Windows.Forms.Label();
            this.panel_LogText = new System.Windows.Forms.Panel();
            this.btn_errorForm = new System.Windows.Forms.Button();
            this.btn_settingForm = new System.Windows.Forms.Button();
            this.lb_progress_percentage = new System.Windows.Forms.Label();
            this.pic_title = new System.Windows.Forms.PictureBox();
            this.BW = new System.ComponentModel.BackgroundWorker();
            this.timer_nextRun = new System.Windows.Forms.Timer(this.components);
            this.BW_D1 = new System.ComponentModel.BackgroundWorker();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.richTextBoxLog1 = new MESdbToERPdb.RichTextBoxLog();
            this.panel_Controller.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel_LogText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Controller
            // 
            this.panel_Controller.Controls.Add(this.groupBox1);
            this.panel_Controller.Controls.Add(this.pic_logo);
            this.panel_Controller.Location = new System.Drawing.Point(12, 12);
            this.panel_Controller.Name = "panel_Controller";
            this.panel_Controller.Size = new System.Drawing.Size(421, 649);
            this.panel_Controller.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_fMailPass);
            this.groupBox1.Controls.Add(this.btn_FixMail);
            this.groupBox1.Controls.Add(this.btn_start);
            this.groupBox1.Controls.Add(this.btn_stop);
            this.groupBox1.Location = new System.Drawing.Point(3, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 541);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txb_fMailPass
            // 
            this.txb_fMailPass.Location = new System.Drawing.Point(241, 512);
            this.txb_fMailPass.Name = "txb_fMailPass";
            this.txb_fMailPass.Size = new System.Drawing.Size(100, 22);
            this.txb_fMailPass.TabIndex = 7;
            // 
            // btn_FixMail
            // 
            this.btn_FixMail.BackColor = System.Drawing.Color.Red;
            this.btn_FixMail.Location = new System.Drawing.Point(347, 512);
            this.btn_FixMail.Name = "btn_FixMail";
            this.btn_FixMail.Size = new System.Drawing.Size(62, 23);
            this.btn_FixMail.TabIndex = 6;
            this.btn_FixMail.Text = "FMail";
            this.btn_FixMail.UseVisualStyleBackColor = false;
            this.btn_FixMail.Click += new System.EventHandler(this.btn_FixMail_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(76, 35);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(245, 90);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(76, 147);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(245, 90);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // pic_logo
            // 
            this.pic_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pic_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(0, 0);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(421, 99);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logo.TabIndex = 3;
            this.pic_logo.TabStop = false;
            // 
            // lb_logText
            // 
            this.lb_logText.AutoSize = true;
            this.lb_logText.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logText.Location = new System.Drawing.Point(3, 105);
            this.lb_logText.Name = "lb_logText";
            this.lb_logText.Size = new System.Drawing.Size(112, 21);
            this.lb_logText.TabIndex = 4;
            this.lb_logText.Text = "Log output : ";
            // 
            // panel_LogText
            // 
            this.panel_LogText.Controls.Add(this.btn_errorForm);
            this.panel_LogText.Controls.Add(this.btn_settingForm);
            this.panel_LogText.Controls.Add(this.lb_logText);
            this.panel_LogText.Controls.Add(this.elementHost1);
            this.panel_LogText.Controls.Add(this.lb_progress_percentage);
            this.panel_LogText.Controls.Add(this.pic_title);
            this.panel_LogText.Location = new System.Drawing.Point(439, 12);
            this.panel_LogText.Name = "panel_LogText";
            this.panel_LogText.Size = new System.Drawing.Size(811, 649);
            this.panel_LogText.TabIndex = 1;
            // 
            // btn_errorForm
            // 
            this.btn_errorForm.BackColor = System.Drawing.Color.White;
            this.btn_errorForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_errorForm.BackgroundImage")));
            this.btn_errorForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_errorForm.FlatAppearance.BorderSize = 0;
            this.btn_errorForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_errorForm.Location = new System.Drawing.Point(649, 19);
            this.btn_errorForm.Name = "btn_errorForm";
            this.btn_errorForm.Size = new System.Drawing.Size(59, 60);
            this.btn_errorForm.TabIndex = 9;
            this.btn_errorForm.UseVisualStyleBackColor = false;
            this.btn_errorForm.Visible = false;
            this.btn_errorForm.Click += new System.EventHandler(this.btn_errorForm_Click);
            // 
            // btn_settingForm
            // 
            this.btn_settingForm.BackColor = System.Drawing.Color.White;
            this.btn_settingForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settingForm.BackgroundImage")));
            this.btn_settingForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settingForm.FlatAppearance.BorderSize = 0;
            this.btn_settingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settingForm.Location = new System.Drawing.Point(734, 19);
            this.btn_settingForm.Name = "btn_settingForm";
            this.btn_settingForm.Size = new System.Drawing.Size(60, 60);
            this.btn_settingForm.TabIndex = 8;
            this.btn_settingForm.UseVisualStyleBackColor = false;
            this.btn_settingForm.Click += new System.EventHandler(this.btn_settingForm_Click);
            // 
            // lb_progress_percentage
            // 
            this.lb_progress_percentage.AutoSize = true;
            this.lb_progress_percentage.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_progress_percentage.Location = new System.Drawing.Point(70, 584);
            this.lb_progress_percentage.Name = "lb_progress_percentage";
            this.lb_progress_percentage.Size = new System.Drawing.Size(0, 23);
            this.lb_progress_percentage.TabIndex = 6;
            // 
            // pic_title
            // 
            this.pic_title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_title.BackgroundImage")));
            this.pic_title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_title.Location = new System.Drawing.Point(0, 0);
            this.pic_title.Name = "pic_title";
            this.pic_title.Size = new System.Drawing.Size(811, 99);
            this.pic_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_title.TabIndex = 0;
            this.pic_title.TabStop = false;
            // 
            // BW
            // 
            this.BW.WorkerReportsProgress = true;
            this.BW.WorkerSupportsCancellation = true;
            this.BW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_DoWork);
            this.BW.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_ProgressChanged);
            this.BW.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_RunWorkerCompleted);
            // 
            // timer_nextRun
            // 
            this.timer_nextRun.Interval = 1000;
            this.timer_nextRun.Tick += new System.EventHandler(this.timer_nextRun_Tick);
            // 
            // BW_D1
            // 
            this.BW_D1.WorkerReportsProgress = true;
            this.BW_D1.WorkerSupportsCancellation = true;
            this.BW_D1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BW_D1_DoWork);
            this.BW_D1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BW_D1_ProgressChanged);
            this.BW_D1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BW_D1_RunWorkerCompleted);
            // 
            // elementHost1
            // 
            this.elementHost1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elementHost1.Location = new System.Drawing.Point(3, 140);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(805, 506);
            this.elementHost1.TabIndex = 7;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.richTextBoxLog1;
            // 
            // mes2ERPMainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel_LogText);
            this.Controls.Add(this.panel_Controller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mes2ERPMainWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MES database to ERP database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mes2ERPMainWin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mes2ERPMainWin_FormClosed);
            this.Load += new System.EventHandler(this.mes2ERPMainWin_Load);
            this.panel_Controller.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel_LogText.ResumeLayout(false);
            this.panel_LogText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_title)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Controller;
        private System.Windows.Forms.Panel panel_LogText;
        private System.Windows.Forms.PictureBox pic_title;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lb_logText;
        private System.Windows.Forms.Label lb_progress_percentage;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.ComponentModel.BackgroundWorker BW;
        private System.Windows.Forms.Timer timer_nextRun;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Button btn_settingForm;
        private RichTextBoxLog richTextBoxLog1;
        private System.Windows.Forms.Button btn_errorForm;
        private System.ComponentModel.BackgroundWorker BW_D1;
        private System.Windows.Forms.TextBox txb_fMailPass;
        private System.Windows.Forms.Button btn_FixMail;
    }
}

