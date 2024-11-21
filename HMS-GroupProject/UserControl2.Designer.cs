namespace HMS_GroupProject
{
    partial class MainControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contentpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // contentpanel
            // 
            this.contentpanel.Location = new System.Drawing.Point(95, 79);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(200, 100);
            this.contentpanel.TabIndex = 0;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::HMS_GroupProject.Properties.Resources.mainCont;
            this.Controls.Add(this.contentpanel);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(936, 474);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contentpanel;
    }
}
