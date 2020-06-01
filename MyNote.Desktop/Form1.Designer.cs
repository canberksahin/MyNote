namespace MyNote.Desktop
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
            if (disposing)
            {
                client.Dispose();
            }
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnListNotes = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTitle = new System.Windows.Forms.ListBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(23, 39);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(230, 26);
            this.txtusername.TabIndex = 1;
            // 
            // btnListNotes
            // 
            this.btnListNotes.Location = new System.Drawing.Point(410, 39);
            this.btnListNotes.Name = "btnListNotes";
            this.btnListNotes.Size = new System.Drawing.Size(130, 26);
            this.btnListNotes.TabIndex = 2;
            this.btnListNotes.Text = "List Notes";
            this.btnListNotes.UseVisualStyleBackColor = true;
            this.btnListNotes.Click += new System.EventHandler(this.btnListNotes_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(265, 39);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(139, 26);
            this.txtpassword.TabIndex = 4;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password :";
            // 
            // lstTitle
            // 
            this.lstTitle.FormattingEnabled = true;
            this.lstTitle.ItemHeight = 20;
            this.lstTitle.Location = new System.Drawing.Point(23, 72);
            this.lstTitle.Name = "lstTitle";
            this.lstTitle.Size = new System.Drawing.Size(236, 364);
            this.lstTitle.TabIndex = 7;
            this.lstTitle.SelectedIndexChanged += new System.EventHandler(this.lstTitle_SelectedIndexChanged);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(265, 72);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(275, 157);
            this.txtNote.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 463);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.lstTitle);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnListNotes);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "MyNote Desktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnListNotes;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTitle;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

