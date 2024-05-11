namespace Estructura_Basica_Grafica.presentacion
{
    partial class Presentation
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControll1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.trackBarTraslationX_Scroll = new System.Windows.Forms.TrackBar();
            this.trackBarTraslationZ_Scroll = new System.Windows.Forms.TrackBar();
            this.trackBarTraslationY_Scroll = new System.Windows.Forms.TrackBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.trackBarScalationZ_Scroll = new System.Windows.Forms.TrackBar();
            this.trackBarScalationY_Scroll = new System.Windows.Forms.TrackBar();
            this.trackBarScalationX_Scroll = new System.Windows.Forms.TrackBar();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.trackBarRotationZ_Scroll = new System.Windows.Forms.TrackBar();
            this.trackBarRotationY_Scroll = new System.Windows.Forms.TrackBar();
            this.trackBarRotationX_Scroll = new System.Windows.Forms.TrackBar();
            this.tabControll1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTraslationX_Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTraslationZ_Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTraslationY_Scroll)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScalationZ_Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScalationY_Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScalationX_Scroll)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationZ_Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationY_Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationX_Scroll)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Seleccione Objeto";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(67, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Seleccionar Parte";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // tabControll1
            // 
            this.tabControll1.Controls.Add(this.tabPage1);
            this.tabControll1.Controls.Add(this.tabPage2);
            this.tabControll1.Controls.Add(this.tabPage3);
            this.tabControll1.Location = new System.Drawing.Point(5, 113);
            this.tabControll1.Name = "tabControll1";
            this.tabControll1.SelectedIndex = 0;
            this.tabControll1.Size = new System.Drawing.Size(318, 251);
            this.tabControll1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.trackBarTraslationX_Scroll);
            this.tabPage1.Controls.Add(this.trackBarTraslationZ_Scroll);
            this.tabPage1.Controls.Add(this.trackBarTraslationY_Scroll);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(310, 225);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trasladar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // trackBarTraslationX_Scroll
            // 
            this.trackBarTraslationX_Scroll.Location = new System.Drawing.Point(6, 22);
            this.trackBarTraslationX_Scroll.Minimum = -10;
            this.trackBarTraslationX_Scroll.Name = "trackBarTraslationX_Scroll";
            this.trackBarTraslationX_Scroll.Size = new System.Drawing.Size(298, 45);
            this.trackBarTraslationX_Scroll.TabIndex = 6;
            this.trackBarTraslationX_Scroll.Scroll += new System.EventHandler(this.trackBarTraslationX_Scroll_Scroll);
            // 
            // trackBarTraslationZ_Scroll
            // 
            this.trackBarTraslationZ_Scroll.Location = new System.Drawing.Point(6, 156);
            this.trackBarTraslationZ_Scroll.Minimum = -10;
            this.trackBarTraslationZ_Scroll.Name = "trackBarTraslationZ_Scroll";
            this.trackBarTraslationZ_Scroll.Size = new System.Drawing.Size(298, 45);
            this.trackBarTraslationZ_Scroll.TabIndex = 5;
            this.trackBarTraslationZ_Scroll.Scroll += new System.EventHandler(this.trackBarTraslationZ_Scroll_Scroll);
            // 
            // trackBarTraslationY_Scroll
            // 
            this.trackBarTraslationY_Scroll.Location = new System.Drawing.Point(6, 91);
            this.trackBarTraslationY_Scroll.Minimum = -10;
            this.trackBarTraslationY_Scroll.Name = "trackBarTraslationY_Scroll";
            this.trackBarTraslationY_Scroll.Size = new System.Drawing.Size(298, 45);
            this.trackBarTraslationY_Scroll.TabIndex = 4;
            this.trackBarTraslationY_Scroll.Scroll += new System.EventHandler(this.trackBarTraslationY_Scroll_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.trackBarScalationZ_Scroll);
            this.tabPage2.Controls.Add(this.trackBarScalationY_Scroll);
            this.tabPage2.Controls.Add(this.trackBarScalationX_Scroll);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(310, 225);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Escalar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // trackBarScalationZ_Scroll
            // 
            this.trackBarScalationZ_Scroll.Location = new System.Drawing.Point(6, 156);
            this.trackBarScalationZ_Scroll.Minimum = -10;
            this.trackBarScalationZ_Scroll.Name = "trackBarScalationZ_Scroll";
            this.trackBarScalationZ_Scroll.Size = new System.Drawing.Size(298, 45);
            this.trackBarScalationZ_Scroll.TabIndex = 5;
            this.trackBarScalationZ_Scroll.Scroll += new System.EventHandler(this.trackBarScalationZ_Scroll_Scroll);
            // 
            // trackBarScalationY_Scroll
            // 
            this.trackBarScalationY_Scroll.Location = new System.Drawing.Point(6, 91);
            this.trackBarScalationY_Scroll.Minimum = -10;
            this.trackBarScalationY_Scroll.Name = "trackBarScalationY_Scroll";
            this.trackBarScalationY_Scroll.Size = new System.Drawing.Size(298, 45);
            this.trackBarScalationY_Scroll.TabIndex = 4;
            this.trackBarScalationY_Scroll.Scroll += new System.EventHandler(this.trackBarScalationY_Scroll_Scroll);
            // 
            // trackBarScalationX_Scroll
            // 
            this.trackBarScalationX_Scroll.Location = new System.Drawing.Point(6, 23);
            this.trackBarScalationX_Scroll.Maximum = 20;
            this.trackBarScalationX_Scroll.Minimum = -20;
            this.trackBarScalationX_Scroll.Name = "trackBarScalationX_Scroll";
            this.trackBarScalationX_Scroll.Size = new System.Drawing.Size(298, 45);
            this.trackBarScalationX_Scroll.TabIndex = 3;
            this.trackBarScalationX_Scroll.Scroll += new System.EventHandler(this.trackBarScalationX_Scroll_Scroll);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.trackBarRotationZ_Scroll);
            this.tabPage3.Controls.Add(this.trackBarRotationY_Scroll);
            this.tabPage3.Controls.Add(this.trackBarRotationX_Scroll);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(310, 225);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rotar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // trackBarRotationZ_Scroll
            // 
            this.trackBarRotationZ_Scroll.Location = new System.Drawing.Point(6, 160);
            this.trackBarRotationZ_Scroll.Maximum = 50;
            this.trackBarRotationZ_Scroll.Minimum = -50;
            this.trackBarRotationZ_Scroll.Name = "trackBarRotationZ_Scroll";
            this.trackBarRotationZ_Scroll.Size = new System.Drawing.Size(298, 45);
            this.trackBarRotationZ_Scroll.TabIndex = 2;
            this.trackBarRotationZ_Scroll.Scroll += new System.EventHandler(this.trackBarRotationZ_Scroll_Scroll);
            // 
            // trackBarRotationY_Scroll
            // 
            this.trackBarRotationY_Scroll.Location = new System.Drawing.Point(6, 95);
            this.trackBarRotationY_Scroll.Maximum = 50;
            this.trackBarRotationY_Scroll.Minimum = -50;
            this.trackBarRotationY_Scroll.Name = "trackBarRotationY_Scroll";
            this.trackBarRotationY_Scroll.Size = new System.Drawing.Size(298, 45);
            this.trackBarRotationY_Scroll.TabIndex = 1;
            this.trackBarRotationY_Scroll.Scroll += new System.EventHandler(this.trackBarRotationY_Scroll_Scroll);
            // 
            // trackBarRotationX_Scroll
            // 
            this.trackBarRotationX_Scroll.Location = new System.Drawing.Point(6, 27);
            this.trackBarRotationX_Scroll.Maximum = 50;
            this.trackBarRotationX_Scroll.Minimum = -50;
            this.trackBarRotationX_Scroll.Name = "trackBarRotationX_Scroll";
            this.trackBarRotationX_Scroll.Size = new System.Drawing.Size(298, 45);
            this.trackBarRotationX_Scroll.TabIndex = 0;
            this.trackBarRotationX_Scroll.Scroll += new System.EventHandler(this.trackBarRotationX_Scroll_Scroll);
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 468);
            this.Controls.Add(this.tabControll1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Presentation";
            this.Text = "Presentation";
            this.Load += new System.EventHandler(this.Presentation_Load);
            this.tabControll1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTraslationX_Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTraslationZ_Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTraslationY_Scroll)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScalationZ_Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScalationY_Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScalationX_Scroll)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationZ_Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationY_Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotationX_Scroll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TabControl tabControll1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TrackBar trackBarTraslationZ_Scroll;
        private System.Windows.Forms.TrackBar trackBarTraslationY_Scroll;
        private System.Windows.Forms.TrackBar trackBarScalationZ_Scroll;
        private System.Windows.Forms.TrackBar trackBarScalationY_Scroll;
        private System.Windows.Forms.TrackBar trackBarScalationX_Scroll;
        private System.Windows.Forms.TrackBar trackBarRotationZ_Scroll;
        private System.Windows.Forms.TrackBar trackBarRotationY_Scroll;
        private System.Windows.Forms.TrackBar trackBarRotationX_Scroll;
        private System.Windows.Forms.TrackBar trackBarTraslationX_Scroll;
    }
}