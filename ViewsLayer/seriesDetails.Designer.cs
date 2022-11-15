
namespace AdminSeriesPS.ViewsLayer
{
    partial class seriesDetails
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStars = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cboxAtp = new System.Windows.Forms.CheckBox();
            this.btnAcept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Estrellas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePremiere = new System.Windows.Forms.DateTimePicker();
            this.cboxGenres = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(121, 19);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(670, 28);
            this.txtTitle.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(121, 71);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(670, 104);
            this.txtDescription.TabIndex = 0;
            // 
            // txtStars
            // 
            this.txtStars.Location = new System.Drawing.Point(404, 200);
            this.txtStars.Multiline = true;
            this.txtStars.Name = "txtStars";
            this.txtStars.Size = new System.Drawing.Size(190, 28);
            this.txtStars.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(404, 248);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 28);
            this.txtPrice.TabIndex = 0;
            // 
            // cboxAtp
            // 
            this.cboxAtp.AutoSize = true;
            this.cboxAtp.Location = new System.Drawing.Point(654, 200);
            this.cboxAtp.Name = "cboxAtp";
            this.cboxAtp.Size = new System.Drawing.Size(139, 17);
            this.cboxAtp.TabIndex = 1;
            this.cboxAtp.Text = "Apta Para Todo Publico";
            this.cboxAtp.UseVisualStyleBackColor = true;
            this.cboxAtp.CheckedChanged += new System.EventHandler(this.cboxAtp_CheckedChanged);
            // 
            // btnAcept
            // 
            this.btnAcept.Location = new System.Drawing.Point(614, 278);
            this.btnAcept.Name = "btnAcept";
            this.btnAcept.Size = new System.Drawing.Size(75, 23);
            this.btnAcept.TabIndex = 2;
            this.btnAcept.Text = "Aceptar";
            this.btnAcept.UseVisualStyleBackColor = true;
            this.btnAcept.Click += new System.EventHandler(this.btnAcept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 278);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Estreno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genero";
            // 
            // Estrellas
            // 
            this.Estrellas.AutoSize = true;
            this.Estrellas.Location = new System.Drawing.Point(331, 203);
            this.Estrellas.Name = "Estrellas";
            this.Estrellas.Size = new System.Drawing.Size(46, 13);
            this.Estrellas.TabIndex = 3;
            this.Estrellas.Text = "Estrellas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Precio";
            // 
            // dateTimePremiere
            // 
            this.dateTimePremiere.Location = new System.Drawing.Point(115, 200);
            this.dateTimePremiere.Name = "dateTimePremiere";
            this.dateTimePremiere.Size = new System.Drawing.Size(187, 20);
            this.dateTimePremiere.TabIndex = 4;
            // 
            // cboxGenres
            // 
            this.cboxGenres.FormattingEnabled = true;
            this.cboxGenres.Location = new System.Drawing.Point(115, 248);
            this.cboxGenres.Name = "cboxGenres";
            this.cboxGenres.Size = new System.Drawing.Size(187, 21);
            this.cboxGenres.TabIndex = 5;
            this.cboxGenres.SelectedIndexChanged += new System.EventHandler(this.cboxGenres_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(39, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "id invisible";
            this.label5.Visible = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(94, 284);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 7;
            this.txtId.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "state invisible";
            this.label7.Visible = false;
            // 
            // txtState
            // 
            this.txtState.Enabled = false;
            this.txtState.Location = new System.Drawing.Point(311, 281);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 9;
            this.txtState.Visible = false;
            // 
            // seriesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxGenres);
            this.Controls.Add(this.dateTimePremiere);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Estrellas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAcept);
            this.Controls.Add(this.cboxAtp);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStars);
            this.Controls.Add(this.txtTitle);
            this.Name = "seriesDetails";
            this.Text = "Formulario Serie";
            this.Load += new System.EventHandler(this.seriesDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStars;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox cboxAtp;
        private System.Windows.Forms.Button btnAcept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Estrellas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePremiere;
        private System.Windows.Forms.ComboBox cboxGenres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtState;
    }
}