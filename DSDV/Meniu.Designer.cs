namespace DSDV
{
    partial class Meniu
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRouterToDelete = new System.Windows.Forms.TextBox();
            this.buttonRouterToDelete = new System.Windows.Forms.Button();
            this.labelInfoLine = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAddRouter = new System.Windows.Forms.TextBox();
            this.textBoxAddLinkA = new System.Windows.Forms.TextBox();
            this.textBoxAddLinkB = new System.Windows.Forms.TextBox();
            this.buttonDeleteLink = new System.Windows.Forms.Button();
            this.buttonAddRouter = new System.Windows.Forms.Button();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Router";
            // 
            // textBoxRouterToDelete
            // 
            this.textBoxRouterToDelete.Location = new System.Drawing.Point(86, 55);
            this.textBoxRouterToDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRouterToDelete.Name = "textBoxRouterToDelete";
            this.textBoxRouterToDelete.Size = new System.Drawing.Size(46, 26);
            this.textBoxRouterToDelete.TabIndex = 1;
            // 
            // buttonRouterToDelete
            // 
            this.buttonRouterToDelete.Location = new System.Drawing.Point(298, 53);
            this.buttonRouterToDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRouterToDelete.Name = "buttonRouterToDelete";
            this.buttonRouterToDelete.Size = new System.Drawing.Size(112, 35);
            this.buttonRouterToDelete.TabIndex = 2;
            this.buttonRouterToDelete.Text = "Delete";
            this.buttonRouterToDelete.UseVisualStyleBackColor = true;
            this.buttonRouterToDelete.Click += new System.EventHandler(this.buttonRouterToDelete_Click);
            // 
            // labelInfoLine
            // 
            this.labelInfoLine.AutoSize = true;
            this.labelInfoLine.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.labelInfoLine.ForeColor = System.Drawing.Color.Red;
            this.labelInfoLine.Location = new System.Drawing.Point(28, 405);
            this.labelInfoLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfoLine.Name = "labelInfoLine";
            this.labelInfoLine.Size = new System.Drawing.Size(0, 25);
            this.labelInfoLine.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Router";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Link";
            // 
            // textBoxAddRouter
            // 
            this.textBoxAddRouter.Location = new System.Drawing.Point(86, 143);
            this.textBoxAddRouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddRouter.Name = "textBoxAddRouter";
            this.textBoxAddRouter.Size = new System.Drawing.Size(46, 26);
            this.textBoxAddRouter.TabIndex = 8;
            // 
            // textBoxAddLinkA
            // 
            this.textBoxAddLinkA.Location = new System.Drawing.Point(86, 186);
            this.textBoxAddLinkA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddLinkA.Name = "textBoxAddLinkA";
            this.textBoxAddLinkA.Size = new System.Drawing.Size(46, 26);
            this.textBoxAddLinkA.TabIndex = 11;
            // 
            // textBoxAddLinkB
            // 
            this.textBoxAddLinkB.Location = new System.Drawing.Point(142, 186);
            this.textBoxAddLinkB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAddLinkB.Name = "textBoxAddLinkB";
            this.textBoxAddLinkB.Size = new System.Drawing.Size(46, 26);
            this.textBoxAddLinkB.TabIndex = 12;
            // 
            // buttonDeleteLink
            // 
            this.buttonDeleteLink.Location = new System.Drawing.Point(298, 183);
            this.buttonDeleteLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDeleteLink.Name = "buttonDeleteLink";
            this.buttonDeleteLink.Size = new System.Drawing.Size(112, 35);
            this.buttonDeleteLink.TabIndex = 14;
            this.buttonDeleteLink.Text = "Add";
            this.buttonDeleteLink.UseVisualStyleBackColor = true;
            this.buttonDeleteLink.Click += new System.EventHandler(this.buttonAddLink_Click);
            // 
            // buttonAddRouter
            // 
            this.buttonAddRouter.Location = new System.Drawing.Point(298, 141);
            this.buttonAddRouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddRouter.Name = "buttonAddRouter";
            this.buttonAddRouter.Size = new System.Drawing.Size(112, 35);
            this.buttonAddRouter.TabIndex = 9;
            this.buttonAddRouter.Text = "Add";
            this.buttonAddRouter.UseVisualStyleBackColor = true;
            this.buttonAddRouter.Click += new System.EventHandler(this.buttonAddRouter_Click);
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(206, 186);
            this.numericUpDownWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(72, 26);
            this.numericUpDownWeight.TabIndex = 13;
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 258);
            this.Controls.Add(this.numericUpDownWeight);
            this.Controls.Add(this.labelInfoLine);
            this.Controls.Add(this.buttonDeleteLink);
            this.Controls.Add(this.buttonAddRouter);
            this.Controls.Add(this.buttonRouterToDelete);
            this.Controls.Add(this.textBoxAddLinkB);
            this.Controls.Add(this.textBoxAddLinkA);
            this.Controls.Add(this.textBoxAddRouter);
            this.Controls.Add(this.textBoxRouterToDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRouterToDelete;
        private System.Windows.Forms.Button buttonRouterToDelete;
        private System.Windows.Forms.Label labelInfoLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddRouter;
        private System.Windows.Forms.TextBox textBoxAddLinkA;
        private System.Windows.Forms.TextBox textBoxAddLinkB;
        private System.Windows.Forms.Button buttonDeleteLink;
        private System.Windows.Forms.Button buttonAddRouter;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
    }
}