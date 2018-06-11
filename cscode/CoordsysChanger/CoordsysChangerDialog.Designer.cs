namespace CoordsysChanger
{
    partial class CoordsysChangerDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordsysChangerDialog));
            this._labelProjection = new System.Windows.Forms.Label();
            this._textBoxProjection = new System.Windows.Forms.TextBox();
            this._buttonProjection = new System.Windows.Forms.Button();
            this._labelTables = new System.Windows.Forms.Label();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonTransform = new System.Windows.Forms.Button();
            this._listBoxTables = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // _labelProjection
            // 
            this._labelProjection.AutoSize = true;
            this._labelProjection.Location = new System.Drawing.Point(12, 236);
            this._labelProjection.Name = "_labelProjection";
            this._labelProjection.Size = new System.Drawing.Size(54, 13);
            this._labelProjection.TabIndex = 0;
            this._labelProjection.Text = "Projection";
            // 
            // _textBoxProjection
            // 
            this._textBoxProjection.Location = new System.Drawing.Point(12, 253);
            this._textBoxProjection.Name = "_textBoxProjection";
            this._textBoxProjection.Size = new System.Drawing.Size(393, 20);
            this._textBoxProjection.TabIndex = 1;
            // 
            // _buttonProjection
            // 
            this._buttonProjection.Location = new System.Drawing.Point(411, 253);
            this._buttonProjection.Name = "_buttonProjection";
            this._buttonProjection.Size = new System.Drawing.Size(29, 19);
            this._buttonProjection.TabIndex = 2;
            this._buttonProjection.Text = "...";
            this._buttonProjection.UseVisualStyleBackColor = true;
            this._buttonProjection.Click += new System.EventHandler(this._buttonProjection_Click);
            // 
            // _labelTables
            // 
            this._labelTables.AutoSize = true;
            this._labelTables.Location = new System.Drawing.Point(13, 12);
            this._labelTables.Name = "_labelTables";
            this._labelTables.Size = new System.Drawing.Size(97, 13);
            this._labelTables.TabIndex = 4;
            this._labelTables.Text = "Tables to transform";
            // 
            // _buttonCancel
            // 
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.Location = new System.Drawing.Point(366, 58);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 23);
            this._buttonCancel.TabIndex = 5;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            // 
            // _buttonTransform
            // 
            this._buttonTransform.Location = new System.Drawing.Point(366, 29);
            this._buttonTransform.Name = "_buttonTransform";
            this._buttonTransform.Size = new System.Drawing.Size(75, 23);
            this._buttonTransform.TabIndex = 6;
            this._buttonTransform.Text = "Transform";
            this._buttonTransform.UseVisualStyleBackColor = true;
            // 
            // _listBoxTables
            // 
            this._listBoxTables.FormattingEnabled = true;
            this._listBoxTables.Location = new System.Drawing.Point(16, 29);
            this._listBoxTables.Name = "_listBoxTables";
            this._listBoxTables.Size = new System.Drawing.Size(344, 199);
            this._listBoxTables.TabIndex = 7;
            // 
            // CoordsysChangerDialog
            // 
            this.AcceptButton = this._buttonTransform;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._buttonCancel;
            this.ClientSize = new System.Drawing.Size(453, 285);
            this.Controls.Add(this._listBoxTables);
            this.Controls.Add(this._buttonTransform);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._labelTables);
            this.Controls.Add(this._buttonProjection);
            this.Controls.Add(this._textBoxProjection);
            this.Controls.Add(this._labelProjection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CoordsysChangerDialog";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CoordsysChangerDialog";
            this.Load += new System.EventHandler(this.CoordsysChangerDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelProjection;
        private System.Windows.Forms.TextBox _textBoxProjection;
        private System.Windows.Forms.Button _buttonProjection;
        private System.Windows.Forms.Label _labelTables;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonTransform;
        private System.Windows.Forms.ListBox _listBoxTables;
    }
}