namespace Radar
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
            this.plot1 = new OxyPlot.WindowsForms.PlotView();
            this.labelSignal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxSignal = new System.Windows.Forms.ComboBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.comboBoxOutput = new System.Windows.Forms.ComboBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelFill = new System.Windows.Forms.Label();
            this.labelBandwidth = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxFill = new System.Windows.Forms.TextBox();
            this.textBoxBandwidth = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plot1
            // 
            this.plot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plot1.Location = new System.Drawing.Point(0, 0);
            this.plot1.Name = "plot1";
            this.plot1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plot1.Size = new System.Drawing.Size(507, 364);
            this.plot1.TabIndex = 0;
            this.plot1.Text = "plot1";
            this.plot1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plot1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plot1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // labelSignal
            // 
            this.labelSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSignal.AutoSize = true;
            this.labelSignal.Location = new System.Drawing.Point(567, 24);
            this.labelSignal.Name = "labelSignal";
            this.labelSignal.Size = new System.Drawing.Size(43, 13);
            this.labelSignal.TabIndex = 1;
            this.labelSignal.Text = "Сигнал";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.plot1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 366);
            this.panel1.TabIndex = 2;
            // 
            // comboBoxSignal
            // 
            this.comboBoxSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSignal.FormattingEnabled = true;
            this.comboBoxSignal.Items.AddRange(new object[] {
            "ЛЧМ"});
            this.comboBoxSignal.Location = new System.Drawing.Point(616, 21);
            this.comboBoxSignal.Name = "comboBoxSignal";
            this.comboBoxSignal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSignal.TabIndex = 3;
            // 
            // labelOutput
            // 
            this.labelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(541, 58);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(69, 13);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Отображать";
            // 
            // comboBoxOutput
            // 
            this.comboBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxOutput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxOutput.FormattingEnabled = true;
            this.comboBoxOutput.Items.AddRange(new object[] {
            "Сигнал",
            "Спектр",
            "Модуль сигнала",
            "Модуль спектра"});
            this.comboBoxOutput.Location = new System.Drawing.Point(616, 55);
            this.comboBoxOutput.Name = "comboBoxOutput";
            this.comboBoxOutput.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOutput.TabIndex = 5;
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShow.Location = new System.Drawing.Point(662, 212);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 6;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // labelDuration
            // 
            this.labelDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(529, 98);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(106, 13);
            this.labelDuration.TabIndex = 7;
            this.labelDuration.Text = "Длительность, мкс";
            // 
            // labelFill
            // 
            this.labelFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFill.AutoSize = true;
            this.labelFill.Location = new System.Drawing.Point(553, 124);
            this.labelFill.Name = "labelFill";
            this.labelFill.Size = new System.Drawing.Size(82, 13);
            this.labelFill.TabIndex = 8;
            this.labelFill.Text = "Заполнение, %";
            // 
            // labelBandwidth
            // 
            this.labelBandwidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBandwidth.AutoSize = true;
            this.labelBandwidth.Location = new System.Drawing.Point(563, 154);
            this.labelBandwidth.Name = "labelBandwidth";
            this.labelBandwidth.Size = new System.Drawing.Size(72, 13);
            this.labelBandwidth.TabIndex = 9;
            this.labelBandwidth.Text = "Полоса, МГц";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDuration.Location = new System.Drawing.Point(641, 95);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 20);
            this.textBoxDuration.TabIndex = 10;
            this.textBoxDuration.Text = "10";
            // 
            // textBoxFill
            // 
            this.textBoxFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFill.Location = new System.Drawing.Point(641, 121);
            this.textBoxFill.Name = "textBoxFill";
            this.textBoxFill.Size = new System.Drawing.Size(100, 20);
            this.textBoxFill.TabIndex = 11;
            this.textBoxFill.Text = "50";
            // 
            // textBoxBandwidth
            // 
            this.textBoxBandwidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBandwidth.Location = new System.Drawing.Point(641, 147);
            this.textBoxBandwidth.Name = "textBoxBandwidth";
            this.textBoxBandwidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxBandwidth.TabIndex = 12;
            this.textBoxBandwidth.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 390);
            this.Controls.Add(this.textBoxBandwidth);
            this.Controls.Add(this.textBoxFill);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.labelBandwidth);
            this.Controls.Add(this.labelFill);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.comboBoxOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.comboBoxSignal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSignal);
            this.Name = "Form1";
            this.Text = "Example 1 (WindowsForms)";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView plot1;
        private System.Windows.Forms.Label labelSignal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxSignal;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.ComboBox comboBoxOutput;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelFill;
        private System.Windows.Forms.Label labelBandwidth;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxFill;
        private System.Windows.Forms.TextBox textBoxBandwidth;
    }
}

