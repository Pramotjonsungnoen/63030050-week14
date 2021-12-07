using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Pluginpramot
{
	/// <summary>
	/// Summary description for ctlMain.
	/// </summary>
	public class ctlMain : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Button butMain;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

		public ctlMain()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.butMain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butMain
            // 
            this.butMain.BackColor = System.Drawing.Color.Gainsboro;
            this.butMain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butMain.Location = new System.Drawing.Point(257, 196);
            this.butMain.Name = "butMain";
            this.butMain.Size = new System.Drawing.Size(88, 32);
            this.butMain.TabIndex = 0;
            this.butMain.Text = "&Click Me!";
            this.butMain.UseVisualStyleBackColor = false;
            this.butMain.Click += new System.EventHandler(this.butMain_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "my name is pramot chonsunngnoen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(31, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "My nicename oil";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(31, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "I like play football";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(44, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(558, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "the motto is i like to do what i think is right and good for my heart";
            // 
            // ctlMain
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Pluginpramot.Properties.Resources.thumb2_roronoa_zoro_battle_one_piece_manga_twilight;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butMain);
            this.Name = "ctlMain";
            this.Size = new System.Drawing.Size(664, 512);
            this.Resize += new System.EventHandler(this.ctlMain_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
		int newH = 0;
		int newV = 0;
			
		Random rndH = new Random(20);
		Random rndV = new Random(20);
		
		private void MoveButton()
		{
			newH = rndH.Next(this.Width - 40);
			
			
			newV = rndV.Next(this.Height - 40);
			
			this.butMain.Top = newV;
			this.butMain.Left = newH;
		}
		
		private void butMain_Click(object sender, System.EventArgs e)
		{
			this.MoveButton();			
		}

		private void ctlMain_Resize(object sender, System.EventArgs e)
		{
			this.MoveButton();
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
