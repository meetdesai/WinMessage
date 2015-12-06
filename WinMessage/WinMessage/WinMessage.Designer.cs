/*

 */
namespace WinMessage
{
	partial class WinMessage
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinMessage));
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.SuspendLayout();
            // 
            // webControl1
            // 
            this.webControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webControl1.Location = new System.Drawing.Point(20, 30);
            this.webControl1.Size = new System.Drawing.Size(593, 353);
            this.webControl1.TabIndex = 0;
            // 
            // WinMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 403);
            this.Controls.Add(this.webControl1);
            this.DisplayHeader = false;
            this.DisplayTitle = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WinMessage";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "WinMessage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinMessage_FormClosed);
            this.Load += new System.EventHandler(this.WinMessageLoad);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.WinMessage_PreviewKeyDown);
            this.ResumeLayout(false);

		}

        private Awesomium.Windows.Forms.WebControl webControl1;
    }
}
