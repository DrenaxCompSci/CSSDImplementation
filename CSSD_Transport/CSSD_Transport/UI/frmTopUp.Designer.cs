﻿namespace CSSD_Transport.UI
{
    partial class frmTopUp
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblTopUpAmount = new System.Windows.Forms.Label();
            this.lblInsertBill = new System.Windows.Forms.Label();
            this.btnInsertNote = new System.Windows.Forms.Button();
            this.btnEnterTopUpAmount = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(12, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Enabled = false;
            this.txtCurrentBalance.Location = new System.Drawing.Point(81, 37);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.Size = new System.Drawing.Size(118, 20);
            this.txtCurrentBalance.TabIndex = 5;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(85, 21);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(108, 13);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Current Card Balance";
            // 
            // lblTopUpAmount
            // 
            this.lblTopUpAmount.AutoSize = true;
            this.lblTopUpAmount.Location = new System.Drawing.Point(86, 76);
            this.lblTopUpAmount.Name = "lblTopUpAmount";
            this.lblTopUpAmount.Size = new System.Drawing.Size(108, 13);
            this.lblTopUpAmount.TabIndex = 7;
            this.lblTopUpAmount.Text = "Enter Top-up Amount";
            // 
            // lblInsertBill
            // 
            this.lblInsertBill.AutoSize = true;
            this.lblInsertBill.Location = new System.Drawing.Point(92, 181);
            this.lblInsertBill.Name = "lblInsertBill";
            this.lblInsertBill.Size = new System.Drawing.Size(95, 13);
            this.lblInsertBill.TabIndex = 8;
            this.lblInsertBill.Text = "Or Insert Bill Below";
            // 
            // btnInsertNote
            // 
            this.btnInsertNote.Location = new System.Drawing.Point(95, 208);
            this.btnInsertNote.Name = "btnInsertNote";
            this.btnInsertNote.Size = new System.Drawing.Size(92, 35);
            this.btnInsertNote.TabIndex = 9;
            this.btnInsertNote.Text = "Insert Note";
            this.btnInsertNote.UseVisualStyleBackColor = true;
            this.btnInsertNote.Click += new System.EventHandler(this.btnInsertNote_Click);
            // 
            // btnEnterTopUpAmount
            // 
            this.btnEnterTopUpAmount.Location = new System.Drawing.Point(95, 131);
            this.btnEnterTopUpAmount.Name = "btnEnterTopUpAmount";
            this.btnEnterTopUpAmount.Size = new System.Drawing.Size(92, 35);
            this.btnEnterTopUpAmount.TabIndex = 11;
            this.btnEnterTopUpAmount.Text = "Enter Amount";
            this.btnEnterTopUpAmount.UseVisualStyleBackColor = true;
            this.btnEnterTopUpAmount.Click += new System.EventHandler(this.btnEnterTopUpAmount_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(81, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 20);
            this.textBox1.TabIndex = 12;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Location = new System.Drawing.Point(186, 282);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(86, 37);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // frmTopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 330);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEnterTopUpAmount);
            this.Controls.Add(this.btnInsertNote);
            this.Controls.Add(this.lblInsertBill);
            this.Controls.Add(this.lblTopUpAmount);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtCurrentBalance);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmTopUp";
            this.Text = "frmTopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblTopUpAmount;
        private System.Windows.Forms.Label lblInsertBill;
        private System.Windows.Forms.Button btnInsertNote;
        private System.Windows.Forms.Button btnEnterTopUpAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnConfirm;
    }
}