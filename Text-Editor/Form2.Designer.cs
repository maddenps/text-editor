namespace Text_Editor {
    partial class FontForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.setFontButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontSizeBox = new System.Windows.Forms.TextBox();
            this.fontStyleBox = new System.Windows.Forms.TextBox();
            this.fontNameBox = new System.Windows.Forms.TextBox();
            this.fonNametList = new System.Windows.Forms.ListBox();
            this.fontStyleList = new System.Windows.Forms.ListBox();
            this.fontSizeList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fontLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setFontButton
            // 
            this.setFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setFontButton.Location = new System.Drawing.Point(256, 197);
            this.setFontButton.Name = "setFontButton";
            this.setFontButton.Size = new System.Drawing.Size(78, 31);
            this.setFontButton.TabIndex = 0;
            this.setFontButton.Text = "Apply";
            this.setFontButton.UseVisualStyleBackColor = true;
            this.setFontButton.Click += new System.EventHandler(this.setFontButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Font Style:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Size:";
            // 
            // fontSizeBox
            // 
            this.fontSizeBox.Location = new System.Drawing.Point(302, 43);
            this.fontSizeBox.Name = "fontSizeBox";
            this.fontSizeBox.Size = new System.Drawing.Size(56, 20);
            this.fontSizeBox.TabIndex = 4;
            // 
            // fontStyleBox
            // 
            this.fontStyleBox.Location = new System.Drawing.Point(182, 43);
            this.fontStyleBox.Name = "fontStyleBox";
            this.fontStyleBox.Size = new System.Drawing.Size(98, 20);
            this.fontStyleBox.TabIndex = 5;
            // 
            // fontNameBox
            // 
            this.fontNameBox.Location = new System.Drawing.Point(16, 43);
            this.fontNameBox.Name = "fontNameBox";
            this.fontNameBox.Size = new System.Drawing.Size(140, 20);
            this.fontNameBox.TabIndex = 6;
            // 
            // fonNametList
            // 
            this.fonNametList.FormattingEnabled = true;
            this.fonNametList.Items.AddRange(new object[] {
            "Abadi MT Condensed Light",
            "Aharoni",
            "Aldhabi",
            "Andalus",
            "Angsana New",
            "AngsanaUPC",
            "Aparajita",
            "Arabic Typesetting",
            "Arial",
            "Arial Black",
            "Arial Nova",
            "Batang",
            "BatangChe",
            "Book Antiqua",
            "Browallia New",
            "BrowalliaUPC",
            "Calibri",
            "Calibri Light",
            "Calisto MT",
            "Cambria",
            "Cambria Math",
            "Candara",
            "Century Gothic",
            "Comic Sans MS",
            "Consolas",
            "Constantia",
            "Copperplate Gothic Bold",
            "Copperplate Gothic Light",
            "Corbel",
            "Cordia New",
            "CordiaUPC",
            "Courier New",
            "DaunPenh",
            "David",
            "Dengxian",
            "DFKai-SB",
            "DilleniaUPC",
            "DokChampa",
            "Dotum",
            "DotumChe",
            "Ebrima",
            "Estrangelo Edessa",
            "EucrosiaUPC",
            "Euphemia",
            "FangSong",
            "Franklin Gothic Medium",
            "FrankRuehl",
            "FreesiaUPC",
            "Gabriola",
            "Gadugi",
            "Gautami",
            "Georgia",
            "Georgia Pro",
            "Gill Sans Nova",
            "Gisha",
            "Gulim",
            "GulimChe",
            "Gungsuh",
            "GungsuhChe",
            "Impact",
            "IrisUPC",
            "Iskoola Pota",
            "JasmineUPC",
            "Javanese Text",
            "KaiTi",
            "Kalinga",
            "Kartika",
            "Khmer UI",
            "KodchiangUPC",
            "Kokila",
            "Lao UI",
            "Latha",
            "Leelawadee",
            "Leelawadee UI",
            "Levenim MT",
            "LilyUPC",
            "Lucida Console",
            "Lucida Handwriting Italic",
            "Lucida Sans Unicode",
            "Malgun Gothic",
            "Mangal",
            "Manny ITC",
            "Marlett",
            "Meiryo",
            "Meiryo UI",
            "Microsoft Himalaya",
            "Microsoft JhengHei",
            "Microsoft JhengHei UI",
            "Microsoft New Tai Lue",
            "Microsoft PhagsPa",
            "Microsoft Sans Serif",
            "Microsoft Tai Le",
            "Microsoft Uighur",
            "Microsoft YaHei",
            "Microsoft YaHei UI",
            "Microsoft Yi Baiti",
            "MingLiU, PMingLiU",
            "MingLiU-ExtB, PMingLiU-ExtB",
            "MingLiU_HKSCS",
            "MingLiU_HKSCS-ExtB",
            "Miriam, Miriam Fixed",
            "Mongolian Baiti",
            "MoolBoran",
            "MS Gothic, MS PGothic",
            "MS Mincho, MS PMincho",
            "MS UI Gothic",
            "MV Boli",
            "Myanmar Text",
            "Narkisim",
            "Neue Haas Grotesk Text Pro",
            "News Gothic MT",
            "Nirmala UI",
            "NSimSun",
            "Nyala",
            "Palatino Linotype",
            "Plantagenet Cherokee",
            "Raavi",
            "Rockwell Nova",
            "Rod",
            "Sakkal Majalla",
            "Sanskrit Text",
            "Segoe MDL2 Assets",
            "Segoe Print",
            "Segoe Script",
            "Segoe UI v5.00[3]",
            "",
            "",
            "",
            "",
            "",
            "",
            "Segoe UI v5.01[4]",
            "Segoe UI v5.27[5]",
            "Segoe UI v5.35",
            "Segoe UI Emoji",
            "Segoe UI Historic[6]",
            "Segoe UI Symbol",
            "Shonar Bangla",
            "Shruti",
            "SimHei",
            "SimKai",
            "Simplified Arabic",
            "SimSun",
            "SimSun-ExtB",
            "Sitka Banner",
            "Sitka Display",
            "Sitka Heading",
            "Sitka Small",
            "Sitka Subheading",
            "Sitka Text",
            "Sylfaen",
            "Symbol",
            "Tahoma",
            "Times New Roman",
            "Traditional Arabic",
            "Trebuchet MS",
            "Tunga",
            "Urdu Typesetting",
            "Utsaah",
            "Vani",
            "Verdana",
            "Verdana Pro",
            "Vijaya",
            "Vrinda",
            "Webdings",
            "Westminster",
            "Wingdings",
            "Yu Gothic",
            "Yu Gothic UI",
            "Yu Mincho"});
            this.fonNametList.Location = new System.Drawing.Point(16, 64);
            this.fonNametList.Name = "fonNametList";
            this.fonNametList.Size = new System.Drawing.Size(140, 95);
            this.fonNametList.TabIndex = 7;
            this.fonNametList.SelectedIndexChanged += new System.EventHandler(this.fonNametList_SelectedIndexChanged);
            this.fonNametList.SelectedValueChanged += new System.EventHandler(this.fonNametList_SelectedValueChanged);
            // 
            // fontStyleList
            // 
            this.fontStyleList.FormattingEnabled = true;
            this.fontStyleList.Items.AddRange(new object[] {
            "Regular",
            "Bold",
            "Oblique",
            "Bold Oblique"});
            this.fontStyleList.Location = new System.Drawing.Point(182, 64);
            this.fontStyleList.Name = "fontStyleList";
            this.fontStyleList.Size = new System.Drawing.Size(98, 95);
            this.fontStyleList.TabIndex = 8;
            this.fontStyleList.SelectedIndexChanged += new System.EventHandler(this.fontStyleList_SelectedIndexChanged);
            // 
            // fontSizeList
            // 
            this.fontSizeList.FormattingEnabled = true;
            this.fontSizeList.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.fontSizeList.Location = new System.Drawing.Point(302, 64);
            this.fontSizeList.Name = "fontSizeList";
            this.fontSizeList.Size = new System.Drawing.Size(56, 95);
            this.fontSizeList.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fontLabel);
            this.groupBox1.Location = new System.Drawing.Point(16, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 71);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sample";
            // 
            // fontLabel
            // 
            this.fontLabel.Location = new System.Drawing.Point(6, 16);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(188, 36);
            this.fontLabel.TabIndex = 0;
            this.fontLabel.Text = "AaBbYyZz";
            this.fontLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 259);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fontSizeList);
            this.Controls.Add(this.fontStyleList);
            this.Controls.Add(this.fonNametList);
            this.Controls.Add(this.fontNameBox);
            this.Controls.Add(this.fontStyleBox);
            this.Controls.Add(this.fontSizeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setFontButton);
            this.Name = "FontForm";
            this.Text = "Font";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button setFontButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox fontSizeBox;
        private System.Windows.Forms.TextBox fontStyleBox;
        private System.Windows.Forms.TextBox fontNameBox;
        private System.Windows.Forms.ListBox fonNametList;
        private System.Windows.Forms.ListBox fontStyleList;
        private System.Windows.Forms.ListBox fontSizeList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fontLabel;
    }
}