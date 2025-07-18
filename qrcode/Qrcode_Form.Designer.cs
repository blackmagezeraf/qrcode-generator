namespace qrcode {
    partial class Qrcode_Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.generateqrcode_button = new System.Windows.Forms.Button();
            this.saveqrcode_button = new System.Windows.Forms.Button();
            this.qrcodetext_label = new System.Windows.Forms.Label();
            this.apptitle_label = new System.Windows.Forms.Label();
            this.qrcode_picturebox = new System.Windows.Forms.PictureBox();
            this.qrcodetext_textbox = new System.Windows.Forms.TextBox();
            this.reset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrcode_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // generateqrcode_button
            // 
            this.generateqrcode_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateqrcode_button.Font = new System.Drawing.Font("Consolas", 10F);
            this.generateqrcode_button.Location = new System.Drawing.Point(474, 52);
            this.generateqrcode_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.generateqrcode_button.Name = "generateqrcode_button";
            this.generateqrcode_button.Size = new System.Drawing.Size(170, 25);
            this.generateqrcode_button.TabIndex = 2;
            this.generateqrcode_button.Text = "Generate QR Code";
            this.generateqrcode_button.UseVisualStyleBackColor = true;
            this.generateqrcode_button.Click += new System.EventHandler(this.generateqrcode_button_Click);
            // 
            // saveqrcode_button
            // 
            this.saveqrcode_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveqrcode_button.Font = new System.Drawing.Font("Consolas", 10F);
            this.saveqrcode_button.Location = new System.Drawing.Point(474, 81);
            this.saveqrcode_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.saveqrcode_button.Name = "saveqrcode_button";
            this.saveqrcode_button.Size = new System.Drawing.Size(170, 25);
            this.saveqrcode_button.TabIndex = 3;
            this.saveqrcode_button.Text = "Save QR Code";
            this.saveqrcode_button.UseVisualStyleBackColor = true;
            this.saveqrcode_button.Click += new System.EventHandler(this.saveqrcode_button_Click);
            // 
            // qrcodetext_label
            // 
            this.qrcodetext_label.AutoSize = true;
            this.qrcodetext_label.Font = new System.Drawing.Font("Consolas", 10F);
            this.qrcodetext_label.Location = new System.Drawing.Point(29, 57);
            this.qrcodetext_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.qrcodetext_label.Name = "qrcodetext_label";
            this.qrcodetext_label.Size = new System.Drawing.Size(104, 17);
            this.qrcodetext_label.TabIndex = 0;
            this.qrcodetext_label.Text = "QR Code Text";
            // 
            // apptitle_label
            // 
            this.apptitle_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.apptitle_label.Font = new System.Drawing.Font("Consolas", 20F);
            this.apptitle_label.Location = new System.Drawing.Point(137, 10);
            this.apptitle_label.Margin = new System.Windows.Forms.Padding(10);
            this.apptitle_label.Name = "apptitle_label";
            this.apptitle_label.Size = new System.Drawing.Size(331, 35);
            this.apptitle_label.TabIndex = 0;
            this.apptitle_label.Text = "QR Code Generator App";
            // 
            // qrcode_picturebox
            // 
            this.qrcode_picturebox.Location = new System.Drawing.Point(137, 79);
            this.qrcode_picturebox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.qrcode_picturebox.Name = "qrcode_picturebox";
            this.qrcode_picturebox.Size = new System.Drawing.Size(331, 331);
            this.qrcode_picturebox.TabIndex = 4;
            this.qrcode_picturebox.TabStop = false;
            // 
            // qrcodetext_textbox
            // 
            this.qrcodetext_textbox.Font = new System.Drawing.Font("Consolas", 10F);
            this.qrcodetext_textbox.Location = new System.Drawing.Point(137, 51);
            this.qrcodetext_textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.qrcodetext_textbox.Name = "qrcodetext_textbox";
            this.qrcodetext_textbox.Size = new System.Drawing.Size(330, 23);
            this.qrcodetext_textbox.TabIndex = 1;
            // 
            // reset_button
            // 
            this.reset_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_button.Font = new System.Drawing.Font("Consolas", 10F);
            this.reset_button.Location = new System.Drawing.Point(474, 113);
            this.reset_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(170, 25);
            this.reset_button.TabIndex = 4;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Qrcode_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 441);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.qrcodetext_textbox);
            this.Controls.Add(this.qrcode_picturebox);
            this.Controls.Add(this.apptitle_label);
            this.Controls.Add(this.qrcodetext_label);
            this.Controls.Add(this.saveqrcode_button);
            this.Controls.Add(this.generateqrcode_button);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Qrcode_Form";
            this.Text = "QR Code Generator";
            this.Load += new System.EventHandler(this.Qrcode_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrcode_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateqrcode_button;
        private System.Windows.Forms.Button saveqrcode_button;
        private System.Windows.Forms.Label qrcodetext_label;
        private System.Windows.Forms.Label apptitle_label;
        private System.Windows.Forms.PictureBox qrcode_picturebox;
        private System.Windows.Forms.TextBox qrcodetext_textbox;
        private System.Windows.Forms.Button reset_button;
    }
}

