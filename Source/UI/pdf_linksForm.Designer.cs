//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace NSPdf_links {
    
    public partial class pdf_linksForm : System.Windows.Forms.Form {
        #region fields
        /// <summary>
        /// Required designer variable.
        /// </summary>
        IContainer components = null;
        MenuStrip ms1;
        ToolStripMenuItem tsmiFile;
        ToolStripMenuItem tsmiFileExit;
        #endregion
        #region Windows Form Designer generated code
        /// <summary>Required method for Designer support</summary>
        void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ms1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsLocation = new System.Windows.Forms.Button();
            this.tbInstSheet = new System.Windows.Forms.TextBox();
            this.tbOpSheet = new System.Windows.Forms.TextBox();
            this.btnOpLocation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbInstruct = new System.Windows.Forms.ListBox();
            this.lbOps = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGenOpSheet = new System.Windows.Forms.Button();
            this.pdflinksFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsmiFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.ms1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdflinksFormBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ms1
            // 
            this.ms1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile});
            this.ms1.Location = new System.Drawing.Point(0, 0);
            this.ms1.Name = "ms1";
            this.ms1.Size = new System.Drawing.Size(542, 24);
            this.ms1.TabIndex = 0;
            this.ms1.Text = "ms1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileOpen,
            this.tsmiFileNew,
            this.tsmiFileExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiFileNew
            // 
            this.tsmiFileNew.Name = "tsmiFileNew";
            this.tsmiFileNew.Size = new System.Drawing.Size(155, 22);
            this.tsmiFileNew.Text = "New";
            this.tsmiFileNew.Click += new System.EventHandler(this.tsmiFileNew_Click);
            // 
            // tsmiFileExit
            // 
            this.tsmiFileExit.Name = "tsmiFileExit";
            this.tsmiFileExit.Size = new System.Drawing.Size(155, 22);
            this.tsmiFileExit.Text = "Exit";
            this.tsmiFileExit.Click += new System.EventHandler(this.exitClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instruction sheets:";
            // 
            // btnInsLocation
            // 
            this.btnInsLocation.Location = new System.Drawing.Point(503, 60);
            this.btnInsLocation.Name = "btnInsLocation";
            this.btnInsLocation.Size = new System.Drawing.Size(27, 23);
            this.btnInsLocation.TabIndex = 2;
            this.btnInsLocation.Text = "...";
            this.btnInsLocation.UseVisualStyleBackColor = true;
            // 
            // tbInstSheet
            // 
            this.tbInstSheet.AllowDrop = true;
            this.tbInstSheet.Location = new System.Drawing.Point(15, 62);
            this.tbInstSheet.Name = "tbInstSheet";
            this.tbInstSheet.Size = new System.Drawing.Size(483, 20);
            this.tbInstSheet.TabIndex = 3;
            // 
            // tbOpSheet
            // 
            this.tbOpSheet.AllowDrop = true;
            this.tbOpSheet.Location = new System.Drawing.Point(15, 273);
            this.tbOpSheet.Name = "tbOpSheet";
            this.tbOpSheet.Size = new System.Drawing.Size(483, 20);
            this.tbOpSheet.TabIndex = 6;
            // 
            // btnOpLocation
            // 
            this.btnOpLocation.Location = new System.Drawing.Point(503, 270);
            this.btnOpLocation.Name = "btnOpLocation";
            this.btnOpLocation.Size = new System.Drawing.Size(27, 23);
            this.btnOpLocation.TabIndex = 5;
            this.btnOpLocation.Text = "...";
            this.btnOpLocation.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Operation sheets:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(233, 465);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create Document";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbInstruct
            // 
            this.lbInstruct.AllowDrop = true;
            this.lbInstruct.FormattingEnabled = true;
            this.lbInstruct.Location = new System.Drawing.Point(15, 89);
            this.lbInstruct.Name = "lbInstruct";
            this.lbInstruct.Size = new System.Drawing.Size(220, 160);
            this.lbInstruct.TabIndex = 8;
            this.lbInstruct.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbInstruct_DragDrop);
            this.lbInstruct.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbInstruct_DragEnter);
            // 
            // lbOps
            // 
            this.lbOps.AllowDrop = true;
            this.lbOps.FormattingEnabled = true;
            this.lbOps.Location = new System.Drawing.Point(15, 299);
            this.lbOps.Name = "lbOps";
            this.lbOps.Size = new System.Drawing.Size(220, 160);
            this.lbOps.TabIndex = 9;
            this.lbOps.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbOps_DragDrop);
            this.lbOps.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbOps_DragEnter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(152, 465);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear Files";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGenOpSheet
            // 
            this.btnGenOpSheet.Location = new System.Drawing.Point(314, 465);
            this.btnGenOpSheet.Name = "btnGenOpSheet";
            this.btnGenOpSheet.Size = new System.Drawing.Size(94, 23);
            this.btnGenOpSheet.TabIndex = 11;
            this.btnGenOpSheet.Text = "Create Op Sheet";
            this.btnGenOpSheet.UseVisualStyleBackColor = true;
            this.btnGenOpSheet.Click += new System.EventHandler(this.btnGenOpSheet_Click);
            // 
            // pdflinksFormBindingSource
            // 
            this.pdflinksFormBindingSource.DataSource = typeof(NSPdf_links.pdf_linksForm);
            // 
            // tsmiFileOpen
            // 
            this.tsmiFileOpen.Name = "tsmiFileOpen";
            this.tsmiFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiFileOpen.Size = new System.Drawing.Size(155, 22);
            this.tsmiFileOpen.Text = "Open...";
            this.tsmiFileOpen.Click += new System.EventHandler(this.tsmiFileOpen_Click);
            // 
            // pdf_linksForm
            // 
            this.ClientSize = new System.Drawing.Size(542, 494);
            this.Controls.Add(this.btnGenOpSheet);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbOps);
            this.Controls.Add(this.lbInstruct);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbOpSheet);
            this.Controls.Add(this.btnOpLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInstSheet);
            this.Controls.Add(this.btnInsLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ms1);
            this.MainMenuStrip = this.ms1;
            this.Name = "pdf_linksForm";
            this.Load += new System.EventHandler(this.formLoad);
            this.ms1.ResumeLayout(false);
            this.ms1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdflinksFormBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if ((components != null)) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private ToolStripMenuItem tsmiFileNew;
        private Label label1;
        private Button btnInsLocation;
        private TextBox tbInstSheet;
        private TextBox tbOpSheet;
        private Button btnOpLocation;
        private Label label2;
        private BindingSource pdflinksFormBindingSource;
        private Button btnCreate;
        private ListBox lbInstruct;
        private ListBox lbOps;
        private Button btnClear;
        private Button btnGenOpSheet;
        private ToolStripMenuItem tsmiFileOpen;
    }
}
