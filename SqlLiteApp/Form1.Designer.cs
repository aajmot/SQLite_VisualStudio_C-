namespace SqlLiteApp
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
            this.gbForm1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.gbForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbForm1
            // 
            this.gbForm1.Controls.Add(this.lblMessage);
            this.gbForm1.Controls.Add(this.lblMsg);
            this.gbForm1.Controls.Add(this.btnSave);
            this.gbForm1.Controls.Add(this.txtText);
            this.gbForm1.Location = new System.Drawing.Point(12, 12);
            this.gbForm1.Name = "gbForm1";
            this.gbForm1.Size = new System.Drawing.Size(565, 186);
            this.gbForm1.TabIndex = 0;
            this.gbForm1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(127, 81);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(105, 39);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(293, 20);
            this.txtText.TabIndex = 0;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg.Location = new System.Drawing.Point(11, 39);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(74, 20);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "Message";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(69, 138);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(82, 20);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "[message]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 210);
            this.Controls.Add(this.gbForm1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbForm1.ResumeLayout(false);
            this.gbForm1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbForm1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblMessage;
    }
}

