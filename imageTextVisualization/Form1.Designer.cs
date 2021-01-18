
namespace imageTextVisualization
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.translate = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.index = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.sel_img = new System.Windows.Forms.Button();
            this.sel_txt = new System.Windows.Forms.Button();
            this.tb_sel_img = new System.Windows.Forms.TextBox();
            this.tb_sel_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.original = new System.Windows.Forms.TextBox();
            this.index_label = new System.Windows.Forms.Label();
            this.copy_original = new System.Windows.Forms.Button();
            this.paste_translate = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(568, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(586, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ข้อความเดิม";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(585, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "ข้อความแปล";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // translate
            // 
            this.translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translate.Location = new System.Drawing.Point(586, 193);
            this.translate.Multiline = true;
            this.translate.Name = "translate";
            this.translate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.translate.Size = new System.Drawing.Size(469, 63);
            this.translate.TabIndex = 4;
            this.translate.Text = "a test text for shsdgdsgsdgdsgsdgdsgdgdsgs gsdgsdgsd gdssgsdg gdsgsdgsow adfhdfhd" +
    "fhdfhdfhdffhdfhdha aha test test blabla hello world hahasafasa safasfsaf afsf";
            this.translate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(586, 316);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(191, 39);
            this.back.TabIndex = 7;
            this.back.Text = "ย้อนกลับ";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // index
            // 
            this.index.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.index.Location = new System.Drawing.Point(783, 316);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(138, 26);
            this.index.TabIndex = 9;
            this.index.Text = "99999";
            this.index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.index.KeyDown += new System.Windows.Forms.KeyEventHandler(this.index_KeyDown);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(927, 316);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(191, 39);
            this.next.TabIndex = 10;
            this.next.Text = "ถัดไป";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // sel_img
            // 
            this.sel_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_img.Location = new System.Drawing.Point(586, 372);
            this.sel_img.Name = "sel_img";
            this.sel_img.Size = new System.Drawing.Size(121, 39);
            this.sel_img.TabIndex = 11;
            this.sel_img.Text = "เลือก";
            this.sel_img.UseVisualStyleBackColor = true;
            this.sel_img.Click += new System.EventHandler(this.sel_img_Click);
            // 
            // sel_txt
            // 
            this.sel_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_txt.Location = new System.Drawing.Point(586, 417);
            this.sel_txt.Name = "sel_txt";
            this.sel_txt.Size = new System.Drawing.Size(121, 39);
            this.sel_txt.TabIndex = 12;
            this.sel_txt.Text = "เลือก";
            this.sel_txt.UseVisualStyleBackColor = true;
            this.sel_txt.Click += new System.EventHandler(this.sel_txt_Click);
            // 
            // tb_sel_img
            // 
            this.tb_sel_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sel_img.Location = new System.Drawing.Point(713, 372);
            this.tb_sel_img.Multiline = true;
            this.tb_sel_img.Name = "tb_sel_img";
            this.tb_sel_img.ReadOnly = true;
            this.tb_sel_img.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_sel_img.Size = new System.Drawing.Size(405, 39);
            this.tb_sel_img.TabIndex = 13;
            this.tb_sel_img.Text = "เลือก Folder ที่เก็บรูป";
            this.tb_sel_img.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_sel_txt
            // 
            this.tb_sel_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sel_txt.Location = new System.Drawing.Point(713, 417);
            this.tb_sel_txt.Multiline = true;
            this.tb_sel_txt.Name = "tb_sel_txt";
            this.tb_sel_txt.ReadOnly = true;
            this.tb_sel_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_sel_txt.Size = new System.Drawing.Size(405, 39);
            this.tb_sel_txt.TabIndex = 14;
            this.tb_sel_txt.Text = "เลือกไฟล์ List ข้อความ";
            this.tb_sel_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1106, 45);
            this.label3.TabIndex = 15;
            this.label3.Text = "แปลภาษา V0.01";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(586, 271);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(532, 39);
            this.save.TabIndex = 16;
            this.save.Text = "บันทึก";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // original
            // 
            this.original.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.original.Location = new System.Drawing.Point(586, 95);
            this.original.Multiline = true;
            this.original.Name = "original";
            this.original.ReadOnly = true;
            this.original.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.original.Size = new System.Drawing.Size(469, 63);
            this.original.TabIndex = 17;
            this.original.Text = "a test text for shsdgdsgsdgdsgsdgdsgdgdsgs gsdgsdgsd gdssgsdg gdsgsdgsow adfhdfhd" +
    "fhdfhdfhdffhdfhdha aha test test blabla hello world hahasafasa safasfsaf afsf";
            this.original.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // index_label
            // 
            this.index_label.Location = new System.Drawing.Point(783, 345);
            this.index_label.Name = "index_label";
            this.index_label.Size = new System.Drawing.Size(138, 22);
            this.index_label.TabIndex = 18;
            this.index_label.Text = "Total : ???";
            this.index_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // copy_original
            // 
            this.copy_original.Location = new System.Drawing.Point(1063, 96);
            this.copy_original.Name = "copy_original";
            this.copy_original.Size = new System.Drawing.Size(55, 62);
            this.copy_original.TabIndex = 19;
            this.copy_original.Text = "COPY";
            this.copy_original.UseVisualStyleBackColor = true;
            this.copy_original.Click += new System.EventHandler(this.copy_original_Click);
            // 
            // paste_translate
            // 
            this.paste_translate.Location = new System.Drawing.Point(1063, 194);
            this.paste_translate.Name = "paste_translate";
            this.paste_translate.Size = new System.Drawing.Size(55, 62);
            this.paste_translate.TabIndex = 20;
            this.paste_translate.Text = "PASTE";
            this.paste_translate.UseVisualStyleBackColor = true;
            this.paste_translate.Click += new System.EventHandler(this.paste_translate_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 462);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1104, 409);
            this.webBrowser1.TabIndex = 21;
            this.webBrowser1.Url = new System.Uri("https://translate.google.com/?sl=en&tl=th&op=translate&hl=th", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 883);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.paste_translate);
            this.Controls.Add(this.copy_original);
            this.Controls.Add(this.index_label);
            this.Controls.Add(this.original);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_sel_txt);
            this.Controls.Add(this.tb_sel_img);
            this.Controls.Add(this.sel_txt);
            this.Controls.Add(this.sel_img);
            this.Controls.Add(this.next);
            this.Controls.Add(this.index);
            this.Controls.Add(this.back);
            this.Controls.Add(this.translate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "แปลภาษา V0.01";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox translate;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox index;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button sel_img;
        private System.Windows.Forms.Button sel_txt;
        private System.Windows.Forms.TextBox tb_sel_img;
        private System.Windows.Forms.TextBox tb_sel_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox original;
        private System.Windows.Forms.Label index_label;
        private System.Windows.Forms.Button copy_original;
        private System.Windows.Forms.Button paste_translate;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

