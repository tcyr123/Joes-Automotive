namespace Joe_s_Automotive
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.OilChangeCB = new System.Windows.Forms.CheckBox();
            this.LubeJobCB = new System.Windows.Forms.CheckBox();
            this.RadiatorFlushCB = new System.Windows.Forms.CheckBox();
            this.TransmissionFlushCB = new System.Windows.Forms.CheckBox();
            this.InspectionCB = new System.Windows.Forms.CheckBox();
            this.ReplaceMufflerCB = new System.Windows.Forms.CheckBox();
            this.TireRotationCB = new System.Windows.Forms.CheckBox();
            this.PartsIn = new System.Windows.Forms.TextBox();
            this.LaborIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ServLaborOut = new System.Windows.Forms.Label();
            this.PartsOut = new System.Windows.Forms.Label();
            this.TaxOnPartsOut = new System.Windows.Forms.Label();
            this.TotalFeesOut = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.LubeJobCB);
            this.groupBox1.Controls.Add(this.OilChangeCB);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(63, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.TireRotationCB);
            this.groupBox2.Controls.Add(this.ReplaceMufflerCB);
            this.groupBox2.Controls.Add(this.InspectionCB);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(63, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.TransmissionFlushCB);
            this.groupBox3.Controls.Add(this.RadiatorFlushCB);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(440, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 188);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flushes";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.LaborIn);
            this.groupBox4.Controls.Add(this.PartsIn);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(440, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(355, 292);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox5.Controls.Add(this.TotalFeesOut);
            this.groupBox5.Controls.Add(this.TaxOnPartsOut);
            this.groupBox5.Controls.Add(this.PartsOut);
            this.groupBox5.Controls.Add(this.ServLaborOut);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox5.Location = new System.Drawing.Point(63, 562);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(732, 332);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(63, 926);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(324, 926);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 68);
            this.button2.TabIndex = 4;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(582, 926);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 68);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OilChangeCB
            // 
            this.OilChangeCB.AutoSize = true;
            this.OilChangeCB.Location = new System.Drawing.Point(19, 55);
            this.OilChangeCB.Name = "OilChangeCB";
            this.OilChangeCB.Size = new System.Drawing.Size(237, 29);
            this.OilChangeCB.TabIndex = 0;
            this.OilChangeCB.Text = "Oil Change ($26.00)";
            this.OilChangeCB.UseVisualStyleBackColor = true;
            // 
            // LubeJobCB
            // 
            this.LubeJobCB.AutoSize = true;
            this.LubeJobCB.Location = new System.Drawing.Point(19, 115);
            this.LubeJobCB.Name = "LubeJobCB";
            this.LubeJobCB.Size = new System.Drawing.Size(219, 29);
            this.LubeJobCB.TabIndex = 1;
            this.LubeJobCB.Text = "Lube Job ($18.00)";
            this.LubeJobCB.UseVisualStyleBackColor = true;
            // 
            // RadiatorFlushCB
            // 
            this.RadiatorFlushCB.AutoSize = true;
            this.RadiatorFlushCB.Location = new System.Drawing.Point(18, 55);
            this.RadiatorFlushCB.Name = "RadiatorFlushCB";
            this.RadiatorFlushCB.Size = new System.Drawing.Size(270, 29);
            this.RadiatorFlushCB.TabIndex = 2;
            this.RadiatorFlushCB.Text = "Radiator Flush ($30.00)";
            this.RadiatorFlushCB.UseVisualStyleBackColor = true;
            // 
            // TransmissionFlushCB
            // 
            this.TransmissionFlushCB.AutoSize = true;
            this.TransmissionFlushCB.Location = new System.Drawing.Point(18, 115);
            this.TransmissionFlushCB.Name = "TransmissionFlushCB";
            this.TransmissionFlushCB.Size = new System.Drawing.Size(317, 29);
            this.TransmissionFlushCB.TabIndex = 3;
            this.TransmissionFlushCB.Text = "Transmission Flush ($80.00)";
            this.TransmissionFlushCB.UseVisualStyleBackColor = true;
            // 
            // InspectionCB
            // 
            this.InspectionCB.AutoSize = true;
            this.InspectionCB.Location = new System.Drawing.Point(28, 60);
            this.InspectionCB.Name = "InspectionCB";
            this.InspectionCB.Size = new System.Drawing.Size(228, 29);
            this.InspectionCB.TabIndex = 4;
            this.InspectionCB.Text = "Inspection ($15.00)";
            this.InspectionCB.UseVisualStyleBackColor = true;
            // 
            // ReplaceMufflerCB
            // 
            this.ReplaceMufflerCB.AutoSize = true;
            this.ReplaceMufflerCB.Location = new System.Drawing.Point(28, 143);
            this.ReplaceMufflerCB.Name = "ReplaceMufflerCB";
            this.ReplaceMufflerCB.Size = new System.Drawing.Size(293, 29);
            this.ReplaceMufflerCB.TabIndex = 5;
            this.ReplaceMufflerCB.Text = "Replace Muffler ($100.00)";
            this.ReplaceMufflerCB.UseVisualStyleBackColor = true;
            // 
            // TireRotationCB
            // 
            this.TireRotationCB.AutoSize = true;
            this.TireRotationCB.Location = new System.Drawing.Point(28, 225);
            this.TireRotationCB.Name = "TireRotationCB";
            this.TireRotationCB.Size = new System.Drawing.Size(253, 29);
            this.TireRotationCB.TabIndex = 6;
            this.TireRotationCB.Text = "Tire Rotation ($20.00)";
            this.TireRotationCB.UseVisualStyleBackColor = true;
            // 
            // PartsIn
            // 
            this.PartsIn.Location = new System.Drawing.Point(128, 98);
            this.PartsIn.Name = "PartsIn";
            this.PartsIn.Size = new System.Drawing.Size(100, 31);
            this.PartsIn.TabIndex = 0;
            // 
            // LaborIn
            // 
            this.LaborIn.Location = new System.Drawing.Point(128, 172);
            this.LaborIn.Name = "LaborIn";
            this.LaborIn.Size = new System.Drawing.Size(100, 31);
            this.LaborIn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Labor ($)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Services and Labor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Parts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tax on Parts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(154, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Fees";
            // 
            // ServLaborOut
            // 
            this.ServLaborOut.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ServLaborOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ServLaborOut.Location = new System.Drawing.Point(286, 68);
            this.ServLaborOut.Name = "ServLaborOut";
            this.ServLaborOut.Size = new System.Drawing.Size(176, 33);
            this.ServLaborOut.TabIndex = 8;
            // 
            // PartsOut
            // 
            this.PartsOut.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PartsOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PartsOut.Location = new System.Drawing.Point(286, 132);
            this.PartsOut.Name = "PartsOut";
            this.PartsOut.Size = new System.Drawing.Size(176, 33);
            this.PartsOut.TabIndex = 9;
            // 
            // TaxOnPartsOut
            // 
            this.TaxOnPartsOut.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TaxOnPartsOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TaxOnPartsOut.Location = new System.Drawing.Point(286, 198);
            this.TaxOnPartsOut.Name = "TaxOnPartsOut";
            this.TaxOnPartsOut.Size = new System.Drawing.Size(176, 33);
            this.TaxOnPartsOut.TabIndex = 10;
            // 
            // TotalFeesOut
            // 
            this.TotalFeesOut.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.TotalFeesOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TotalFeesOut.Location = new System.Drawing.Point(286, 267);
            this.TotalFeesOut.Name = "TotalFeesOut";
            this.TotalFeesOut.Size = new System.Drawing.Size(176, 33);
            this.TotalFeesOut.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(854, 1043);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox LubeJobCB;
        private System.Windows.Forms.CheckBox OilChangeCB;
        private System.Windows.Forms.CheckBox TireRotationCB;
        private System.Windows.Forms.CheckBox ReplaceMufflerCB;
        private System.Windows.Forms.CheckBox InspectionCB;
        private System.Windows.Forms.CheckBox TransmissionFlushCB;
        private System.Windows.Forms.CheckBox RadiatorFlushCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LaborIn;
        private System.Windows.Forms.TextBox PartsIn;
        private System.Windows.Forms.Label TotalFeesOut;
        private System.Windows.Forms.Label TaxOnPartsOut;
        private System.Windows.Forms.Label PartsOut;
        private System.Windows.Forms.Label ServLaborOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

