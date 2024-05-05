namespace pryLopezEtapa6
{
    partial class frmVehiculos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAuto = new Button();
            btnBarco = new Button();
            btnAvion = new Button();
            SuspendLayout();
            // 
            // btnAuto
            // 
            btnAuto.Location = new Point(12, 409);
            btnAuto.Name = "btnAuto";
            btnAuto.Size = new Size(94, 29);
            btnAuto.TabIndex = 0;
            btnAuto.Text = "Auto";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += btnAuto_Click;
            // 
            // btnBarco
            // 
            btnBarco.Location = new Point(212, 409);
            btnBarco.Name = "btnBarco";
            btnBarco.Size = new Size(94, 29);
            btnBarco.TabIndex = 1;
            btnBarco.Text = "Barco";
            btnBarco.UseVisualStyleBackColor = true;
            btnBarco.Click += btnBarco_Click;
            // 
            // btnAvion
            // 
            btnAvion.Location = new Point(112, 409);
            btnAvion.Name = "btnAvion";
            btnAvion.Size = new Size(94, 29);
            btnAvion.TabIndex = 2;
            btnAvion.Text = "Avion";
            btnAvion.UseVisualStyleBackColor = true;
            btnAvion.Click += btnAvion_Click;
            // 
            // frmVehiculos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAvion);
            Controls.Add(btnBarco);
            Controls.Add(btnAuto);
            Name = "frmVehiculos";
            Text = "Vehiculos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAuto;
        private Button btnBarco;
        private Button btnAvion;
    }
}
