namespace FormularioOperacionesAritmeticas
{
    partial class FormOperacionesAritmeticas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperacionesAritmeticas));
            this.numero1Label = new System.Windows.Forms.Label();
            this.numero2Label = new System.Windows.Forms.Label();
            this.numero1TextBox = new System.Windows.Forms.TextBox();
            this.numero2TextBox = new System.Windows.Forms.TextBox();
            this.mcdRadioButton = new System.Windows.Forms.RadioButton();
            this.mcmRadioButton = new System.Windows.Forms.RadioButton();
            this.calcularButton = new System.Windows.Forms.Button();
            this.salirButton = new System.Windows.Forms.Button();
            this.TipoOperacionGroupBox = new System.Windows.Forms.GroupBox();
            this.indicadorLabel = new System.Windows.Forms.Label();
            this.resultadoLabel = new System.Windows.Forms.Label();
            this.TipoOperacionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // numero1Label
            // 
            resources.ApplyResources(this.numero1Label, "numero1Label");
            this.numero1Label.Name = "numero1Label";
            // 
            // numero2Label
            // 
            resources.ApplyResources(this.numero2Label, "numero2Label");
            this.numero2Label.Name = "numero2Label";
            // 
            // numero1TextBox
            // 
            resources.ApplyResources(this.numero1TextBox, "numero1TextBox");
            this.numero1TextBox.Name = "numero1TextBox";
            this.numero1TextBox.TextChanged += new System.EventHandler(this.numero1TextBox_TextChanged);
            this.numero1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero1TextBox_KeyPress);
            // 
            // numero2TextBox
            // 
            resources.ApplyResources(this.numero2TextBox, "numero2TextBox");
            this.numero2TextBox.Name = "numero2TextBox";
            this.numero2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero2TextBox_KeyPress);
            // 
            // mcdRadioButton
            // 
            resources.ApplyResources(this.mcdRadioButton, "mcdRadioButton");
            this.mcdRadioButton.Checked = true;
            this.mcdRadioButton.Name = "mcdRadioButton";
            this.mcdRadioButton.TabStop = true;
            this.mcdRadioButton.UseVisualStyleBackColor = true;
            this.mcdRadioButton.Enter += new System.EventHandler(this.mcdRadioButton_Enter);
            // 
            // mcmRadioButton
            // 
            resources.ApplyResources(this.mcmRadioButton, "mcmRadioButton");
            this.mcmRadioButton.Name = "mcmRadioButton";
            this.mcmRadioButton.UseVisualStyleBackColor = true;
            this.mcmRadioButton.Enter += new System.EventHandler(this.mcmRadioButton_Enter);
            // 
            // calcularButton
            // 
            resources.ApplyResources(this.calcularButton, "calcularButton");
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // salirButton
            // 
            resources.ApplyResources(this.salirButton, "salirButton");
            this.salirButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salirButton.Name = "salirButton";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // TipoOperacionGroupBox
            // 
            resources.ApplyResources(this.TipoOperacionGroupBox, "TipoOperacionGroupBox");
            this.TipoOperacionGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.TipoOperacionGroupBox.Controls.Add(this.mcdRadioButton);
            this.TipoOperacionGroupBox.Controls.Add(this.mcmRadioButton);
            this.TipoOperacionGroupBox.Name = "TipoOperacionGroupBox";
            this.TipoOperacionGroupBox.TabStop = false;
            // 
            // indicadorLabel
            // 
            resources.ApplyResources(this.indicadorLabel, "indicadorLabel");
            this.indicadorLabel.Name = "indicadorLabel";
            // 
            // resultadoLabel
            // 
            resources.ApplyResources(this.resultadoLabel, "resultadoLabel");
            this.resultadoLabel.Name = "resultadoLabel";
            // 
            // FormOperacionesAritmeticas
            // 
            this.AcceptButton = this.calcularButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.salirButton;
            this.Controls.Add(this.resultadoLabel);
            this.Controls.Add(this.indicadorLabel);
            this.Controls.Add(this.TipoOperacionGroupBox);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.numero2TextBox);
            this.Controls.Add(this.numero1TextBox);
            this.Controls.Add(this.numero2Label);
            this.Controls.Add(this.numero1Label);
            this.MaximizeBox = false;
            this.Name = "FormOperacionesAritmeticas";
            this.Load += new System.EventHandler(this.FormOperacionesAritmeticas_Load);
            this.TipoOperacionGroupBox.ResumeLayout(false);
            this.TipoOperacionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numero1Label;
        private System.Windows.Forms.Label numero2Label;
        private System.Windows.Forms.TextBox numero1TextBox;
        private System.Windows.Forms.TextBox numero2TextBox;
        private System.Windows.Forms.RadioButton mcdRadioButton;
        private System.Windows.Forms.RadioButton mcmRadioButton;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Button salirButton;
        private System.Windows.Forms.GroupBox TipoOperacionGroupBox;
        private System.Windows.Forms.Label indicadorLabel;
        private System.Windows.Forms.Label resultadoLabel;
    }
}

