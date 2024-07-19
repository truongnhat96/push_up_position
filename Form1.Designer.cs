using System.Media;

namespace push_up_position
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputname = new System.Windows.Forms.TextBox();
            this.chkMusic = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.btnChongday = new System.Windows.Forms.Button();
            this.lblOutputname = new System.Windows.Forms.Label();
            this.lblKetqua = new System.Windows.Forms.Label();
            this.picDown = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên của bạn:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInputname
            // 
            this.txtInputname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputname.Location = new System.Drawing.Point(188, 24);
            this.txtInputname.Name = "txtInputname";
            this.txtInputname.Size = new System.Drawing.Size(340, 28);
            this.txtInputname.TabIndex = 1;
            this.txtInputname.TextChanged += new System.EventHandler(this.txtInputname_TextChanged);
            // 
            // chkMusic
            // 
            this.chkMusic.AutoSize = true;
            this.chkMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMusic.Location = new System.Drawing.Point(682, 23);
            this.chkMusic.Name = "chkMusic";
            this.chkMusic.Size = new System.Drawing.Size(81, 24);
            this.chkMusic.TabIndex = 2;
            this.chkMusic.Text = "Music";
            this.chkMusic.UseVisualStyleBackColor = true;
            this.chkMusic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.linkLabel1.Location = new System.Drawing.Point(0, 543);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(376, 28);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Copyright by Luong Nhat Truong";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // picUp
            // 
            this.picUp.Image = ((System.Drawing.Image)(resources.GetObject("picUp.Image")));
            this.picUp.Location = new System.Drawing.Point(67, 74);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(631, 309);
            this.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUp.TabIndex = 4;
            this.picUp.TabStop = false;
            // 
            // btnChongday
            // 
            this.btnChongday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnChongday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChongday.ForeColor = System.Drawing.Color.MistyRose;
            this.btnChongday.Location = new System.Drawing.Point(310, 401);
            this.btnChongday.Name = "btnChongday";
            this.btnChongday.Size = new System.Drawing.Size(161, 47);
            this.btnChongday.TabIndex = 5;
            this.btnChongday.Text = "Push-Up";
            this.btnChongday.UseVisualStyleBackColor = false;
            this.btnChongday.Click += new System.EventHandler(this.btnChongday_Click);
            // 
            // lblOutputname
            // 
            this.lblOutputname.BackColor = System.Drawing.Color.LightYellow;
            this.lblOutputname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputname.ForeColor = System.Drawing.Color.Red;
            this.lblOutputname.Location = new System.Drawing.Point(12, 474);
            this.lblOutputname.Name = "lblOutputname";
            this.lblOutputname.Size = new System.Drawing.Size(354, 47);
            this.lblOutputname.TabIndex = 6;
            this.lblOutputname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutputname.Click += new System.EventHandler(this.lblOutputname_Click);
            // 
            // lblKetqua
            // 
            this.lblKetqua.BackColor = System.Drawing.Color.LightGray;
            this.lblKetqua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetqua.ForeColor = System.Drawing.Color.Blue;
            this.lblKetqua.Location = new System.Drawing.Point(642, 483);
            this.lblKetqua.Name = "lblKetqua";
            this.lblKetqua.Size = new System.Drawing.Size(175, 57);
            this.lblKetqua.TabIndex = 7;
            this.lblKetqua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picDown
            // 
            this.picDown.Image = ((System.Drawing.Image)(resources.GetObject("picDown.Image")));
            this.picDown.Location = new System.Drawing.Point(67, 74);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(631, 309);
            this.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDown.TabIndex = 4;
            this.picDown.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(829, 566);
            this.Controls.Add(this.lblKetqua);
            this.Controls.Add(this.lblOutputname);
            this.Controls.Add(this.btnChongday);
            this.Controls.Add(this.picDown);
            this.Controls.Add(this.picUp);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.chkMusic);
            this.Controls.Add(this.txtInputname);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tập thể thao";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputname;
        private System.Windows.Forms.CheckBox chkMusic;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.Button btnChongday;
        private System.Windows.Forms.Label lblOutputname;
        private System.Windows.Forms.Label lblKetqua;
        private System.Windows.Forms.PictureBox picDown;
        private SoundPlayer music;
    }
}

